using System;
namespace Task1.Products.Mesh
{
    public class Mesh2D : IMesh
    {
        public Mesh2D()
        {
        }

        public IMesh Clone()
        {
            return new Mesh2D();
        }
    }
}
