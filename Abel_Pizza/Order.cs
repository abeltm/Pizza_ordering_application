using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abel_Pizza
{
    
   public class Order
    {
        public static string customername { get; set; }
        public static string phonenum { get; set; }
        public static string type { get; set; }
        public static string size { get; set; }
        public static List<string> toppings { get; set; }
        public static int qty { get; set; }

        public static double totalcost { get; set; }
        public static double TAX { get; set; }

      public  void CalculateCost()
        {
            totalcost = 0;
            if (type=="NON-VEG")
            {
                totalcost += (toppings.Count * 0.33);
                if (size == "Small")
                {
                    totalcost += 6.99 * qty;
                }
                if (size == "Medium")
                {
                    totalcost += 8.99 * qty;
                }
                if (size == "Large")
                {
                    totalcost += 12.99 * qty;
                }
                if (size == "Extra-Large")
                {
                    totalcost += 15 * qty;
                }
                TAX = totalcost / 100 * 13;
                totalcost += TAX;
            }
            else
            {
                totalcost += (toppings.Count * 0.33);
                if (size == "Small")
                {
                    totalcost += 5.99 * qty;
                }
                if (size == "Medium")
                {
                    totalcost += 7.99 * qty;
                }
                if (size == "Large")
                {
                    totalcost += 10.99 * qty;
                }
                if (size == "Extra-Large")
                {
                    totalcost += 13.99 * qty;
                }
                 TAX = totalcost / 100 * 13;
                totalcost += TAX;
                
            }
        }

    }
}
