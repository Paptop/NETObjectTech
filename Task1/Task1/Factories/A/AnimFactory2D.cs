using System;
using Task1.Products.Animation;

namespace Task1.Factories.A
{
    public class AnimFactory2D : IFactory
    {
        public AnimFactory2D()
        {
        }

        public IAnimation CreateAnimation()
        {
            return new Anim2D();
        }
    }
}
