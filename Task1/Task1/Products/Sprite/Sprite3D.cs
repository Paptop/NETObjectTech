using System;
using System.Collections;
using System.Reflection;

namespace Task1.Products.Sprite
{
    public class Sprite3D : ISprite
    {
        private Transform   _transform;
        private String      _texture;

        public Sprite3D()
        {
            _transform = new Transform();
            _texture = null;
        }

        public void Init(Hashtable param)
        {
            _transform = (Transform)param["transform"];
            _texture = (String)param["texture"];
        }

        public ISprite Clone()
        {
            Type type = this.GetType();
            object copy = Activator.CreateInstance(type);
            MethodInfo method = type.GetMethod("Init");
            return (ISprite)copy;
        }

        public override String ToString()
        {
            return $"Sprite3D:\n {_transform} Texture: {_texture} \n";
        }
    }
}
