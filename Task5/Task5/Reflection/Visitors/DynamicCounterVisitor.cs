using System;
using System.Collections.Generic;
using System.Text;
using Task5.Reflection.Components;
using Task5.Reflection.Components.Leafs;

namespace Task5.Reflection.Visitors
{
    public class DynamicCounterVisitor : IVisitor
    {
        private int Scenes = 0;
        private int Sprites = 0;
        private int Particles = 0;
        private int Meshes = 0;

        //Custom addition
        private int Nodes2d = 0;
        private int Nodes3d = 0;

        public void VisitAll(IEnumerable<Node> nodes)
        {
            foreach(Node node in nodes)
            {
                Visit((dynamic)node);
            }

            System.Console.WriteLine("Nodes2d : " + Nodes2d);
            System.Console.WriteLine("Nodes3d : " + Nodes3d);

            System.Console.WriteLine("Scenes :" + Scenes);
            System.Console.WriteLine("Sprites : " + Sprites);
            System.Console.WriteLine("Particles : " + Particles);
            System.Console.WriteLine("Meshes : " + Meshes);
        }

        //Added new methods, without changing the interface

        public void Visit(Node2D node2d)
        {
            System.Console.WriteLine("Counting by a new method: Node2D");
            Nodes2d++;
        }

        public void Visit(Node3D node3d)
        {
            System.Console.WriteLine("Counting by a new method: Node3D");
            Nodes3d++;
        }


        //Interface methods
        public void Visit(Scene scene)
        {
            Scenes++;
        }

        public void Visit(Mesh mesh)
        {
            Meshes++;
        }

        public void Visit(Sprite sprite)
        {
            Sprites++;
        }

        public void Visit(Particle particle)
        {
            Particles++;
        }
    }
}
