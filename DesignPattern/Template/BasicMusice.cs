using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Template
{
    abstract class BasicMusice
    {
        public string Make()
        {
            return Editing() + "`" + Compression() + "`" + Upload();
        }

        public string Compression()
        {
            return "壓縮音樂";
        }

        public string Upload()
        {
            return "上傳音樂";
        }

        abstract protected string Editing();
    }
}
