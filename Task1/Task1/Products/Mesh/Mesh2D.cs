using System;
using System.Collections;

namespace Task1.Products.Mesh
{
    public class Mesh2D : IMesh
    {
        public Mesh2D()
        {
        }

        public void Init(Hashtable table)
        {
        }

        public IMesh Clone()
        {
            return new Mesh2D();
        }
    }
}
