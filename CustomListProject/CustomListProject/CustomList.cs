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
        //gives the correct value while method is being called, needs a place to store that new result
        public CustomList<T>Zip(CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> finalResult = new CustomList<T>();           
            if (listOne.Count != 0)
            {
                for (int i = 0; i < listOne.Count; i++)
                {
                    finalResult.Add(listOne[i]);
                    finalResult.Add(listTwo[i]);
                }
            }
            
            return finalResult;

            //if (listOne.Count != 0)
            //{
            //for (int i = 0; i < listOne.Count; i++)
            //{
            //   yield return finalResult.Add(listOne[i]);
            //    yield return finalResult.Add(listTwo[i]);

            //}
            //}
            //return finalResult;
        }


        //Overload + operator
        public static CustomList<T> operator +(CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> finalList = new CustomList<T>();
            if (listOne.Count != 0)
            {
                for (int i = 0; i < listOne.Count; i++)
                {
                    finalList.Add(listOne[i]);
                }
            }
            if (listTwo.Count != 0)
            {
                for (int j = 0; j < listTwo.Count; j++)
                {
                    finalList.Add(listTwo[j]);
                }
            }
            
            return finalList;               
        }
        //OverLoad - operator
        public static CustomList<T> operator -(CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> finalList = new CustomList<T>();
            if (listOne.Count != 0)
            {
                for (int i = 0; i < listOne.Count; i++)
                {
                    finalList.Add(listOne[i]);
                }
            }
            if (listTwo.Count != 0)
            {
                for (int j = 0; j < listTwo.Count; j++)
                {
                    finalList.Add(listTwo[j]);
                }
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
            //index was replaced with Count in for loop
            for (int i = 0; i < Count; i++)
            {
                newArray[i] = firstArray[i + 1];
            }
            firstArray = newArray;
        }
        
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
