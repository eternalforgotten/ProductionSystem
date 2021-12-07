using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Production
{
    public partial class Form1 : Form
    {
        List<Fact> facts;
        List<Rule> rules;
        public Form1()
        {
            InitializeComponent();
            facts = Parsing.ParseFacts("facts.txt");
            rules = Parsing.ParseRules("rules.txt", facts);
        }
    }
}
