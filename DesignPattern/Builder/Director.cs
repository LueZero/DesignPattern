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

        public void SetBuilder(BuilderInterface builder)
        {
            _builder = builder;
        }

        public void ConstructMobilePhone()
        {
            _builder.Reset();
            _builder.SetSystem();
            _builder.SetPassword();
        }
    }
}
