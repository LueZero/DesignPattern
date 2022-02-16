using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory
{
    public class System
    {
        private GUIFactoryInterface _gui;

        private ButtonInterface _button;

        private CheckboxInterface _checkbox;

        public System(GUIFactoryInterface gui)
        {
            _gui = gui;
        }

        public void CreateUI()
        {
            _button = _gui.CreateButton();
            _checkbox = _gui.CreateCheckbox();
        }

        public void Paint()
        {
            _button.Paint();
            _checkbox.Paint();
        }
    }
}