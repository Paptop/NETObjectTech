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
    public class Test
    {
        public Test()
        {
            Test_D_E();
        }

        public void Test_D_E()
        {
            Mesh2D prototypeMesh = new Mesh2D();
            Sprite3D prototypeSprite = new Sprite3D();

            IFactory fac = new MeshSpriteFactory(new Mesh2D(), new Sprite3D());
            ISprite sprite = fac.CreateSprite();

            System.Console.WriteLine($"[TEST D-E] Testing clone factories D-E {sprite.Equals(prototypeSprite)}");
        }
    }
}
