using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Web.UI.WebControls;

namespace KeliasTarpVietoviu
{
    public class InOutUtils
    {
        public void ReadFromFile(string fileName, out string start, out string finish)
        {
            RouteList routes = new RouteList();
            VillageList villageList = new VillageList();

            int M, N;
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
                    Village vill = new Village();
                    line = reader.ReadLine();
                    vill.AddVillage(line, i);

                    villageList.Add(vill);
                }

                for(int k = 0; k < villageList.GetQuantity(); k++)
                {
                    if (villageList.GetVillage(k).Name.Length <= 10)
                        break;
                    else
                    {
                        throw new InvalidDataException("Village names can only be up to 10 characters.");
                    }
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

                    routes.Add(routeInfo);
                }
            }
        }

        public void PrintToFile(string fileName, string start, string finish, int length, List<string> route)
        {
            using (var fr = File.AppendText(fileName))
            {
                fr.Write("Minimalus atstumas tarp vietoviu ");
                fr.WriteLine(start + " - " + finish + " yra " + length + " km");

                fr.WriteLine("\nTrasa eina per vietoves: ");
                foreach (string item in route)
                {
                    fr.WriteLine(item);
                }
            }
        }
    }
}