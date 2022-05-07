using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Mediator
{
    public interface MediatorInterface
    {
        public void Notify(object sender, string ev);
    }
}
