using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder
{
    class Test
    {
        public void Tests()
        {
            Console.WriteLine("生成器模式測試");

            Director director = new Director();

            BuilderInterface applebuilder = new AppleBuilder();
            director.setBuilder(applebuilder);
            director.constructMobilePhone();

            BuilderInterface applemanualBuilder = new AppleManualBuilder();
            director.setBuilder(applemanualBuilder);
            director.constructMobilePhone();
        }
    }
}
