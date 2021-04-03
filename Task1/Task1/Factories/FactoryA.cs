using System;
using Task1.Interfaces;
using Task1.Products.A;

namespace Task1.Factories
{
    public class FactoryA : IFactory
    {
        private int _windowId;
        private float _x, _y;

        public FactoryA(int windowId, float x, float y)
        {
            _windowId = windowId;
            _x = x; _y = y;
        }

        public IButton CreateButton(string canvas)
        {
            UnixButton button = new UnixButton(canvas);
            button.WindowID = _windowId;
            button.PosX = _x;
            button.PosY = _y;
            button.CheckInput("INIT");
            button.Enable(true);
            return button;
        }

        public ICheckBox CreateCheckBox(string canvas)
        {
            UnixCheckBox box = new UnixCheckBox(canvas);
            box.WindowID = _windowId;
            box.PosX = _x;
            box.PosY = _y;
            box.Toggle();
            return box;
        }
    }
}
