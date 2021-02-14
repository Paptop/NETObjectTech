using System;
namespace Task1.Products.Sprite
{
    public class Sprite2D : ISprite
    {
        public Sprite2D()
        {
        }

        public ISprite Clone()
        {
            return new Sprite2D();
        }
    }
}
