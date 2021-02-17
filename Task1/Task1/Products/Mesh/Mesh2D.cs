using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Task1.Products.Mesh
{
    public class Mesh2D : IMesh
    {
        private List<Vec2> _points;
        private Color      _color;

        public Mesh2D()
        {
            _points = new List<Vec2>();
            _color = Color.NO_COLOR;
        }

        public void Init(Hashtable table)
        {
            _points = new List<Vec2>((List<Vec2>)table["points"]);
            _color = (Color)table["color"];
        }

        public IMesh Clone()
        {
            Mesh2D copy = new Mesh2D();
            copy.Init(new Hashtable()
            {
                { "color", _color },
                { "points", _points }
            });
            return copy;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Mesh2D))
            {
                return false;
            }

            Mesh2D spr = (Mesh2D)obj;
            return _points.SequenceEqual<Vec2>(spr._points) &&
                   _color.Equals(spr._color);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override String ToString()
        {
            String output = "Mesh2D\n";

            output += " Polygon: ";
            foreach (Vec2 point in _points)
            {
                output += " " + point.ToString();
            }

            output += " Color: ";
            output += _color.ToString();
            return output;
        }
    }
}
