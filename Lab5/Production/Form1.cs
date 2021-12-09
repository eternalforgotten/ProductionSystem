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

            InitialFacts.Items.AddRange((from fact in facts where fact.layer == FactLayer.INITIAL select fact.description).ToArray());
            Finals.Items.AddRange((from fact in facts where fact.layer == FactLayer.FINAL select fact.description).ToArray());

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
                foreach (var rule in rules.Where(r => (int)r.production.layer == i))
                    if (rule.premises.All(p => initials.Contains(p)))
                        initials.Add(rule.production); 

            Result.Items.AddRange((from fact in initials where fact.layer == FactLayer.FINAL select fact.description).ToArray());

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

        private void PrettyPrint(List<Fact> current, List<(Fact, Fact)> all, int tab = (int)FactLayer.FINAL)
        {
            foreach (var f in current)
            {
                Result.Items.Add(string.Join("", (from t in new string[((int)FactLayer.FINAL - tab) * 4] select ".")) + f.description);
                PrettyPrint(all.Where(a => a.Item2 == f).Select(i => i.Item1).ToList(), all, tab - 1);
            }
        }

        private void BackwardButton_Click(object sender, EventArgs e)
        {
            if (Finals.SelectedItem == null)
                return;

            var text = (string)Finals.SelectedItem;

            List<(Fact, Fact)> set = new List<(Fact, Fact)>() { (facts.Find(f => f.description == text), null) };

            for (int i = (int)FactLayer.FINAL; i >= 0; --i)
            {
                List<(Fact, Fact)> newSet = new List<(Fact, Fact)>(set);
                foreach (var fact in set.Where(f => (int)f.Item1.layer == i))
                {
                    foreach (var rule in rules.Where(r => r.production == fact.Item1))
                    {
                        newSet.AddRange(
                            rule.premises
                            //.Where(p => !newSet.Select(s => s.Item1).Contains(p))
                            .Select(x => (x, fact.Item1))
                            .ToArray());
                    }
                }
                set = new List<(Fact, Fact)>(newSet);
            }

            Result.Items.Clear();

            PrettyPrint(new List<Fact>() { facts.Find(f => f.description == text) }, set);

            /* Just initial facts, we need some explanation

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

            */
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
