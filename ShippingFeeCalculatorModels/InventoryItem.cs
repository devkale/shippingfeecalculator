using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingFeeCalculatorModels
{
    public class InventoryItem
    {
        public Product Product { get; set; }
        public Location Sitelocation { get; set; }
    }
}
