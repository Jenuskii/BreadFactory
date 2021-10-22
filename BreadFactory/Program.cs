using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace BreadFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Bread Cream = new Cream(200);
            Bread Sugar = new Sugar(200);
            Bread Butter = new Butter(50);

            //List<string> list = new List<string>();

            //list.Add(Cream.Recipe.ToString());
            //list.Add(Sugar.Recipe.ToString());
            //list.Add(Butter.Recipe.ToString());




            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);

            //}
            //Console.WriteLine(list.ToString());



            List<string> list = new List<string>();
            list.Add(Cream.Recipe.ToString());
            list.Add(Sugar.Recipe.ToString());
            list.Add(Butter.Recipe.ToString());
            Console.WriteLine(list);
            string joinedNames = String.Join(", ", list.ToArray());
            Console.WriteLine("[" + joinedNames + "]");
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}
        }
    }
}
