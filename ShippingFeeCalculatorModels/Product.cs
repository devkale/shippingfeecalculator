using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingFeeCalculatorModels
{
    public class Product
    {
        public string Name { get; set; }

        public Dimension Dimension { get; set; }
        public Handling Handling { get; set; }

    }
}
