using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Production
{
    public enum FactLayer { INITIAL = 0, SECOND, THIRD, FINAL, UNDEFINED}

    public class Fact : IComparable
    {
        public string description;
        public int number;
        public FactLayer layer;
        public Fact(string description, int number, FactLayer layer)
        {
            this.description = description;
            this.number = number;
            this.layer = layer;
        }

        public int CompareTo(object other)
        {
            var fact = other as Fact;
            return 1;
        }
    }

    public class Rule
    {
        public int id;
        public List<Fact> premises;
        public Fact production; 
        public Rule(int id, List<Fact> premises, Fact production)
        {
            this.id = id;
            this.premises = premises;
            this.production = production; 
        }
    }
}
