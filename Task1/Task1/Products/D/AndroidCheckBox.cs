using System;
using Task1.Interfaces;

namespace Task1.Products.D
{
    //Writing a default cloning, via protected constructors
    public class AndroidCheckBox : ICheckBoxPrototype, ICheckBox
    {
        public Data AndroidData { get { return _androidData; } set { _androidData = value; } }


        private Data _androidData;
        private String _canvas;

        public AndroidCheckBox()
        {
            _androidData = new Data(10);
        }

        protected AndroidCheckBox(AndroidCheckBox another)
        {
            _androidData = new Data(another._androidData.Pointer);
            _canvas = another._canvas;
        }

        public virtual IPrototype Clone()
        {
            return new AndroidCheckBox(this);
        }

        public void Init(string canvas)
        {
            _canvas = canvas;
        }

        public void Toggle()
        {
            System.Console.WriteLine("Toggling android checkbox");
        }
    }
}
