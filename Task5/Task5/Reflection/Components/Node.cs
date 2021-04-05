using System;
using System.Collections.Generic;
using System.Text;
using Task5.Classic.Visitors;

namespace Task5.Reflection.Components
{
    public abstract class Node
    {
        //NO accept method for components to implement
        //Proper dynamic visit method call is now delegated to reflection mechanism
    }
}
