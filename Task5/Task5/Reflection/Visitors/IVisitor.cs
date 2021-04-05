using System;
using System.Collections.Generic;
using System.Text;
using Task5.Reflection.Components;
using Task5.Reflection.Components.Leafs;

namespace Task5.Reflection.Visitors
{
    public interface IVisitor
    {
        void Visit(Scene scene);
        void Visit(Mesh mesh);
        void Visit(Sprite sprite);
        void Visit(Particle particle);

        void VisitAll(IEnumerable<Node> nodes);
    }
}
