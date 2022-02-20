using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder
{
    public class AppleBuilder : BuilderInterface
    {
        private Apple _apple;

        public void reset()
        {
            _apple = new Apple();
        }

        public void setSystem()
        {
            _apple.setSystem();
        }

        public void setPassword()
        {
            _apple.setPassword();
        }
    }
}
