using System;
using System.Collections;

namespace Task1.Creators
{
    public abstract class Creator<Type> where Type : class
    {
        public Creator()
        {
        }

        public abstract Type Create(Hashtable param);
    }
}
