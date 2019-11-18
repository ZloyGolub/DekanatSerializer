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
            this.components = new System.ComponentModel.Container();
            this.ButtonRoom = new System.Windows.Forms.Button();
            this.buttonGroupes = new System.Windows.Forms.Button();
            this.buttonStudents = new System.Windows.Forms.Button();
            this.panelOnTop = new System.Windows.Forms.Panel();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.pictureBoxMini = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonHostel = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelOnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMini)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonRoom
            // 
            this.ButtonRoom.Location = new System.Drawing.Point(3, 96);
            this.ButtonRoom.Name = "ButtonRoom";
            this.ButtonRoom.Size = new System.Drawing.Size(161, 39);
            this.ButtonRoom.TabIndex = 44;
            this.ButtonRoom.Text = "Кімнати";
            this.ButtonRoom.UseVisualStyleBackColor = true;
            this.ButtonRoom.Click += new System.EventHandler(this.ButtonRoomes_Click);
            // 
            // buttonGroupes
            // 
            this.buttonGroupes.Location = new System.Drawing.Point(3, 51);
            this.buttonGroupes.Name = "buttonGroupes";
            this.buttonGroupes.Size = new System.Drawing.Size(161, 39);
            this.buttonGroupes.TabIndex = 43;
            this.buttonGroupes.Text = "Групи";
            this.buttonGroupes.UseVisualStyleBackColor = true;
            this.buttonGroupes.Click += new System.EventHandler(this.ButtonGroupes_Click);
            // 
            // buttonStudents
            // 
            this.buttonStudents.Location = new System.Drawing.Point(3, 6);
            this.buttonStudents.Name = "buttonStudents";
            this.buttonStudents.Size = new System.Drawing.Size(161, 39);
            this.buttonStudents.TabIndex = 42;
            this.buttonStudents.Text = "Студенти";
            this.buttonStudents.UseVisualStyleBackColor = true;
            this.buttonStudents.Click += new System.EventHandler(this.ButtonStudents_Click);
            // 
            // panelOnTop
            // 
            this.panelOnTop.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelOnTop.Controls.Add(this.pictureBoxExit);
            this.panelOnTop.Controls.Add(this.pictureBoxMini);
            this.panelOnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOnTop.Location = new System.Drawing.Point(0, 0);
            this.panelOnTop.Name = "panelOnTop";
            this.panelOnTop.Size = new System.Drawing.Size(1079, 50);
            this.panelOnTop.TabIndex = 45;
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.BackgroundImage = global::DekanatSerializer.Properties.Resources.power_button;
            this.pictureBoxExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxExit.Location = new System.Drawing.Point(1040, 9);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(33, 32);
            this.pictureBoxExit.TabIndex = 39;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.PictureBoxExit_Click);
            // 
            // pictureBoxMini
            // 
            this.pictureBoxMini.BackgroundImage = global::DekanatSerializer.Properties.Resources.minimize;
            this.pictureBoxMini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxMini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMini.Location = new System.Drawing.Point(1001, 9);
            this.pictureBoxMini.Name = "pictureBoxMini";
            this.pictureBoxMini.Size = new System.Drawing.Size(33, 32);
            this.pictureBoxMini.TabIndex = 38;
            this.pictureBoxMini.TabStop = false;
            this.pictureBoxMini.Click += new System.EventHandler(this.pictureBoxMini_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.ButtonHostel);
            this.panel1.Controls.Add(this.buttonStudents);
            this.panel1.Controls.Add(this.buttonGroupes);
            this.panel1.Controls.Add(this.ButtonRoom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 504);
            this.panel1.TabIndex = 46;
            // 
            // ButtonHostel
            // 
            this.ButtonHostel.Location = new System.Drawing.Point(4, 141);
            this.ButtonHostel.Name = "ButtonHostel";
            this.ButtonHostel.Size = new System.Drawing.Size(161, 39);
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(170, 51);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(900, 495);
            this.flowLayoutPanel1.TabIndex = 47;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelOnTop;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 554);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelOnTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelOnTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMini)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonRoom;
        private System.Windows.Forms.Button buttonGroupes;
        private System.Windows.Forms.Button buttonStudents;
        private System.Windows.Forms.Panel panelOnTop;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.PictureBox pictureBoxMini;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button ButtonHostel;
    }
}

