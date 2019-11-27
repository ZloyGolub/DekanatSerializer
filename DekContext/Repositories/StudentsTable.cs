using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DekContext
{
    /// <summary>
    /// 
    /// </summary>
    public class StudentsTable
    {
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

        public byte[] Bin { get; set; }
    }
}
