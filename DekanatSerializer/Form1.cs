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
    /// <summary>
    /// Main form
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Form1 : Form
    {
        TabStudents TabStudentControl;
        TabGropes TabGroupeControl;
        TabRoomes TabRoomControl;
        TabHostels TabHostelControl;

        private enum For { Student,Groupe,Room,Hostel}
        /// <summary>Initializes a new instance of the <see cref="Form1"/> class.</summary>
        public Form1()
        {
            InitializeComponent();
            OnLoad();
        }

        /// <summary>Called when [load].</summary>
        private void OnLoad()
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(TabStudentControl = new TabStudents());
        }

        /// <summary>Handles the Click event of the PictureBoxExit control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void PictureBoxExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>Handles the Click event of the ButtonStudents control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ButtonStudents_Click(object sender, EventArgs e)
        {
            TabStudentControl = new TabStudents();
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(TabStudentControl);
            ClearFlow(For.Student);
        }

        /// <summary>Handles the Click event of the ButtonGroupes control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ButtonGroupes_Click(object sender, EventArgs e)
        {
            TabGroupeControl = new TabGropes();
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(TabGroupeControl);
            ClearFlow(For.Groupe);
        }

        /// <summary>Handles the Click event of the ButtonRoomes control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ButtonRoomes_Click(object sender, EventArgs e)
        {
            TabRoomControl = new TabRoomes();
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(TabRoomControl);
            ClearFlow(For.Room);
        }

        /// <summary>Handles the Click event of the ButtonHostel control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ButtonHostel_Click(object sender, EventArgs e)
        {
            TabHostelControl = new TabHostels();
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(TabHostelControl);
            ClearFlow(For.Hostel);
        }

        /// <summary>Clears the flow.</summary>
        /// <param name="for">For.</param>
        private void ClearFlow(For @for)
        {
            switch (@for)
            {
                case (For.Student):
                    {
                        if (TabGroupeControl != null) TabGroupeControl.Dispose();
                        if (TabRoomControl != null) TabRoomControl.Dispose();
                        if (TabHostelControl != null) TabHostelControl.Dispose();
                        break;
                    }
                case (For.Groupe):
                    {
                        if (TabStudentControl != null) TabStudentControl.Dispose();
                        if (TabRoomControl != null) TabRoomControl.Dispose();
                        if (TabHostelControl != null) TabHostelControl.Dispose();
                        break;
                    }
                case (For.Room):
                    {
                        if (TabGroupeControl != null) TabGroupeControl.Dispose();
                        if (TabStudentControl != null) TabStudentControl.Dispose();
                        if (TabHostelControl != null) TabHostelControl.Dispose();
                        break;
                    }
                case (For.Hostel):
                    {
                        if (TabGroupeControl != null) TabGroupeControl.Dispose();
                        if (TabStudentControl != null) TabStudentControl.Dispose();
                        if (TabRoomControl != null) TabRoomControl.Dispose();
                        break;
                    }
            }
        }

        /// <summary>Handles the Click event of the pictureBoxMini control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void pictureBoxMini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
