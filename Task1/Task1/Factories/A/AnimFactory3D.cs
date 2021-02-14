using System;
using Task1.Products.Animation;

namespace Task1.Factories.A
{
    public class AnimFactory3D : IFactory
    {
        public AnimFactory3D()
        {
        }

        public IAnimation CreateAnimation()
        {
            return new Anim3D();
        }
    }
}
