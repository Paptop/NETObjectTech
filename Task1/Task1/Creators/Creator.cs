using System;
namespace Task1.Creators
{
    public abstract class Creator<T>
    {
        public Creator()
        {
        }

        public abstract T Create();
    }
}
