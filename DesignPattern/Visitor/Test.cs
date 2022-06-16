using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Visitor
{
    class Test
    {
        public void Tests()
        {
            Console.WriteLine("訪問者模式測試");

            var taiwanRoadRun = new TaiwanRoadRun();

            var junior = new Junior();
            var senior = new Senior();

            taiwanRoadRun.GetJoggingShoes(junior);
            taiwanRoadRun.GetSupplies(junior);

            taiwanRoadRun.GetJoggingShoes(senior);
            taiwanRoadRun.GetSupplies(senior);
        }
    }
}
