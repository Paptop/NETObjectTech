using System;
using System.Collections;

namespace Task1.Products.Animation
{
    public class Anim3D : IAnimation
    {
        private String _spine3D;

        public Anim3D()
        {
            _spine3D = "Spine animation 3D";
        }


        public void Init(Hashtable param)
        {
            object spine3d;

            if ((spine3d = param["transform"]) != null)
            {
                _spine3D = (String)spine3d;
            }
        }

        public override String ToString()
        {
            return $"Anim3D:\n using Spine3D {_spine3D} \n";
        }
    }
}
