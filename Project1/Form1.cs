using System;
using System.IO;
using System.Windows.Forms;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;


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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        public Form1()
        {
          InitializeComponent();
        }

            private void btnSave_Click(object sender, EventArgs e)
            {
                // Gets the values from the text boxes
                string studentID = txtStudentID.Text;
                string name = txtName.Text;
                string age = txtAge.Text;
                string course = txtCourse.Text;

                // Displays the entered details in a message box temporarily
                MessageBox.Show($"Student ID: {studentID}\nName: {name}\nAge: {age}\nCourse: {course}", "Student Details");

        
            }

            // Define the file path where we want to save the information
            string filePath = @"C:\Users\User\source\repos\PRG2782_Project1\Project1\StudentsInfo\txt";

            // Use StreamWriter to write data to a text file
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true)) // true for appending data
                {
                    writer.WriteLine("StudentID: " + txtStudentID);
                    writer.WriteLine("Name: " + txtName);
                    writer.WriteLine("Age: " + txtAge);
                    writer.WriteLine("Course: " + txtCourse);
                    writer.WriteLine("---------------------------");
                }
                MessageBox.Show("Information saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
    

