using System;
using Task1.Products;

namespace Task1
{
    public class Vec2 : IClone<Vec2>
    {
        public float x
        {
            get { return _x; }
            set { _x = value; }
        }

        public float y
        {
            get { return _y;  }
            set { _y = value;  }
        }

        private float _x, _y;

        public Vec2()
        {
            _x = 0.0f;  _y = 0.0f;
        }

        public Vec2(float x, float y)
        {
            _x = x; _y = y;
        }

        public Vec2 Clone()
        {
            return new Vec2(_x, _y);
        }

        public override String ToString()
        {
            return $"Vec2( x: {_x}, y: {_y})\n";
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            float epsilon = 0.01f;

            if(!(obj is Vec2))
            {
                return false;
            }

            Vec2 v = (Vec2)obj;

            return Math.Abs(v.x - _x) < epsilon &&
                   Math.Abs(v.y - _y) < epsilon;
        }
    }
}
