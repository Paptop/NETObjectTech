using System;
using System.Collections.Generic;
using System.Text;
using Task5.Classic.Components;
using Task5.Classic.Components.Leafs;
using Task5.Classic.Visitors;

namespace Task5.Classic.Visitors
{
    /*
     * In this example render visitor forces Leafs to have an accept method
     */
    class RenderVisitor : IVisitor
    {
        public void Visit(Scene scene)
        {
            System.Console.WriteLine("Rendering scene");
        }

        public void Visit(Mesh mesh)
        {
            System.Console.WriteLine("Rendering mesh");
        }

        public void Visit(Sprite sprite)
        {
            System.Console.WriteLine("Rendering sprite");
        }

        public void Visit(Particle particle)
        {
            System.Console.WriteLine("Rendering particle");
        }

        public void VisitAll(IEnumerable<Node> nodes)
        {
            foreach (Node node in nodes)
                node.Accept(this);
        }
    }
}
