using System;
using System.Collections;

namespace Task1.Products.Button
{
    public class Button2D : IButton
    {
        private Vec2 _pos;

        public Button2D()
        {
            _pos = new Vec2();
        }

        public void Init(Hashtable param)
        {
            object pos = null;

            if( (pos = param["pos"]) != null)
            {
                Vec2 ps = (Vec2)pos;
                _pos = ps.Clone();
            }
        }

        public override String ToString()
        {
            return $"Button2D:\n {_pos.ToString()}\n";
        }
    }
}
