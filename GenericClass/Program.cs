using System;
using System.Collections.Generic;

namespace GenericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Malatya");
            sehirler.Add("Giresun");
            Console.WriteLine(sehirler.Count);

            MyList<string> myList = new MyList<string>();
            myList.Add("İstanbul");
            myList.Add("İzmir");
            Console.WriteLine(myList.Count);
        }
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
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length - 1] = item;
        }
        public int Count
        {
            get { return _array.Length; }
        }

    }
}
