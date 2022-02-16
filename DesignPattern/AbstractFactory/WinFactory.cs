using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory
{
    public class WinFactory : GUIFactoryInterface
    {
        public ButtonInterface CreateButton()
        {
            return new WinButton();
        }

        public CheckboxInterface CreateCheckbox()
        {
            return new WinCheckbox();
        }
    }
}
