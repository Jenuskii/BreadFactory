using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;

namespace BreadFactory
{
    public abstract class Bread
    {
        private string _breadType;
        private int _Flour;
        private int _Water;
        private JObject _Recipe = new JObject();
        

        public Bread(string Type)
        {
            breadType = Type;
        }

        public string breadType
        {
            get { return _breadType; }
            set { _breadType = value; }
        }

        public int Flour
        {
            get { return _Flour; }
            set { _Flour = value; }
        }

        public int Water
        {
            get { return _Water; }
            set { _Water = value; }
        }

        public abstract void SetFlour(int amount);

        public abstract void SetWater(int amount);
        



        public JObject Recipe
        {
            get { return _Recipe; }
        }

        public void MakeRecipe(int amount)
        {

            JObject temp = new JObject();
            temp.Add("flour", _Flour);
            temp.Add("water", _Water);
            temp.Add(_breadType.ToString(), amount);

            _Recipe.Add("breadType", _breadType);
            _Recipe.Add("recipe", temp);
            
        }

    }

    public class Cream : Bread
    {
        private int _FlavorAmount;
        

        public Cream(int amount)
            : base("cream")
        {
            this._FlavorAmount = amount;
            SetFlour(amount);
            SetWater(amount);
            base.MakeRecipe(amount);
        }

        public override void SetFlour(int amount)
        {
            base.Flour = amount / 2;            
        }

        public override void SetWater(int amount)
        {
            base.Water = amount / 2;
        }
    }

    public class Sugar : Bread
    {
        private int _FlavorAmount;


        public Sugar(int amount)
            : base("sugar")
        {
            this._FlavorAmount = amount;
            SetFlour(amount);
            SetWater(amount);
            base.MakeRecipe(amount);
        }

        public override void SetFlour(int amount)
        {
            base.Flour = amount / 2;
        }

        public override void SetWater(int amount)
        {
            base.Water = amount / 4;
        }
    }

    public class Butter : Bread
    {
        private int _FlavorAmount;


        public Butter(int amount)
            : base("butter")
        {
            this._FlavorAmount = amount;
            SetFlour(amount);
            SetWater(amount);
            base.MakeRecipe(amount);
        }

        public override void SetFlour(int amount)
        {
            base.Flour = amount * 2;
        }

        public override void SetWater(int amount)
        {
            base.Water = amount * 2;
        }
    }
}
