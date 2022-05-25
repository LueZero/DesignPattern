using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Observer
{
    class User : Observer
    {
        protected string name;

        public User(string name)
        {
            this.name = name;
        }

        public override void Update()
        {
            Console.WriteLine("通知");
        }
    }
}
