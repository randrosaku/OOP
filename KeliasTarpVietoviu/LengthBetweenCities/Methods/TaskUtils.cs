using System.Collections.Generic;
using System.Linq;

namespace LengthBetweenCities
{
    public class TaskUtils
    {
        /// <summary>
        /// Finds the shortest path between start and finish
        /// </summary>
        /// <param name="list"> a list containing routes (source, target, length) </param>
        /// <param name="road"> the current starting city </param>
        /// <param name="finish"> the finish city </param>
        /// <param name="final"> the list of a shortest path between cities </param>
        /// <param name="length"> the shortest length from start to finish </param>
        public void ShortestPath(List<Route> list, string road, string finish, ref List<string> final, ref int length)
        {
            final.Add(road);
            SortedDictionary<int, string> dict = new SortedDictionary<int, string>();

            if (road.Equals(finish))
                return;

            for (int i = 0; i < list.Count; i++)
            {
                if(list[i].Source.Equals(road))
                    dict.Add(list[i].Length, list[i].Target);
            }
            
            dict.OrderBy(x => x.Key);

            string newRoad = dict.First().Value;
            length += dict.First().Key;

            ShortestPath(list, newRoad, finish, ref final, ref length);            
        }
    }
}