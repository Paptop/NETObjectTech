using System;
using System.Collections.Generic;
using System.Text;
using Task5.Classic.Components;
using Task5.Classic.Components.Leafs;

namespace Task5.Classic.Visitors
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
