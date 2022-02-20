using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder
{
    public interface BuilderInterface
    {
        public void reset();

        public void setSystem();

        public void setPassword();
    }
}
