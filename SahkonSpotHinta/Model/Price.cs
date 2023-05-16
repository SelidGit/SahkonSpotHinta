using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahkonSpotHinta.Model
{
    public class Price
    {
        public double price { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
    }
    public class Root
    {
        public List<Price> prices { get; set; }
    }

}
