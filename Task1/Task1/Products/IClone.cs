using System;
namespace Task1.Products
{
    public interface IClone<T>
    {
        T Clone()
        {
            throw new NotImplementedException();
        }
    }
}
