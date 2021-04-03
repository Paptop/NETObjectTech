using System;
using Task1.Factories;
using Task1.Interfaces;
using Task1.Products.D;
using Task1.Products.E;

namespace Task1
{

    public class Bar
    {
    }

    public class Foo
    {
        public Bar[,] multiarray = new Bar[10,10];
        public Foo instance;

        public Foo()
        {
            for(int i = 0; i < 10; ++i)
            {
                for(int j = 0; j < 10; ++j)
                {
                    multiarray[i,j] = new Bar();
                }
            }
        }
    }

    [Serializable]
    public class Test : UniversalClone
    {
        public Test Instance { set { test = value; }  get { return test; } }
        private Test test;


        public bool TestRecursiveClone()
        {
            //Limited simple implementation
            Test test_0 = new Test();
            test_0.Instance = test_0;
            Test test_clone = (Test)UniClone(test_0);
            return test_clone != test_0 &&
                   test_clone.Instance == test_clone;
        }

        public bool TestProduction()
        {
            //A more twisted way to deep copy
            Test test_0 = new Test();
            test_0.Instance = test_0;
            Test test_clone = DeepClone<Test>(test_0);
            return test_clone != test_0 &&
                   test_clone.Instance == test_clone;
        }

        public bool TestProduction2()
        {
            //A more cleaner production way to deep copy
            Foo test_0 = new Foo();
            test_0.instance = test_0;
            Foo test_clone = ProductionUniClone.Copy(test_0);
            return test_clone != test_0 &&
                   test_clone.multiarray != test_0.multiarray &&
                   test_clone.instance == test_clone;
        }

        public bool TestAndroidButtonClone()
        {
            /*
             * IOS class uses clone via production clone method, using reflection.
             * 
             * Android is using vanilla cloning using protected constructors.
             */
            CustomAndroidButton original_button = new CustomAndroidButton();
            //Changing custom attribute of button
            original_button.CustomData = new Products.Data(9999);
            //Changing parent attribute of button
            original_button.AndroidData = new Products.Data(13);

            CustomIOSCheckBox original_box = new CustomIOSCheckBox();
            //Changing custom attribute of box
            original_box.CustomIOSData = new Products.Data(7777);
            //Changing parent attribute of box
            original_box.IOSData = new Products.Data(8888);

            FactoryDE fac = new FactoryDE(original_button, original_box);


            bool isValid = true;

            IButton button_clone = fac.CreateButton("mycanvas");
            CustomAndroidButton custom = (CustomAndroidButton)button_clone;
            isValid &= custom.CustomData.Pointer == 9999 &&
                       custom.AndroidData.Pointer == 13 &&
                       custom.CustomData != original_button.CustomData && //Checking references
                       custom.AndroidData != original_button.AndroidData;

            ICheckBox check_clone = fac.CreateCheckBox("mycanvas");
            CustomIOSCheckBox custom_box = (CustomIOSCheckBox)check_clone;
            isValid &= custom_box.CustomIOSData.Pointer == 7777 &&
                       custom_box.IOSData.Pointer == 8888 &&
                       custom_box.CustomIOSData != original_box.CustomIOSData &&
                       custom_box.IOSData != original_box.IOSData;

            return isValid;
        }
    }
}
