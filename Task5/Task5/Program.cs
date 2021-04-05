using System;
using System.Collections.Generic;

namespace Task5
{
    using ClassicComp = Task5.Classic.Components;
    using ClassicLeafs = Task5.Classic.Components.Leafs;
    using ClassicVisit = Task5.Classic.Visitors;

    using ReflectComp = Task5.Reflection.Components;
    using ReflectLeafs = Task5.Reflection.Components.Leafs;
    using ReflectVisit = Task5.Reflection.Visitors;

    class Program
    {
        static void Main(string[] args)
        {
            ClassicalExample();
            System.Console.WriteLine("------------------");
            ReflectionExample();
            System.Console.WriteLine("------------------");
            MultipleDispatchExample();
            System.Console.WriteLine("------------------");
        }

        static void ClassicalExample()
        {
            List<ClassicComp.Node> nodes = new List<ClassicComp.Node>()
            {
                new ClassicLeafs.Sprite(), 
                new ClassicLeafs.Particle(), 
                new ClassicLeafs.Scene(), 
                new ClassicLeafs.Mesh()
            };

            ClassicVisit.IVisitor renderer = new ClassicVisit.RenderVisitor();
            renderer.VisitAll(nodes);
        }

        static void ReflectionExample()
        {
            List<ReflectComp.Node> nodes = new List<ReflectComp.Node>()
            {
                new ReflectLeafs.Sprite(), 
                new ReflectLeafs.Particle(), 
                new ReflectLeafs.Scene(), 
                new ReflectLeafs.Mesh()
            };

            ReflectVisit.IVisitor serializer = new ReflectVisit.ReflectionSerializeVisitor();
            serializer.VisitAll(nodes);
        }

        static void MultipleDispatchExample()
        {
            List<ReflectComp.Node> nodes = new List<ReflectComp.Node>()
            {
                new ReflectLeafs.Sprite(),
                new ReflectLeafs.Particle(),
                new ReflectLeafs.Scene(),
                new ReflectLeafs.Mesh(),
                new ReflectLeafs.Mesh(),
                new ReflectLeafs.Mesh(),
                new ReflectLeafs.Sprite(),
                new ReflectComp.Node2D(),  //Not supported by interface, but still counted
                new ReflectComp.Node3D()
            };

            ReflectVisit.DynamicCounterVisitor counter = new ReflectVisit.DynamicCounterVisitor();
            counter.VisitAll(nodes);
        }
    }
}
