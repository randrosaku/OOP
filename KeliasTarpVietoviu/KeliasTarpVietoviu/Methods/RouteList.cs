using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KeliasTarpVietoviu
{
    public class RouteList
    {
        private Route[] Routes;
        private int N;

        public RouteList()
        {
            N = 0;
            Routes = new Route[100];
        }

        public int GetQuantity()
        {
            return N;
        }

        public Route GetRoute(int i)
        {
            return Routes[i];
        }

        public void Add(Route ob)
        {
            Routes[N++] = ob;
        }

        public void RemoveRoute(int i)
        {
            for (int j = i; j < N - 1; j++)
                Routes[j] = Routes[j + 1];
            Routes[N - 1] = null;
            N--;
        }
    }
}