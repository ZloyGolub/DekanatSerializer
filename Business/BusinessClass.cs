using DekContext;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BusinessClass
    {
        public enum For { Student, Groupe, Room, Hostel }

        private static readonly string FilePath = @"DB.xml";

        public static void Save(object Blok)
        {
            DataLoadSave.SaveXML(FilePath, Blok);
        }

        public static bool FileEx(string path)
        {
            return File.Exists(path);
        }

        public static void CreateIfEx()
        {
            if (!FileEx(FilePath))
            {
                Dek TB = new Dek();
                Save(TB);
            }
        }
        //вынесение даных в дата грид

        public static DataTable InitealDTStudent()
        {
            DataTable ST = new DataTable("Student");
            ST.Columns.Add("ID", Type.GetType("System.Int32"));
            ST.Columns.Add("ПІБ", Type.GetType("System.String"));
            ST.Columns.Add("Група", Type.GetType("System.String"));
            ST.Columns.Add("Кімната", Type.GetType("System.String"));
            ST.Columns.Add("Номер студентського", Type.GetType("System.String"));
            ST.Columns.Add("Форма навчання", Type.GetType("System.String"));
            ST.Columns.Add("Контракт|Бюджет", Type.GetType("System.String"));
            ST.Columns.Add("Опис", Type.GetType("System.String"));
            return ST;
        }

        public static DataTable InitealDTStudentForEdit()
        {
            DataTable ST = new DataTable("Student");
            ST.Columns.Add("ID", Type.GetType("System.Int32"));
            ST.Columns.Add("ГрупаID", Type.GetType("System.String"));
            ST.Columns.Add("КімнатаID", Type.GetType("System.String"));
            ST.Columns.Add("Прізвище", Type.GetType("System.String"));
            ST.Columns.Add("Ім'я", Type.GetType("System.String"));
            ST.Columns.Add("По батькові", Type.GetType("System.String"));
            ST.Columns.Add("Номер студентського", Type.GetType("System.String"));
            ST.Columns.Add("Форма навчання", Type.GetType("System.String"));
            ST.Columns.Add("Контракт|Бюджет", Type.GetType("System.String"));
            ST.Columns.Add("Опис", Type.GetType("System.String"));
            return ST;
        }

        public static DataTable InitealDTSGrope()
        {
            DataTable GT = new DataTable("Groupes");
            GT.Columns.Add("ID", Type.GetType("System.Int32"));
            GT.Columns.Add("Група", Type.GetType("System.String"));
            GT.Columns.Add("Кількість студентів", Type.GetType("System.String"));
            GT.Columns.Add("Опис", Type.GetType("System.String"));
            return GT;
        }

        public static DataTable InitealDTRoom()
        {
            DataTable RT = new DataTable("Roomes");
            RT.Columns.Add("ID", Type.GetType("System.Int32"));
            RT.Columns.Add("Гуртожиток", Type.GetType("System.String"));
            RT.Columns.Add("Номер кімнати", Type.GetType("System.String"));
            RT.Columns.Add("Всі місця", Type.GetType("System.String"));
            RT.Columns.Add("Вільні місця", Type.GetType("System.String"));
            RT.Columns.Add("Опис", Type.GetType("System.String"));
            return RT;
        }

        public static DataTable InitealDTSHostel()
        {
            DataTable HT = new DataTable("Hostels");
            HT.Columns.Add("ID", Type.GetType("System.Int32"));
            HT.Columns.Add("Корпус", Type.GetType("System.String"));
            HT.Columns.Add("Кількість кімнат", Type.GetType("System.String"));
            HT.Columns.Add("Опис", Type.GetType("System.String"));
            return HT;
        }

        public static DataTable DataOutPut(For @for)
        {
            Dek TB;
            if (FileEx(FilePath))
            {
                TB = DataLoadSave.LoadXML(FilePath);

                DataSet Ds = new DataSet("Students");
                //DataTable DekDataTable = new DataTable("DekDataTable");
                DataTable StudentT = InitealDTStudent();
                DataTable GroupeT = InitealDTSGrope();
                DataTable RoomT = InitealDTRoom();
                DataTable HostelT = InitealDTSHostel();

                Ds.Tables.Add(StudentT);
                Ds.Tables.Add(GroupeT);
                Ds.Tables.Add(RoomT);
                Ds.Tables.Add(HostelT);

                switch (@for)
                {
                    case For.Student:
                        foreach (StudentsTable S in TB.Students)
                        {
                            StudentT.Rows.Add(new object[] {S.ID, S.ThirdName_1 +" "+S.Name_2 + " " + S.SurnameName_3,
                        GetGroupeNameByID(TB,S.GroupeID), GetRoomNumberByRoomID(TB,S.RoomID), S.TicetNumber, S.FormStudy, S.ContractBudget, S.Description });
                        }
                        return StudentT;
                    case For.Groupe:
                        foreach (GroupeTable G in TB.Groupes)
                        {
                            GroupeT.Rows.Add(new object[] { G.ID, G.GroupeNumber, G.StudentsInGroupe, G.Description });
                        }
                        return GroupeT;
                    case For.Room:
                        foreach (RoomTable R in TB.Roomes)
                        {
                            RoomT.Rows.Add(new object[] { R.ID, GetHostelNameByID(TB, R.HostelID), R.RoomNumber, R.AllPlace, R.FreePlase, R.Description });
                        }
                        return RoomT;
                    case For.Hostel:
                        foreach (HostelNewTable H in TB.HostelsN)
                        {
                            HostelT.Rows.Add(new object[] { H.ID, H.Frame, H.RoomsCount, H.Decription });
                        }
                        return HostelT;
                    default: return null;
                }
            }
            else return null;
        }

        public static DataTable OpenDataForEdit(For @for, int ID)
        {
            Dek TB = DataLoadSave.LoadXML(FilePath);

            DataSet Ds = new DataSet("Students");

            DataTable StudentTable = InitealDTStudentForEdit();
            DataTable GroupesTable = InitealDTSGrope();
            DataTable RoomTable = InitealDTRoom();
            DataTable HostTable = InitealDTSHostel();

            Ds.Tables.Add(StudentTable);
            Ds.Tables.Add(GroupesTable);
            Ds.Tables.Add(RoomTable);
            Ds.Tables.Add(HostTable);

            if (@for == For.Student)
            {
                int SitemID = GetTrueItemID(TB, ID, @for);
                //if (SitemID < TB.StudID)
                if (SitemID != -1)
                {
                    StudentsTable StudentBlok = TB.Students[SitemID];
                    StudentTable.Rows.Add(new object[] {StudentBlok.ID, GetGroupeNameByID(TB,StudentBlok.GroupeID), GetRoomNumberByRoomID(TB, StudentBlok.RoomID),
                        StudentBlok.ThirdName_1, StudentBlok.Name_2, StudentBlok.SurnameName_3, StudentBlok.TicetNumber, StudentBlok.FormStudy,
                        StudentBlok.ContractBudget, StudentBlok.Description});
                    return StudentTable;
                }
            }
            else if (@for == For.Groupe)
            {
                int GitemID = GetTrueItemID(TB, ID, @for);
                if (GitemID != -1)
                {
                    GroupeTable GroupeBlok = TB.Groupes[GitemID];
                    GroupesTable.Rows.Add(new object[] { GroupeBlok.ID, GroupeBlok.GroupeNumber, GroupeBlok.StudentsInGroupe,
                GroupeBlok.Description});
                    return GroupesTable;
                }
            }
            else if (@for == For.Room)
            {
                int RitemID = GetTrueItemID(TB, ID, @for);
                if (RitemID != -1)
                {
                    RoomTable RoomBlok = TB.Roomes[RitemID];
                    RoomTable.Rows.Add(new object[] { RoomBlok.ID, GetHostelNameByID(TB, RoomBlok.HostelID), RoomBlok.RoomNumber, RoomBlok.AllPlace, RoomBlok.FreePlase, RoomBlok.Description });
                    return RoomTable;
                }
            }
            else if (@for == For.Hostel)
            {
                int HitemID = GetTrueItemID(TB, ID, @for);
                if (HitemID != -1)
                {
                    HostelNewTable HostelBlok = TB.HostelsN[HitemID];
                    HostTable.Rows.Add(new object[] { HostelBlok.ID, HostelBlok.Frame, HostelBlok.RoomsCount, HostelBlok.Decription });
                    return HostTable;
                }
            }
            return null;
        }

        public static string ReturnPicture(int ID)
        {
            Dek TB = DataLoadSave.LoadXML(FilePath);

            var student = TB.Students.First(x => x.ID == ID);

            if (student.ImagePath != "")
            {
                return student.ImagePath;
            }
            return null;
        }

        //внесение даных в таблици

        public static int GetTrueItemID(Dek TableBlok, int ID, For @for)
        {
            switch (@for)
            {
                case For.Student:
                    for (int i = 0; i < TableBlok.Students.Count; i++)
                    {
                        if (TableBlok.Students[i].ID == ID)
                        {
                            return i;
                        }
                    }
                    break;
                case For.Groupe:
                    for (int i = 0; i < TableBlok.Groupes.Count; i++)
                    {
                        if (TableBlok.Groupes[i].ID == ID)
                        {
                            return i;
                        }
                    }
                    break;
                case For.Room:
                    for (int i = 0; i < TableBlok.Roomes.Count; i++)
                    {
                        if (TableBlok.Roomes[i].ID == ID)
                        {
                            return i;
                        }
                    }
                    break;
                case For.Hostel:
                    for (int i = 0; i < TableBlok.HostelsN.Count; i++)
                    {
                        if (TableBlok.HostelsN[i].ID == ID)
                        {
                            return i;
                        }
                    }
                    break;
            }
            return -1;
        }

        public static int GetGroupeIDByGroupeName(Dek TB, string GroupeName)
        {
            foreach (var item in TB.Groupes)
            {
                if (item.GroupeNumber == GroupeName) return item.ID;
            }
            return -1;
        }

        public static string GetGroupeNameByID(Dek TB, int ID)
        {
            foreach (var item in TB.Groupes)
            {
                if (item.ID == ID) return item.GroupeNumber;
            }
            return "";
        }

        public static int GetRoomIdByRoomNumber(Dek TB, string RoomNumber)
        {
            foreach (var item in TB.Roomes)
            {
                if (item.RoomNumber == RoomNumber) return item.ID;
            }
            return -1;
        }

        public static string GetRoomNumberByRoomID(Dek TB, int ID)
        {
            foreach (var item in TB.Roomes)
            {
                if (item.ID == ID) return item.RoomNumber;
            }
            return "";
        }

        public static int GetHostelIdByName(Dek TB, string NAME)
        {
            foreach (var item in TB.HostelsN)
            {
                if (item.Frame == NAME) return item.ID;
            }
            return -1;
        }

        public static string GetHostelNameByID(Dek TB, int ID)
        {
            foreach (var item in TB.HostelsN)
            {
                if (item.ID == ID) return item.Frame;
            }
            return "";
        }

        public static void DataInForStudent(string[] arg)//добавление
        {
            Dek TB = DataLoadSave.LoadXML(FilePath);

            //var student = TB.Students.First(x => x.ID == ID);

            StudentsTable StudentBlok = new StudentsTable
            (
                arg[1] != "" ? GetGroupeIDByGroupeName(TB, arg[1]) : -1,
                arg[2] != "" ? GetRoomIdByRoomNumber(TB, arg[2]) : -1,
                arg[3],
                arg[4],
                arg[5],
                arg[6],
                arg[7],
                arg[8],
                arg[9],
                arg[10] != null ? arg[10] : null
            );

            //StudentBlok.ID = TB.StudID++;
            TB.Students.Add(StudentBlok);
            Save(TB);
            //StudentsInGroupeCount();
            //StudentsInRoomCount();
        }

        public static void DataInForStudent(string[] arg, int ID)//редактирование за айдишником дата грида
        {
            Dek TB = DataLoadSave.LoadXML();
            int i = GetTrueItemID(TB, ID, For.Student);

            StudentsTable StudentBlok = new StudentsTable
            (
                arg[1] != "" ? GetGroupeIDByGroupeName(TB, arg[1]) : -1,
                arg[2] != "" ? GetRoomIdByRoomNumber(TB, arg[2]) : -1,
                arg[3],
                arg[4],
                arg[5],
                arg[6],
                arg[7],
                arg[8],
                arg[9],
                arg[10] != null ? arg[10] : null
            );

            StudentBlok.ID = TB.Students[i].ID;
            TB.Students[i] = StudentBlok;
            Save(TB);
            //Dek TB;
            //if (FileEx(FilePath))
            //    TB = DataLoadSave.LoadXML(FilePath);
            //else TB = new Dek();


            //int i = GetTrueItemID(TB, ID, For.Student);


            //StudentsTable StudentBlok = new StudentsTable
            //{
            //    GroupeID = arg[1] != "" ? GetGroupeIDByGroupeName(TB, arg[1]) : -1,
            //    RoomID = arg[2] != "" ? GetRoomIdByRoomNumber(TB, arg[2]) : -1,
            //    ThirdName_1 = arg[3],
            //    Name_2 = arg[4],
            //    SurnameName_3 = arg[5],
            //    TicetNumber = arg[6],
            //    FormStudy = arg[7],
            //    ContractBudget = arg[8],
            //    Description = arg[9],
            //    Bin = arg[10] != null ? File.ReadAllBytes(arg[10]) : TB.Students[i].Bin
            //};
            //StudentBlok.ID = TB.Students[i].ID;
            //TB.Students[i] = StudentBlok;
            //Save(TB);
            //StudentsInGroupeCount();
            //StudentsInRoomCount();
        }

        public static bool DataDeleteStudent(int ID)
        {
            Dek TB;
            if (FileEx(FilePath))
            {
                TB = DataLoadSave.LoadXML(FilePath);
                TB.Students.RemoveAt(GetTrueItemID(TB, ID, For.Student));
                //TB.Students.RemoveAt(ID);
                DataLoadSave.SaveXML(FilePath, TB);
                return true;
            }
            else return false;
        }//удаление за айдишником дата грида(уже нет)
        //удаление за полем айди в елементе

        //public static void StudentsInGroupeCount()//инициализировать при добавлении каждого студента и редактировании
        //{
        //    Dek TB = DataLoadSave.LoadXML(FilePath);
        //    foreach (var item in TB.Groupes)
        //    {
        //        item.StudentsInGroupe = 0;
        //    }

        //    foreach (var Gitem in TB.Groupes)
        //    {
        //        foreach (var Sitem in TB.Students)
        //        {
        //            if (Gitem.ID == Sitem.GroupeID)
        //            {
        //                Gitem.StudentsInGroupe++;
        //            }
        //        }
        //    }
        //    DataLoadSave.SaveXML(FilePath, TB);
        //}

        public static void DataInForGroupes(string[] arg)
        {
            Dek TB;
            if (FileEx(FilePath))
                TB = DataLoadSave.LoadXML(FilePath);
            else TB = new Dek();
            GroupeTable GroupeBlok = new GroupeTable(arg[1], arg[3]);
            TB.Groupes.Add(GroupeBlok);
            Save(TB);
        }

        public static void DataInForGroupes(string[] arg, int ID)
        {
            Dek TB;
            if (FileEx(FilePath))
                TB = DataLoadSave.LoadXML(FilePath);
            else TB = new Dek();
            int i = GetTrueItemID(TB, ID, For.Groupe);
            GroupeTable GroupeBlok = new GroupeTable(arg[1],arg[3]);
            GroupeBlok.ID = TB.Students[i].ID;
            TB.Groupes[i] = GroupeBlok;
            Save(TB);
        }

        public static bool DataDeleteGroupe(int ID)
        {
            Dek TB;
            if (FileEx(FilePath))
            {
                TB = DataLoadSave.LoadXML(FilePath);
                int i = GetTrueItemID(TB, ID, For.Groupe);
                if (TB.Groupes[i].StudentsInGroupe > 0) return false;
                TB.Groupes.RemoveAt(i);
                DataLoadSave.SaveXML(FilePath, TB);
                return true;
            }
            else return false;
        }

        //public static void StudentsInRoomCount()//вызывать при добавлении каждого студента и редактировании
        //{
        //    Dek TB = DataLoadSave.LoadXML(FilePath);
        //    foreach (var item in TB.Roomes)
        //    {
        //        item.FreePlase = item.AllPlace;
        //    }
        //    foreach (var Ritem in TB.Roomes)
        //    {
        //        foreach (var Sitem in TB.Students)
        //        {
        //            if (Ritem.ID == Sitem.RoomID)
        //            {
        //                Ritem.FreePlase--;
        //            }
        //        }
        //    }
        //    DataLoadSave.SaveXML(FilePath, TB);
        //}

        public static void DataInForRoom(string[] arg)
        {
            //Dek TB;
            //if (FileEx(FilePath))
            //    TB = DataLoadSave.LoadXML(FilePath);
            //else TB = new Dek();
            //RoomTable RoomBlok = new RoomTable
            //{
            //    RoomNumber = arg[2],
            //    HostelID = arg[1] != "" ? GetHostelIdByName(TB, arg[1]) : -1,
            //    AllPlace = arg[3] != "" ? Convert.ToInt32(arg[3]) : 0,
            //    FreePlase = arg[3] != "" ? Convert.ToInt32(arg[3]) : 0,
            //    Description = arg[5]
            //};
            //RoomBlok.ID = TB.RoomID++;
            //TB.Roomes.Add(RoomBlok);
            //Save(TB);
            //RoomsInHostelCount();
        }

        public static void DataInForRoom(string[] arg, int ID)
        {
            //Dek TB;
            //if (FileEx(FilePath))
            //    TB = DataLoadSave.LoadXML(FilePath);
            //else TB = new Dek();
            //int i = GetTrueItemID(TB, ID, For.Room);
            //RoomTable RoomBlok = new RoomTable
            //{
            //    RoomNumber = arg[2],
            //    HostelID = arg[1] != "" ? GetHostelIdByName(TB, arg[1]) : -1,
            //    AllPlace = arg[3] != "" ? Convert.ToInt32(arg[3]) : 0,
            //    //FreePlase = Convert.ToInt32(arg[3]),
            //    Description = arg[5]
            //};
            //RoomBlok.ID = TB.Roomes[i].ID;
            //TB.Roomes[i] = RoomBlok;
            //Save(TB);
            //StudentsInRoomCount();
            //RoomsInHostelCount();
        }

        public static bool DataDeleteRoom(int ID)
        {
            //Dek TB;
            //if (FileEx(FilePath))
            //{
            //    TB = DataLoadSave.LoadXML(FilePath);
            //    int i = GetTrueItemID(TB, ID, For.Room);
            //    StudentsInRoomCount();
            //    if (TB.Roomes[i].FreePlase != TB.Roomes[i].AllPlace) return false;
            //    TB.Roomes.RemoveAt(i);
            //    DataLoadSave.SaveXML(FilePath, TB);
            //    RoomsInHostelCount();
            //    return true;
            //}
            //else return false;
            return false;
        }

        public static void DataInForHostel(string[] arg)
        {
            //Dek TB;
            //if (FileEx(FilePath))
            //    TB = DataLoadSave.LoadXML(FilePath);
            //else TB = new Dek();
            //HostelNewTable HostelBlok = new HostelNewTable
            //{
            //    Frame = arg[1],
            //    RoomsCount = 0,
            //    Decription = arg[3]
            //};
            //HostelBlok.ID = TB.HostID++;
            //TB.HostelsN.Add(HostelBlok);
            //Save(TB);
        }

        public static void RoomsInHostelCount()//вызывать при добавлении и редакт комнаты
        {
            Dek TB = DataLoadSave.LoadXML(FilePath);
            foreach (var item in TB.HostelsN)
            {
                item.RoomsCount = 0;
            }
            foreach (var Hitem in TB.HostelsN)
            {
                foreach (var Ritem in TB.Roomes)
                {
                    if (Hitem.ID == Ritem.HostelID)
                    {
                        Hitem.RoomsCount++;
                    }
                }
            }
            DataLoadSave.SaveXML(FilePath, TB);
        }

        public static void DataInForHostel(string[] arg, int ID)
        {
            //Dek TB;
            //if (FileEx(FilePath))
            //    TB = DataLoadSave.LoadXML(FilePath);
            //else TB = new Dek();
            //int i = GetTrueItemID(TB, ID, For.Hostel);
            //HostelNewTable HostelBlok = new HostelNewTable
            //{
            //    Frame = arg[1],
            //    Decription = arg[3]
            //};
            //HostelBlok.ID = TB.HostelsN[i].ID;
            //TB.HostelsN[i] = HostelBlok;
            //Save(TB);
            //RoomsInHostelCount();
        }

        public static bool DataDeleteHostel(int ID)
        {
            //Dek TB;
            //if (FileEx(FilePath))
            //{
            //    TB = DataLoadSave.LoadXML(FilePath);
            //    int i = GetTrueItemID(TB, ID, For.Hostel);
            //    RoomsInHostelCount();
            //    if (TB.HostelsN[i].RoomsCount > 0) return false;
            //    TB.HostelsN.RemoveAt(i);
            //    DataLoadSave.SaveXML(FilePath, TB);
            //    return true;
            //}
            //else return false;
            return false;
        }

        //поисковые запросы
        public static bool CompareBoolArg(bool[] atg)
        {

            for (int i = 0; i < atg.Length; i++)
            {
                if (atg[i] == true) continue;
                else return false;
            }
            return true;
        }

        public static bool GetHostelIDByRoomID(Dek TB, int RoomID, int HostelID)
        {
            if (RoomID == -1) return false;
            if (TB.Roomes[GetTrueItemID(TB, RoomID, For.Room)].HostelID == HostelID) return true;
            else return false;
        }

        public static DataTable SearchInStudents(string name1, string name2, string name3, string groupe, For @for)
        {
            Dek TB;
            if (FileEx(FilePath))
            {
                TB = DataLoadSave.LoadXML(FilePath);

                DataSet Ds = new DataSet("Students");
                //DataTable DekDataTable = new DataTable("DekDataTable");
                DataTable StudentTable = InitealDTStudent();
                DataTable GroupesTable = InitealDTSGrope();
                DataTable RoomTable = InitealDTRoom();

                Ds.Tables.Add(StudentTable);
                Ds.Tables.Add(GroupesTable);
                Ds.Tables.Add(RoomTable);

                foreach (StudentsTable S in TB.Students)
                {
                    bool[] arg = new bool[4];
                    arg[0] = S.ThirdName_1.Contains(name1) || S.ThirdName_1 == "" ? true : false;
                    arg[1] = S.Name_2.Contains(name2) || S.Name_2 == "" ? true : false;
                    arg[2] = S.SurnameName_3.Contains(name3) || S.SurnameName_3 == "" ? true : false;
                    arg[3] = GetGroupeNameByID(TB, S.GroupeID).Contains(groupe) || GetGroupeNameByID(TB, S.GroupeID) == "" ? true : false;

                    if (CompareBoolArg(arg))
                    {
                        StudentTable.Rows.Add(new object[] {S.ID, S.ThirdName_1 +" "+S.Name_2 + " " + S.SurnameName_3,
                        GetGroupeNameByID(TB, S.GroupeID),GetRoomNumberByRoomID(TB, S.RoomID), S.TicetNumber, S.FormStudy, S.ContractBudget, S.Description });
                    }
                }
                return StudentTable;
                /*
                foreach (GroupeTable G in TB.Groupes)
                {
                    GroupesTable.Rows.Add(new object[] { G.GroupeNumber, G.StudentsInGroupe, G.Description });
                }

                foreach (RoomTable R in TB.Roomes)
                {
                    RoomTable.Rows.Add(new object[] { R.RoomNumber, R.AllPlace, R.FreePlase, R.Description });
                }

                switch (@for)
                {
                    case For.Student: return StudentTable;
                    case For.Groupe: return GroupesTable;
                    case For.Room: return RoomTable;
                    default: return null;
                }
             //arg[4] = GetHostelIDByRoomID(TB, GetRoomIdByRoomNumber(TB,Room), GetHostelIdByName(TB, hostel)) || hostel == "" ? true : false;
                    //arg[5] = GetRoomNumberByRoomID(TB, S.RoomID).Contains(Room) || GetRoomNumberByRoomID(TB, S.RoomID) == "" ? true : false;   
             */
            }
            else return null;
        }
    }
}
