using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableStructIndexerEnum.Models
{
    internal class CustomList<T>
    {
        T[] _arr;

        public int Count { get { return _arr.Length; } }
        public T this[int index] 
        { 
            get
            {
                if (index<_arr.Length)
                {
                    return _arr[index];
                }
                
                return _arr[_arr.Length - 1];
              
            }
            set
            {
                if (index<_arr.Length)
                {
                    _arr[index] = value;
                }
               
            }
        }
        public CustomList()
        {
            _arr = new T[0];
        }
        public CustomList(int length)
        {
            _arr= new T[length];
        }

        public CustomList(params T[] nums)
        {
            _arr=nums;
        }

        public void Add(T item)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = item;
        }
        

    }
}
