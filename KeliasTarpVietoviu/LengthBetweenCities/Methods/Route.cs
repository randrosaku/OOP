namespace LengthBetweenCities
{
    /// <summary>
    /// Route class, stores information of a road: source, target, length
    /// </summary>
    public class Route
    {
        public string Source { get; private set; }
        public string Target { get; private set; }
        public int Length { get; private set; }
        
        public Route()
        {
            Source = "";
            Target = "";
            Length = 0;
        }

        /// <summary>
        /// Adding a route
        /// </summary>
        /// <param name="Source"> start city </param>
        /// <param name="Target"> finish city </param>
        /// <param name="Length"> length between start and finish cities </param>
        public void AddRoute(string Source, string Target, int Length)
        {
            this.Source = Source;
            this.Target = Target;
            this.Length = Length;
        }

        public override string ToString()
        {
            string line = string.Format("| {0, -10} | {1, -9} | {2, 8} |",
                Source, Target, Length);
            return line;
        }
    }
}-