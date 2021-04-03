using System;
namespace Task1.Creators
{
    public class UniversalCreator<T, CT> : Creator<T>
    {
        private Object[] _args = null;

        public UniversalCreator(Object[] arg)
        {
            _args = arg;
        }

        public override T Create()
        {
            var instance = (T)Activator.CreateInstance(typeof(CT), _args);
            return instance;
        }
    }
}
