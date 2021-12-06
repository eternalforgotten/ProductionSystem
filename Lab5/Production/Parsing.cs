using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Production
{
    class Parsing
    {
        public static List<Fact> ParseFacts(String fileName)
        {
            List<Fact> facts = new List<Fact>();
            if (File.Exists(fileName))
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
                return facts;
            }
            else
            {
                throw new Exception("No such file");
            }
        }
    }
}
