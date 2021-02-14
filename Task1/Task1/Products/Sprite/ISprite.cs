using System;
namespace Task1.Products.Sprite
{
    public interface ISprite : IClone<ISprite>
    {
        void Init3D(Transform trans, string TextureName)
        {
            throw new NotImplementedException();
        }

        void Init2D(Vec2 pos, float rotation, string TextureName)
        {
            throw new NotImplementedException();
        }
    }
}
