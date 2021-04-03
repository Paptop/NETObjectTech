using System;

namespace Task1.Products.E
{
    public class CustomIOSButton : IOSButton
    {
        public Data CustomIOSData { get { return _customIosData; } set { _customIosData = value; } }
        private Data _customIosData;

        public CustomIOSButton()
        {
            _customIosData = new Data(888);
        }
    }
}
