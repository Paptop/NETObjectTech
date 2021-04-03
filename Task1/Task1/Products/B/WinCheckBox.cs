using System;
using Task1.Interfaces;

namespace Task1.Products.B
{
    public class WinCheckBox : ICheckBox
    {
        public String Canvas { get { return _canvas; } set { _canvas = value; } }

        private string _canvas;
        private int _window;

        public WinCheckBox(string canvas, int window)
        {
            _canvas = canvas;
            _window = window;
        }

        public void Toggle()
        {
            System.Console.WriteLine("Toggling the win32 checkbox");
        }
    }
}
