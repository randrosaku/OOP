using System.Collections.Generic;
using System.Linq;

namespace Projects
{
    public class TaskUtils
    {
        /// <summary>
        /// Finds how many projects professors have
        /// </summary>
        /// <param name="listSt">  initial student list </param>
        /// <param name="listPr"> initial professor list </param>
        /// <returns> dictionary that stores professor name (key) and number of projects (value) (if > 0) </returns>
        public Dictionary<string, int> ProjectCount(StudentList listSt, ProfessorList listPr)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            int count = 1;

            for (listSt.Begin(); listSt.Exists(); listSt.Next())
            {
                for (listPr.Begin(); listPr.Exists(); listPr.Next())
                {
                    if (listSt.Get().Project.Equals(listPr.Get().Project))
                    {
                        if (dict.ContainsKey(listPr.Get().Name))
                        {
                            dict[listPr.Get().Name] = dict[listPr.Get().Name] + 1;
                            break;
                        }
                        else
                        {
                            dict.Add(listPr.Get().Name, count);
                        }
                    }
                }
            }
            return dict;
        }

        /// <summary>
        /// Removes professors from list whose projects were not chosen
        /// </summary>
        /// <param name="listPr"> initial professor list </param>
        /// <param name="dict"> dictionary that stores the number of projects of professors (if > 0) </param>
        public void Remove(ProfessorList listPr, Dictionary<string, int> dict)
        {
            for (listPr.Begin(); listPr.Exists(); listPr.Next())
            {
                if(!dict.ContainsKey(listPr.Get().Name))
                {
                    listPr.Remove();
                }
            }
        }

        /// <summary>
        /// Finds professor who offers the highest number of projects
        /// </summary>
        /// <param name="dict"> dictionary that stores the number of projects of professors (if > 0) </param>
        /// <returns> list of professors with highest number of projects to offer </returns>
        public List<string> ProfWithMostProjects(Dictionary<string, int> dict)
        {
            List<string> prof = new List<string>();

            if(dict.Count > 0)
            {
                int max = dict.Values.Max();

                for (int i = 0; i < dict.Count; i++)
                {
                    if (dict.Values.ElementAt(i) >= max)
                    {
                        prof.Add(dict.Keys.ElementAt(i));
                    }
                }
            }           

            return prof;
        }
    }
}