using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> list = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> listTwo = new CustomList<int>() { 2, 4, 6 };
            CustomList<int> result = new CustomList<int>() { };
            list.Zip(list, listTwo);
            //List<int> result = list + listTwo;
            //list.Add(2);
            //list.Add(4);
            //list.Add(6);
            //list.Add(24);
            //list.ToString();
            //Console.WriteLine(list[0]);
            //list.Add(27);
            //list.Add(99);
            //list.Add("good");
            //list.Add("bad");
            //list.Add("Monday");
            //list.Add("Ron");

            //list.Remove(2);
            //list.Remove(4);
        }
    }
}
