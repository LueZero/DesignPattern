using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.SimpleFactory
{
    public static class PhoneFactory
    {
        static PhoneInterface _phone;

        public static PhoneInterface GetPhone(string brand)
        {
            switch (brand)
            {
                case "apple":
                    _phone = new Apple();
                    break;

                case "samsung":
                    _phone = new Samsung();
                    break;

                default:
                    throw new Exception("missing matching brand name");
            }

            return _phone;
        }
    }
}
