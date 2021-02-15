using System;
using System.Collections;

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
            Test test = new Test();
            /*
            IFactory fac0 = new AnimFactory2D();
            IFactory fac1 = new AnimFactory3D();
            IFactory factory = new ButtonCheckBoxFactory<Button2D, CheckBox3D>();
            System.Console.WriteLine(factory.CreateCheckBox());
            System.Console.WriteLine(factory.CreateButton());

            
            IFactory fac = new MeshSpriteFactory(new Mesh2D(), new Sprite3D());
            System.Console.WriteLine(fac.CreateMesh());
            System.Console.WriteLine(fac.CreateSprite());


            CreatorFactory fac4 = new CreatorFactory();

            ISprite sprite = fac4.Create<ISprite, Sprite3D>(new Hashtable(){
                { "pos", new Vec2(0.1f, 0.1f) },
                { "rot", 0.1f}
            });

            ISprite sprite3D = fac4.Create<ISprite, Sprite3D>(new Hashtable(){
                { "transform", new Transform() },
                { "texture", "Tree"}
            });


            System.Console.Write(sprite);
            System.Console.Write(sprite3D);

            object sprite2d = fac4.Assemble(typeof(Sprite2D), new Hashtable()
            {
                { "pos", new Vec2(0.1f, 0.1f) },
                { "rot", 0.1f}
            });

            System.Console.Write(sprite2d);
            */
        }
    }
}
