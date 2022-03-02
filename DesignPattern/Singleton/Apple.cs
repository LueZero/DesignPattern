using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Singleton
{
    public sealed  class Apple
    {
        private Apple()
        {

        }

        private static Apple s_instance;

        public static Apple GetInstance()
        {
            if (s_instance == null)
            {
                s_instance = new Apple();
            }
            return s_instance;
        }
    }
}
