using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DekContext
{
    public class Dek
    {
        public string name;
        public string Name { get; } = "DekanatDB";

        //public int StudID { get; set; }
        //public int RoomID { get; set; }
        //public int GroupID { get; set; }
        //public int HostID { get; set; }

        public List<StudentsTable> Students = new List<StudentsTable>();
        public List<RoomTable> Roomes = new List<RoomTable>();
        public List<GroupeTable> Groupes = new List<GroupeTable>();
        public List<HostelNewTable> HostelsN = new List<HostelNewTable>();



    }
}
