using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator
{
    public class Decorator : Apple
    {
        private PhoneAbstract _phone;

        public Decorator(PhoneAbstract phone)
        {
            this._phone = phone;
        }

        public override void Print()
        {
            if (_phone != null)
            {
                _phone.Print();
            }
        }
    }
}
