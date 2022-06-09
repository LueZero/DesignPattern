using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Template
{
    class SeniorMusice : BasicMusice
    {
        protected override string Editing()
        {
            return "編輯高級音樂風格";
        }
    }
}
