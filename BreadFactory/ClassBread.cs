using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;

namespace BreadFactory
{
    public abstract class BaseBread
    {
        public abstract void Show();
        
        public abstract JObject GetData();
          
    }

    public class Bread : BaseBread
    {
        public JObject Data = new JObject();
        public string BreadType;
        
        public Bread(Recipe BreadRecipe)
        {
            BreadType = BreadRecipe.Name;
            Data.Add("breadType", BreadType);
            Data.Add("recipe", BreadRecipe.GetRecipe());

        }

        
        public override void Show()
        {
            string Original = Data.ToString();
            string[] Target = {": {", "{", "  ", "\"", ",", "}"};
            foreach (string i in Target)
            {
                Original = Original.Replace(i, "");
            }
            Console.WriteLine(Original);

        }

        public override JObject GetData()
        {
            return Data;
        }

    }


}
