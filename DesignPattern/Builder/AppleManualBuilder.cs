using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder
{
    public class AppleManualBuilder : BuilderInterface
    {
        private AppleManual _appleManual;

        public void Reset()
        {
            _appleManual = new AppleManual();
        }

        public void SetSystem()
        {
            _appleManual.SetSystem();
        }

        public void SetPassword()
        {
            _appleManual.SetPassword();
        }
    }
}
