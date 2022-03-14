using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.SOLID.SRP
{
    class GoodSRP
    {
        public class Shop
        {
            void AddCart()
            {
            }

            void Checkout()
            {
                var shippingName = "黑貓";

                if (shippingName == "黑貓")
                {
                    var tCat = new TCat();
                    tCat.CalculateShippingCharges();
                }
                else if (shippingName == "郵寄")
                {
                    var post = new Post();
                    post.CalculateShippingCharges();
                }
            }
        }
           
        public interface Shipping
        {
            public void CalculateShippingCharges();
        }

        public class TCat : Shipping
        {
            public void CalculateShippingCharges()
            {
                //TODO
            }
        }

        public class Post : Shipping
        {
            public void CalculateShippingCharges()
            {
                //TODO
            }
        }
    }
}
