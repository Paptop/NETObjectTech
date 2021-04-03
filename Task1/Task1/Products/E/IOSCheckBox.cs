using System;
using Task1.Interfaces;

namespace Task1.Products.E
{
    //No need to specify clone strategy due to default behavior in IPrototype
    //using reflection
    public class IOSCheckBox : ICheckBoxPrototype, ICheckBox
    {
        public Data IOSData { get { return _iosData; } set { _iosData = value; } }
        private Data _iosData;
        private String _canvas;

        public IOSCheckBox()
        {
            _iosData = new Data(999);
        }

        public void Init(string canvas)
        {
            _canvas = canvas;
        }

        public void Toggle()
        {
            System.Console.WriteLine("Changing the state of ios checkbox");
        }
    }
}
