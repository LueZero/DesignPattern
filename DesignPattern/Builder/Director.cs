using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder
{
    public class Director
    {
        private BuilderInterface _builder;

        public void setBuilder(BuilderInterface builder)
        {
            _builder = builder;
        }

        public void constructMobilePhone()
        {
            _builder.reset();
            _builder.setSystem();
            _builder.setPassword();
        }
    }
}
