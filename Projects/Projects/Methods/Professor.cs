using System;

namespace Projects
{
    public class Professor
    {
        public string Project { get; private set; }         // project name
        public string Name { get; set; }                    // professor name
        public int Hours { get; private set; }              // project hours

        public Professor()
        {
            Project = "";
            Name = "";
            Hours = 0;
        }

        /// <summary>
        /// Adds professor
        /// </summary>
        /// <param name="Project"> project name </param>
        /// <param name="Name"> professor name </param>
        /// <param name="Hours"> project hours </param>
        public void Add(string Project, string Name, int Hours)
        {
            this.Project = Project;
            this.Name = Name;
            this.Hours = Hours;
        }

        /// <summary>
        /// Formats professor data
        /// </summary>
        /// <returns> a formatted string </returns>
        public override string ToString()
        {
            string line = string.Format("| {0, -18} | {1, -17} | {2, 5} |",
                Project, Name, Hours);
            return line;
        }

        /// <summary>
        /// Checks for data equality
        /// </summary>
        /// <param name="obj"> object of interest </param>
        /// <returns> true if equal </returns>
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// Compares professors
        /// </summary>
        /// <param name="p1"> first professor </param>
        /// <param name="p2"> second professor </param>
        /// <returns> true if diff > 0 </returns>
        static public bool operator >=(Professor p1, Professor p2)
        {
            int iN = string.Compare(p1.Name, p2.Name, StringComparison.CurrentCulture);

            return (iN > 0);
        }

        /// <summary>
        /// Compares professors
        /// </summary>
        /// <param name="p1"> first professor </param>
        /// <param name="p2"> second professor </param>
        /// <returns> true if diff < 0 </returns>
        static public bool operator <=(Professor p1, Professor p2)
        {
            int iN = string.Compare(p1.Name, p2.Name, StringComparison.CurrentCulture);

            return (iN < 0);
        }
    }
}