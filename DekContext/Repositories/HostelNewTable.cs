using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DekContext
{
    public class HostelNewTable
    {
        public static int StartID = 0;

        public int ID { get; set; }
        public string Frame { get; set; }
        public int RoomsCount { get; set; }
        public string Decription { get; set; }
        public HostelNewTable(string Frame, int RoomsCount, string Decription)
        {
            ID = StartID++;
            this.Frame = Frame;
            this.RoomsCount = RoomsCount;
            this.Decription = Decription;
        }

        public HostelNewTable() { }
    }
}
