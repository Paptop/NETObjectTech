using System;
using Task1.Interfaces;

namespace Task1.Products.C
{
    public class WebButton : IButton
    {
        public WebButton()
        {
        }

        public void CheckInput(string Event)
        {
            if (Event == "Dom.ButtonPressed")
            {
                System.Console.WriteLine("Checking input for web button");
            }
        }

        public void Enable(bool bEnable)
        {
            System.Console.WriteLine("Web Button state: " + bEnable);
        }
    }
}
