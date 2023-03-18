using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Observer
{
    class User : Observer
    {
        protected string Name;

        public User(string name)
        {
            this.Name = name;
        }

        public override void Update()
        {
            Console.WriteLine("通知");
        }
    }
}
