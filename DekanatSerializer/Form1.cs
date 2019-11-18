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
    public partial class Form1 : Form
    {
        TabStudents TabStudentControl;
        TabGropes TabGroupeControl;
        TabRoomes TabRoomControl;
        TabHostels TabHostelControl;
               
        private enum For { Student,Groupe,Room,Hostel}
        public Form1()
        {
            InitializeComponent();
            OnLoad();
        }

        private void OnLoad()
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(TabStudentControl = new TabStudents());
        }
    
        private void PictureBoxExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonStudents_Click(object sender, EventArgs e)
        {
            TabStudentControl = new TabStudents();
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(TabStudentControl);
            ClearFlow(For.Student);
        }

        private void ButtonGroupes_Click(object sender, EventArgs e)
        {
            TabGroupeControl = new TabGropes();
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(TabGroupeControl);
            ClearFlow(For.Groupe);
        }

        private void ButtonRoomes_Click(object sender, EventArgs e)
        {
            TabRoomControl = new TabRoomes();
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(TabRoomControl);
            ClearFlow(For.Room);
        }

        private void ButtonHostel_Click(object sender, EventArgs e)
        {
            TabHostelControl = new TabHostels();
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(TabHostelControl);
            ClearFlow(For.Hostel);
        }

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

        private void pictureBoxMini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
