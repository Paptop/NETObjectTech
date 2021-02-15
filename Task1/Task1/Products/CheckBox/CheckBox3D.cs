using System;
using System.Collections;

namespace Task1.Products.CheckBox
{
    public class CheckBox3D : ICheckBox
    {
        private Transform _transf;
        private bool      _isChecked;

        public CheckBox3D()
        {
            _isChecked = false;
        }

        public void Init(Hashtable param)
        {
            _isChecked = (bool)param["isChecked"];
            _transf = (Transform)param["transform"];
        }
    }
}
