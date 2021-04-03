using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;

namespace Task1.Interfaces
{
    [Serializable]
    public abstract class UniversalClone
    {
        public Object UniClone(Object obj)
        {
            if (obj == null)
            {
                return null;
            }

            Type type = obj.GetType();

            if (type.IsValueType || type == typeof(String))
            {
                return obj;
            }
            else if (type.IsClass)
            {
                Object toret = Activator.CreateInstance(obj.GetType());
                FieldInfo[] fields = type.GetFields(BindingFlags.Public |
                            BindingFlags.NonPublic | BindingFlags.Instance);
                foreach (FieldInfo field in fields)
                {
                    Object fieldValue = field.GetValue(obj);

                    if (fieldValue == null)
                    {
                        continue;
                    }
                    else if(fieldValue == obj) //Fix for recursion
                    {
                        field.SetValue(toret, toret); 
                        continue;
                    }

                    field.SetValue(toret, UniClone(fieldValue));
                }
                return toret;
            }
            else
            {
                throw new ArgumentException("Unknown Type");
            }
        }


        //C# deep copy production code
        //https://stackoverflow.com/questions/129389/how-do-you-do-a-deep-copy-of-an-object-in-net
        // A simple but hack approach
        // A more generic one see ProductionUniClone;

        public T DeepClone<T>(T obj)
        {
            using (var ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, obj);
                ms.Position = 0;

                return (T)formatter.Deserialize(ms);
            }
        }
    }
}
