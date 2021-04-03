using System;
using System.Reflection;
using System.Collections.Generic;

using Task1.Products;
using Task1.Interfaces;
using Task1.Creators;

using Task1.Products.A;
using Task1.Products.B;
using Task1.Products.C;
using Task1.Products.D;
using Task1.Products.E;

using Task1.Factories;

namespace Task1
{
    class Program
    {
        private static Dictionary<string, IFactory> AcceptedTypes = new Dictionary<string, IFactory>()
        {
            {"A",  new FactoryA(743813,0.0f,1.0f)},

            {"B",  new FactoryBC(typeof(WinButton),typeof(WinCheckBox),0)},

            {"C",  new FactoryBC(typeof(WebButton), typeof(WebCheckBox), 0)},

            {"D",  new FactoryDE(new AndroidButton(), new AndroidCheckBox())},

            {"E",  new FactoryDE(new IOSButton(), new IOSCheckBox())},
        };


        static IFactory GetFactory(string type)
        {
            IFactory factory = null;
            if (!AcceptedTypes.TryGetValue(type, out factory))
            {
                throw new ArgumentException($"Wrong type {type}");
            }

            return factory;
        }

        static void HandleArgument(string[] args)
        {
            try
            {
                if (args.Length == 0)
                {
                    throw new ArgumentException("Bad argument count");
                }

                IFactory factory = GetFactory(args[0]);

                System.Console.Write("Enter canvas name: ");
                String canvas = System.Console.ReadLine();
                IButton button = factory.CreateButton(canvas);
                ICheckBox check = factory.CreateCheckBox(canvas);

                System.Console.WriteLine(button);
                System.Console.WriteLine(check);
            }
            catch (ArgumentException earg)
            {
                System.Console.WriteLine($"{earg}\n[MSG] Passed argument via command line is invalid");
                System.Environment.Exit(1);
            }
        }

        static void Main(string[] args)
        {
            /*
             * More checs, examples in Test.cs with specific initializations
             */
            Test test = new Test();
            System.Console.WriteLine("[TEST_REC]" + test.TestRecursiveClone());
            System.Console.WriteLine("[TEST_PRODUCTION]" + test.TestProduction());
            System.Console.WriteLine("[TEST_PRODUCTION_2]" + test.TestProduction2());
            System.Console.WriteLine("[TEST_CLONE_0]" + test.TestAndroidButtonClone());

            HandleArgument(args);
            System.Console.WriteLine("-----------------");
            CreatorExample_0();
            System.Console.WriteLine("-----------------");
            CreatorExample_1();
        }


        static void CreatorExample_0()
        {
            System.Console.Write("Enter canvas name: ");
            String canvas = System.Console.ReadLine();
            Creator<IButton> button = new CreatorUnixButton(canvas, 0, 0.0f, 0.0f);
            Creator<ICheckBox> checkBox = new CreatorUnixCheckBox(canvas, 0, 0.0f, 0.0f);
            CreatorFactory factory = new CreatorFactory(button, checkBox);


            System.Console.WriteLine(factory.CreateButton());
            System.Console.WriteLine(factory.CreateCheckBox());
        }

        static void CreatorExample_1()
        {
            object[] args = new object[2];
            string canvas = "default";

            System.Console.Write("Enter canvas name: ");
            canvas = System.Console.ReadLine();

            args[0] = canvas; //THE ARGUMENT IS PASSED HERE

            int window = 0;
            System.Console.Write("Enter window id: ");
            String id = System.Console.ReadLine();
            if(!Int32.TryParse(id, out window))
            {
                System.Console.WriteLine("Using id 0");
            }
            args[1] = window; //THE ARGUMENT IS PASSED HERE

            Creator<IButton> button = new UniversalCreator<IButton, WinButton>(args);
            Creator<ICheckBox> checkBox = new UniversalCreator<ICheckBox, WebCheckBox>(null);
            CreatorFactory factory = new CreatorFactory(button, checkBox);

            System.Console.WriteLine(factory.CreateButton());
            System.Console.WriteLine(factory.CreateCheckBox());
        }
    }
}
