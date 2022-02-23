using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder
{
    public class AppleBuilder : BuilderInterface
    {
        private Apple _Apple;

        public void Reset()
        {
            _Apple = new Apple();
        }

        public void SetSystem()
        {
            _Apple.SetSystem();
        }

        public void SetPassword()
        {
            _Apple.SetPassword();
        }
    }
}
