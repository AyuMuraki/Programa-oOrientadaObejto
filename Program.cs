using System;
using System.Collections.Generic;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("da");
            list.Add("Gloria");
            list.Add("Muraki");
            list.Add("Naruse");


            foreach (string obj in list)
            {
                Console.WriteLine(obj);



            }
            Console.WriteLine("List Count:" + list.Count);

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("List count " + s1);


            string s2 = list.Find(x => x[0] == 'A');
            Console.WriteLine("List count " + s2);


            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("List position " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("List position " + pos2);

            List<string> list2 = list.FindAll(X => X.Length == 5);

            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }

            list.Remove("Muraki");
            Console.WriteLine("--------------");
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("--------------");
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }


        }
    }
}