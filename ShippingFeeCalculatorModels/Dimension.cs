using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingFeeCalculatorModels
{
    public class Dimension
    {
        public float Length { get; set; }
        public float Breadth { get; set; }
        public float Height { get; set; }

        public float GetVolumeWeight()
        {
            return (Length * Breadth * Height) / 5000;
        }

        //public float GetPackagingFees()
        //{
        //    return (Length * Breadth * Height) / 100;
        //}
    }
}
