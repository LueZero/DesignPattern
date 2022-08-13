using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy
{
    class Program
    {
        private StrategyInterface _strategy;

        public Program()
        { 
        }

        public Program(StrategyInterface strategy)
        {
            this._strategy = strategy;
        }

        public void SetStrategy(StrategyInterface strategy)
        {
            this._strategy = strategy;
        }

        public void DoSomething()
        {
            Console.WriteLine("Run: Sorting data using the strategy (not sure how it'll do it)");

            var list = this._strategy.DoAlgorithm(new List<string> { "a", "b", "c", "d", "e" });

            string resultStr = string.Empty;

            foreach (var element in list as List<string>)
            {
                resultStr += element + ",";
            }

            Console.WriteLine(resultStr);
        }
    }
}
