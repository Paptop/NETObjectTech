using System;
using System.Collections;

namespace Task1.Products.CheckBox
{
    public class CheckBox2D : ICheckBox
    {
        private Vec2 _pos;
        private bool _isChecked;

        public CheckBox2D()
        {
        }

        public void Init(Hashtable param)
        {
            _isChecked = (bool)param["isChecked"];
            _pos = (Vec2)param["pos"];
        }
    }
}
