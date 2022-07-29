using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class GenericCollection<T>
    {
        private T[] _values;
        private int _maxLength;

        public GenericCollection(int maxLength)
        {
            _maxLength=maxLength;
            _values = new T[maxLength];
        }

        public T this[int index]
        {
            get => _values[index];
            set => _values[index] = value;
        }
        public void SwapItems(int index1, int index2)
        {
            if (index1 == index2)
                throw new Exception("Indexes must be different!");
            (_values[index1], _values[index2]) = (_values[index2],_values[index1]);
        }
        public void SwapItems( T value1, T value2)
        {
            SwapItems(Array.IndexOf(_values, value1), Array.IndexOf(_values, value2));
        }
        public void SwapItems(int index1, T value2)
        {
            SwapItems(index1, Array.IndexOf(_values, value2));
        }
        public void SwapItems(T value1, int index2)
        {
            SwapItems(Array.IndexOf(_values,value1),index2);
        }
    }
}
