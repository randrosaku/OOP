using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KeliasTarpVietoviu
{
    public class TaskUtils
    {
        public List<string> FindShortestPath(Village[] routes, string source, string target, List<string> routeList)
        {
            List<string> shortestPath = new List<string>();
            List<string> prec = new List<string> { [0] = source };
            List<int> d = new List<int> { [0] = 0 };

            for (int i = 0; i < routes.Length; i++)
            {
                if(routes[i].Source.Equals(source))
                {


                } else
                    throw new InvalidProgramException("There is no starting point.");
            }

            return shortestPath;
        }
    }
}