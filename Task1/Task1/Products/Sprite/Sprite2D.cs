using System;
using System.Collections;

namespace Task1.Products.Sprite
{
    public class Sprite2D : ISprite
    {
        private Vec2    _pos;
        private float   _rot;
        private String  _textureName;

        public Sprite2D()
        {
        }

        public void Init(Hashtable table)
        {
            _rot = (float)table["rot"];
            _pos = (Vec2)table["pos"];
            _textureName = (String)table["textureName"];
        }

        public ISprite Clone()
        {
            return new Sprite2D();
        }

        public override String ToString()
        {
            return $"Sprite2D:\n pos.x {_pos.x} pos.y {_pos.y} with rot {_rot} \n";
        }
    }
}
