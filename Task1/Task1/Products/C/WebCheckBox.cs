using System;
using Task1.Interfaces;

namespace Task1.Products.C
{
    public class WebCheckBox : ICheckBox
    {
        public WebCheckBox()
        {
        }

        public void Toggle()
        {
            System.Console.WriteLine("Changing the state of html checkbox");
        }
    }
}
