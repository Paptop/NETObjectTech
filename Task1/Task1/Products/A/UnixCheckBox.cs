using System;
using Task1.Interfaces;

namespace Task1.Products.A
{
    public class UnixCheckBox : ICheckBox
    {
        public String Canvas { get { return _canvas; } set { _canvas = value; } }
        public int WindowID { get { return _windowID; } set { _windowID = value; } }
        public float PosX { get { return x; } set { x = value; } }
        public float PosY { get { return y; } set { y = value; } }

        private string _canvas;
        private int _windowID = 0;
        private float x = 0, y = 0;

        public UnixCheckBox(string canvas)
        {
            _canvas = canvas;
        }

        public void Toggle()
        {
            System.Console.WriteLine("Toggling unix checkbox");
        }
    }
}
