using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FisherYatesShuffle
{
    class ArrayShuffle
    {
        private static Random _swap;

        public ArrayShuffle()
        {
            _swap = new Random();   
        }

        public void Shuffle<T>(T[] array)
        {
            int length = array.Length;
            for (int index = 0; index < length; index++)
            {
                int current = _swap.Next(index, length);
                T temp = array[index];
                array[index] = array[current];
                array[current] = temp;
            }
        }

        public void Shuffle<T>(List<T> list)
        {
            T[] array = list.ToArray();
            Shuffle(array);
            list.Clear();
            list.AddRange(array);
        }
    }
}
