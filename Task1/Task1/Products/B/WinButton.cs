using System;
using Task1.Interfaces;

namespace Task1.Products.B
{
    public class WinButton : IButton
    {
        public String Canvas { get { return _canvas; } set { _canvas = value; } }

        private string _canvas;
        private int _window;

        public WinButton(string canvas, int window)
        {
            _canvas = canvas;
            _window = window;
        }

        public void Enable(bool bEnable)
        {
            System.Console.WriteLine("Win button active state is: " + bEnable);
        }

        public void CheckInput(string Event)
        {
            if (Event == "Win32Press")
            {
                System.Console.WriteLine("Win32 button was pressed");
            }
        }
    }
}
