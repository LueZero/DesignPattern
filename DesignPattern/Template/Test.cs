using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Template
{
    class Test
    {
        public void Tests()
        {
            Console.WriteLine("樣板模式測試");

            var seniorMusice =  new SeniorMusic();

            Console.WriteLine(seniorMusice.Make());

            var juniorMusice = new JuniorMusic();

            Console.WriteLine(juniorMusice.Make());
        }
    }
}
