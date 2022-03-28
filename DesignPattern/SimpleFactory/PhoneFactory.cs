using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.SimpleFactory
{
    public static class PhoneFactory
    {
        private static ProductInterface s_phone;

        public static ProductInterface CreatePhone(string brand)
        {
            switch (brand)
            {
                case "Apple":
                    s_phone = new Apple();
                    break;

                case "Samsung":
                    s_phone = new Samsung();
                    break;

                default:
                    throw new Exception("missing matching brand name");
            }

            return s_phone;
        }
    }
}
