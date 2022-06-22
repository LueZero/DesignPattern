using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Facade
{
    class AppleFacade
    {
        public static string MakeApplePhone()
        {
            var apple = new Apple();

            return apple.Set().Make().Check();
        }
    }
}
