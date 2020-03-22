using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DekContext
{
    public class GroupeTable
    {
        public static int StartID = 0;
        public int ID { get; set; }
        public string GroupeNumber { get; set; }
        public int StudentsInGroupe 
        {
            get
            {
                Dek dek = DataLoadSave.LoadXML();
                return dek.Students.Where(x => x.GroupeID == ID).Count();
            }                
        }
        public string Description { get; set; }

        public GroupeTable() { }
        public GroupeTable(string GroupeNumber, string Description)
        {
            ID = StartID++;
            this.GroupeNumber = GroupeNumber;
            this.Description = Description;
        }
    }
}
