using System;
using Task1.Interfaces;

namespace Task1.Products.E
{
    public class CustomIOSCheckBox : IOSCheckBox
    {
        public Data CustomIOSData { get { return _customIosData; } set { _customIosData = value; } }
        private Data _customIosData;

        public CustomIOSCheckBox()
        {
            _customIosData = new Data(333);
        }
    }
}
