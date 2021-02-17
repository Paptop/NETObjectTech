using System;
using System.Collections;
using System.Collections.Generic;

using Task1.Factories;
using Task1.Factories.A;
using Task1.Factories.BC;
using Task1.Factories.DE;

using Task1.Products.Animation;
using Task1.Products.Button;
using Task1.Products.Mesh;
using Task1.Products.CheckBox;
using Task1.Products.Sprite;

namespace Task1
{
    public class Test
    {
        private IMesh prototypeMesh2D = new Mesh2D();
        private IMesh prototypeMesh3D = new Mesh3D();

        private ISprite prototypeSprite2D = new Sprite2D();
        private ISprite prototypeSprite3D = new Sprite3D();

        public Test()
        {
            Transform trans = new Transform();
            trans.Pos = new Vec3(0.1f, 0.2f, 0.3f);
            trans.Rot = new Vec3(0.2f, 0.3f, 0.4f);
            trans.Scale = new Vec3(1.0f, 1.0f, 1.0f);

            prototypeSprite2D.Init(new Hashtable
            {
                {"texture", "House" },
                {"pos", new Vec2(10.0f,10.0f)},
                {"rot", 0.5f }
            });

            prototypeSprite3D.Init(new Hashtable
            {
                {"transform", trans},
                {"texture", "Tree3D" }
            });

            prototypeMesh2D.Init(new Hashtable
            {
                {"points", new List<Vec2>(){
                    new Vec2(0.1f,0.1f),
                    new Vec2(0.2f,0.2f),
                    new Vec2(0.3f,0.3f)
                }},
                {"color", Color.RED}
            });

            prototypeMesh3D.Init(new Hashtable
            {
                {"points", new List<Vec3>(){
                    new Vec3(0.1f,0.1f,-0.01f),
                    new Vec3(0.2f,0.2f,0.01f),
                    new Vec3(0.3f,0.3f,0.1f)
                }},
                {"transform", trans},
                {"color", Color.RED}
            });

            Test_A();
            Test_B_C();
            Test_D_E_2D();
            Test_D_E_3D();
        }

        public void Test_A()
        {
            IFactory fac2D = new AnimFactory2D();
            IFactory fac3D = new AnimFactory3D();

            IAnimation anim2D = fac2D.CreateAnimation();
            IAnimation anim3D = fac3D.CreateAnimation();

            bool IsAnim = anim2D is Anim2D;
            IsAnim &= anim3D is Anim3D;

            System.Console.WriteLine($"[TEST A] [{IsAnim.ToString().ToUpper()}]");
        }

        public void Test_B_C()
        {
            IFactory factory = new ButtonCheckBoxFactory<Button2D, CheckBox2D>();

            ICheckBox box = factory.CreateCheckBox();
            IButton button = factory.CreateButton();

            bool pass = box is CheckBox2D;
            pass &= button is Button2D;

            System.Console.WriteLine($"[TEST B-C] [{pass.ToString().ToUpper()}]");
        }

        public void Test_D_E_2D()
        {
            IFactory fac = new MeshSpriteFactory(prototypeMesh2D, prototypeSprite2D);

            ISprite sprite = fac.CreateSprite();
            IMesh mesh = fac.CreateMesh();

            bool AreEqual = sprite.Equals(prototypeSprite2D);
            AreEqual &= mesh.Equals(prototypeMesh2D);
            System.Console.WriteLine($"[TEST D-E-2D] [{AreEqual.ToString().ToUpper()}]");
        }

        public void Test_D_E_3D()
        {
            IFactory fac = new MeshSpriteFactory(prototypeMesh3D, prototypeSprite3D);

            ISprite sprite = fac.CreateSprite();
            IMesh mesh = fac.CreateMesh();

            bool AreEqual = sprite.Equals(prototypeSprite3D);
            AreEqual &= mesh.Equals(prototypeMesh3D);
            System.Console.WriteLine($"[TEST D-E-3D] [{AreEqual.ToString().ToUpper()}]");
        }
    }
}
