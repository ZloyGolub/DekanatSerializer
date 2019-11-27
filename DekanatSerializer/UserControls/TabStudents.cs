using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using System.IO;

namespace DekanatSerializer
{
    /// <summary>
    /// 
    /// </summary>
    public partial class TabStudents : UserControl
    {

        /// <summary>Initializes a new instance of the <see cref="TabStudents"/> class.</summary>
        public TabStudents()
        {
            InitializeComponent();
            BusinessClass.CreateIfEx();
            UpdateData(TableName);
            PresentationLayerClass.NonSortableGrid(dataGridView1);
            PresentationLayerClass.OnlyReadSwitch(panel1, 3, true);
            PresentationLayerClass.EnableDisableButtons(new Button[] {
                ButtonSelectGroupe, ButtonErace,ButtonEdit, ButtonSelectRoom,ButtonClear, ButtonOpen, ButtonSave }, false);
        }

        /// <summary>Gets the name of the table.</summary>
        /// <value>The name of the table.</value>
        public BusinessClass.For TableName { get; private set; } = BusinessClass.For.Student;
        /// <summary>Gets a value indicating whether [flag selected row].</summary>
        /// <value>
        ///   <c>true</c> if [flag selected row]; otherwise, <c>false</c>.</value>
        public bool FlagSelectedRow { get; private set; } = false;
        /// <summary>Gets the file path.</summary>
        /// <value>The file path.</value>
        public string FilePath { get; private set; }

        /// <summary>Updates the data.</summary>
        /// <param name="for">For.</param>
        private void UpdateData(BusinessClass.For @for)
        {
            dataGridView1.DataSource = BusinessClass.DataOutPut(@for);
            PresentationLayerClass.AddItemsToComboBox(comboBox1, BusinessClass.For.Groupe);
            PresentationLayerClass.AddItemsToComboBox(comboBox2, BusinessClass.For.Hostel);
            PresentationLayerClass.AddItemsToComboBox(comboBox3, BusinessClass.For.Room);            
        }

        /// <summary>Handles the Click event of the ButtonSave control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (FlagSelectedRow)
            {
                PresentationLayerClass.SendDataFromStudentTextBox(panel1, FilePath);
                UpdateData(TableName);
                //PresentationLayerClass.ClearControls(this);
                PresentationLayerClass.ClearBeforeCreate(panel1, pictureBox1, dataGridView1);
                PresentationLayerClass.OnlyReadSwitch(panel1, 3, true);
                PresentationLayerClass.EnableDisableButtons(new Button[] {
                    ButtonSearch,ButtonDelete, ButtonResetFilters, ButtonCreate,ButtonEdit },true);
                PresentationLayerClass.EnableDisableButtons(new Button[] {
                    ButtonSelectGroupe,ButtonErace, ButtonSelectRoom, ButtonSave, ButtonOpen, ButtonClear, }, false);
                dataGridView1.Enabled = true;
                ButtonCancelEdit.Hide();
            }
            else
            {
                if (dataGridView1.CurrentRow != null)
                {
                    int i = dataGridView1.CurrentRow.Index;
                    PresentationLayerClass.SendDataFromStudentTextBox(panel1, FilePath,
                        Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString()));
                    UpdateData(TableName);
                    dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[0];
                    {
                        //dataGridView1.SelectedRows[i].Cells[0];
                        //dataGridView1.Rows[i].Selected = true;
                        //MessageBox.Show(Convert.ToString(dataGridView1.CurrentRow.Index));
                        //-------
                    }
                    PresentationLayerClass.AddDataToTextBox(panel1, TableName,
                        Convert.ToInt32(dataGridView1[0, i].Value.ToString()));
                    PresentationLayerClass.GetSetPicture(pictureBox1,
                        Convert.ToInt32(dataGridView1[0, i].Value.ToString()));
                    FilePath = null;
                    FlagSelectedRow = false;
                    PresentationLayerClass.OnlyReadSwitch(panel1, 3, true);
                    PresentationLayerClass.EnableDisableButtons(new Button[] {
                    ButtonSearch, ButtonDelete, ButtonResetFilters, ButtonCreate,ButtonEdit }, true);
                    PresentationLayerClass.EnableDisableButtons(new Button[] {
                    ButtonSelectGroupe,ButtonErace, ButtonSelectRoom, ButtonSave, ButtonOpen, ButtonClear}, false);
                    dataGridView1.Enabled = true;
                    ButtonCancelEdit.Hide();
                }
            }
        }

        /// <summary>Handles the Click event of the ButtonOpen control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ButtonOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            FilePath = openFileDialog1.FileName;
            pictureBox1.Image = Image.FromFile(FilePath);
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            PresentationLayerClass.EnableDisableButtons(new Button[] {
                ButtonSelectGroupe,ButtonErace, ButtonSelectRoom, ButtonOpen, ButtonSave, ButtonClear }, true);
            PresentationLayerClass.EnableDisableButtons(new Button[] {
                    ButtonDelete, ButtonCreate, ButtonSearch, ButtonResetFilters, ButtonEdit }, false);
            PresentationLayerClass.OnlyReadSwitch(panel1, 3, false);
            dataGridView1.Enabled = false;
            ButtonCancelEdit.Visible = true;
            PresentationLayerClass.ClearBeforeCreate(panel1, pictureBox1, dataGridView1);
            FlagSelectedRow = true;
            textBoxName1.Focus();
        }

        private void ButtonClear_Clic(object sender, EventArgs e)
        {
            PresentationLayerClass.ClearBeforeCreate(panel1, pictureBox1);
            textBoxName1.Focus();
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            {
                //MessageBox.Show(Convert.ToString(dataGridView1.CurrentRow.Index));
                //DataTable dataTable = BusinessClass.SpecString("Students", dataGridView1.CurrentRow.Index);
                //textBoxGroupe.Text = Convert.ToString(dataTable.Rows[0][0]);
                //MessageBox.Show(Convert.ToString(dataGridView1.CurrentRow.Index));
                //dataGridView1.Columns..SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            ButtonEdit.Enabled = true;
            PresentationLayerClass.AddDataToTextBox(panel1, TableName,
                Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString()));
            //PresentationLayerClass.AddDataToTextBox(panel1, TableName)
            PresentationLayerClass.GetSetPicture(pictureBox1,
                Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString()));
            FilePath = null;
            FlagSelectedRow = false;

        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Обраний запис видалится.", "Видалити?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                    BusinessClass.DataDeleteStudent(Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString()));
                UpdateData(TableName);
                PresentationLayerClass.ClearBeforeCreate(panel1, pictureBox1, dataGridView1);
                FlagSelectedRow = true;
            }
            catch
            {

            }
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BusinessClass.SearchInStudents(textBox1.Text, textBox2.Text,
                textBox3.Text, comboBox1.Text, TableName);
        }

        private void ButtonResetFilters_Click(object sender, EventArgs e)
        {
            PresentationLayerClass.ClearFiltres(panel2);
            UpdateData(TableName);
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (!FlagSelectedRow)
            {
                PresentationLayerClass.EnableDisableButtons(new Button[] {
                    ButtonSelectGroupe,ButtonErace, ButtonSelectRoom, ButtonOpen, ButtonSave, ButtonDelete, ButtonClear }, true);
                PresentationLayerClass.EnableDisableButtons(new Button[] {
                    ButtonDelete, ButtonCreate, ButtonSearch, ButtonResetFilters, ButtonEdit }, false);
                PresentationLayerClass.OnlyReadSwitch(panel1, 3, false);
                ButtonCancelEdit.Visible = true;
            }
        }

        private void ButtonCancelEdit_Click(object sender, EventArgs e)
        {
            PresentationLayerClass.ClearBeforeCreate(panel1, pictureBox1);
            try
            {
                PresentationLayerClass.AddDataToTextBox(panel1, TableName,
                    Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString()));
                PresentationLayerClass.GetSetPicture(pictureBox1,
                    Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString()));
            }
            catch { }
            FilePath = null;
            FlagSelectedRow = false;
            ButtonCancelEdit.Visible = false;
            dataGridView1.Enabled = true;
            PresentationLayerClass.EnableDisableButtons(new Button[] {
                ButtonSelectGroupe, ButtonErace,ButtonSelectRoom, ButtonOpen, ButtonSave, ButtonDelete, ButtonClear }, false);
            PresentationLayerClass.EnableDisableButtons(new Button[] {
                ButtonDelete, ButtonCreate, ButtonSearch, ButtonResetFilters, ButtonEdit }, true);
            PresentationLayerClass.OnlyReadSwitch(panel1, 0, true);
        }

        private void ButtonSelectGroupe_Click(object sender, EventArgs e)
        {
            DialogSelectGroupe DSG = new DialogSelectGroupe();            
            DSG.ShowDialog();
            if(DSG.DialogResult == DialogResult.OK)
            {
                textBoxGroupe.Text = DSG.Result;
                DSG.Dispose();
            }
            else
            {
                DSG.Dispose();
            }
        }

        private void ButtonSelectRoom_Click(object sender, EventArgs e)
        {
            DialogSelectRoom DSR = new DialogSelectRoom();
            DSR.ShowDialog();
            if (DSR.DialogResult == DialogResult.OK)
            {
                textBoxRoom.Text = DSR.Result;
                DSR.Dispose();
            }
            else
            {
                DSR.Dispose();
            }
        }

        private void ButtonErace_Click(object sender, EventArgs e)
        {
            textBoxRoom.Clear();
        }
    }
}
