using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory
{
    public interface GUIFactoryInterface
    {
        public ButtonInterface CreateButton();

        public CheckboxInterface CreateCheckbox();
    }
}
