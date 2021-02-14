using System;
namespace Task1.Products.Mesh
{
    public class Mesh3D : IMesh
    {
        public Mesh3D()
        {
        }

        public IMesh Clone()
        {
            return new Mesh3D();
        }
    }
}
