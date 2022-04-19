using System;
using System.Drawing;

namespace Moles
{
    public partial class WebForm1 : System.Web.UI.Page
    {       
        protected void Page_Load(object sender, EventArgs e)
        {
            string data = Server.MapPath("~/App_Code/data.txt");
            //string data = Server.MapPath("~/App_Code/data1.txt");
            //string data = Server.MapPath("~/App_Code/data2.txt");

            InOutUtils isDoing = new InOutUtils();
            Matrix M = isDoing.Read(data);
            isDoing.Print(M, Table1);
            Session["DATA"] = M;
        }

        /// <summary>
        /// Randomly chooses colors to highlight the holes
        /// </summary>
        protected void ColorMode()
        {
            Random randomGen = new Random();
            KnownColor[] names = (KnownColor[])Enum.GetValues(typeof(KnownColor));
            KnownColor randomColorName = names[randomGen.Next(names.Length)];

            Matrix M = Session["DATA"] as Matrix;

            for (int i = 0; i < M.Rows; i++)
            {
                for (int j = 0; j < M.Columns; j++)
                {
                    if (M.Get(i, j) == 'u')
                    {
                        Table1.Rows[i].Cells[j].ForeColor = Color.FromKnownColor(randomColorName);
                        Table1.Rows[i].Cells[j].Font.Bold = true;
                    }
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Calculate();            
        }

        /// <summary>
        /// Sorts holes in descending order
        /// </summary>
        /// <param name="moleHoles"> hole sizes </param>
        /// <param name="moles"> mole count </param>
        /// <returns> sorted holes as a string </returns>
        protected string MaxMin(int[] moleHoles, int moles)
        {
            int minInd;
            int area = 5;
            string line = " ";

            for (int k = 0; k < moles; k++)
                moleHoles[k] = moleHoles[k] * area;
                        
            for(int i = 0; i < moles-1; i++)
            {
                minInd = i;
                for(int j = i+1; j < moles; j++)
                {
                    if (moleHoles[j] > moleHoles[minInd])
                        minInd = j;
                }

                int temp = moleHoles[i];
                moleHoles[i] = moleHoles[minInd];
                moleHoles[minInd] = temp;
            }

            if (moles == 0)
                line = "-";

            for (int i = 0; i < moles; i++)
                line += "" + moleHoles[i] + "m^2 ";

            return line;
        }

        /// <summary>
        /// Calculates how many moles are in the ground and how big are their holes
        /// </summary>
        protected void Calculate()
        {
            TaskUtils task = new TaskUtils();            
            Matrix matrix = Session["DATA"] as Matrix;

            task.Calculate(matrix, 'u', out int count, out int[] moleHoles);
            string line = MaxMin(moleHoles, count);

            if (count == 0)
                Table2.Rows[1].Cells[0].Text = "No moles here!";
            else
                Table2.Rows[1].Cells[0].Text = "" + count;

            Table2.Rows[1].Cells[1].Text = line;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ColorMode();
        }
    }
}