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
            _transf = new Transform();
        }

        public void Init(Hashtable param)
        {
            object ischecked = null;
            object trans = null;

            if ((ischecked = param["isChecked"]) != null)
            {
                _isChecked = (bool)ischecked;
            }
            else if ((trans = param["transform"]) != null)
            {
                Transform trs = (Transform)(trans);
                _transf = trs.Clone();
            }
        }


        public override String ToString()
        {
            return $"CheckBox3D:\n {_transf.ToString()} , Check {_isChecked}\n";
        }
    }
}
