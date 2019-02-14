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
            CustomList<int> list = new CustomList<int>() { 1, 4, 5 };
            CustomList<int> listTwo = new CustomList<int>() { 1, 4, 6 };
            CustomList<int> result = new CustomList<int>() { };
            //list = list.Zip(list, listTwo);
            //result = list + listTwo;
            result = list - listTwo;
            //Console.WriteLine(result);
            //Console.ReadLine();

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

            //list.Remove(3);
            //list.Remove(4);
        }
    }
}
