using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingFeeCalculatorModels
{
    public class Order
    {
        public Location ShippingLocation { get; set; }
        public List<LineItem> LineItems { get; set; }
    }
}
