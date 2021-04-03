using System;
using Task1.Interfaces;

namespace Task1.Products.D
{
    //Writing a default cloning, via protected constructors
    public class AndroidButton : IButtonPrototype, IButton
    {
        public Data AndroidData {get { return _androidData; } set { _androidData = value; } }

        private Data _androidData;
        private String _canvas;
        private bool _bEnabled = true;

        public AndroidButton()
        {
            _androidData = new Data(1);
        }

        protected AndroidButton(AndroidButton another)
        {
            _androidData = new Data(another._androidData.Pointer);
            _canvas = another._canvas;
        }

        public virtual IPrototype Clone()
        {
            return new AndroidButton(this);
        }

        public void Init(string canvas)
        {
            _canvas = canvas;
        }

        public void Enable(bool bEnable)
        {
            _bEnabled = bEnable;
        }

        public void CheckInput(string Event)
        {
            if(Event == "Press")
            {
                System.Console.WriteLine("Button Pressed");
            }
        }
    }
}
