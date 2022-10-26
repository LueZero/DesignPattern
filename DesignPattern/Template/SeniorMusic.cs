using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Template
{
    class SeniorMusic : BasicMusic
    {
        protected override string Editing()
        {
            return "編輯高級音樂風格";
        }
    }
}
