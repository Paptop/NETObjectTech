using System;
using Task1.Creators;
using Task1.Interfaces;
using Task1.Products.A;

namespace Task1.Creators
{
    public class CreatorUnixCheckBox : Creator<ICheckBox>
    {
        private string _canvas;
        private int _windowId;
        private float _x, _y;

        public CreatorUnixCheckBox(string canvas, int windowId, float x, float y)
        {
            _canvas = canvas;
            _windowId = windowId;
            _x = x;
            _y = y;
        }

        public override ICheckBox Create()
        {
            UnixCheckBox box = new UnixCheckBox(_canvas);
            box.PosX = _x; box.PosY = _y;
            box.WindowID = _windowId;
            box.Toggle();
            return box;
        }
    }
}
