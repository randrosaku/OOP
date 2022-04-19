namespace Projects
{
    public class Student
    {
        public string Project { get; private set; }         // project name
        public string Surname { get; private set; }         // student surname
        public string Name { get; private set; }            // student forename
        public string Group { get; private set; }           // student group

        /// <summary>
        /// Sets initial student values
        /// </summary>
        public Student()
        {
            Project = "";
            Surname = "";
            Name = "";
            Group = "";
        }

        /// <summary>
        /// Adds student
        /// </summary>
        /// <param name="Project"> project name </param>
        /// <param name="Surname"> student surname </param>
        /// <param name="Name"> student forename </param>
        /// <param name="Group"> student group </param>
        public void Add(string Project, string Surname, string Name, string Group)
        {
            this.Project = Project;
            this.Surname = Surname;
            this.Name = Name;
            this.Group = Group;
        }

        /// <summary>
        /// Formats student data
        /// </summary>
        /// <returns> formatted string </returns>
        public override string ToString()
        {
            string line = string.Format("| {0, -16} | {1, -9} | {2, -8} | {3, -5} |",
                Project, Surname, Name, Group);
            return line;
        }
    }
}