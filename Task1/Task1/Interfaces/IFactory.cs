using System;
using Task1.Interfaces;

namespace Task1.Factories
{
    public interface IFactory
    {
        IButton CreateButton(string canvas);
        ICheckBox CreateCheckBox(string canvas);
    }
}
