using System;
using System.IO;
using System.Windows.Forms;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic.Devices;


namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ComboBoxAdd();
        }
        public void ComboBoxAdd()
        {
            txtCourse.Items.Add("Maths");
            txtCourse.Items.Add("Science");
            txtCourse.Items.Add("English");
            txtCourse.Items.Add("History");
            txtCourse.Items.Add("Geography");

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
            //Gets the values from the text boxes
            string studentID = txtStudentID.Text;
            string name = txtName.Text;
            string age = txtAge.Text;
            string course = txtCourse.Text;

            //Displays the entered details in a message box temporarily
            MessageBox.Show($"Student ID: {studentID}\nName: {name}\nAge: {age}\nCourse: {course}", "Student Details");

            //Defines the file path where we want to save the information
            string filePath = @"C:\Users\User\source\repos\PRG2782_Project1\Project1\StudentsInfo\StudentsInfo.txt";

            //Use StreamWriter to write data to a text file
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true)) // true for the current data
                {
                    writer.WriteLine($"{studentID}, {name}, {age}, {course}");
                }
                MessageBox.Show("Information saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void DeleteStudents(string studentId)
        {
            // Read all lines from students.txt into a list
            var lines = File.ReadAllLines("students.txt").ToList();

            // Remove the line that starts with the given Student ID
            lines.RemoveAll(line => line.StartsWith(studentId + ","));

            // Write the remaining lines back to students.txt
            File.WriteAllLines("students.txt", lines);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            {
                // Check if any row is selected in the DataGridView
                if (dvgStudents.SelectedRows.Count > 0)
                {
                    // Get the Student ID from the selected row's first cell
                    string studentId = dvgStudents.SelectedRows[0].Cells[0].Value.ToString();

                    // Call the DeleteStudent method with the selected Student ID
                    DeleteStudents(studentId);

                    // Reload the DataGridView to reflect the changes
                    LoadStudents();

                    // Optional: Show a message indicating successful deletion
                    MessageBox.Show("Student record deleted successfully.");
                }
                else
                {
                    // Inform the user to select a student if no row is selected
                    MessageBox.Show("Please select a student to delete.");
                }
            }

        }
    }
}
