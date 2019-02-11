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
            CustomList<int> list = new CustomList<int>();

            list.Add(2);
            list.Add(4);
            list.Add(6);
            list.Add(24);
            list.Add(13);
            list.Add(9);
            list.Add(60);
            list.Add(47);

        }
    }
}
