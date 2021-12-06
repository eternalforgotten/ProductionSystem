using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Production
{
    enum FactLayer { INITIAL = 0, SECOND, THIRD, FINAL, UNDEFINED}
    class Fact
    {
        public String description;
        public int number;
        public FactLayer layer;
        public Fact(String description, int number, FactLayer layer)
        {
            this.description = description;
            this.number = number;
            this.layer = layer;
        }
    }
}
