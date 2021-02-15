using System;
using System.Collections;

using Task1.Products;

namespace Task1.Creators
{
    public class ConcreteCreator<Type,ConcreteType> : Creator<Type>
        where Type : class
        where ConcreteType : Type, new()
    {
        public ConcreteCreator()
        {
        }

        public override Type Create(Hashtable param)
        {
            ConcreteType obj = new ConcreteType();
            IInitializable iobj = (IInitializable)obj;
            iobj.Init(param);
            return obj;
        }
    }
}
