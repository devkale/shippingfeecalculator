using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShippingFeeCalculatorModels;
namespace ShippingFeeCalculatorLogic
{
    public class ProductCatalog
    {
        public static List<Product> products = new List<Product>();
        static ProductCatalog()
        {
            Init();
        }
        public static void Init()
        {
            Product product2 = new Product()
            {
                Name = "p2",
                Dimension = new Dimension() { Length = 250, Breadth = 200, Height = 20 },
                Handling = new Handling() { Type = Constants.Regular }
            };

            Product product1 = new Product()
            {
                Name = "p1",
                Dimension = new Dimension() { Length = 10, Breadth = 5, Height = 5 },
                Handling = new Handling() { Type = Constants.Fragile }
            };

            Product product6 = new Product()
            {
                Name = "p6",
                Dimension = new Dimension() { Length = 25, Breadth = 50, Height = 51 },
                Handling = new Handling() { Type = Constants.Fragile }
            };

            products.Add(product1); //0
            products.Add(product2); // 1
            products.Add(product6); //6
        }
    }
}
