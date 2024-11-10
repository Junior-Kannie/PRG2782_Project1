namespace Project1
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
            dvgStudents = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtStudentID = new TextBox();
            txtName = new TextBox();
            txtAge = new TextBox();
            txtCourse = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dvgStudents).BeginInit();
            SuspendLayout();
            // 
            // dvgStudents
            // 
            dvgStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgStudents.Location = new Point(278, 3);
            dvgStudents.Name = "dvgStudents";
            dvgStudents.RowHeadersWidth = 51;
            dvgStudents.RowTemplate.Height = 29;
            dvgStudents.Size = new Size(510, 241);
            dvgStudents.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 21);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 1;
            label1.Text = "Add New Student";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 57);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 2;
            label2.Text = "StudentID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 92);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 3;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 131);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 4;
            label4.Text = "Age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 166);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 5;
            label5.Text = "Course";
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(129, 54);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(125, 27);
            txtStudentID.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.Location = new Point(129, 89);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 7;
            //txtName.TextChanged += textBox2_TextChanged;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(129, 128);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(125, 27);
            txtAge.TabIndex = 8;
            //txtAge.TextChanged += textBox3_TextChanged;
            // 
            // txtCourse
            // 
            txtCourse.FormattingEnabled = true;
            txtCourse.Location = new Point(129, 163);
            txtCourse.Name = "txtCourse";
            txtCourse.Size = new Size(125, 28);
            txtCourse.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(24, 215);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            // button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(278, 268);
            button2.Name = "button2";
            button2.Size = new Size(130, 29);
            button2.TabIndex = 11;
            button2.Text = "View Students";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(471, 268);
            button3.Name = "button3";
            button3.Size = new Size(127, 29);
            button3.TabIndex = 12;
            button3.Text = "Update Student";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(661, 268);
            button4.Name = "button4";
            button4.Size = new Size(127, 29);
            button4.TabIndex = 13;
            button4.Text = "Delete Student";
            button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtCourse);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Controls.Add(txtStudentID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dvgStudents);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dvgStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dvgStudents;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtStudentID;
        private TextBox txtName;
        private TextBox txtAge;
        private ComboBox txtCourse;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
