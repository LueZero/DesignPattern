using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.SimpleFactory
{
    public static class PhoneFactory
    {
        static PhoneInterface _Phone;

        public static PhoneInterface GetPhone(string brand)
        {
            switch (brand)
            {
                case "apple":
                    _Phone = new Apple();
                    break;

                case "samsung":
                    _Phone = new Samsung();
                    break;

                default:
                    throw new Exception("missing matching brand name");
            }

            return _Phone;
        }
    }
}
