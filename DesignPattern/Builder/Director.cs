using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder
{
    public class Director
    {
        private BuilderInterface _Builder;

        public void SetBuilder(BuilderInterface builder)
        {
            _Builder = builder;
        }

        public void ConstructMobilePhone()
        {
            _Builder.Reset();
            _Builder.SetSystem();
            _Builder.SetPassword();
        }
    }
}
