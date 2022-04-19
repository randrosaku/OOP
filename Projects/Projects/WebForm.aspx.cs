using System;
using System.Collections.Generic;
using System.IO;
using System.Data;

namespace Projects
{
    public partial class WebForm : System.Web.UI.Page
    {

        readonly InOutUtils to = new InOutUtils();
        readonly TaskUtils find = new TaskUtils();

        protected void Page_Load(object sender, EventArgs e)
        {
            // retrieving datatables from session
            DataTable dt1 = (DataTable)Session["data1"];
            DataTable dt2 = (DataTable)Session["data2"];
            DataTable dt3 = (DataTable)Session["data3"];

            // initial data files
            string DataStud = Server.MapPath("~/App_Data/U22a.txt");
            string DataProf = Server.MapPath("~/App_Data/U22b.txt");

            // results data file
            string Results = Server.MapPath("~/App_Data/Results.txt");

            // professor name to generate projects
            string professor = TextBox1.Text;

            if (File.Exists(Results))
                File.Delete(Results);

            // reading initial data
            StudentList StudData = to.ReadStudentList(DataStud);
            ProfessorList ProfData = to.ReadProfessorList(DataProf);
            
            // printing initial data to results file
            to.PrintStudentList(Results, StudData);
            to.PrintProfessorList(Results, ProfData);

            // printing results to results file
            to.PrintProfessors(Results, ProfData);
            to.PrintSortedProfessors(Results, ProfData);
            to.PrintUpdatedProfessors(Results, ProfData, StudData);
            to.PrintProfWithMostProjects(Results, ProfData, StudData);
            to.ShowProfProjects(Results, ProfData, professor);
        }

        // prints the initial student and professor data and saves it to session
        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "Students";
            Label2.Text = "Professors";

            DataTable data1 = ShowStudentData();
            DataTable data2 = ShowProfessorData();

            Session["data1"] = data1;
            Session["data2"] = data2;
        }

        // prints the unique professor list and saves it to session
        protected void Button2_Click(object sender, EventArgs e)
        {
            DataTable data3 = ShowProfessors();

            Session["data3"] = data3;
        }

        // prints the sorted unique professor list and updates it in session
        protected void Button3_Click(object sender, EventArgs e)
        {
            DataTable data3 = ShowSorted();

            Session["data3"] = data3;
        }

        // prints updates professor list
        protected void Button4_Click(object sender, EventArgs e)
        {
            ShowUpdatedProfessors();
        }

        // prints which professor(s) offer(s) the highest number of projects
        protected void Button5_Click(object sender, EventArgs e)
        {
            List<string> data4 = Professor();
        }

        // prints the chosen professor's projects
        protected void Button6_Click(object sender, EventArgs e)
        {
            DataTable data5 = ShowProfessorProjects();
        }
    }
}