using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder
{
    public class AppleManualBuilder : BuilderInterface
    {
        private AppleManual _apple;

        public void reset()
        {
            _apple = new AppleManual();
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
