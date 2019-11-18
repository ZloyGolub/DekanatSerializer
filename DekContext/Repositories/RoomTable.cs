using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DekContext
{
    public class RoomTable
    {
        public int ID { get; set; }
        
        public int HostelID { get; set; }

        public string RoomNumber { get; set; }

        public int AllPlace { get; set; }

        public int FreePlase { get; set; }

        public string Description { get; set; }
    }
}
