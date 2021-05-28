namespace Cambios
{
    using Modelos;
    using Servicos;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    public partial class Form1 : Form
    {
        #region Atributos
        private List<Rate> Rates;
        private NetworkService networkService;
        private ApiService apiService;
        private DialogService dialogService;
        private DataService dataService;
        #endregion


        public Form1()
        {
            InitializeComponent();
            networkService = new NetworkService();
            apiService = new ApiService();
            dialogService = new DialogService();
            dataService = new DataService();
            LoadRates();
        }

        private async void LoadRates()
        {
            bool load;

            lblResultado.Text = "A atualizar taxas...";

            var connection = networkService.CheckConnection();

            if (!connection.IsSuccess)
            {
                LoadLocalRates();
                load = false;
            }
            else
            {
                await LoadApiRates();
                load = true;
            }

            if (Rates.Count==0)
            {
                lblResultado.Text = "Não há ligação à Internet" + Environment.NewLine + 
                    "e não foram previamente carregadas as taxas." + Environment.NewLine +
                    "Tente mais tarde!";

                lblStatus.Text = "Primeira inicialização deverá ter ligação à Internet";

                return;
            }

            //var client = new HttpClient();

            cbMoedaOrigem.DataSource = Rates;
            cbMoedaOrigem.DisplayMember = "Name";

            cbMoedaDestino.BindingContext = new BindingContext();

            cbMoedaDestino.DataSource = Rates;
            cbMoedaOrigem.DisplayMember = "Name";

           
            

            lblResultado.Text = "Taxas actualizadas...";

            if (load)
            {
                lblStatus.Text = string.Format("Taxas carregadas da internet em {0:F}", DateTime.Now);
            }
            else
            {
                lblStatus.Text = string.Format("Taxas carregadas da Base de Dados");
            }

            progressBar1.Value = 100;

            btnConverter.Enabled = true;
            btnTroca.Enabled = true;
        }

        private void LoadLocalRates()
        {
            Rates = dataService.GetData();
        }

        private async Task LoadApiRates()
        {
            progressBar1.Value = 0;

            var response = await apiService.GetRates("http://cambios.somee.com/api/rates", "/api/Rates");

            Rates = (List<Rate>)response.Result;

            dataService.DeleteData();

            dataService.SaveData(Rates);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            Convert();
        }

        private void Convert()
        {
            if (string.IsNullOrEmpty(txtValor.Text))
            {
                dialogService.ShowMessage("Erro", "Insira um valor a converter");
                return;
            }

            decimal valor;
            if (!decimal.TryParse(txtValor.Text, out valor))
            {
                dialogService.ShowMessage("Erro de conversão", "Valor terá que ser numérico");
                return;
            }

            if (cbMoedaOrigem.SelectedItem==null)
            {
                dialogService.ShowMessage("Erro", "Tem que escolher uma moeda a converter");
                return;
            }

            if (cbMoedaDestino.SelectedItem == null)
            {
                dialogService.ShowMessage("Erro", "Tem que escolher uma moeda de destino para converter");
                return;
            }

            var taxaOrigem = (Rate)cbMoedaOrigem.SelectedItem;
            var taxaDestino = (Rate)cbMoedaDestino.SelectedItem;
            var valorConvertido = valor / (decimal)taxaOrigem.TaxRate * (decimal)taxaDestino.TaxRate;

            lblResultado.Text = string.Format("{0} {1:C2} = {2} {3:C2}",
                taxaOrigem.Code,
                valor,
                taxaDestino.Code,
                valorConvertido);
        }

        private void btnTroca_Click(object sender, EventArgs e)
        {
            var aux = cbMoedaOrigem.SelectedIndex;
            cbMoedaOrigem.SelectedIndex = cbMoedaDestino.SelectedIndex;
            cbMoedaDestino.SelectedIndex = aux;
            Convert();
        }
    }
}
