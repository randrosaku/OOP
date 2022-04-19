namespace Moles
{
    /// <summary>
    /// Stores information about matrix
    /// </summary>
    public class Matrix
    {
        private const int CMaxRow = 500;
        private const int CMaxCol = 500;

        private char[,] Land;
        public int Rows { get; set; }
        public int Columns { get; set; }

        public Matrix()
        {
            Rows = 0;
            Columns = 0;
            Land = new char[CMaxRow, CMaxCol];
        }

        public void Set(int i, int j, char letter)
        {
            Land[i, j] = letter;
        }

        public char Get(int i, int j)
        {
            return Land[i, j];
        }
    }
}