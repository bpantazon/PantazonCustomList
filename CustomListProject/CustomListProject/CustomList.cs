using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T>
    {
        private T[] firstArray = new T[4];
        public int Count  { get; set; }
        private int Capacity { get; set; }
        
        public CustomList()
        {
            Count = 0;
            Capacity = 4;
            firstArray = new T[Capacity];
        }
        public void Add(T item)
        {
            if (Count == Capacity)
            {
                Capacity += 4;
                T[] newArray = new T[Capacity];
                
            }
            else
            {
                firstArray[Count] = item;

                Count++;
            }
            
            

            //count equals zero, then for how many items in list, count goes up one
            //currently runs an infinite loop
            //for (int i = 0; i < Count; Capacity++)
            //{
            //    if (Count > 2)
            //    {
            //        T[] items = new T[2];
            //    }
            //}
            
            //array is made with count and capacity of 0
            //array is made as T[1]
            //item is added, count++, capacity = 4
            //
            
            
            
        }
        public void Remove(T item)
        {

        }
        
    }
}
