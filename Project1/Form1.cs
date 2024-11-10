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
        //Defines the file path where we want to save the information
        //private string fileName = "students.txt";
        //public string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        //private string filePath = Path.Combine(folderPath, fileName);

        private string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "students.txt");

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

        public void button1_Click(object sender, EventArgs e)
        {
            //Gets the values from the text boxes
            string studentID = txtStudentID.Text;
            string name = txtName.Text;
            int age = Convert.ToInt32(txtAge.Text);
            string course = txtCourse.Text;

            //Displays the entered details in a message box temporarily
            MessageBox.Show($"Student ID: {studentID}\nName: {name}\nAge: {age}\nCourse: {course}", "Student Details");

            //Use StreamWriter to write data to a text file
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true)) // true for the current data
                {
                    writer.WriteLine($"{studentID},{name},{age},{course}");
                }
                MessageBox.Show("Information saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        public void DeleteStudents(string studentId)
        {
            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath).ToList();
                int initialCount = lines.Count;

                // Attempt to remove the specified line
                lines.RemoveAll(line => line.StartsWith(studentId + ","));

                if (lines.Count < initialCount) // Check if any lines were removed
                {
                    File.WriteAllLines(filePath, lines);
                    MessageBox.Show("Student record deleted successfully.");
                }
                else
                {
                    MessageBox.Show("No matching student record found to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("students.txt file not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dvgStudents.SelectedRows.Count > 0)
            {
                string studentId = dvgStudents.SelectedRows[0].Cells[0].Value.ToString();

                // Confirm deletion
                DialogResult result = MessageBox.Show("Are you sure you want to delete this student record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DeleteStudents(studentId);
                    LoadStudents(); // Reload DataGridView to reflect changes
                }
            }
            else
            {
                MessageBox.Show("Please select a student to delete.");
            }
        }
    }
}
