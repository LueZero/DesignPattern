using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.SimpleFactory
{
    public static class PhoneFactory
    {
        private static PhoneInterface s_phone;

        public static PhoneInterface GetPhone(string brand)
        {
            switch (brand)
            {
                case "apple":
                    s_phone = new Apple();
                    break;

                case "samsung":
                    s_phone = new Samsung();
                    break;

                default:
                    throw new Exception("missing matching brand name");
            }

            return s_phone;
        }
    }
}
