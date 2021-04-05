using System;
using System.Collections.Generic;
using System.Text;
using Task5.Classic.Visitors;

namespace Task5.Classic.Components.Leafs
{
    public class Scene : Node
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
