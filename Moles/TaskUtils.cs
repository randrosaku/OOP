using System.Collections.Generic;

namespace Moles
{
    public class TaskUtils
    {
        /// <summary>
        /// Finds the first hole in the ground
        /// </summary>
        /// <param name="Matrix"> matrix name </param>
        /// <param name="value"> value we're looking for </param>
        /// <returns> the exact location in the matrix where the hole starts </returns>
        private (int row, int column) FindHole(Matrix Matrix, char value)
        {
            int k = -1, l = -1;

            for (int row = 0; row < Matrix.Rows; row++)
            {
                for (int column = 0; column < Matrix.Columns; column++)
                {
                    if (Matrix.Get(row, column) == value)
                        return (row, column);
                }
            }
            return (k, l);
        }

        /// <summary>
        /// Checks if the value is inside the matrix
        /// </summary>
        /// <param name="row"> rows </param>
        /// <param name="column"> columns </param>
        /// <param name="Matrix"> matrix </param>
        /// <returns> true if inside </returns>
        private bool Inside(int row, int column, Matrix Matrix)
        {
            if (row < 0 || row >= Matrix.Rows || column < 0 || column >= Matrix.Columns)
                return false;
            return true;
        }

        /// <summary>
        /// Finds all the neighbours of the value
        /// </summary>
        /// <param name="Matrix"> matrix </param>
        /// <param name="row"> row index </param>
        /// <param name="column"> column index </param>
        /// <param name="value"> value we're looking for </param>
        /// <param name="holes"> list of hole pieces </param>
        private void FindAllHoles(Matrix Matrix, int row, int column, char value, ref List<(int, int)> holes)
        {
            // check up
            if ((Inside(row - 1, column, Matrix) == true) && (Matrix.Get(row - 1, column) == value))
            {
                holes.Add((row - 1, column));
                Matrix.Set(row - 1, column, '-');
                FindAllHoles(Matrix, row - 1, column, value, ref holes);
            }

            //check right
            if ((Inside(row, column + 1, Matrix) == true) && (Matrix.Get(row, column + 1) == value))
            {
                holes.Add((row, column + 1));
                Matrix.Set(row, column + 1, '-');
                FindAllHoles(Matrix, row, column + 1, value, ref holes);
            }

            // check down 
            if ((Inside(row + 1, column, Matrix) == true) && (Matrix.Get(row + 1, column) == value))
            {
                holes.Add((row + 1, column));
                Matrix.Set(row + 1, column, '-');
                FindAllHoles(Matrix, row + 1, column, value, ref holes);
            }

            // check left 
            if ((Inside(row, column - 1, Matrix) == true) && (Matrix.Get(row, column - 1) == value))
            {
                holes.Add((row, column - 1));
                Matrix.Set(row, column - 1, '-');
                FindAllHoles(Matrix, row, column - 1, value, ref holes);
            }
        }

        /// <summary>
        /// Calculates how many moles and their hole sizes
        /// </summary>
        /// <param name="Matrix"> matrix </param>
        /// <param name="value"> value we're looking for </param>
        /// <param name="count"> mole count </param>
        /// <param name="moleHoles"> hole pieces </param>
        public void Calculate(Matrix Matrix, char value, out int count, out int[] moleHoles)
        {
            List<(int, int)> holes = new List<(int, int)> { };

            count = 0;
            moleHoles = new int[100];

            int k = 0;
            (int row, int column) = FindHole(Matrix, value);

            while (row >= 0 && column >= 0)
            {
                Matrix.Set(row, column, '-');
                holes.Add((row, column));

                FindAllHoles(Matrix, row, column, value, ref holes);
                count++;

                (row, column) = FindHole(Matrix, value);

                moleHoles[k++] = holes.Count;
                holes.Clear();
            }
        }
    }    
}