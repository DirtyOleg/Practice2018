using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator
{
    public class PriceCalculation
    {
        public static float CalculateFinalPriceAfterDiscount(float totalPriceBeforeDiscount, string discountType)
        {
            float finalPrice;

            //later should using Factory Pattern to implement this method            
            switch (discountType)
            {
                case "None":
                    finalPrice = totalPriceBeforeDiscount;
                    break;

                case "20% off":
                    finalPrice = totalPriceBeforeDiscount * 0.8f;
                    break;

                default:
                    finalPrice = 0f;
                    break;
            }

            return finalPrice;
        }
    }
}
