using System;
using System.Linq;
using System.Reflection;
using Task1.Interfaces;

namespace Task1.Factories
{
    public class FactoryBC : IFactory
    {
        private Type  _button;
        private Type  _checkbox;
        private int   _window;

        public FactoryBC(Type button, Type checkBox, int window)
        {
            _button = button;
            _checkbox = checkBox;
            _window = window;
        }

        public IButton CreateButton(string canvas)
        {
            object[] args = new object[2];
            args[0] = canvas;
            args[1] = _window;

            args = _button.GetConstructors().Any(c => c.GetParameters().Length == 2) ? args : null;
            IButton button = (IButton)System.Activator.CreateInstance(_button, args);
            button.Enable(true);
            return button;
        }

        public ICheckBox CreateCheckBox(string canvas)
        {
            object[] args = new object[2];
            args[0] = canvas;
            args[1] = _window;

            args = _checkbox.GetConstructors().Any(c => c.GetParameters().Length == 2) ? args : null;
            ICheckBox box = (ICheckBox)System.Activator.CreateInstance(_checkbox, args);
            box.Toggle();
            return box;
        }
    }
}
