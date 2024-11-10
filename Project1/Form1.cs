using System;
using System.IO;
using System.Windows.Forms;
using System.Data;


namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void LoadStudents()
        {
            string filePath = @"C:\Users\junio\Documents\students.txt";

            //Creates a DataTable to store student data
            DataTable students = new DataTable();
            students.Columns.Add("StudentID", typeof(string));
            students.Columns.Add("Name", typeof(string));
            students.Columns.Add("Age", typeof(int));
            students.Columns.Add("Course", typeof(string));

            //Checks if the file exists
            if (File.Exists(filePath))
            {
                foreach (string line in File.ReadAllLines(filePath))
                {
                    string[] parts = line.Split(',');

                    if (parts.Length == 4 && int.TryParse(parts[2], out int age))
                    {
                        students.Rows.Add(parts[0], parts[1], int.Parse(parts[2]), parts[3]);
                    }
                    else
                    {
                        MessageBox.Show($"Invalid data format in line: {line}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                dvgStudents.DataSource = students;
            }
            else
            {
                MessageBox.Show("students.txt file not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
    

