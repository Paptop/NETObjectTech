using System;
using System.Collections.Generic;
using System.Text;
using Task5.Reflection.Components;
using Task5.Reflection.Components.Leafs;

namespace Task5.Reflection.Visitors
{
    class ReflectionSerializeVisitor : IVisitor
    {
        public void VisitAll(IEnumerable<Node> nodes)
        {
            foreach(Node node in nodes)
            {
                Type type = node.GetType();
                var method = GetType().GetMethod("Visit", new Type[] { type });
                if(method == null)
                {
                    throw new MissingMethodException();
                }
                method.Invoke(this, new object[] {node});
            }
        }

        public void Visit(Scene scene)
        {
            System.Console.WriteLine("Serialiazing scene");
        }

        public void Visit(Mesh mesh)
        {
            System.Console.WriteLine("Serializing mesh");
        }

        public void Visit(Sprite sprite)
        {
            System.Console.WriteLine("Serializing sprite");
        }

        public void Visit(Particle particle)
        {
            System.Console.WriteLine("Serializing particle");
        }
    }
}
