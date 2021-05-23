using System;
using System.Collections.Generic;
using System.Text;

// It's rare that we create generics
// We most often use generics from the .net framework
namespace Foundation.Advanced_Topics
{
    class Generics
    {

    }

    // Generic list of objects
    // Generics have a parameter, typically it's just "T" for template or type.
    public class GenericList<T>
    {
        public void Add(T Value)
        {

        }

        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }

    // Generic Dictionary/keyvarlue pars
    public class GenericDictionary<TKey, TValue>
    {
        public void Add(TKey key, TValue value)
        {

        }
    }
}
