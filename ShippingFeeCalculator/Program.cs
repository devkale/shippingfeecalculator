using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShippingFeeCalculatorModels;
using ShippingFeeCalculatorLogic;
namespace ShippingFeeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                ShippingLocation = new Location() { X = 12, Y = 3},
                LineItems = new List<LineItem>()
                {
                    new LineItem()
                    {
                        Product = new Product() {Name = "p2"},
                    },
                    new LineItem()
                    {
                        Product = new Product() {Name = "p6"}
                    },
                    new LineItem()
                    {
                        Product = new Product() {Name = "p1"}
                    },
                    new LineItem()
                    {
                        Product = new Product() {Name = "p1"}
                    }

                }
            };

            foreach(var item in order.LineItems)
            {
                // TODO checking availability in inventory
                Console.Out.WriteLine("Product:" + item.Product.Name);
                Product pcat = ProductCatalog.products.Find(x => x.Name == item.Product.Name);
                float packfees = PackagingFeeCalculator.GetPackagingFees(pcat.Dimension);
                Console.Out.WriteLine("Packaging Fees:" + packfees);
                Console.Out.WriteLine("Volumetric weight:" + pcat.Dimension.GetVolumeWeight());
                
                
                    //find all sites from inventry where it will be available
                    List<InventoryItem> inventory = Inventory.inventory.FindAll(x => x.Product.Name == item.Product.Name);
                    
                    // sort by distance

                    // find logistics cost
                    float anscost = float.MaxValue;
                    string ansmode = "";
                    Location location = null;
                    float ansdistance = 0;
                    foreach (var invitem in inventory)
                    {
                        float woroot = (invitem.Sitelocation.X - order.ShippingLocation.X) * (invitem.Sitelocation.X - order.ShippingLocation.X);
                        woroot += (invitem.Sitelocation.Y - order.ShippingLocation.Y) * (invitem.Sitelocation.Y - order.ShippingLocation.Y);
                        float distance = (float)Math.Sqrt( woroot);

                        ansdistance = distance;
                        if(pcat.Dimension.GetVolumeWeight() <= Land.MaxVolumetricWeight)
                        {
                            float landrate = Land.Rates.Find(x => (distance >= x.start && distance <= x.end)).rate;
                            float logisticscostland = landrate * distance;
                            if (logisticscostland < anscost)
                            {
                                anscost = logisticscostland;
                                ansmode = Land.name;
                                location = invitem.Sitelocation;
                            
                            }
                        }
                            
                        if(pcat.Dimension.GetVolumeWeight() <= Drone.MaxVolumetricWeight)
                        {
                            float dronerate = Drone.Rates.Find(x => (distance >= x.start && distance <= x.end)).rate;
                            float logisticscostdrone = dronerate * distance;
                            if (logisticscostdrone < anscost)
                            {
                                anscost = logisticscostdrone;
                                ansmode = Drone.name;
                                location = invitem.Sitelocation;
                            }
                        }
                        
                    }

                    // print minimum
                    Console.Out.WriteLine("Shipping from:" + location.X + "," + location.Y);
                    Console.Out.WriteLine("Shipping by:" + ansmode);
                    Console.Out.WriteLine("Distance:" + ansdistance);
                    Console.Out.WriteLine("Logistics cost:" + anscost);
                    Console.Out.WriteLine("Logistics cost:" +anscost);
                    Console.Out.WriteLine();

            }
            Console.In.Read();


        }
    }
}
