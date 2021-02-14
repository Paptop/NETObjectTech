using System;
namespace Task1.Creators
{
    public class ConcreteCreator<Type,ConcreteType> : Creator<Type>
        where Type : class
        where ConcreteType : Type, new()
    {
        public ConcreteCreator()
        {
        }

        public override Type Create()
        {
            return new ConcreteType();
        }
    }
}
