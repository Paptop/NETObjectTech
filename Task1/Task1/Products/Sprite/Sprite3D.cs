using System;
using System.Collections;
using System.Reflection;

namespace Task1.Products.Sprite
{
    public class Sprite3D : ISprite
    {
        public Transform Transform
        {
            get { return _transform; }
        }

        public String Texture
        {
            get { return _texture;  }
            set { _texture = value;  }
        }
        
        private Transform   _transform;
        private String      _texture;

        public Sprite3D()
        {
            _transform = new Transform();
            _texture = "NaN";
        }

        public void Init(Hashtable param)
        {
            Transform trans = (Transform)param["transform"];
            _transform = trans.Clone();
            _texture = (String)param["texture"];
        }

        public ISprite Clone()
        {
            Type type = this.GetType();
            object copy = Activator.CreateInstance(type);
            MethodInfo method = type.GetMethod("Init");
            method.Invoke(copy, new object[]
            {
                new Hashtable()
                {
                    {"transform", _transform },
                    {"texture", _texture }
                }
            });
            return (ISprite)copy;
        }

        public override bool Equals(object obj)
        {
            if(obj == null || !(obj is Sprite3D))
            {
                return false;
            }

            Sprite3D spr = (Sprite3D)obj;
            return _transform.Equals(spr.Transform) &&
                   _texture.Equals(spr.Texture);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override String ToString()
        {
            return $"Sprite3D:\n {_transform} Texture: {_texture} \n";
        }
    }
}
