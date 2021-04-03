using System;
using Task1.Interfaces;
using Task1.Products.A;

namespace Task1.Creators
{
    public class CreatorUnixButton : Creator<IButton>
    {
        private string _canvas;
        private int _windowId;
        private float _x, _y;

        public CreatorUnixButton(string canvas, int windowId, float x, float y)
        {
            _canvas = canvas;
            _windowId = windowId;
            _x = x;
            _y = y;
        }

        public override IButton Create()
        {
            UnixButton button = new UnixButton(_canvas);
            button.PosX = _x; button.PosY = _y;
            button.WindowID = _windowId;
            button.CheckInput("INIT");
            return button;
        }
    }
}
