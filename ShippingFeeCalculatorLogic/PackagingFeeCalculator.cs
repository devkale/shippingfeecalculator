using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShippingFeeCalculatorModels;

namespace ShippingFeeCalculatorLogic
{
    public class PackagingFeeCalculator
    {
        public static float GetPackagingFees(Dimension dimension )
        {
            return (dimension.Length * dimension.Breadth * dimension.Height) / 100;
        }
    }
}
