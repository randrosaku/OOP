using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KeliasTarpVietoviu
{
    public class Route
    {
        public string Source { get; set; }
        public string Target { get; set; }
        public int Length { get; set; }

        public Route()
        {
            Source = "";
            Target = "";
            Length = 0;
        }

        public void AddRoute(string Source, string Target, int Length)
        {
            this.Source = Source;
            this.Target = Target;
            this.Length = Length;
        }
    }
}