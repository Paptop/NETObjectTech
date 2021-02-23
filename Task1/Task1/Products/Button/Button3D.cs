using System;
using System.Collections;

namespace Task1.Products.Button
{
    public class Button3D : IButton
    {
        private Transform _transform;

        public Button3D()
        {
            _transform = new Transform();
        }

        public void Init(Hashtable param)
        {
            object transform = null;

            if ((transform = param["transform"]) != null)
            {
                Transform trs = (Transform)transform;
                _transform = trs.Clone();
            }
        }

        public override String ToString()
        {
            return $"Button3D:\n {_transform.ToString()}\n";
        }
    }
}
