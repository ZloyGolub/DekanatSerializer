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

namespace DekanatSerializer
{
    public partial class TabHostels : UserControl
    {
        public TabHostels()
        {
            InitializeComponent();
            UpdateData(TableName);
            PresentationLayerClass.OnlyReadSwitch(panel1, 0, true);
            PresentationLayerClass.EnableDisableButtons(new Button[] {
                ButtonClear, ButtonSave }, false);
        }

        public BusinessClass.For TableName { get; private set; } = BusinessClass.For.Hostel;
        public bool FlagSelectedRow { get; private set; } = false;

        private void UpdateData(BusinessClass.For @for)
        {
            dataGridView1.DataSource = BusinessClass.DataOutPut(@for);
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (FlagSelectedRow)
            {
                PresentationLayerClass.SendDataFromHostelTextBox(panel1);
                UpdateData(TableName);
                //PresentationLayerClass.ClearControls(this);
                PresentationLayerClass.ClearBeforeCreate(panel1, dataGridView1);
                PresentationLayerClass.OnlyReadSwitch(panel1, 1, true);
                TextBoxRoomsCount.ReadOnly = true;
                PresentationLayerClass.EnableDisableButtons(new Button[] {
                    ButtonDelete, ButtonCreate,ButtonEdit }, true);
                PresentationLayerClass.EnableDisableButtons(new Button[] {
                    ButtonSave, ButtonClear, }, false);
                dataGridView1.Enabled = true;
                ButtonCancelEdit.Hide();
            }
            else
            {
                if (dataGridView1.CurrentRow != null)
                {
                    int i = dataGridView1.CurrentRow.Index;
                    PresentationLayerClass.SendDataFromHostelTextBox(panel1,
                        Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString()));
                    UpdateData(TableName);
                    dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[0];

                    PresentationLayerClass.AddDataToTextBox(panel1, TableName,
                        Convert.ToInt32(dataGridView1[0, i].Value.ToString()));
                    FlagSelectedRow = false;
                    PresentationLayerClass.OnlyReadSwitch(panel1, 1, true);
                    TextBoxRoomsCount.ReadOnly = true;
                    PresentationLayerClass.EnableDisableButtons(new Button[] {
                    ButtonDelete, ButtonCreate,ButtonEdit }, true);
                    PresentationLayerClass.EnableDisableButtons(new Button[] {
                    ButtonSave, ButtonClear}, false);
                    dataGridView1.Enabled = true;
                    ButtonCancelEdit.Hide();
                }
            }
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            PresentationLayerClass.EnableDisableButtons(new Button[] {
                ButtonSave, ButtonClear }, true);
            PresentationLayerClass.EnableDisableButtons(new Button[] {
                    ButtonDelete, ButtonCreate, ButtonEdit }, false);
            PresentationLayerClass.OnlyReadSwitch(panel1, 1, false);
            TextBoxRoomsCount.ReadOnly = true;
            dataGridView1.Enabled = false;
            ButtonCancelEdit.Visible = true;
            PresentationLayerClass.ClearBeforeCreate(panel1, dataGridView1);
            FlagSelectedRow = true;
            TextBoxName.Focus();
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            PresentationLayerClass.ClearBeforeCreate(panel1);
            TextBoxName.Focus();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            PresentationLayerClass.AddDataToTextBox(panel1, TableName,
                Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString()));
            FlagSelectedRow = false;
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Обраний запис видалится.", "Видалити?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (BusinessClass.DataDeleteHostel(Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString())))
                    {
                        MessageBox.Show("Гуртожиток успішно видалено.");
                    }
                    else MessageBox.Show("Видалення неможливе. В гуртожитку є кімнати.");
                }
                UpdateData(TableName);
                PresentationLayerClass.ClearBeforeCreate(panel1, dataGridView1);
                FlagSelectedRow = true;
            }
            catch
            {

            }
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (!FlagSelectedRow)
            {
                PresentationLayerClass.EnableDisableButtons(new Button[] {
                    ButtonSave, ButtonDelete, ButtonClear }, true);
                PresentationLayerClass.EnableDisableButtons(new Button[] {
                    ButtonDelete, ButtonCreate, ButtonEdit }, false);
                PresentationLayerClass.OnlyReadSwitch(panel1, 1, false);
                TextBoxRoomsCount.ReadOnly = true;
                ButtonCancelEdit.Visible = true;
            }
        }

        private void ButtonCancelEdit_Click(object sender, EventArgs e)
        {
            PresentationLayerClass.ClearBeforeCreate(panel1);
            try
            {
                PresentationLayerClass.AddDataToTextBox(panel1, TableName,
               Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString()));
            }
            catch { }
            FlagSelectedRow = false;
            ButtonCancelEdit.Visible = false;
            dataGridView1.Enabled = true;
            PresentationLayerClass.EnableDisableButtons(new Button[] {
                ButtonSave, ButtonDelete, ButtonClear }, false);
            PresentationLayerClass.EnableDisableButtons(new Button[] {
                ButtonDelete, ButtonCreate, ButtonEdit }, true);
            PresentationLayerClass.OnlyReadSwitch(panel1, 0, true);
            TextBoxRoomsCount.ReadOnly = true;
        }
    }
}
