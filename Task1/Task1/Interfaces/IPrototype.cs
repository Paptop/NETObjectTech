using System;
namespace Task1.Interfaces
{
    public interface IPrototype
    {
        public IPrototype Clone()
        {
            //Default implementation using reflection
            return ProductionUniClone.Copy(this);
        }

        void Init(string canvas);
    }
}
