using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableStructIndexerEnum.Models
{
    internal class ListInt
    {
        int[] _arr;

        public int Count { get { return _arr.Length; } }
        public int this[int index] 
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
        public ListInt()
        {
            _arr = new int[0];
        }
        public ListInt(int length)
        {
            _arr= new int[length];
        }

        public ListInt(params int[] nums)
        {
            _arr=nums;
        }

        public void Add(int num)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = num;
        }
        

    }
}
