using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator
{ 
    public abstract class Discount
    {
        public string DiscountName { get; }

        public abstract float CalculationPrice(float totalPrice);

        public static void RefreshDiscountList()
        {
            InitializingDisocuntList();
        }

        public static void InitializingDisocuntList()
        {
            //later should implement Reflection to dynamically load the .dll files
        }        
    }
}
