using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

using Task1.Products.Button;
using Task1.Products.Mesh;
using Task1.Products.CheckBox;
using Task1.Products.Sprite;
using Task1.Factories;


namespace Task1
{
    class Program
    {
        private static CreatorFactory  factory = new CreatorFactory();
        private static Dictionary<string, string> AcceptedTypes = new Dictionary<string, string>()
        {
            {"Sprite2D", "Task1.Products.Sprite.Sprite2D" },
            {"Sprite3D", "Task1.Products.Sprite.Sprite3D" },

            {"Mesh2D", "Task1.Products.Mesh.Mesh2D" },
            {"Mesh3D", "Task1.Products.Mesh.Mesh3D" },

            {"CheckBox2D", "Task1.Products.CheckBox.CheckBox2D" },
            {"CheckBox3D", "Task1.Products.CheckBox.CheckBox3D" },

            {"Button2D", "Task1.Products.Button.Button2D"},
            {"Button3D", "Task1.Products.Button.Button3D" },

            {"Anim2D", "Task1.Products.Animation.Anim2D" },
            {"Anim3D", "Task1.Products.Animation.Anim3D" }
        };

        static Object Create(string type)
        {
            string fullType = "";
            if(!AcceptedTypes.TryGetValue(type,out fullType))
            {
                throw new ArgumentException($"Wrong type {type}");
            }

            Type ctype = Type.GetType(fullType);
            return factory.Assemble(ctype, new Hashtable(){});
        }

        static void Main(string[] args)
        {
            Test test = new Test();
            HandleArgument(args);
        }

        static void HandleArgument(string[] args)
        {
            try
            {
                if (args.Length == 0)
                {
                    throw new ArgumentException("Bad argument count");
                }
                System.Console.WriteLine($"Assembled object : {Create(args[0])}");
            }
            catch(ArgumentException earg)
            {
                System.Console.WriteLine($"{earg}\n[MSG] Passed argument via command line is invalid");
                System.Environment.Exit(1);
            }
        }
    }
}
