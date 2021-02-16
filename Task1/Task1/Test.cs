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
            Transform trans = new Transform();
            trans.Pos = new Vec3(0.1f, 0.2f, 0.3f);
            trans.Rot = new Vec3(0.2f, 0.3f, 0.4f);
            trans.Scale = new Vec3(1.0f, 1.0f, 1.0f);


            Mesh2D prototypeMesh = new Mesh2D();
            Sprite3D prototypeSprite = new Sprite3D();

            prototypeSprite.Init(new Hashtable
            {
                {"transform", trans},
                {"texture", "House" }
            });

            IFactory fac = new MeshSpriteFactory(new Mesh2D(), prototypeSprite);
            ISprite sprite = fac.CreateSprite();

            prototypeSprite.Texture = "Hello There";
            trans.Scale = new Vec3(-1.0f, -1.0f, -1.0f);

            bool AreEqual = sprite.Equals(prototypeSprite);

            System.Console.WriteLine($"[TEST D-E] [{AreEqual.ToString().ToUpper()}]");

            System.Console.Write(sprite);
            System.Console.Write(prototypeSprite);
        }
    }
}
