using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DekContext
{
    public class StudentsTable
    {
        public static int StartID = 0;

        public int ID { get; set; }
        public int GroupeID { get; set; }
        public int RoomID { get; set; }
        public string ThirdName_1 { get; set; }
        public string Name_2 { get; set; }
        public string SurnameName_3 { get; set; }

        public string TicetNumber { get; set; }
        public string FormStudy { get; set; }
        public string ContractBudget { get; set; }
        public string Description { get; set; }

        public string ImagePath { get; set; }

        public StudentsTable() { }
        public StudentsTable(
            int GroupeID,
            int RoomID,
            string ThirdName_1,
            string Name_2,
            string SurnameName_3,
            string TicetNumber,
            string FormStudy,
            string ContractBudget,
            string Description,
            string ImagePath)
        {
            this.ID = StartID++;

            this.GroupeID = GroupeID;
            this.RoomID = RoomID;
            this.ThirdName_1 = ThirdName_1;
            this.Name_2 = Name_2;
            this.SurnameName_3 = SurnameName_3;
            this.TicetNumber = TicetNumber;
            this.FormStudy = FormStudy;
            this.ContractBudget = ContractBudget;
            this.Description = Description;
            this.ImagePath = ImagePath;
        }
    }
}
