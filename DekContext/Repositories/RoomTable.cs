using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DekContext
{
    public class RoomTable
    {
        public static int StartID = 0;
        public int ID { get; set; } 
        public int HostelID { get; set; }
        public string RoomNumber { get; set; }
        public int AllPlace { get; set; }
        public int FreePlase { get; set; }
        public string Description { get; set; }

        public RoomTable() { }
        public RoomTable (int HostelID, string RoomNumber ,int AllPlace, int FreePlase, string Description)
        {
            ID = StartID++;

            this.HostelID = HostelID;
            this.RoomNumber = RoomNumber;
            this.AllPlace = AllPlace;
            this.FreePlase = FreePlase;
            this.Description = Description;
        }
    }
}
