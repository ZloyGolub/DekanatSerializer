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
    /// <summary></summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class TabGropes : UserControl
    {
        /// <summary>Initializes a new instance of the <see cref="TabGropes"/> class.</summary>
        public TabGropes()
        {
            InitializeComponent();
            UpdateData(TableName);
            PresentationLayerClass.NonSortableGrid(dataGridView1);
            PresentationLayerClass.OnlyReadSwitch(panel1, 0, true);
            PresentationLayerClass.EnableDisableButtons(new Button[] {
                ButtonClear, ButtonSave }, false);
        }
        /// <summary>Gets the name of the table.</summary>
        /// <value>The name of the table.</value>
        public BusinessClass.For TableName { get; private set; } = BusinessClass.For.Groupe;
        /// <summary>Gets a value indicating whether [flag selected row].</summary>
        /// <value>
        ///   <c>true</c> if [flag selected row]; otherwise, <c>false</c>.</value>
        public bool FlagSelectedRow { get; private set; } = false;

        /// <summary>Updates the data.</summary>
        /// <param name="for">For.</param>
        private void UpdateData(BusinessClass.For @for)
        {
            dataGridView1.DataSource = BusinessClass.DataOutPut(@for);
        }

        /// <summary>Handles the Click event of the ButtonCreate control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            PresentationLayerClass.EnableDisableButtons(new Button[] {
                ButtonSave, ButtonClear }, true);
            PresentationLayerClass.EnableDisableButtons(new Button[] {
                    ButtonDelete, ButtonCreate, ButtonEdit }, false);
            PresentationLayerClass.OnlyReadSwitch(panel1, 1, false);
            textBox2.ReadOnly = true;
            dataGridView1.Enabled = false;
            ButtonCancelEdit.Visible = true;
            PresentationLayerClass.ClearBeforeCreate(panel1);
            FlagSelectedRow = true;
        }

        /// <summary>Handles the Click event of the ButtonSave control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (FlagSelectedRow)
            {
                PresentationLayerClass.SendDataFromGroupeTextBox(panel1);
                UpdateData(TableName);
                PresentationLayerClass.ClearBeforeCreate(panel1, dataGridView1);
                PresentationLayerClass.OnlyReadSwitch(panel1, 1, true);
                textBox2.ReadOnly = true;
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
                    PresentationLayerClass.SendDataFromGroupeTextBox(panel1, Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString()));
                    UpdateData(TableName);
                    dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[0];
                    PresentationLayerClass.AddDataToTextBox(panel1, TableName, Convert.ToInt32(dataGridView1[0, i].Value.ToString()));
                    FlagSelectedRow = false;
                    PresentationLayerClass.OnlyReadSwitch(panel1, 1, true);
                    textBox2.ReadOnly = true;
                    PresentationLayerClass.EnableDisableButtons(new Button[] {
                    ButtonDelete, ButtonCreate,ButtonEdit }, true);
                    PresentationLayerClass.EnableDisableButtons(new Button[] {
                    ButtonSave, ButtonClear}, false);
                    dataGridView1.Enabled = true;
                    ButtonCancelEdit.Hide();
                }
            }
        }

        /// <summary>Handles the Click event of the ButtonClear control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ButtonClear_Click(object sender, EventArgs e)
        {
            PresentationLayerClass.ClearControls(panel1);
            textBox1.Focus();
        }

        /// <summary>Handles the Click event of the ButtonDelete control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Обраний запис видалится.", "Видалити?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (BusinessClass.DataDeleteGroupe(Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString())))
                    {
                        MessageBox.Show("Групу успішно видалено.");
                    }
                    else MessageBox.Show("Видалення неможливе. В групі є студенти.");
                }
                UpdateData(TableName);
                PresentationLayerClass.ClearBeforeCreate(panel1, dataGridView1);
                FlagSelectedRow = true;
            }
            catch
            {

            }
        }

        /// <summary>Handles the SelectionChanged event of the dataGridView1 control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            PresentationLayerClass.AddDataToTextBox(panel1, TableName, Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString()));
            FlagSelectedRow = false;
        }

        /// <summary>Handles the Click event of the ButtonEdit control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (!FlagSelectedRow)
            {
                PresentationLayerClass.EnableDisableButtons(new Button[] {
                    ButtonSave, ButtonDelete, ButtonClear }, true);
                PresentationLayerClass.EnableDisableButtons(new Button[] {
                    ButtonDelete, ButtonCreate, ButtonEdit }, false);
                PresentationLayerClass.OnlyReadSwitch(panel1, 1, false);
                textBox2.ReadOnly = true;
                ButtonCancelEdit.Visible = true;
            }
        }

        /// <summary>Handles the Click event of the ButtonCancelEdit control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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
            textBox2.ReadOnly = true;
        }
    }
}