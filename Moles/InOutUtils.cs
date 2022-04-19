using System;
using System.IO;
using System.Web.UI.WebControls;

namespace Moles
{
    public class InOutUtils
    {
        /// <summary>
        /// Reads data file
        /// </summary>
        /// <param name="FileName"> data file name </param>
        /// <returns> matrix of data </returns>
        public Matrix Read(string FileName)
        {
            Matrix Land = new Matrix();
            string line;
            char letter;
            string punct = " ,.;:?!()/";
            char[] punctuation = punct.ToCharArray();

            using (StreamReader reader = new StreamReader(FileName))
            {
                line = reader.ReadLine();
                string[] firstLine = line.Split(punctuation, StringSplitOptions.RemoveEmptyEntries);

                Land.Rows = int.Parse(firstLine[0]);
                Land.Columns = int.Parse(firstLine[1]);

                for (int i = 0; i < Land.Rows; i++)
                {
                    line = reader.ReadLine();
                    char[] letters = line.ToCharArray();

                    for (int j = 0; j < Land.Columns; j++)
                    {
                        letter = letters[j];
                        Land.Set(i, j, letter);
                    }
                }
            }
            return Land;
        }

        /// <summary>
        /// Prints out matrix to the table
        /// </summary>
        /// <param name="Land"> matrix name </param>
        /// <param name="table"> table name </param>
        public void Print(Matrix Matrix, Table table)
        {            
            for(int i = 0; i < Matrix.Rows; i++)
            {
                TableRow Rows = new TableRow();
                for(int j = 0; j < Matrix.Columns; j++)
                {
                    TableCell MatrixValue = new TableCell
                    {
                        Text = Convert.ToString(Matrix.Get(i, j))
                    };
                    Rows.Cells.Add(MatrixValue);
                }
                table.Rows.Add(Rows);
            }
        }
    }
}