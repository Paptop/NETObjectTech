using System;
namespace Task1.Products.Sprite
{
    public class Sprite3D : ISprite
    {
        public Sprite3D()
        {
        }

        public ISprite Clone()
        {
            return new Sprite3D();
        }
    }
}
