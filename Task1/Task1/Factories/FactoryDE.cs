using System;
using Task1.Interfaces;

namespace Task1.Factories
{
    public class FactoryDE : IFactory
    {
        private IButtonPrototype   _buttonProtype;
        private ICheckBoxPrototype _checkBoxPrototype;

        public FactoryDE(IButtonPrototype button, ICheckBoxPrototype checkbox)
        {
            _buttonProtype = button;
            _checkBoxPrototype = checkbox;
        }

        public IButton CreateButton(string canvas)
        {
            IPrototype clone = _buttonProtype.Clone();
            clone.Init(canvas);
            IButton button = (IButton)clone;
            button.Enable(true);
            return button;
        }

        public ICheckBox CreateCheckBox(string canvas)
        {
            IPrototype clone = _checkBoxPrototype.Clone();
            clone.Init(canvas);
            ICheckBox box = (ICheckBox)clone;
            box.Toggle();
            return box;
        }
    }
}
