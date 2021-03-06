﻿using System;
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
        public int Count { get { return count; } }
        private int count;
        private int Capacity { get; set; }
        

        public CustomList()
        {
            count = 0;
            Capacity = 4;
            
            firstArray = new T[Capacity];
        }
        public T this[int i]
        {
            //if ( count >= i >= 0)
              //{
           
                get { return firstArray[i]; }
                set { firstArray[i] = value; }
            
              //}
        }
        public void Add(T item)
        {
            if (count == Capacity) //this only happens once the array is filled with values
            {
                Capacity += 4; //adds another 4 to the capacity counter with the new array
                T[] newArray = new T[Capacity]; //creates new array with as many indexes as the capacity counter
                for (int i = 0; i < count; i++) 
                {
                    newArray[i] = firstArray[i];
                }
                firstArray = newArray;
                firstArray[count] = item;
                count++;
            }
            else
            {
                firstArray[count] = item;
                count++;
            }
        }
        
        
        public CustomList<T>Zip(CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> finalResult = new CustomList<T>();
            if (listOne.count != 0)
            {
                for (int i = 0; i < listOne.count; i++)
                {
                    finalResult.Add(listOne[i]);
                    finalResult.Add(listTwo[i]);
                }
            }          
            return finalResult;

        }


        //Overload + operator
        public static CustomList<T> operator +(CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> finalList = new CustomList<T>();
            if (listOne.count != 0)
            {
                for (int i = 0; i < listOne.count; i++)
                {
                    finalList.Add(listOne[i]);
                }
            }
            if (listTwo.count != 0)
            {
                for (int j = 0; j < listTwo.count; j++)
                {
                    finalList.Add(listTwo[j]);
                }
            }
            
            return finalList;               
        }

        //OverLoad - operator       
        public static CustomList<T> operator -(CustomList<T> listOne, CustomList<T> listTwo)
        {         
                foreach (T item1 in listOne)
                {                   
                    for (int i = 0; i < listTwo.count; i++)
                    {
                    if (item1.Equals(listTwo[i]))
                        {
                            listOne.Remove(item1);               
                        }
                    }
                }           
            return listOne;
        }
      
        public bool Remove(T item)
        {           
            T[] newArray = new T[Capacity];           
            foreach (T item1 in firstArray)
            {
                int j = 0;
                for (int i = 0; i < count; i++)
                {                   
                    if (!item.Equals(firstArray[i]))
                    {                      
                        newArray[j] = firstArray[i];
                        j++;
                    }
                }
            }
            count--;
            firstArray = newArray;
            return true;
        }
        //public bool Remove(T item)
        //{
        //    for (int i = 0; i < count; i++)
        //    {
        //        if (firstArray[i].Equals(item))
        //        {
        //            count--;
        //            ShiftItems(i);
        //            return true;
        //        }
        //    }
        //    return false;
        //}
        //private void ShiftItems(int index)
        //{
        //    T[] newArray = new T[Capacity];
        //    //index was replaced with count in for loop
        //    for (int i = 0; i < count; i++)
        //    {
        //        newArray[i] = firstArray[i + 1];
        //    }
        //    firstArray = newArray;
        //}

        public override string ToString() 
        {
            string myString = "";
            for (int i = 0; i < count; i++)
            {
               myString += $"{firstArray[i]}";               
            }
            return myString;
        }

        public IEnumerator GetEnumerator()
        {
            
            for (int index = 0; index < firstArray.Length; index++)
            {
                yield return firstArray[index];
            }
        }


    
        
        

        
            


    }
}
