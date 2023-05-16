using SahkonSpotHinta.Model;
using SahkonSpotHinta.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahkonSpotHinta.ViewModel
{
    public partial class PriceViewModel : BaseViewModel
    {
        PricesService pricesService;
        public ObservableCollection<Price> Prices { get; } = new();
        public PriceViewModel(PricesService pricesService) 
        {
            Title = "Sähkön spot-hinnat";
            this.pricesService = pricesService;
        }

        async Task GetPricesAsync()
        {
            if(IsBusy) return;

            try
            {
                IsBusy = true;
                var prices = await pricesService.GetPrices();
                
                if(Prices.Count != 0)
                   Prices.Clear();

                foreach(var price in prices)
                    Prices.Add(price);
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex);
                await Shell.Current.DisplayAlert("Error!", $"Unable to connect to spot-prices: {ex.Message}", "OK");
            }
            finally 
            {
                IsBusy = false;
            }
        }
    }
}
