using System;

using System.Collections.Generic;
using System.Collections;
using System.Reflection;

using Task1.Creators;

using Task1.Products.Animation;
using Task1.Products.Button;
using Task1.Products.CheckBox;
using Task1.Products.Sprite;
using Task1.Products.Mesh;
using Task1.Products;



namespace Task1.Factories
{
    public class CreatorFactory
    {
        Dictionary<Type, Creator<IMesh>> MeshCreators = new Dictionary<Type, Creator<IMesh>>();
        Dictionary<Type, Creator<ISprite>> SpriteCreators = new Dictionary<Type, Creator<ISprite>>();

        Hashtable Creators = new Hashtable();

        public CreatorFactory()
        {
            Creators.Add(typeof(IMesh), MeshCreators);
            Creators.Add(typeof(ISprite), SpriteCreators);

            RegisterType<IMesh, Mesh2D>();
            RegisterType<IMesh, Mesh3D>();
            RegisterType<ISprite, Sprite2D>();
            RegisterType<ISprite, Sprite3D>();
        }

        public void RegisterType<T,C>()
            where T : class
            where C : T, new()
        {
            Dictionary<Type, Creator<T>> familyOfCreators = (Dictionary<Type, Creator<T>>)Creators[typeof(T)];
            Creator<T> creator = new ConcreteCreator<T, C>();
            familyOfCreators.Add(typeof(C), creator);
        }

        public T Create<T,C>(Hashtable param)
            where T : class
            where C : T, new()
        {
            Dictionary<Type, Creator<T>> familyOfCreators = (Dictionary<Type, Creator<T>>)Creators[typeof(T)];
            return familyOfCreators[typeof(C)].Create(param);
        }

        public Object Assemble(Type type, Hashtable param)
        {
            Type[] parent = type.GetInterfaces();
            MethodInfo method = typeof(CreatorFactory).GetMethod("Create");
            MethodInfo genericMethod = method.MakeGenericMethod(parent[0],type);
            return genericMethod.Invoke(this, new object[] {param});
        }
    }
}
