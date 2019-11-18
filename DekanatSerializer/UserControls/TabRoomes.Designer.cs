namespace DekanatSerializer
{
    partial class TabRoomes
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxRoomNumber = new System.Windows.Forms.TextBox();
            this.TextBoxAllPlace = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxFreePlace = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxDescription = new System.Windows.Forms.TextBox();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonCreate = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TextBoxID = new System.Windows.Forms.TextBox();
            this.Labelid = new System.Windows.Forms.Label();
            this.TextBoxHostel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ButtonSelectHostel = new System.Windows.Forms.Button();
            this.ButtonCancelEdit = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 106;
            this.label1.Text = "Номер кімнати";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 107;
            this.label2.Text = "Місця в кімнаті";
            // 
            // TextBoxRoomNumber
            // 
            this.TextBoxRoomNumber.Location = new System.Drawing.Point(92, 120);
            this.TextBoxRoomNumber.Name = "TextBoxRoomNumber";
            this.TextBoxRoomNumber.Size = new System.Drawing.Size(75, 20);
            this.TextBoxRoomNumber.TabIndex = 3;
            // 
            // TextBoxAllPlace
            // 
            this.TextBoxAllPlace.Location = new System.Drawing.Point(92, 146);
            this.TextBoxAllPlace.Name = "TextBoxAllPlace";
            this.TextBoxAllPlace.Size = new System.Drawing.Size(75, 20);
            this.TextBoxAllPlace.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 110;
            this.label3.Text = "Вільні місця";
            // 
            // TextBoxFreePlace
            // 
            this.TextBoxFreePlace.Location = new System.Drawing.Point(240, 146);
            this.TextBoxFreePlace.Name = "TextBoxFreePlace";
            this.TextBoxFreePlace.ReadOnly = true;
            this.TextBoxFreePlace.Size = new System.Drawing.Size(75, 20);
            this.TextBoxFreePlace.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 112;
            this.label4.Text = "Опис";
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.Location = new System.Drawing.Point(45, 172);
            this.TextBoxDescription.Multiline = true;
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.Size = new System.Drawing.Size(270, 72);
            this.TextBoxDescription.TabIndex = 6;
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(3, 32);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(75, 23);
            this.ButtonSave.TabIndex = 114;
            this.ButtonSave.Text = "Зберегти";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonCreate
            // 
            this.ButtonCreate.Location = new System.Drawing.Point(3, 3);
            this.ButtonCreate.Name = "ButtonCreate";
            this.ButtonCreate.Size = new System.Drawing.Size(75, 23);
            this.ButtonCreate.TabIndex = 115;
            this.ButtonCreate.Text = "Створити";
            this.ButtonCreate.UseVisualStyleBackColor = true;
            this.ButtonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(3, 61);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(75, 23);
            this.ButtonDelete.TabIndex = 116;
            this.ButtonDelete.Text = "Видалити";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonClear
            // 
            this.ButtonClear.Location = new System.Drawing.Point(84, 3);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(75, 23);
            this.ButtonClear.TabIndex = 117;
            this.ButtonClear.Text = "Очистити";
            this.ButtonClear.UseVisualStyleBackColor = true;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ButtonCancelEdit);
            this.panel1.Controls.Add(this.ButtonEdit);
            this.panel1.Controls.Add(this.ButtonSelectHostel);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TextBoxHostel);
            this.panel1.Controls.Add(this.Labelid);
            this.panel1.Controls.Add(this.TextBoxID);
            this.panel1.Controls.Add(this.ButtonClear);
            this.panel1.Controls.Add(this.ButtonDelete);
            this.panel1.Controls.Add(this.ButtonCreate);
            this.panel1.Controls.Add(this.ButtonSave);
            this.panel1.Controls.Add(this.TextBoxDescription);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TextBoxFreePlace);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TextBoxAllPlace);
            this.panel1.Controls.Add(this.TextBoxRoomNumber);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 489);
            this.panel1.TabIndex = 118;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView1.Location = new System.Drawing.Point(330, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 60;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dataGridView1.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(567, 489);
            this.dataGridView1.TabIndex = 119;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // TextBoxID
            // 
            this.TextBoxID.Location = new System.Drawing.Point(201, 6);
            this.TextBoxID.Name = "TextBoxID";
            this.TextBoxID.ReadOnly = true;
            this.TextBoxID.Size = new System.Drawing.Size(100, 20);
            this.TextBoxID.TabIndex = 1;
            // 
            // Labelid
            // 
            this.Labelid.AutoSize = true;
            this.Labelid.Location = new System.Drawing.Point(177, 9);
            this.Labelid.Name = "Labelid";
            this.Labelid.Size = new System.Drawing.Size(18, 13);
            this.Labelid.TabIndex = 119;
            this.Labelid.Text = "ID";
            // 
            // TextBoxHostel
            // 
            this.TextBoxHostel.Location = new System.Drawing.Point(109, 94);
            this.TextBoxHostel.Name = "TextBoxHostel";
            this.TextBoxHostel.ReadOnly = true;
            this.TextBoxHostel.Size = new System.Drawing.Size(125, 20);
            this.TextBoxHostel.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 121;
            this.label5.Text = "Корпус гуртожитку";
            // 
            // ButtonSelectHostel
            // 
            this.ButtonSelectHostel.Location = new System.Drawing.Point(240, 92);
            this.ButtonSelectHostel.Name = "ButtonSelectHostel";
            this.ButtonSelectHostel.Size = new System.Drawing.Size(75, 23);
            this.ButtonSelectHostel.TabIndex = 122;
            this.ButtonSelectHostel.Text = "Обрати";
            this.ButtonSelectHostel.UseVisualStyleBackColor = true;
            this.ButtonSelectHostel.Click += new System.EventHandler(this.ButtonSelectHostel_Click);
            // 
            // ButtonCancelEdit
            // 
            this.ButtonCancelEdit.Location = new System.Drawing.Point(84, 32);
            this.ButtonCancelEdit.Name = "ButtonCancelEdit";
            this.ButtonCancelEdit.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancelEdit.TabIndex = 124;
            this.ButtonCancelEdit.Text = "Відмінити";
            this.ButtonCancelEdit.UseVisualStyleBackColor = true;
            this.ButtonCancelEdit.Visible = false;
            this.ButtonCancelEdit.Click += new System.EventHandler(this.ButtonCancelEdit_Click);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Location = new System.Drawing.Point(84, 62);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(75, 23);
            this.ButtonEdit.TabIndex = 123;
            this.ButtonEdit.Text = "Редагувати";
            this.ButtonEdit.UseVisualStyleBackColor = true;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // TabRoomes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "TabRoomes";
            this.Size = new System.Drawing.Size(900, 495);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxRoomNumber;
        private System.Windows.Forms.TextBox TextBoxAllPlace;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxFreePlace;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxDescription;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonCreate;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Labelid;
        private System.Windows.Forms.TextBox TextBoxID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBoxHostel;
        private System.Windows.Forms.Button ButtonSelectHostel;
        private System.Windows.Forms.Button ButtonCancelEdit;
        private System.Windows.Forms.Button ButtonEdit;
    }
}
