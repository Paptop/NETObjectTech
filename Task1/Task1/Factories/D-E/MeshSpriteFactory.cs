using System;
using Task1.Products.Mesh;
using Task1.Products.Sprite;

namespace Task1.Factories.DE
{
    public class MeshSpriteFactory : IFactory
    {
        private IMesh   _mesh;
        private ISprite _sprite;

        public MeshSpriteFactory(IMesh mesh, ISprite spr)
        {
            _mesh = mesh;
            _sprite = spr;
        }

        public IMesh CreateMesh()
        {
            return _mesh.Clone();
        }

        public ISprite CreateSprite()
        {
            return _sprite.Clone();
        }
    }
}
