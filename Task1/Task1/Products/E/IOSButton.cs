using System;
using Task1.Interfaces;

namespace Task1.Products.E
{
    //No need to specify clone strategy due to default behavior in IPrototype
    //using reflection

    public class IOSButton : IButtonPrototype, IButton
    {
        public Data    IOSData { get { return _iosData; } set { _iosData = value; } }
        private Data   _iosData;
        private String _canvas;

        public IOSButton()
        {
            _iosData = new Data(3);
        }

        public void Init(string canvas)
        {
            _canvas = canvas;
        }

        public void Enable(bool bEnable)
        {
            System.Console.WriteLine("Calling system to enable ios button");
        }

        public void CheckInput(string Event)
        {
            System.Console.WriteLine("Checking input event for ios button");
        }
    }
}
