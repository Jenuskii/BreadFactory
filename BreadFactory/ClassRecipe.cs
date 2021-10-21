using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;

namespace BreadFactory
{
    public abstract class BaseRecipe
    {
        public abstract void SetName(string name);

        public abstract void NumberInput(int n1, int n2, int n3); 
    }

    public class Recipe : BaseRecipe
    {
        public string Name;
        public JObject JsonRecipe = new JObject();

        public Recipe(string name, int n1, int n2, int n3)
        {
            SetName(name);
            NumberInput(n1, n2, n3);
        }

        public override void SetName(string name)
        {
            Name = name;
        }

        public override void NumberInput(int n1, int n2, int n3)
        {
            JsonRecipe.Add("flour", n1);
            JsonRecipe.Add("water", n2);
            JsonRecipe.Add(Name, n3);
        }

        public JObject GetRecipe()
        {
            return JsonRecipe;
        }

    }


}
