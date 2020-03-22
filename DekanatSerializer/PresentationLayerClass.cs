using Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DekanatSerializer
{
    public partial class PresentationLayerClass
    {
        public static void OnlyReadSwitch(Control parent, int ExceptThisTextTabTextBoxes, bool SwitchTo)
        {
            foreach (Control c in parent.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    TextBox textBox = new TextBox();
                    textBox = (TextBox)c;
                    if (textBox.TabIndex > ExceptThisTextTabTextBoxes)
                        textBox.ReadOnly = SwitchTo;
                }
            }
        }
        public static void EnableDisableButtons(Button[] MassButtons , bool Enabled)
        {
            foreach (var item in MassButtons) item.Enabled = Enabled;
        }
        public static bool Check(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    TextBox textBox = new TextBox();
                    textBox = (TextBox)c;
                    if (textBox.TabIndex > 1)
                        if (textBox.Text == "") return false;
                }
            }
            return true;
        }
        public static void ClearControls(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    TextBox textBox = new TextBox();
                    textBox = (TextBox)c;
                    if (textBox.TabIndex != 1) textBox.Clear();
                }
            }
        }
        public static void ClearFiltres(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    TextBox textBox = new TextBox();
                    textBox = (TextBox)c;
                    textBox.Clear();
                }
                else if (c.GetType() == typeof(ComboBox))
                {
                    ComboBox comboBox = new ComboBox();
                    comboBox = (ComboBox)c;
                    comboBox.ResetText();
                }
            }
        }
        public static void SendDataFromHostelTextBox(Control parent)
        {
            int i = 0;
            foreach (Control c in parent.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    i++;
                }
            }
            string[] mass = new string[i];
            foreach (Control c in parent.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    TextBox textBox = new TextBox();
                    textBox = (TextBox)c;
                    mass[textBox.TabIndex - 1] = textBox.Text;
                }
            }
            BusinessClass.DataInForHostel(mass);
        }
        public static void SendDataFromHostelTextBox(Control parent, int RowIndex)
        {
            int i = 0;
            foreach (Control c in parent.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    i++;
                }
            }
            string[] mass = new string[i];

            foreach (Control c in parent.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    TextBox textBox = new TextBox();
                    textBox = (TextBox)c;
                    mass[textBox.TabIndex - 1] = textBox.Text;

                }
            }
            BusinessClass.DataInForHostel(mass, RowIndex);
        }
        public static void SendDataFromRoomTextBox(Control parent)
        {
            int i = 0;
            foreach (Control c in parent.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    i++;
                }
            }
            string[] mass = new string[i];
            foreach (Control c in parent.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    TextBox textBox = new TextBox();
                    textBox = (TextBox)c;
                    mass[textBox.TabIndex - 1] = textBox.Text;
                }
            }
            BusinessClass.DataInForRoom(mass);
        }
        public static void SendDataFromRoomTextBox(Control parent, int RowIndex)
        {
            int i = 0;
            foreach (Control c in parent.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    i++;
                }
            }
            string[] mass = new string[i];

            foreach (Control c in parent.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    TextBox textBox = new TextBox();
                    textBox = (TextBox)c;
                    mass[textBox.TabIndex - 1] = textBox.Text;

                }
            }
            BusinessClass.DataInForRoom(mass, RowIndex);
        }
        public static void SendDataFromGroupeTextBox(Control parent)
        {
            int i = 0;
            foreach (Control c in parent.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    i++;
                }
            }
            string[] mass = new string[i];
            foreach (Control c in parent.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    TextBox textBox = new TextBox();
                    textBox = (TextBox)c;
                    mass[textBox.TabIndex - 1] = textBox.Text;
                }
            }
            BusinessClass.DataInForGroupes(mass);
        }
        public static void SendDataFromGroupeTextBox(Control parent, int RowIndex)
        {
            int i = 0;
            foreach (Control c in parent.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    i++;
                }
            }
            string[] mass = new string[i];

            foreach (Control c in parent.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    TextBox textBox = new TextBox();
                    textBox = (TextBox)c;
                    mass[textBox.TabIndex - 1] = textBox.Text;

                }
            }
            BusinessClass.DataInForGroupes(mass, RowIndex);
        }
        public static void SendDataFromStudentTextBox(Control parent, string filePath)
        {            
            int i = 0;
            foreach (Control c in parent.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    i++;
                }
            }
            string[] mass = new string[i+1];
            
            foreach (Control c in parent.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    TextBox textBox = new TextBox();
                    textBox = (TextBox)c;
                    mass[textBox.TabIndex-1] = textBox.Text;
                    
                }
            }
            mass[mass.Length-1] = filePath;
            //foreach (var item in mass) MessageBox.Show(Convert.ToString(item));            
            //BusinessClass.DataInForStudent(textBoxGroupe.Text, textBoxRoom.Text, textBoxName1.Text, textBoxName2.Text, textBoxName3.Text, textBoxTicet.Text, textBoxFormStudy.Text, textBoxCB.Text, textBoxDescription.Text, FilePath);
            BusinessClass.DataInForStudent(mass);
        }
        public static void SendDataFromStudentTextBox(Control parent, string filePath, int RowIndex)
        {
            int i = 0;
            foreach (Control c in parent.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    i++;
                }
            }
            string[] mass = new string[i + 1];

            foreach (Control c in parent.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    TextBox textBox = new TextBox();
                    textBox = (TextBox)c;
                    mass[textBox.TabIndex - 1] = textBox.Text;

                }
            }
            mass[mass.Length - 1] = filePath;
            BusinessClass.DataInForStudent(mass, RowIndex);
        }
        public static void AddDataToTextBox(Control parent, BusinessClass.For @for, int RowIndex)
        {
            //int i = 0;
            //MessageBox.Show(RowIndex);
            DataTable dataTable = BusinessClass.OpenDataForEdit(@for, RowIndex);
            if (dataTable != null)
            {
                foreach (Control c in parent.Controls)
                {
                    if (c.GetType() == typeof(TextBox))
                    {
                        TextBox textBox = new TextBox();
                        textBox = (TextBox)c;
                        textBox.Text = Convert.ToString(dataTable.Rows[0][textBox.TabIndex - 1]);

                    }
                }
            }
            
        }
        public static void NonSortableGrid(DataGridView parent)
        {
            int i;
            for (i = 0; i < parent.ColumnCount; i++)
            {
                parent.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            parent.Columns[1].Width = 200;
            parent.Columns[i - 1].Width = 100;
            parent.Columns[i - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            parent.RowTemplate.MinimumHeight = 24;
            //parent.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

        }
        public static void GetSetPicture(PictureBox parent, int RowIndex)
        {

            if (BusinessClass.ReturnPicture(RowIndex) != null)
            {
                Bitmap bitmap = new Bitmap(BusinessClass.ReturnPicture(RowIndex));
                parent.Image = bitmap;
            }
            else parent.Image = null;
        }
        public static void GetSetPicture(PictureBox parent)
        {
            parent.Image = null;
        }
        public static void ClearBeforeCreate(Panel panel)
        {
            ClearControls(panel);
        }
        public static void ClearBeforeCreate(Panel panel, PictureBox pictureBox)
        {
            ClearControls(panel);
            GetSetPicture(pictureBox);
        }
        public static void ClearBeforeCreate(Panel panel, DataGridView parent)
        {
            parent.ClearSelection();
            ClearControls(panel);
        }
        public static void ClearBeforeCreate(Panel panel, PictureBox pictureBox, DataGridView parent)
        {
            parent.ClearSelection();
            ClearControls(panel);
            GetSetPicture(pictureBox);
        }        
        public static void AddItemsToComboBox(ComboBox parent, BusinessClass.For @for)
        {
            //List<ComboboxItem> Ilist = new List<ComboboxItem>();
            DataTable dataTable;
            if (@for == BusinessClass.For.Groupe)
            {
                dataTable = BusinessClass.DataOutPut(@for);
                parent.Items.Clear();
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    parent.Items.Add(Convert.ToString(dataTable.Rows[i][1]));
                }
            }
            else if (@for == BusinessClass.For.Hostel)
            {
                dataTable = BusinessClass.DataOutPut(@for);
                parent.Items.Clear();
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    parent.Items.Add(Convert.ToString(dataTable.Rows[i][1]));
                }
            }
            else if (@for == BusinessClass.For.Room)
            {
                dataTable = BusinessClass.DataOutPut(@for);
                parent.Items.Clear();
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    parent.Items.Add(Convert.ToString(dataTable.Rows[i][2]));
                }
            }

            {
                //ComboboxItem item = new ComboboxItem();
                //item.Gnumber = Convert.ToString(dataTable.Rows[i][3]);
                //Ilist.Add(item);

                //return Ilist
            }
        }
    }
}
