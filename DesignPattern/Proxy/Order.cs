using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Proxy
{
    public class Order
    {
        public string Read(string orderNumber)
        {
            if(orderNumber == "123456")
                return "訂單結果";

            return "";
        }
    }
}
