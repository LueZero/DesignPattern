using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory
{
    public class System
    {
        private GUIFactoryInterface _Gui;

        private ButtonInterface _Button;

        private CheckboxInterface _Checkbox;

        public System(GUIFactoryInterface gui)
        {
            _Gui = gui;
        }

        public void CreateUI()
        {
            _Button = _Gui.CreateButton();
            _Checkbox = _Gui.CreateCheckbox();
        }

        public void Paint()
        {
            _Button.Paint();
            _Checkbox.Paint();
        }
    }
}