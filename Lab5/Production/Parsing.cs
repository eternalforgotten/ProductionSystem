using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Production
{
    public class Parsing
    {
        public static List<Fact> ParseFacts(string fileName)
        {
            List<Fact> facts = new List<Fact>();
            try
            { 
                foreach (var line in File.ReadLines(fileName))
                {
                    var splitted = line.Split(';');
                    var description = splitted.Last();
                    var layerAndNumber = splitted.First();
                    var layerString = layerAndNumber[0];
                    var number = int.Parse(layerAndNumber.Substring(1));
                    FactLayer factLayer;
                    switch (layerString)
                    {
                        case 'A': factLayer = FactLayer.INITIAL; break;
                        case 'B': factLayer = FactLayer.SECOND; break;
                        case 'C': factLayer = FactLayer.THIRD; break;
                        case 'D': factLayer = FactLayer.FINAL; break;
                        default: factLayer = FactLayer.UNDEFINED; break;
                    }
                    Fact fact = new Fact(description, number, factLayer);
                    facts.Add(fact);
                }
            }
            catch (FileNotFoundException)
            {
                // Say file not found
            }

            return facts;
        }

        public static List<Rule> ParseRules(string fileName, List<Fact> facts)
        {
            List<Rule> rules = new List<Rule>();
            try
            {
                foreach (var line in File.ReadLines(fileName))
                {
                    var words = line.Split(';');
                    rules.Add(
                        new Rule(
                            int.Parse(words[0].Substring(1)), 
                            words[1].Split(',').Select(x => facts.Find(f => f.number == int.Parse(x.Substring(1)) && ((int)f.layer) == x[0] - 'A')).ToList(), 
                            facts.Find(f => f.number == int.Parse(words.Last().Substring(1)) && ((int)f.layer == words.Last()[0] - 'A'))
                            )
                        );
                }
            }
            catch (FileNotFoundException)
            {
                // Say file not found
            }

            return rules;
        }
    }
}
