using System;
namespace Task1.Creators
{
    public abstract class Creator<Type> where Type : class
    {
        public Creator()
        {
        }

        public abstract Type Create();
    }
}
