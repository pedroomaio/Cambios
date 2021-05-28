
namespace Cambios
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnConverter = new System.Windows.Forms.Button();
            this.lblValor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.cbMoedaOrigem = new System.Windows.Forms.ComboBox();
            this.cbMoedaDestino = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnTroca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConverter
            // 
            this.btnConverter.Enabled = false;
            this.btnConverter.Location = new System.Drawing.Point(596, 80);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(91, 45);
            this.btnConverter.TabIndex = 0;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(97, 70);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(39, 15);
            this.lblValor.TabIndex = 1;
            this.lblValor.Text = "Valor: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Moeda de origem:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Moeda de destino: ";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(231, 234);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(248, 15);
            this.lblResultado.TabIndex = 1;
            this.lblResultado.Text = "Escolha um valor, moeda de origem e destino";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(142, 67);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(413, 23);
            this.txtValor.TabIndex = 2;
            // 
            // cbMoedaOrigem
            // 
            this.cbMoedaOrigem.FormattingEnabled = true;
            this.cbMoedaOrigem.Location = new System.Drawing.Point(211, 112);
            this.cbMoedaOrigem.Name = "cbMoedaOrigem";
            this.cbMoedaOrigem.Size = new System.Drawing.Size(344, 23);
            this.cbMoedaOrigem.TabIndex = 3;
            // 
            // cbMoedaDestino
            // 
            this.cbMoedaDestino.FormattingEnabled = true;
            this.cbMoedaDestino.Location = new System.Drawing.Point(211, 176);
            this.cbMoedaDestino.Name = "cbMoedaDestino";
            this.cbMoedaDestino.Size = new System.Drawing.Size(344, 23);
            this.cbMoedaDestino.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(53, 278);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(39, 15);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Status";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(528, 278);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(159, 28);
            this.progressBar1.TabIndex = 4;
            // 
            // btnTroca
            // 
            this.btnTroca.Enabled = false;
            this.btnTroca.Image = ((System.Drawing.Image)(resources.GetObject("btnTroca.Image")));
            this.btnTroca.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTroca.Location = new System.Drawing.Point(591, 152);
            this.btnTroca.Name = "btnTroca";
            this.btnTroca.Size = new System.Drawing.Size(96, 69);
            this.btnTroca.TabIndex = 5;
            this.btnTroca.UseVisualStyleBackColor = true;
            this.btnTroca.Click += new System.EventHandler(this.btnTroca_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 332);
            this.Controls.Add(this.btnTroca);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.cbMoedaDestino);
            this.Controls.Add(this.cbMoedaOrigem);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.btnConverter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.ComboBox cbMoedaOrigem;
        private System.Windows.Forms.ComboBox cbMoedaDestino;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnTroca;
    }
}

