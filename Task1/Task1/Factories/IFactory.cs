using System;

using Task1.Products.Animation;
using Task1.Products.Button;
using Task1.Products.CheckBox;
using Task1.Products.Sprite;
using Task1.Products.Mesh;
using Task1.Products;


namespace Task1.Factories
{
    public interface IFactory
    {
        ISprite CreateSprite()
        {
            return new EmptyNode();
        }

        IButton CreateButton()
        {
            return new EmptyNode();
        }

        IAnimation CreateAnimation()
        {
            return new EmptyNode();
        }

        ICheckBox CreateCheckBox()
        {
            return new EmptyNode();
        }

        IMesh CreateMesh()
        {
            return new EmptyNode();
        }
    }
}
