namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgv_student = new System.Windows.Forms.DataGridView();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.cb_dept = new System.Windows.Forms.ComboBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.label_id = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_address = new System.Windows.Forms.Label();
            this.label_age = new System.Windows.Forms.Label();
            this.label_dept = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_student)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_student
            // 
            this.dgv_student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_student.Location = new System.Drawing.Point(1, 252);
            this.dgv_student.Name = "dgv_student";
            this.dgv_student.RowTemplate.Height = 25;
            this.dgv_student.Size = new System.Drawing.Size(800, 198);
            this.dgv_student.TabIndex = 0;
            this.dgv_student.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_student_RowHeaderMouseDoubleClick);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(22, 67);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(100, 23);
            this.txt_search.TabIndex = 1;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Silver;
            this.btn_search.Location = new System.Drawing.Point(159, 67);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // cb_dept
            // 
            this.cb_dept.FormattingEnabled = true;
            this.cb_dept.Location = new System.Drawing.Point(606, 128);
            this.cb_dept.Name = "cb_dept";
            this.cb_dept.Size = new System.Drawing.Size(100, 23);
            this.cb_dept.TabIndex = 3;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(606, 12);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 23);
            this.txt_id.TabIndex = 4;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(606, 41);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 23);
            this.txt_name.TabIndex = 5;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(606, 70);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(100, 23);
            this.txt_address.TabIndex = 6;
            // 
            // txt_age
            // 
            this.txt_age.Location = new System.Drawing.Point(606, 99);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(100, 23);
            this.txt_age.TabIndex = 7;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Silver;
            this.btn_add.Location = new System.Drawing.Point(704, 211);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Silver;
            this.btn_delete.Location = new System.Drawing.Point(512, 211);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Silver;
            this.btn_update.Location = new System.Drawing.Point(606, 211);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 10;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.BackColor = System.Drawing.Color.Silver;
            this.label_id.Location = new System.Drawing.Point(517, 15);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(17, 15);
            this.label_id.TabIndex = 11;
            this.label_id.Text = "Id";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.BackColor = System.Drawing.Color.Silver;
            this.label_name.Location = new System.Drawing.Point(517, 44);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(39, 15);
            this.label_name.TabIndex = 12;
            this.label_name.Text = "Name";
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.BackColor = System.Drawing.Color.Silver;
            this.label_address.Location = new System.Drawing.Point(517, 73);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(49, 15);
            this.label_address.TabIndex = 13;
            this.label_address.Text = "Address";
            // 
            // label_age
            // 
            this.label_age.AutoSize = true;
            this.label_age.BackColor = System.Drawing.Color.Silver;
            this.label_age.Location = new System.Drawing.Point(517, 102);
            this.label_age.Name = "label_age";
            this.label_age.Size = new System.Drawing.Size(28, 15);
            this.label_age.TabIndex = 14;
            this.label_age.Text = "Age";
            // 
            // label_dept
            // 
            this.label_dept.AutoSize = true;
            this.label_dept.BackColor = System.Drawing.Color.Silver;
            this.label_dept.Location = new System.Drawing.Point(517, 131);
            this.label_dept.Name = "label_dept";
            this.label_dept.Size = new System.Drawing.Size(70, 15);
            this.label_dept.TabIndex = 15;
            this.label_dept.Text = "Department";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(750, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 15);
            this.label6.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_dept);
            this.Controls.Add(this.label_age);
            this.Controls.Add(this.label_address);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.cb_dept);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.dgv_student);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_student)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv_student;
        private TextBox txt_search;
        private Button btn_search;
        private ComboBox cb_dept;
        private TextBox txt_id;
        private TextBox txt_name;
        private TextBox txt_address;
        private TextBox txt_age;
        private Button btn_add;
        private Button btn_delete;
        private Button btn_update;
        private Label label_id;
        private Label label_name;
        private Label label_address;
        private Label label_age;
        private Label label_dept;
        private Label label6;
    }
}