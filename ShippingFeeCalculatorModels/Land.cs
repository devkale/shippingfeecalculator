using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingFeeCalculatorModels
{
    public class Land : Mode
    {
        public static string name = "Land";
        public static float MaxVolumetricWeight = 500;
        public static List<Rate> Rates = new List<Rate>()
        {
            new Rate()
            {
                start = 0, end = 5, rate = 9.8F
            },
            new Rate()
            {
                start = 6, end = 10, rate = 12
            },
            new Rate()
            {
                start = 11, end = 36.44F, rate = 15.6F
            },
            new Rate()
            {
                start = 36.44F, end = 50, rate = 28
            }
        };
        public static Boolean IsProductAllowed(string type)
        {
            return true;
        }
        
    }

    public class Drone : Mode
    {
        public static string name = "Drone";
        public static float MaxVolumetricWeight = 50;

        public static List<Rate> Rates = new List<Rate>()
        {
            new Rate()
            {
                start = 0, end = 5, rate = 2.7F
            },
            new Rate()
            {
                start = 6, end = 10, rate = 8.9F
            },
            new Rate()
            {
                start = 11, end = 36.44F, rate = 25
            },
            new Rate()
            {
                start = 36.44F, end = 50, rate = 30
            }
        };
        public static Boolean IsProductAllowed(string type)
        {
            if(type == Constants.Flammable)
            {
                return false;
            }
            return true;
        }

    }
    class Air : Mode
    {
        public static float MaxVolumetricWeight = 100;
        public static Boolean IsProductAllowed(string type)
        {
            if (type == Constants.Flammable || type == Constants.Fragile)
            {
                return false;
            }
            return true;
        }

    }

    public class Rate
    {
        public float start { get; set; }
        public float end { get; set; }
        public float rate { get; set; }
    }

}
