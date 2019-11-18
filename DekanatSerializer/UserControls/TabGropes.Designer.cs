namespace DekanatSerializer
{
    partial class TabGropes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonCreate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonCancelEdit = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 105;
            this.label1.Text = "Номер групи";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 106;
            this.label2.Text = "Студентів в групі";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 107;
            this.label3.Text = "Опис";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(79, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(104, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(79, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(229, 6);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(267, 72);
            this.textBox3.TabIndex = 4;
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(816, 35);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(75, 23);
            this.ButtonSave.TabIndex = 111;
            this.ButtonSave.Text = "Зберегти";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonCreate
            // 
            this.ButtonCreate.Location = new System.Drawing.Point(816, 4);
            this.ButtonCreate.Name = "ButtonCreate";
            this.ButtonCreate.Size = new System.Drawing.Size(75, 23);
            this.ButtonCreate.TabIndex = 112;
            this.ButtonCreate.Text = "Створити";
            this.ButtonCreate.UseVisualStyleBackColor = true;
            this.ButtonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ButtonCancelEdit);
            this.panel1.Controls.Add(this.ButtonEdit);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.ButtonClear);
            this.panel1.Controls.Add(this.ButtonDelete);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ButtonCreate);
            this.panel1.Controls.Add(this.ButtonSave);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 125);
            this.panel1.TabIndex = 113;
            // 
            // ButtonCancelEdit
            // 
            this.ButtonCancelEdit.Location = new System.Drawing.Point(735, 35);
            this.ButtonCancelEdit.Name = "ButtonCancelEdit";
            this.ButtonCancelEdit.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancelEdit.TabIndex = 118;
            this.ButtonCancelEdit.Text = "Відмінити";
            this.ButtonCancelEdit.UseVisualStyleBackColor = true;
            this.ButtonCancelEdit.Visible = false;
            this.ButtonCancelEdit.Click += new System.EventHandler(this.ButtonCancelEdit_Click);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Location = new System.Drawing.Point(735, 64);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(75, 23);
            this.ButtonEdit.TabIndex = 117;
            this.ButtonEdit.Text = "Редагувати";
            this.ButtonEdit.UseVisualStyleBackColor = true;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 116;
            this.label4.Text = "Id";
            this.label4.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(117, 58);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(66, 20);
            this.textBox4.TabIndex = 1;
            this.textBox4.Visible = false;
            // 
            // ButtonClear
            // 
            this.ButtonClear.Location = new System.Drawing.Point(735, 4);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(75, 23);
            this.ButtonClear.TabIndex = 114;
            this.ButtonClear.Text = "Очистити";
            this.ButtonClear.UseVisualStyleBackColor = true;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(816, 64);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(75, 23);
            this.ButtonDelete.TabIndex = 113;
            this.ButtonDelete.Text = "Видалити";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(3, 134);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 60;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dataGridView1.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(894, 358);
            this.dataGridView1.TabIndex = 114;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // TabGropes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "TabGropes";
            this.Size = new System.Drawing.Size(900, 495);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonCreate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Button ButtonCancelEdit;
    }
}
