using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T>
    {
        private T[] items = new T[2];
        public int Count  { get; set; }
        private int Capacity { get; set; }
        
        public CustomList()
        {
            Count = 0;
            Capacity = 0;
        }
        public void Add(T item)
        {
            items[Capacity] = item;
            Capacity++;
            Count++;
            //count equals zero, then for how many items in list, capacity goes up one
            //i think this currently runs an infinite loop
            for (int i = 0; i < Count; Capacity++)
            {
                if (Count > 2)
                {
                    T[] items = new T[2];
                }
            }
            
            
            
        }
        public void Remove(T item)
        {

        }
        
    }
}
