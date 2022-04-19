using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KeliasTarpVietoviu
{
    public class VillageList
    {
        private Village[] Villages;
        private int N;

        public VillageList()
        {
            N = 0;
            Villages = new Village[100];
        }

        public int GetQuantity()
        {
            return N;
        }

        public Village GetVillage(int i)
        {
            return Villages[i];
        }

        public void Add(Village ob)
        {
            Villages[N++] = ob;
        }

        public void RemoveVillage(int i)
        {
            for (int j = i; j < N - 1; j++)
                Villages[j] = Villages[j + 1];
            Villages[N - 1] = null;
            N--;
        }
    }
}