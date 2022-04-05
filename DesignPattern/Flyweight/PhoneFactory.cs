using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Flyweight
{
    public class PhoneFactory
    {
        private List<Tuple<Phone, string>> _phones = new List<Tuple<Phone, string>>();

        public PhoneInterface GetPhone(string name)
        {
            if(_phones.Where(s => s.Item2 ==  name).Count() == 0)
            {
                _phones.Add(Tuple.Create(new Phone(), name));
            }
            
            return _phones.Where(s => s.Item2 == name).FirstOrDefault().Item1;
        }
    }
}
