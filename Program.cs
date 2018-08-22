using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };

            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            List<string> OtherPlanets = new List<string>() { "Uranus", "Neptune" };
            planetList.AddRange(OtherPlanets);
            planetList.Insert(3, "Earth");
            planetList.Insert(1, "Venus");
            planetList.Add("Pluto");

            planetList.Remove("Pluto");


            // foreach (string i in planetList)
            // {
            //     Console.WriteLine(i);
            // }
            List<string> RockyPlanets = new List<string>();
            planetList.GetRange(0, 4);

// extra practice
            List<Dictionary<string, string>> probes = new List<Dictionary<string, string>>();

            Dictionary<string, string> opportunity = new Dictionary<string, string>() {
    { "Saturn", "Opportunity" }
};
            Dictionary<string, string> viking = new Dictionary<string, string>() {
    { "Mars", "Viking" }
};
            Dictionary<string, string> curiosity = new Dictionary<string, string>() {
    { "Mars", "Curiosity" }
};

            probes.Add(opportunity);
            probes.Add(viking);
            probes.Add(curiosity);

            foreach (string planet in planetList)
            {
                List<string> visitedProbes = new List<string>();

                foreach (Dictionary<string, string> probe in probes)
                {
                    if (probe.ContainsKey(planet))
                    {
                        visitedProbes.Add(probe[planet]);
                    }
                }
                if (visitedProbes.Count > 0) {
                Console.WriteLine($"{planet}: {String.Join(",", visitedProbes)}");
                }
            }

        }
    }
}
