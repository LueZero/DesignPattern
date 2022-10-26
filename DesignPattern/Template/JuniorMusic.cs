using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Template
{
    class JuniorMusic : BasicMusic
    {
        protected override string Editing()
        {
            return "編輯初階音樂風格";
        }
    }
}
