using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DekanatSerializer
{
    public partial class DialogSelectGroupe : Form
    {
        public DialogSelectGroupe()
        {
            InitializeComponent();
            UpdateData(BusinessClass.For.Groupe);
        }

        public string Result { get; private set; }

        private void UpdateData(BusinessClass.For @for)
        {
            dataGridView1.DataSource = BusinessClass.DataOutPut(@for);
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            Result = Convert.ToString(dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString());
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
