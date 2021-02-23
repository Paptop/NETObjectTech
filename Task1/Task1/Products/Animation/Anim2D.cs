using System;
using System.Collections;

namespace Task1.Products.Animation
{
    public class Anim2D : IAnimation
    {
        private String _spine2D;

        public Anim2D()
        {
            _spine2D = "Spine_anim_2D";
        }


        public void Init(Hashtable param)
        {
            object spine = null;

            if ((spine = param["transform"]) != null)
            {
                _spine2D = (String)spine;
            }
        }

        public override String ToString()
        {
            return $"Anim2D:\n using Spine2D {_spine2D} \n";
        }
    }
}
