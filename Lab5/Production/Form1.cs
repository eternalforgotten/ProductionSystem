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

            InitialFacts.Items.AddRange(facts.Where(f => f.layer == FactLayer.INITIAL).Select(f => f.description).ToArray());
            Finals.Items.AddRange(facts.Where(f => f.layer == FactLayer.FINAL).Select(f => f.description).ToArray());

        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            Result.Items.Clear(); 

            List<Fact> initials = new List<Fact>();
            foreach (var fact in InitialFacts.CheckedItems)
            {
                string f = fact as string;
                initials.Add(facts.Find(x => x.description == f));
            }

            for (int i = 1; i < 4; ++i)
            {
                foreach (var rule in rules.Where(r => (int)r.production.layer == i))
                {
                    if (rule.premises.All(p => initials.Contains(p)))
                    {
                        initials.Add(rule.production); 
                    }
                }
            }

            Result.Items.AddRange(initials.Where(f => f.layer == FactLayer.FINAL).Select(f => f.description).ToArray());

        }

        private void Result_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Result.SelectedItem == null)
                return;

            var name = (string)Result.SelectedItem;


        }

        private void Finals_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BackwardButton_Click(object sender, EventArgs e)
        {
            if (Finals.SelectedItem == null)
                return;

            var text = (string)Finals.SelectedItem;

            List<Fact> set = new List<Fact>() { facts.Find(f => f.description == text) };

            while (!set.All(elem => elem.layer == FactLayer.INITIAL))
            {
                List<Fact> newSet = new List<Fact>(set); 
                foreach (var fact in set.Where(f => f.layer != FactLayer.INITIAL))
                {
                    newSet.AddRange(rules.Find(r => r.production == fact).premises);

                    newSet.Remove(fact);

                    newSet = newSet.Distinct().ToList(); 
                }
                set = new List<Fact>(newSet);
            }

            Result.Items.Clear();
            Result.Items.AddRange(set.Select(elem => elem.description).ToArray());
        }

        private void CanCookButton_Click(object sender, EventArgs e)
        {
            if (Finals.SelectedItem == null)
                return;

            var text = (string)Finals.SelectedItem;

            List<Fact> set = new List<Fact>() { facts.Find(f => f.description == text) };

            while (!set.All(elem => elem.layer == FactLayer.INITIAL))
            {
                List<Fact> newSet = new List<Fact>(set);
                foreach (var fact in set.Where(f => f.layer != FactLayer.INITIAL))
                {
                    newSet.AddRange(rules.Find(r => r.production == fact).premises);

                    newSet.Remove(fact);

                    newSet = newSet.Distinct().ToList();
                }
                set = new List<Fact>(newSet);
            }

            Result.Items.Clear();
            Result.Items.Add(set.All(elem => InitialFacts.CheckedItems.Contains(elem.description)).ToString());
        }
    }
}
