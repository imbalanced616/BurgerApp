using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp
{
    public class Burger
    {
        private string Name;
        private int Beef;
        private int Salad;
        private int Tomato;
        private int Onion;
        private int Cucumber;
        private int Count;
        private int Price;
        public string NAME
        {
            get { return Name; }
            set { Name = value; }
        }
        public int BEEF
        {
            get { return Beef; }
            set { Beef = value; }
        }
        public int SALAD
        {
            get { return Salad; }
            set { Salad = value; }
        }
        public int TOMATO
        {
            get { return Tomato; }
            set { Tomato = value; }
        }
        public int ONION
        {
            get { return Onion; }
            set { Onion = value; }
        }
        public int CUCUMBER
        {
            get { return Cucumber; }
            set { Cucumber = value; }
        }
        public int COUNT
        {
            get { return Count; }
            set { Count = value; }
        }
        public int PRICE
        {
            get { return Price; }
            set { Price = value; }
        }
        public Burger()
        {
            Name = "";
            Beef = 0;
            Salad = 0;
            Tomato = 0;
            Onion = 0;
            Cucumber = 0;
            Count = 0;
            Price = 0;
        }
        public Burger(string name, int beef, int salad, int tomato, int onion, int cucumber, int count)
        {
            Name = name;
            Beef = beef;
            Salad = salad;
            Tomato = tomato;
            Onion = onion;
            Cucumber = cucumber;
            Count = count;
            Price = count * (beef + salad * 10 + tomato * 5 + onion * 5 + cucumber * 15);
        }
    }
}
