using System;
namespace Task1
{
    public class Vec3
    {
        public float x
        {
            get { return _x; }
            set { _x = value; }
        }

        public float y
        {
            get { return _y; }
            set { _y = value; }
        }

        public float z
        {
            get { return _z; }
            set { _z = value; }
        }

        public float _x, _y, _z;

        public Vec3()
        {
            _x = 0.0f; _y = 0.0f; _z = 0.0f;
        }

        public override String ToString()
        {
            return $"Vec3( x: {_x}, y: {_y}, z: {_z})\n";
        }
    }
}
