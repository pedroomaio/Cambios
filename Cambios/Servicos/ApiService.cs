﻿namespace Cambios.Servicos
{
    using Modelos;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    class ApiService
    {
        public async Task<Response> GetRates(string urlBase, string controller)
            {
        try 
	{
                var client = new HttpClient();
                    client.BaseAddress = new Uri(urlBase);

                var response = await client.GetAsync(controller);

                var result = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    return new Response
                    {
                        IsSuccess = false,
                        Message = result,
                    };
                }

                var rates = JsonConvert.DeserializeObject<List<Rate>>(result);

                return new Response
                {
                    IsSuccess = true,
                    Result = rates
                };
            }
            catch(Exception ex)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }
        }
    }
}
