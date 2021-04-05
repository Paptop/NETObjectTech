using System;
using System.Collections.Generic;
using System.Text;

namespace Task5.Reflection.Components.Leafs
{
    class DummyNoStaticalDependence : Node
    {
       // Added a new child, which do not need to implement accept method, thus no statical dependece for visitors
    }
}
