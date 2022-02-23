using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder
{
    public class AppleManualBuilder : BuilderInterface
    {
        private AppleManual _Apple;

        public void Reset()
        {
            _Apple = new AppleManual();
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
