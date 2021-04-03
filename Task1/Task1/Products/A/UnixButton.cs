using System;
using Task1.Interfaces;

namespace Task1.Products.A
{
    public class UnixButton : IButton
    {
        public String Canvas { get { return _canvas; } set { _canvas = value; } }
        public int WindowID { get { return _windowID; } set { _windowID = value; } }
        public float PosX { get { return x; } set { x = value; } }
        public float PosY { get { return y; } set { y = value; } }

        private string _canvas;
        private int    _windowID = 0;
        private float x = 0, y = 0;

        public UnixButton(string canvas)
        {
            _canvas = canvas;
        }

        public void Enable(bool bEnable)
        {
            System.Console.WriteLine("Requesting context to change active state to:" + bEnable);
        }

        public void CheckInput(string Event)
        {
            if(Event == "UnixPress")
            {
                System.Console.WriteLine("Unix button pressed");
            }
        }
    }
}