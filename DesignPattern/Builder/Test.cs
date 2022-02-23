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
            Console.WriteLine("建造者模式測試");

            Director director = new Director();

            BuilderInterface appleBuilder = new AppleBuilder();
            director.SetBuilder(appleBuilder);
            director.ConstructMobilePhone();

            BuilderInterface appleManualBuilder = new AppleManualBuilder();
            director.SetBuilder(appleManualBuilder);
            director.ConstructMobilePhone();
        }
    }
}
