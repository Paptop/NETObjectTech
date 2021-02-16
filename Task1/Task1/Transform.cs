using System;
using Task1.Products;

namespace Task1
{
    public class Transform : IClone<Transform>
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

        public Transform(Vec3 pos, Vec3 rot, Vec3 scale)
        {
            _pos = pos;
            _rot = rot;
            _scale = scale;
        }

        public Transform Clone()
        {
            return new Transform(_pos.Clone(),
                                 _rot.Clone(),
                                 _scale.Clone());
        }

        public override String ToString()
        {
            return $"Transform3D\n Pos: {_pos} Rot: {_rot} Scale: {_scale}";
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


        public override bool Equals(object obj)
        {
            if( !(obj is Transform))
            {
                return false;
            }

            Transform trs = (Transform)obj;
            return _pos.Equals(trs.Pos) &&
                   _rot.Equals(trs.Rot) &&
                   _scale.Equals(trs.Scale);
        }
    }
}
