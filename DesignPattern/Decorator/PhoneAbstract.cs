using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator
{
    /// <summary>
    /// 手機抽象類，即裝飾者模式中的抽象元件類
    /// </summary>
    public abstract class PhoneAbstract
    {
        public abstract void Print();
    }
}
