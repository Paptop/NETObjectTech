using System;
namespace Task1
{
    public class Transform
    {
        public Vec3 Pos
        {
            get { return _pos; }
            set { _pos = value;  }
        }
        public Vec3 Rot
        {
            get { return _rot; }
            set { _rot = value; }
        }
        public Vec3 Scale
        {
            get { return _scale; }
            set { _scale = value; }
        }

        private Vec3 _pos;
        private Vec3 _rot;
        private Vec3 _scale;

        public Transform()
        {
            _pos = new Vec3();
            _rot = new Vec3();
            _scale = new Vec3();
        }
    }
}
