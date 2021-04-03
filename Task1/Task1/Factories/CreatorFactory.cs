using System;
using Task1.Interfaces;
using Task1.Creators;

namespace Task1.Factories
{
    public class CreatorFactory
    {
        private Creator<IButton>    _button;
        private Creator<ICheckBox>  _checkBox;

        public CreatorFactory(Creator<IButton> button, Creator<ICheckBox> checkbox)
        {
            _button = button;
            _checkBox = checkbox;
        }

        public IButton CreateButton()
        {
            return _button.Create();
        }

        public ICheckBox CreateCheckBox()
        {
            return _checkBox.Create();
        }
    }
}
