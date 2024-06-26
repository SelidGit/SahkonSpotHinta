﻿using SahkonSpotHinta.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SahkonSpotHinta.Services
{
    public class PricesService
    {
        HttpClient httpClient;
        public PricesService() 
        { 
            httpClient = new HttpClient();
        }

        List<Price> priceList = new ();
        public async Task<List<Price>> GetPrices()
        {
            if(priceList?.Count > 0)
            return priceList;

            var url = "https://api.porssisahko.net/v1/latest-prices.json";
            var response = await httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var pricesResponse = JsonSerializer.Deserialize<Root>(jsonString);

                priceList = pricesResponse.prices;
            }
            

            return priceList;
        }
    }
}
