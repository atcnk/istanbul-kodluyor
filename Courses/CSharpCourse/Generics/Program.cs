using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cities = new List<string>();
        }

        class MyList<T>
        {
            T[] _array;
            T[] _tempArray;

            public MyList()
            {
                _array = new T[0];
            }

            public void Add(T item)
            {
                _tempArray = _array;
                _array = new T[_array.Length + 1];
            }

            public int Count
            {
                get { return _array.Length; }
            }
        }
    }
}
