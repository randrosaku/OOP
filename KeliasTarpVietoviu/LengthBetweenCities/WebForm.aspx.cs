using System;
using System.Collections.Generic;
using System.IO;
using System.Web.UI.WebControls;

namespace LengthBetweenCities
{
    public partial class WebForm : System.Web.UI.Page
    {
        private string start, finish;
        private List<string> final = new List<string>();
        private int length = 0;
        readonly InOutUtils to = new InOutUtils();
        readonly TaskUtils toFind = new TaskUtils();

        protected void Page_Load(object sender, EventArgs e)
        {
            string Data = Server.MapPath("~/App_Data/U3.txt");
            string Result = Server.MapPath("~/App_Data/Results.txt");

            if (File.Exists(Result))
                File.Delete(Result);

            List<Route> list = to.ReadFromFile(Data, out start, out finish, 
                out int N, out int M, out List<string> dict);

            Label1.Text = "<b>" + N.ToString() + "</b>";
            Label2.Text = "<b>" + M.ToString() + "</b>";
            Label3.Text = "<b>" + start + "</b>";
            Label4.Text = "<b>" + finish + "</b>";
            
            ViewCityData(dict);
            ViewRouteData(list);
        }

        /// <summary>
        /// Creates a table to store route information (source, target, length)
        /// </summary>
        /// <param name="list"> a list containing routes (source, target, length) </param>
        public void ViewRouteData(List<Route> list)
        {
            TableRow row1 = new TableRow();

            TableCell id = new TableCell { Text = "<b>Id</b>" };
            row1.Cells.Add(id);
            TableCell source = new TableCell { Text = "<b>Source</b>" };
            row1.Cells.Add(source);
            TableCell target = new TableCell { Text = "<b>Target</b>" };
            row1.Cells.Add(target);
            TableCell length = new TableCell { Text = "<b>Length</b>" };
            row1.Cells.Add(length);

            Table1.Rows.Add(row1);

            for(int i = 0; i < list.Count; i++)
            {
                TableRow r = new TableRow();

                TableCell id1 = new TableCell { Text = i+1 + "" };
                r.Cells.Add(id1);
                TableCell source1 = new TableCell { Text = list[i].Source };
                r.Cells.Add(source1);
                TableCell target1 = new TableCell { Text = list[i].Target };
                r.Cells.Add(target1);
                TableCell length1 = new TableCell { Text = list[i].Length.ToString() };
                r.Cells.Add(length1);

                Table1.Rows.Add(r);
            }
        }

        /// <summary>
        /// Creates a table to store city information (name, index)
        /// </summary>
        /// <param name="dict"> cities </param>
        public void ViewCityData(List<string> dict)
        {
            TableRow row1 = new TableRow();

            TableCell id = new TableCell { Text = "<b>Id</b>" };
            row1.Cells.Add(id);
            TableCell name = new TableCell { Text = "<b>Name</b>" };
            row1.Cells.Add(name);

            Table3.Rows.Add(row1);

            for (int i = 0; i < dict.Count; i++)
            {
                TableRow r = new TableRow();

                TableCell id1 = new TableCell { Text = i + 1 + "" };
                r.Cells.Add(id1);
                TableCell name1 = new TableCell { Text = dict[i] };
                r.Cells.Add(name1);

                Table3.Rows.Add(r);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ShowResults();
        }

        /// <summary>
        /// Shows the results: shortest length between the cities and the route itself
        /// </summary>
        public void ShowResults()
        {
            string Data = Server.MapPath("~/App_Data/U3.txt");
            string Result = Server.MapPath("~/App_Data/Results.txt");
            List<Route> list = to.ReadFromFile(Data, out start, out finish,
                out _, out _, out List<string> dict);

            toFind.ShortestPath(list, start, finish, ref final, ref length);

            if(final.Count-2 < 5)
            {
                for (int i = 0; i < final.Count; i++)
                {
                    TableRow r = new TableRow();

                    TableCell name = new TableCell { Text = final[i] };
                    r.Cells.Add(name);

                    Table2.Rows.Add(r);
                }
                ShowData(length);
            } else
            {
                Label9.Text = "There can be up to 5 transitional cities.";
            }
            
            to.PrintToFile(Result, start, finish, length, final, dict, list);
        }

        /// <summary>
        /// Shows result data
        /// </summary>
        /// <param name="length"> the shortest path length between start and finish cities </param>
        public void ShowData(int length)
        {
            Label9.Text = "Minimal length between the cities";
            Label6.Text = Label3.Text;
            Label7.Text = "and";
            Label10.Text = Label4.Text;
            Label11.Text = "is";
            Label12.Text = "<b>" + length.ToString() + "</b>";
            Label13.Text = "km.";
            Label14.Text = "The route is following these roads:";
        }
    }
}