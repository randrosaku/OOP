using System;
using System.Collections.Generic;
using System.IO;

namespace Projects
{
    public class InOutUtils
    {
        readonly TaskUtils find = new TaskUtils();

        /// <summary>
        /// Read student data from file
        /// </summary>
        /// <param name="FileName"> initial student data file </param>
        /// <returns> student list from file </returns>
        public StudentList ReadStudentList(string FileName)
        {
            StudentList StudentData = new StudentList();
            char[] punctuation = { ',', ';' };

            string[] lines = File.ReadAllLines(FileName);

            foreach(string line in lines)
            {
                string[] parts = line.Split(punctuation, StringSplitOptions.RemoveEmptyEntries);
                string project = parts[0];
                string surname = parts[1];
                string name = parts[2];
                string group = parts[3];

                Student Stud = new Student();
                Stud.Add(project, surname, name, group);

                StudentData.AddStudent(Stud);
            }

            return StudentData;
        }

        /// <summary>
        /// Reads professor data from file
        /// </summary>
        /// <param name="FileName"> initial professor data file </param>
        /// <returns> professor list from file </returns>
        public ProfessorList ReadProfessorList(string FileName)
        {
            ProfessorList ProftData = new ProfessorList();
            char[] punctuation = { ',', ';' };

            string[] lines = File.ReadAllLines(FileName);

            foreach (string line in lines)
            {
                string[] parts = line.Split(punctuation, StringSplitOptions.RemoveEmptyEntries);
                string project = parts[0];
                string name = parts[1];
                int hours = int.Parse(parts[2]);

                Professor Prof = new Professor();
                Prof.Add(project, name, hours);

                ProftData.AddProfessor(Prof);
            }

            return ProftData;
        }

        /// <summary>
        /// Prints initial student list to file
        /// </summary>
        /// <param name="FileName"> results file </param>
        /// <param name="data"> initial student list </param>
        public void PrintStudentList(string FileName, StudentList data)
        {
            string dashed = new string('-', 51);

            using(var fr = File.AppendText(FileName))
            {
                if (data == null)
                    fr.WriteLine("No data has been found.");
                else
                {
                    fr.WriteLine("Student list");
                    fr.WriteLine(dashed);
                    fr.WriteLine("|   Project name   |  Surname  |   Name   | Group |");
                    fr.WriteLine(dashed);

                    for(data.Begin(); data.Exists(); data.Next())
                    {
                        fr.WriteLine("{0}", data.Get().ToString());
                    }

                    fr.WriteLine(dashed);
                    fr.WriteLine();
                }
              
            }
        }

        /// <summary>
        /// Prints initial professor list to file
        /// </summary>
        /// <param name="FileName"> results file </param>
        /// <param name="data"> initial professor list </param>
        public void PrintProfessorList(string FileName, ProfessorList data)
        {
            string dashed = new string('-', 50);

            using (var fr = File.AppendText(FileName))
            {
                if (data == null)
                    fr.WriteLine("No data has been found.");
                else
                {
                    fr.WriteLine("Professor list");
                    fr.WriteLine(dashed);
                    fr.WriteLine("|    Project name    |       Name        | Hours |");
                    fr.WriteLine(dashed);

                    for (data.Begin(); data.Exists(); data.Next())
                    {
                        fr.WriteLine("{0}", data.Get().ToString());
                    }

                    fr.WriteLine(dashed);
                    fr.WriteLine();
                }
            }
        }

        /// <summary>
        /// Prints unique professor list to file
        /// </summary>
        /// <param name="FileName"> results file </param>
        /// <param name="ProfData"> initial professor list </param>
        public void PrintProfessors(string FileName, ProfessorList ProfData)
        {
            string dashed = new string('-', 21);
            Dictionary<int, string> profs = new Dictionary<int, string>();
            int key = 1;

            using (var fr = File.AppendText(FileName))
            {
                if (ProfData == null)
                    fr.WriteLine("No data has been found.");
                else
                {
                    fr.WriteLine("Professors");
                    fr.WriteLine(dashed);
                    fr.WriteLine("|       Name        |");
                    fr.WriteLine(dashed);

                    for (ProfData.Begin(); ProfData.Exists(); ProfData.Next())
                    {
                        if (profs.ContainsValue(ProfData.Get().Name))
                        {
                            continue;
                        }
                        else
                        {
                            profs.Add(key, ProfData.Get().Name);
                            fr.WriteLine("| {0, -17} |", ProfData.Get().Name);
                        }
                        key++;
                    }

                    fr.WriteLine(dashed);
                    fr.WriteLine();
                }
            }
        }

        /// <summary>
        /// Prints alphabetically sorted unique professor list to file
        /// </summary>
        /// <param name="FileName"> results file </param>
        /// <param name="ProfData"> initial professor list </param>
        public void PrintSortedProfessors(string FileName, ProfessorList ProfData)
        {
            string dashed = new string('-', 21);
            Dictionary<int, string> profs = new Dictionary<int, string>();
            ProfData.Sort();
            int key = 1;

            using (var fr = File.AppendText(FileName))
            {
                if (ProfData == null)
                    fr.WriteLine("No data has been found.");
                else
                {
                    fr.WriteLine("Professors sorted alphabetically");
                    fr.WriteLine(dashed);
                    fr.WriteLine("|       Name        |");
                    fr.WriteLine(dashed);

                    for (ProfData.Begin(); ProfData.Exists(); ProfData.Next())
                    {
                        if (profs.ContainsValue(ProfData.Get().Name))
                        {
                            continue;
                        }
                        else
                        {
                            profs.Add(key, ProfData.Get().Name);
                            fr.WriteLine("| {0, -17} |", ProfData.Get().Name);
                        }
                        key++;
                    }

                    fr.WriteLine(dashed);
                    fr.WriteLine();
                }
            }
        }

        /// <summary>
        /// Prints professor list to file after removing the ones whose projects were not chosen
        /// </summary>
        /// <param name="FileName"> results file </param>
        /// <param name="ProfData"> initial professor list </param>
        /// <param name="StudData"> initial student list </param>
        public void PrintUpdatedProfessors(string FileName, ProfessorList ProfData, StudentList StudData)
        {
            string dashed = new string('-', 21);
            Dictionary<string, int> dict = find.ProjectCount(StudData, ProfData);

            find.Remove(ProfData, dict);

            Dictionary<int, string> profs = new Dictionary<int, string>();
            int key = 1;

            using (var fr = File.AppendText(FileName))
            {
                if (ProfData == null)
                    fr.WriteLine("No data has been found.");
                else
                {
                    fr.WriteLine("Updated professor list");
                    fr.WriteLine(dashed);
                    fr.WriteLine("|       Name        |");
                    fr.WriteLine(dashed);

                    for (ProfData.Begin(); ProfData.Exists(); ProfData.Next())
                    {
                        if (profs.ContainsValue(ProfData.Get().Name))
                        {
                            continue;
                        }
                        else
                        {
                            profs.Add(key, ProfData.Get().Name);
                            fr.WriteLine("| {0, -17} |", ProfData.Get().Name);
                        }
                        key++;
                    }

                    fr.WriteLine(dashed);
                    fr.WriteLine();
                }
            }
        }

        /// <summary>
        /// Prints professor name to file who has the most projects to offer
        /// </summary>
        /// <param name="FileName"> results file </param>
        /// <param name="ProfData"> initial professor list </param>
        /// <param name="StudData"> initial students list </param>
        public void PrintProfWithMostProjects(string FileName, ProfessorList ProfData, StudentList StudData)
        {
            List<string> prof = new List<string>();
            Dictionary<string, int> dict = find.ProjectCount(StudData, ProfData);
            prof = find.ProfWithMostProjects(dict);

            using (var fr = File.AppendText(FileName))
            {
                if (ProfData == null)
                    fr.WriteLine("No data has been found.");
                else
                {
                    fr.WriteLine("Professor(s) having the most projects:");

                    if (prof.Count > 1)
                    {
                        fr.WriteLine(string.Join(" and ", prof));
                    }
                    else if (prof.Count < 1)
                    {
                        fr.WriteLine("No professors found.");
                    }
                    else
                    {
                        fr.WriteLine(string.Join(" ", prof));
                    }
                }
            }            
        }

        /// <summary>
        /// Prints projects to file which belong to the chosen professor
        /// </summary>
        /// <param name="FileName"> results file </param>
        /// <param name="ProfData"> initial professor list </param>
        /// <param name="professor"> chosen professor name </param>
        public void ShowProfProjects(string FileName, ProfessorList ProfData, string professor)
        {
            string dashed = new string('-', 24);

            using (var fr = File.AppendText(FileName))
            {
                if (professor == "")
                    fr.WriteLine("\nNo professor has been found.");
                else
                {
                    fr.WriteLine("\nChosen professor's projects");
                    fr.WriteLine(dashed);
                    fr.WriteLine("|       Projects       |");
                    fr.WriteLine(dashed);

                    for (ProfData.Begin(); ProfData.Exists(); ProfData.Next())
                    {
                        if (ProfData.Get().Name.Equals(professor))
                        {
                            fr.WriteLine("| {0, -20} |",ProfData.Get().Project);
                        }
                    }

                    fr.WriteLine(dashed);
                    fr.WriteLine();
                }
            }
        }
    }
}