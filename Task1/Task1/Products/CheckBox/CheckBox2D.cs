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
            _pos = new Vec2();
            _isChecked = false;
        }

        public void Init(Hashtable param)
        {
            object ischecked = null;
            object pos = null;

            if( (ischecked = param["isChecked"]) != null)
            {
                _isChecked = (bool)ischecked;
            }
            else if( (pos = param["pos"]) != null)
            {
                Vec2 ps = (Vec2)(pos);
                _pos = ps.Clone();
            }
        }


        public override String ToString()
        {
            return $"CheckBox2D:\n {_pos.ToString()} , Check {_isChecked}\n";
        }
    }
}
