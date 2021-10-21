using System;
using System.Collections.Generic;

namespace BreadFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Recipe cream = new Recipe("cream", 100, 100, 200);
            Recipe sugar = new Recipe("sugar", 100, 50, 200);
            Recipe butter = new Recipe("butter", 100, 100, 200);

            List<Bread> BreadData = new List<Bread>();
            //Bread Cream = new Bread(cream);
            //Bread Sugar = new Bread(sugar);
            //Bread Butter = new Bread(butter);

            BreadData.Add(new Bread(cream));
            BreadData.Add(new Bread(sugar));
            BreadData.Add(new Bread(butter));


            foreach (Bread EachBread in BreadData)
            {
                EachBread.Show();
            }

        }
    }
}
