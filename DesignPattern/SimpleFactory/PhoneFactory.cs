using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.SimpleFactory
{
    public static class PhoneFactory
    {
        static PhoneInterface phone;

        public static PhoneInterface GetPhone(string brand)
        {
            switch (brand)
            {
                case "apple":
                    phone = new Apple();
                    break;

                case "samsung":
                    phone = new Samsung();
                    break;

                default:
                    throw new Exception("missing matching brand name");
            }

            return phone;
        }
    }
}
