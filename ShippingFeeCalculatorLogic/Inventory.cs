using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShippingFeeCalculatorModels;
namespace ShippingFeeCalculatorLogic
{
    public class Inventory
    {
        public static List<InventoryItem> inventory = new List<InventoryItem>();

        static Inventory()
        {
            InitializeInventory();
        }
        public static void InitializeInventory()
        {

            //Product product2 = new Product()
            //{
            //    Name = "p2",
            //    Dimension = new Dimension() { Length = 250, Breadth = 200, Height = 20 },
            //    Handling = new Handling() { Type = Constants.Regular }
            //};

            //Product product1 = new Product()
            //{
            //    Name = "p1",
            //    Dimension = new Dimension() { Length = 10, Breadth = 5, Height = 5 },
            //    Handling = new Handling() { Type = Constants.Fragile }
            //};

            //Product product6 = new Product()
            //{
            //    Name = "p6",
            //    Dimension = new Dimension() { Length = 25, Breadth = 50, Height = 51 },
            //    Handling = new Handling() { Type = Constants.Fragile }
            //};

            inventory.Add(new InventoryItem()
            {
                Product = ProductCatalog.products.Find(x => x.Name == "p2"),
                Sitelocation = new Location(20, 5)
            });
            inventory.Add(new InventoryItem()
            {
                Product = ProductCatalog.products.Find(x => x.Name == "p1"),
                Sitelocation = new Location(12, 5)
            });

            inventory.Add(new InventoryItem()
            {
                Product = ProductCatalog.products.Find(x => x.Name == "p1"),
                Sitelocation = new Location(22, 50)
            });

            inventory.Add(new InventoryItem()
            {
                Product = ProductCatalog.products.Find(x => x.Name == "p6"),
                Sitelocation = new Location(20, 5)
            });



        }
    }
}
