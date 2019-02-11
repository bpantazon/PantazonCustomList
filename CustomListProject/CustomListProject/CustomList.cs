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
            if (Count == Capacity) //this only happens once the array is filled with values
            {
                Capacity += 4; //adds another 4 to the capacity counter with the new array
                T[] newArray = new T[Capacity]; //creates new array with as many indexes as the capacity counter
                for (int i = 0; i < Count; i++) 
                {
                    newArray[i] = firstArray[i];
                }
                firstArray = newArray;
                firstArray[Count] = item;
                Count++;
            }
            else
            {
                firstArray[Count] = item;
                Count++;
            }
        }
        public bool Remove(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (firstArray[i].Equals(item))
                {
                    Count--;
                    ShiftItems(i);
                    return true;
                }
            }
            return false;
        }
        //make new array to hold values of firstArray, then start new array 
        private void ShiftItems(int index)
        {
            T[] newArray = new T[Capacity];
            //newArray = firstArray;
            //index was replaced with Count in for loop
            for (int i = 0; i < Count; i++)
            {
                newArray[i] = firstArray[i + 1];
            }
            firstArray = newArray;
        }
        
    }
}
