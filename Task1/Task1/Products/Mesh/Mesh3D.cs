using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Task1.Products.Mesh
{
    public class Mesh3D : IMesh
    {
        private List<Vec3> _points;
        private Transform  _transform;
        private Color      _color;

        public Mesh3D()
        {
            _points = new List<Vec3>();
            _transform = new Transform();
            _color = Color.NO_COLOR;
        }

        public void Init(Hashtable table)
        {
            _points = new List<Vec3>((List<Vec3>)table["points"]);
            _color = (Color)table["color"];
            Transform trans = (Transform)table["transform"];
            _transform = trans.Clone();
        }

        public IMesh Clone()
        {
            Mesh3D copy = new Mesh3D();
            copy.Init(new Hashtable()
            {
                { "color", _color },
                { "transform", _transform},
                { "points", _points}
            });
            return copy;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Mesh3D))
            {
                return false;
            }

            Mesh3D spr = (Mesh3D)obj;
            return _points.SequenceEqual<Vec3>(spr._points) &&
                   _transform.Equals(spr._transform) &&
                   _color.Equals(spr._color);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override String ToString()
        {
            String output = "Mesh3D";

            output += " Geometry: ";
            foreach (Vec3 point in _points)
            {
                output += " " + point.ToString();
            }

            output += _transform.ToString();
            output += " Color: ";
            output += _color.ToString();
            return output;
        }
    }
}
