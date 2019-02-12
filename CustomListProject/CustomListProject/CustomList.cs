using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T> : IEnumerable
    {
        private T[] firstArray = new T[4];
        public int Count { get; set; }
        private int Capacity { get; set; }
        
        //public T myString = (T)(object)"";
        //public string otherString = (string)(object);

        public CustomList()
        {
            Count = 0;
            Capacity = 4;
            firstArray = new T[Capacity];
        }
        public T this[int i]
        {
            //if ( Count >= i >= 0)
            //{

            get { return firstArray[i]; }
            set { firstArray[i] = value; }
            //}
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
        //needs a public modifier?
        //start of add two custom lists
        public static CustomList<T> operator +(CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> finalList = new CustomList<T>();
            for (int i = 0; i < (listOne.Count + listTwo.Count); i++)
            {
                finalList[i] = listOne[i];
                finalList[i + 1] = listTwo[i];
                //for (int j = 0; j < (listOne.Count + listTwo.Count); j++)
                //{
                //    finalList[j + 1]
                //}
            }
            return finalList;
               
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
        //doesn't work
        public override string ToString() 
        {
            string myString = "";
            //loop through your array and add value of each index to the empty string
            for (int i = 0; i < Count; i++)
            {
               myString = myString + $"{firstArray[i]}";
               
                
            }
            return myString;
        }

        public IEnumerator GetEnumerator()
        {
            //throw new NotImplementedException();
            for (int index = 0; index < firstArray.Length; index++)
            {
                yield return firstArray[index];
            }
        }


    
        
        

        
            


    }
}
