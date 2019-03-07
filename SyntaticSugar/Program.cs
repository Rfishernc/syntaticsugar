using System;
using System.Collections.Generic;

namespace SyntaticSugar
{
    class Program
    {
        static void Main(string[] args)
        {
            var spider = new Bug("Steve", "Spider", new List<string> { "Birds", "Bats", "Cats"}, new List<string> { "Flys", "Bullweevils", "Ladybugs"});
            var moth = new Bug("Martha", "Moth", new List<string> { "Birds", "Bats", "Cats", "Lights" }, new List<string> { "Flowers" });
            Console.WriteLine(spider.Eat("Flys"));
            Console.WriteLine(moth.Eat("Flys"));
            Console.ReadLine();
        }
        public class Bug
        {
            public string Name { get; } = "";
            public string Species { get; } = "";
            public ICollection<string> Predators { get; } = new List<string>();
            public ICollection<string> Prey { get; } = new List<string>();

            public string FormalName => $"{this.Name} the {this.Species}";

            public Bug(string name, string species, List<string> predators, List<string> prey)
            {
                this.Name = name;
                this.Species = species;
                this.Predators = predators;
                this.Prey = prey;
            }

            public string PreyList() => string.Join(",", this.Prey);
            public string PredatorList() => string.Join(",", this.Predators);
            public string Eat(string food) => this.Prey.Contains(food) ? $"{this.Name} ate the {food}." : $"{this.Name} is still hungry.";
        }
    }
}
