using System;
using Task1.Products.Button;
using Task1.Products.CheckBox;

namespace Task1.Factories.BC
{
    public class ButtonCheckBoxFactory<B,C> : IFactory
        where B : new()
        where C : new()
    {
        public ButtonCheckBoxFactory()
        {
        }

        public IButton CreateButton()
        {
            return (IButton)new B();
        }

        public ICheckBox CreateCheckBox()
        {
            return (ICheckBox)new C();
        }
    }
}
