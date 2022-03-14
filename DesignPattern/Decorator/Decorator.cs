using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator
{
    /// <summary>
    /// 裝飾抽象類,要讓裝飾完全取代抽象元件，所以必須繼承自Photo
    /// </summary>
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
