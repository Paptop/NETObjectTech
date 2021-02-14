using System;
using System.Reflection;
using Task1.Products.Button;
using Task1.Products.CheckBox;

namespace Task1.Factories.BC
{
    public class ButtonCheckBoxFactory<B,C> : IFactory
    {
        public ButtonCheckBoxFactory()
        {
        }

        public IButton CreateButton()
        {
            return (IButton)Activator.CreateInstance<B>();
        }

        public ICheckBox CreateCheckBox()
        {
            return (ICheckBox)Activator.CreateInstance<C>();
        }
    }
}
