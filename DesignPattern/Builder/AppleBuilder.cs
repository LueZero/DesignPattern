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

        public void Reset()
        {
            _apple = new Apple();
        }

        public void SetSystem()
        {
            _apple.SetSystem();
        }

        public void SetPassword()
        {
            _apple.SetPassword();
        }
    }
}
