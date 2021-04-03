using System;
using Task1.Interfaces;

namespace Task1.Products.D
{
    public class CustomAndroidButton : AndroidButton
    {
        public Data CustomData { get { return _customAndroidData; } set { _customAndroidData = value; } }

        private Data _customAndroidData;

        public CustomAndroidButton()
        {
            _customAndroidData = new Data(2);
        }

        protected CustomAndroidButton(CustomAndroidButton another) : base(another)
        {
            _customAndroidData = new Data(another._customAndroidData.Pointer);
        }

        public override IPrototype Clone()
        {
            return new CustomAndroidButton(this);
        }
    }
}
