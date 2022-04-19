using System;
using System.Collections.Generic;
using System.IO;

namespace LengthBetweenCities
{
    public class InOutUtils
    {
        /// <summary>
        /// Reading froma a file
        /// </summary>
        /// <param name="fileName"> input data file </param>
        /// <param name="start"> the start city </param>
        /// <param name="finish"> the finish city </param>
        /// <param name="N"> number of cities </param>
        /// <param name="M"> number of roads </param>
        /// <param name="dictionary"> cities </param>
        /// <returns> a list containing routes (source, target, length) </returns>
        public List<Route> ReadFromFile(string fileName, out string start, 
            out string finish, out int N, out int M, out List<string> dictionary)
        {
            dictionary = new List<string>();
            List<Route> routeList = new List<Route>();

            string line;
            start = finish = "";
            string punct = " ,.;:?!()/\t";
            char[] punctuation = punct.ToCharArray();

            using (StreamReader reader = new StreamReader(fileName))
            {
                line = reader.ReadLine();
                string[] firstLine = line.Split(punctuation, StringSplitOptions.RemoveEmptyEntries);

                N = int.Parse(firstLine[0]);
                M = int.Parse(firstLine[1]);

                for (int i = 0; i < N; i++)
                {
                    line = reader.ReadLine();
                    dictionary.Add(line);
                }
                
                for (int k = 0; k < dictionary.Count; k++)
                {
                    if (dictionary[k].Length <= 10)
                        break;
                    else
                        throw new InvalidDataException("Village names can only be up to 10 characters.");
                }

                reader.ReadLine();
                line = reader.ReadLine();
                string[] parts = line.Split(punctuation, StringSplitOptions.RemoveEmptyEntries);

                start = parts[0];
                finish = parts[1];
                reader.ReadLine();

                for (int j = 0; j < M; j++)
                {
                    line = reader.ReadLine();
                    string[] info = line.Split(punctuation, StringSplitOptions.RemoveEmptyEntries);

                    string source = info[0];
                    string target = info[1];
                    int length = int.Parse(info[2]);

                    Route routeInfo = new Route();
                    routeInfo.AddRoute(source, target, length);

                    routeList.Add(routeInfo);
                }
            }
            return routeList;
        }

        /// <summary>
        /// Prints results to a file
        /// </summary>
        /// <param name="fileName"> result file </param>
        /// <param name="start"> the start city </param>
        /// <param name="finish"> the finish city </param>
        /// <param name="length"> the shortest length from start to finish </param>
        /// <param name="route"> the list of a shortest route from start to finish </param>
        /// <param name="cities"> the list of all cities </param>
        /// <param name="roads"> the list of all roads </param>
        public void PrintToFile(string fileName, string start, string finish, int length, 
            List<string> route, List<string> cities, List<Route> roads)
        {
            using (var fr = File.AppendText(fileName))
            {
                fr.WriteLine("Number of cities - " + cities.Count.ToString());
                fr.WriteLine("Number of roads - " + roads.Count.ToString());

                fr.WriteLine("\nCities");
                fr.WriteLine(new string('-', 16));
                fr.WriteLine("| Id |   Name  |");
                fr.WriteLine(new string('-', 16));
                for (int j = 0; j < cities.Count; j++)
                {
                    fr.WriteLine("| {0, 2} | {1, -7} |", j + 1, cities[j]);
                }
                fr.WriteLine(new string('-', 16));
                fr.WriteLine();

                fr.WriteLine("Roads");
                fr.WriteLine(new string('-', 42));
                fr.WriteLine("| Id |   Source   |   Target  |  Length  |");
                fr.WriteLine(new string('-', 42));
                for (int k = 0; k < roads.Count; k++)
                {
                    fr.WriteLine("| {0, 2} {1} ", k + 1, roads[k].ToString());
                }
                fr.WriteLine(new string('-', 42));
                fr.WriteLine();

                fr.WriteLine("Start: " + start);
                fr.WriteLine("Finish: " + finish);

                if(route.Count-2 < 5)
                {
                    fr.Write("\nMinimal length between the cities ");
                    fr.WriteLine(start + " and " + finish + " is " + length + " km.");

                    fr.WriteLine("\nThe route is following these roads: ");
                    for (int i = 0; i < route.Count; i++)
                    {
                        fr.WriteLine(route[i]);
                    }
                } else
                {
                    fr.WriteLine("There can be up to 5 transitional cities.");
                }                
            }
        }
    }
}