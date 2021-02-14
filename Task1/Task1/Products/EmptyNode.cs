using System;

using Task1.Products.Animation;
using Task1.Products.Button;
using Task1.Products.CheckBox;
using Task1.Products.Mesh;
using Task1.Products.Sprite;


namespace Task1.Products
{
    public class EmptyNode : IAnimation,IButton,ICheckBox,IMesh,ISprite
    {
        public EmptyNode()
        {
        }
    }
}
