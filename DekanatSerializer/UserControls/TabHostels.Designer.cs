namespace DekanatSerializer
{
    partial class TabHostels
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.ButtonCancelEdit = new System.Windows.Forms.Button();
            this.ButtonCreate = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.TextBoxID = new System.Windows.Forms.TextBox();
            this.TextBoxDescription = new System.Windows.Forms.TextBox();
            this.TextBoxRoomsCount = new System.Windows.Forms.TextBox();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ButtonEdit);
            this.panel1.Controls.Add(this.ButtonCancelEdit);
            this.panel1.Controls.Add(this.ButtonCreate);
            this.panel1.Controls.Add(this.ButtonDelete);
            this.panel1.Controls.Add(this.ButtonClear);
            this.panel1.Controls.Add(this.ButtonSave);
            this.panel1.Controls.Add(this.TextBoxID);
            this.panel1.Controls.Add(this.TextBoxDescription);
            this.panel1.Controls.Add(this.TextBoxRoomsCount);
            this.panel1.Controls.Add(this.TextBoxName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 97);
            this.panel1.TabIndex = 0;
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Location = new System.Drawing.Point(735, 64);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(75, 23);
            this.ButtonEdit.TabIndex = 118;
            this.ButtonEdit.Text = "Редагувати";
            this.ButtonEdit.UseVisualStyleBackColor = true;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // ButtonCancelEdit
            // 
            this.ButtonCancelEdit.Location = new System.Drawing.Point(735, 35);
            this.ButtonCancelEdit.Name = "ButtonCancelEdit";
            this.ButtonCancelEdit.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancelEdit.TabIndex = 119;
            this.ButtonCancelEdit.Text = "Відмінити";
            this.ButtonCancelEdit.UseVisualStyleBackColor = true;
            this.ButtonCancelEdit.Visible = false;
            this.ButtonCancelEdit.Click += new System.EventHandler(this.ButtonCancelEdit_Click);
            // 
            // ButtonCreate
            // 
            this.ButtonCreate.Location = new System.Drawing.Point(816, 6);
            this.ButtonCreate.Name = "ButtonCreate";
            this.ButtonCreate.Size = new System.Drawing.Size(75, 23);
            this.ButtonCreate.TabIndex = 117;
            this.ButtonCreate.Text = "Створити";
            this.ButtonCreate.UseVisualStyleBackColor = true;
            this.ButtonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(816, 64);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(75, 23);
            this.ButtonDelete.TabIndex = 116;
            this.ButtonDelete.Text = "Видалити";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonClear
            // 
            this.ButtonClear.Location = new System.Drawing.Point(735, 6);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(75, 23);
            this.ButtonClear.TabIndex = 115;
            this.ButtonClear.Text = "Очистити";
            this.ButtonClear.UseVisualStyleBackColor = true;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(816, 35);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(75, 23);
            this.ButtonSave.TabIndex = 114;
            this.ButtonSave.Text = "Зберегти";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // TextBoxID
            // 
            this.TextBoxID.Location = new System.Drawing.Point(53, 54);
            this.TextBoxID.Name = "TextBoxID";
            this.TextBoxID.ReadOnly = true;
            this.TextBoxID.Size = new System.Drawing.Size(38, 20);
            this.TextBoxID.TabIndex = 1;
            this.TextBoxID.Visible = false;
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.Location = new System.Drawing.Point(131, 29);
            this.TextBoxDescription.Multiline = true;
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.Size = new System.Drawing.Size(328, 55);
            this.TextBoxDescription.TabIndex = 4;
            // 
            // TextBoxRoomsCount
            // 
            this.TextBoxRoomsCount.Location = new System.Drawing.Point(387, 3);
            this.TextBoxRoomsCount.Name = "TextBoxRoomsCount";
            this.TextBoxRoomsCount.ReadOnly = true;
            this.TextBoxRoomsCount.Size = new System.Drawing.Size(72, 20);
            this.TextBoxRoomsCount.TabIndex = 3;
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(131, 3);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(155, 20);
            this.TextBoxName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Опис";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Кількість кімнат";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Найменування корпус";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            this.label1.Visible = false;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(3, 106);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 60;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dataGridView1.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(894, 386);
            this.dataGridView1.TabIndex = 104;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // TabHostels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "TabHostels";
            this.Size = new System.Drawing.Size(900, 495);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxID;
        private System.Windows.Forms.TextBox TextBoxDescription;
        private System.Windows.Forms.TextBox TextBoxRoomsCount;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Button ButtonCancelEdit;
        private System.Windows.Forms.Button ButtonCreate;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
