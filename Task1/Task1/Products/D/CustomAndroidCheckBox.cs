using System;
using Task1.Interfaces;

namespace Task1.Products.D
{
    public class CustomAndroidCheckBox : AndroidCheckBox
    {
        private Data _customCheckBoxData;

        public CustomAndroidCheckBox()
        {
            _customCheckBoxData = new Data(2);
        }

        protected CustomAndroidCheckBox(AndroidCheckBox another) : base(another)
        {
            _customCheckBoxData = new Data(another.AndroidData.Pointer);
        }

        public override IPrototype Clone()
        {
            return new CustomAndroidCheckBox(this);
        }
    }
}
