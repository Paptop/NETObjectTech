using System;
using System.Collections;
using System.Reflection;

namespace Task1.Products.Sprite
{
    public class Sprite2D : ISprite
    {
        private Vec2 _pos;
        private float _rot;
        private String _texture;

        public Vec2 Pos
        {
            get { return _pos; }
        }

        public float Rot
        {
            get { return _rot;  }
        }

        public String Texture
        {
            get { return _texture;  }
        }

        public Sprite2D()
        {
        }

        public void Init(Hashtable table)
        {
            _rot = (float)table["rot"];
            _pos = (Vec2)table["pos"];
            _texture = (String)table["texture"];
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
                    {"pos",      _pos },
                    { "rot",     _rot },
                    { "texture", _texture }
                }
            });
            return (ISprite)copy;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Sprite2D))
            {
                return false;
            }

            Sprite2D spr = (Sprite2D)obj;
            return _pos.Equals(spr.Pos) &&
                   _rot.Equals(spr.Rot) &&
                   _texture.Equals(spr.Texture);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override String ToString()
        {
            return $"Sprite2D:\n pos.x {_pos.x} pos.y {_pos.y} rot {_rot} texture {_texture}\n";
        }
    }
}
