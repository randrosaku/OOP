using System.Collections.Generic;
using System.Data;

namespace Projects
{
    public partial class WebForm : System.Web.UI.Page
    {
        /// <summary>
        /// Prints initial student data
        /// </summary>
        /// <returns> datatable with student data </returns>
        public DataTable ShowStudentData()
        {
            DataTable dtSt = new DataTable();
            dtSt.Clear();

            string DataSt = Server.MapPath("~/App_Data/U22a.txt");
            StudentList StudData = to.ReadStudentList(DataSt);

            dtSt.Columns.Add("Project Name");
            dtSt.Columns.Add("Surname");
            dtSt.Columns.Add("Name");
            dtSt.Columns.Add("Group");

            for (StudData.Begin(); StudData.Exists(); StudData.Next())
            {
                DataRow row = dtSt.NewRow();

                row["Project Name"] = StudData.Get().Project;
                row["Surname"] = StudData.Get().Surname;
                row["Name"] = StudData.Get().Name;
                row["Group"] = StudData.Get().Group;

                dtSt.Rows.Add(row);
            }

            if (dtSt.Rows.Count == 0)
            {
                dtSt.Clear();
                Label2.Text = "No student data found.";
            }
            else
            {
                GridView1.DataSource = dtSt;
                GridView1.DataBind();
            }


            return dtSt;
        }

        /// <summary>
        /// Prints initial professor data 
        /// </summary>
        /// <returns> datatable with professor data </returns>
        public DataTable ShowProfessorData()
        {
            string DataPr = Server.MapPath("~/App_Data/U22b.txt");
            ProfessorList ProfData = to.ReadProfessorList(DataPr);

            DataTable dtPr = new DataTable();
            dtPr.Clear();

            dtPr.Columns.Add("Project Name");
            dtPr.Columns.Add("Name");
            dtPr.Columns.Add("Hours");

            for (ProfData.Begin(); ProfData.Exists(); ProfData.Next())
            {
                DataRow row = dtPr.NewRow();

                row["Project Name"] = ProfData.Get().Project;
                row["Name"] = ProfData.Get().Name;
                row["Hours"] = ProfData.Get().Hours.ToString();

                dtPr.Rows.Add(row);
            }

            if (dtPr.Rows.Count == 0)
            {
                dtPr.Clear();
                Label2.Text = "No professor data found.";
            } else
            {
                GridView2.DataSource = dtPr;
                GridView2.DataBind();
            }

            return dtPr;
        }

        /// <summary>
        /// Prints unique professor list
        /// </summary>
        /// <returns> datatable with unique professors </returns>
        public DataTable ShowProfessors()
        {
            string DataPr = Server.MapPath("~/App_Data/U22b.txt");
            ProfessorList ProfData = to.ReadProfessorList(DataPr);

            Dictionary<int, string> profs = new Dictionary<int, string>();
            int key = 1;
            
            DataTable dtPr = new DataTable();
            dtPr.Clear();
            
            dtPr.Columns.Add("Name");

            for (ProfData.Begin(); ProfData.Exists(); ProfData.Next())
            {
                if(profs.ContainsValue(ProfData.Get().Name))
                {
                    continue;
                } else
                {
                    profs.Add(key, ProfData.Get().Name);
                    DataRow row = dtPr.NewRow();

                    row["Name"] = ProfData.Get().Name;

                    dtPr.Rows.Add(row);
                }
                key++;
            }

            GridView3.DataSource = dtPr;
            GridView3.DataBind();
            
            return dtPr;
        }

        /// <summary>
        /// Prints sorted unique professor list
        /// </summary>
        /// <returns> datatable with sorted unique professors </returns>
        public DataTable ShowSorted()
        {
            string DataPr = Server.MapPath("~/App_Data/U22b.txt");
            ProfessorList ProfData = to.ReadProfessorList(DataPr);

            Dictionary<int, string> profs = new Dictionary<int, string>();
            int key = 1;

            ProfData.Sort();

            DataTable dtPr = new DataTable();
            dtPr.Clear();
            
            dtPr.Columns.Add("Name");

            for (ProfData.Begin(); ProfData.Exists(); ProfData.Next())
            {
                if (profs.ContainsValue(ProfData.Get().Name))
                {
                    continue;
                }
                else
                {
                    profs.Add(key, ProfData.Get().Name);
                    DataRow row = dtPr.NewRow();

                    row["Name"] = ProfData.Get().Name;

                    dtPr.Rows.Add(row);
                }
                key++;
            }

            GridView3.DataSource = dtPr;
            GridView3.DataBind();

            return dtPr;
        }

        /// <summary>
        /// Prints updated professors list after removing those whose projects were not chosen
        /// </summary>
        /// <returns> datatable with updated professors </returns>
        public DataTable ShowUpdatedProfessors()
        {
            string DataPr = Server.MapPath("~/App_Data/U22b.txt");
            ProfessorList ProfData = to.ReadProfessorList(DataPr);

            string DataSt = Server.MapPath("~/App_Data/U22a.txt");
            StudentList StudData = to.ReadStudentList(DataSt);

            Dictionary<string, int> dict = find.ProjectCount(StudData, ProfData);

            find.Remove(ProfData, dict);
            ProfData.Sort();

            Dictionary<int, string> profs = new Dictionary<int, string>();
            int key = 1;
            
            DataTable dtPr = new DataTable();
            dtPr.Clear();

            dtPr.Columns.Add("Name");

            for (ProfData.Begin(); ProfData.Exists(); ProfData.Next())
            {
                if (profs.ContainsValue(ProfData.Get().Name))
                {
                    continue;
                }
                else
                {
                    profs.Add(key, ProfData.Get().Name);
                    DataRow row = dtPr.NewRow();

                    row["Name"] = ProfData.Get().Name;
                    dtPr.Rows.Add(row);
                }
                key++;
            }

            GridView3.DataSource = dtPr;
            GridView3.DataBind();

            return dtPr;
        }
        
        /// <summary>
        /// Prints the name(s) of professors who offer the highest number of projects
        /// </summary>
        /// <returns> list of professor(s) name(s) </returns>
        public List<string> Professor()
        {
            List<string> prof = new List<string>();

            string DataPr = Server.MapPath("~/App_Data/U22b.txt");
            ProfessorList ProfData = to.ReadProfessorList(DataPr);

            string DataSt = Server.MapPath("~/App_Data/U22a.txt");
            StudentList StudData = to.ReadStudentList(DataSt);
            
            Dictionary<string, int> dict = find.ProjectCount(StudData, ProfData);
            prof = find.ProfWithMostProjects(dict);

            if(prof.Count > 1)
            {
                Label4.Text = string.Join(" and ", prof);
            } else if (prof.Count < 1)
            {
                Label4.Text = "No professors found.";
            } else
            {
                Label4.Text = string.Join(" ", prof);
            }

            return prof;
        }

        /// <summary>
        /// Prints projects of the chosen professor
        /// </summary>
        /// <returns> datatable with chosen professor projects </returns>
        public DataTable ShowProfessorProjects()
        {
            DataTable dtProj = new DataTable();
            dtProj.Clear();

            string professor = TextBox1.Text;

            string DataPr = Server.MapPath("~/App_Data/U22b.txt");
            ProfessorList ProfData = to.ReadProfessorList(DataPr);
            
            dtProj.Columns.Add("Projects");

            for (ProfData.Begin(); ProfData.Exists(); ProfData.Next())
            {
                if(ProfData.Get().Name.Equals(professor))
                {
                    DataRow row = dtProj.NewRow();

                    row["Projects"] = ProfData.Get().Project;
                    dtProj.Rows.Add(row);
                }
            }

            if(dtProj.Rows.Count == 0)
            {
                dtProj.Clear();
                Label5.Text = "No such professor found.";
            } else
            {
                Label5.Text = "";
            }

            GridView4.DataSource = dtProj;
            GridView4.DataBind();

            return dtProj;
        }
    }
}