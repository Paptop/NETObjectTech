using System;
using System.Collections;

namespace Task1.Products.Mesh
{
    public class Mesh3D : IMesh
    {
        public Mesh3D()
        {
        }

        public void Init(Hashtable table)
        {
        }

        public IMesh Clone()
        {
            return new Mesh3D();
        }
    }
}
