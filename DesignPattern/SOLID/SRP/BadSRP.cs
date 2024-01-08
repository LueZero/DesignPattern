using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.SOLID.SRP
{
    class BadSRP
    {
        public class Shop
        {
            void AddCart()
            {
            }

            void Checkout()
            {
                CalculateFreight();
            }

            void CalculateFreight()
            {
                var shippingName = "黑貓"; 

                if (shippingName == "黑貓")
                {
                    //TODO 計算運費
                }
                else if (shippingName == "郵寄")
                {
                    //TODO 計算運費
                }
            }
        }
    }
}
