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
                    tCat.CalculateFreight();
                }
                else if (shippingName == "郵寄")
                {
                    var post = new Post();
                    post.CalculateFreight();
                }
            }
        }
           
        public interface Shipping
        {
            public void CalculateFreight();
        }

        public class TCat : Shipping
        {
            public void CalculateFreight()
            {
                //TODO
            }
        }

        public class Post : Shipping
        {
            public void CalculateFreight()
            {
                //TODO
            }
        }
    }
}
