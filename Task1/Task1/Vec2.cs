using System;
namespace Task1
{
    public class Vec2
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

        public override String ToString()
        {
            return $"Vec2( x: {_x}, y: {_y})\n";
        }
    }
}
