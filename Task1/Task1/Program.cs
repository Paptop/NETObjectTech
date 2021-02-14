using System;

using Task1.Factories;
using Task1.Factories.A;
using Task1.Factories.BC;
using Task1.Factories.DE;

using Task1.Products.Button;
using Task1.Products.Mesh;
using Task1.Products.CheckBox;
using Task1.Products.Sprite;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IFactory factory = new ButtonCheckBoxFactory<Button2D, CheckBox3D>();
            System.Console.WriteLine(factory.CreateCheckBox());
            System.Console.WriteLine(factory.CreateButton());


            
            IFactory fac = new MeshSpriteFactory(new Mesh2D(), new Sprite3D());
            System.Console.WriteLine(fac.CreateMesh());
            System.Console.WriteLine(fac.CreateSprite());
        }
    }
}
