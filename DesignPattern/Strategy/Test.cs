using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy
{
    class Test
    {
        public void Tests()
        {
            Console.WriteLine("策略模式測試");

            var run = new Program();
            run.SetStrategy(new ConcreteStrategyA());
            run.DoSomething();

            run.SetStrategy(new ConcreteStrategyB());
            run.DoSomething();
        }
    }
}
