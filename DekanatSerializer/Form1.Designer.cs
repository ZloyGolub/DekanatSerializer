namespace DekanatSerializer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonRoom = new System.Windows.Forms.Button();
            this.buttonGroupes = new System.Windows.Forms.Button();
            this.buttonStudents = new System.Windows.Forms.Button();
            this.panelOnTop = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonHostel = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonRoom
            // 
            this.ButtonRoom.Location = new System.Drawing.Point(4, 118);
            this.ButtonRoom.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonRoom.Name = "ButtonRoom";
            this.ButtonRoom.Size = new System.Drawing.Size(215, 48);
            this.ButtonRoom.TabIndex = 44;
            this.ButtonRoom.Text = "Кімнати";
            this.ButtonRoom.UseVisualStyleBackColor = true;
            this.ButtonRoom.Click += new System.EventHandler(this.ButtonRoomes_Click);
            // 
            // buttonGroupes
            // 
            this.buttonGroupes.Location = new System.Drawing.Point(4, 63);
            this.buttonGroupes.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGroupes.Name = "buttonGroupes";
            this.buttonGroupes.Size = new System.Drawing.Size(215, 48);
            this.buttonGroupes.TabIndex = 43;
            this.buttonGroupes.Text = "Групи";
            this.buttonGroupes.UseVisualStyleBackColor = true;
            this.buttonGroupes.Click += new System.EventHandler(this.ButtonGroupes_Click);
            // 
            // buttonStudents
            // 
            this.buttonStudents.Location = new System.Drawing.Point(4, 7);
            this.buttonStudents.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStudents.Name = "buttonStudents";
            this.buttonStudents.Size = new System.Drawing.Size(215, 48);
            this.buttonStudents.TabIndex = 42;
            this.buttonStudents.Text = "Студенти";
            this.buttonStudents.UseVisualStyleBackColor = true;
            this.buttonStudents.Click += new System.EventHandler(this.ButtonStudents_Click);
            // 
            // panelOnTop
            // 
            this.panelOnTop.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelOnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOnTop.Location = new System.Drawing.Point(0, 0);
            this.panelOnTop.Margin = new System.Windows.Forms.Padding(4);
            this.panelOnTop.Name = "panelOnTop";
            this.panelOnTop.Size = new System.Drawing.Size(1439, 62);
            this.panelOnTop.TabIndex = 45;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.ButtonHostel);
            this.panel1.Controls.Add(this.buttonStudents);
            this.panel1.Controls.Add(this.buttonGroupes);
            this.panel1.Controls.Add(this.ButtonRoom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 62);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 620);
            this.panel1.TabIndex = 46;
            // 
            // ButtonHostel
            // 
            this.ButtonHostel.Location = new System.Drawing.Point(5, 174);
            this.ButtonHostel.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonHostel.Name = "ButtonHostel";
            this.ButtonHostel.Size = new System.Drawing.Size(215, 48);
            this.ButtonHostel.TabIndex = 45;
            this.ButtonHostel.Text = "Гуртожиток";
            this.ButtonHostel.UseVisualStyleBackColor = true;
            this.ButtonHostel.Click += new System.EventHandler(this.ButtonHostel_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(227, 63);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1200, 609);
            this.flowLayoutPanel1.TabIndex = 47;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1439, 682);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelOnTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonRoom;
        private System.Windows.Forms.Button buttonGroupes;
        private System.Windows.Forms.Button buttonStudents;
        private System.Windows.Forms.Panel panelOnTop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button ButtonHostel;
    }
}

