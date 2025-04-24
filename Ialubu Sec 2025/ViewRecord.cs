using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data.SqlClient;

namespace Ialubu_Sec_2025
{
    public partial class ViewRecord : Form
    {
        public ViewRecord()
        {
            InitializeComponent();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Integrated Security=True";
            DatabaseHelper db = new DatabaseHelper(connectionString);

            // Fetch all student data
            DataTable studentsTable = db.GetAllStudents();

            if (studentsTable != null && studentsTable.Rows.Count > 0)
            {
                // Bind the DataTable to the DataGridView
                studentGridView.DataSource = studentsTable;

                // Ensure the 'Id' column is visible in the DataGridView
                studentGridView.Columns["Id"].Visible = true;  // Make sure 'Id' column is visible
                studentGridView.Columns["Id"].HeaderText = "Student ID";  // Optional: Rename the 'Id' column header

                // Optionally, you can set other properties like column width
                studentGridView.Columns["Id"].Width = 80;  // Set width of the 'Id' column

                // Adjust other columns if needed, for example:
                studentGridView.Columns["Name"].HeaderText = "Student Name"; // Rename 'Name' column header
                studentGridView.Columns["Grade"].HeaderText = "Grade";  // Rename 'Grade' column header
                studentGridView.Columns["Subject"].HeaderText = "Subject";  // Rename 'Subject' column header
                studentGridView.Columns["Marks"].HeaderText = "Marks";  // Rename 'Marks' column header

                // Optional: Hide columns that are not needed (if any)
                // For example, if you want to hide a column:
                // studentGridView.Columns["SomeOtherColumn"].Visible = false;
            }
            else
            {
                MessageBox.Show("Failed to load student data.");
            }
        }

        private void PdfButton_Click(object sender, EventArgs e)
        {
            // Create the FolderBrowserDialog to prompt the user to select a folder
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Select the folder to save the PDF file";
                folderDialog.RootFolder = Environment.SpecialFolder.MyComputer;

                // Show the dialog and check if the user selected a folder
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected folder path
                    string selectedFolderPath = folderDialog.SelectedPath;

                    // Check if the user didn't cancel and selected a valid path
                    if (!string.IsNullOrEmpty(selectedFolderPath))
                    {
                        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Integrated Security=True;";
                        DatabaseHelper db = new DatabaseHelper(connectionString);

                        // Fetch all student data
                        DataTable studentsTable = db.GetAllStudents();

                        if (studentsTable != null && studentsTable.Rows.Count > 0)
                        {
                            // Create the PDF document
                            Document document = new Document(PageSize.A4);

                            // Construct the file path using the selected folder path
                            string filePath = System.IO.Path.Combine(selectedFolderPath, "StudentRecords.pdf");

                            // Create a FileStream to write the PDF
                            PdfWriter.GetInstance(document, new System.IO.FileStream(filePath, System.IO.FileMode.Create));

                            // Open the document to start writing content
                            document.Open();

                            // Add a title to the PDF using iTextSharp's Font class
                            iTextSharp.text.Font titleFont = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA_BOLD, 18);
                            Paragraph title = new Paragraph("Student Records", titleFont);
                            title.Alignment = Element.ALIGN_CENTER;
                            document.Add(title);

                            // Add space
                            document.Add(new Paragraph("\n"));

                            // Create a table with the number of columns that correspond to your data
                            PdfPTable table = new PdfPTable(5); // 5 columns: ID, Name, Grade, Subject, Marks

                            // Set column widths (optional, but makes the table look nicer)
                            table.SetWidths(new float[] { 1f, 3f, 1f, 2f, 2f });

                            // Add table headers
                            table.AddCell("ID");        // Added ID column
                            table.AddCell("Name");
                            table.AddCell("Grade");
                            table.AddCell("Subject");
                            table.AddCell("Marks");

                            // Loop through the DataTable and add each student record to the table
                            foreach (DataRow row in studentsTable.Rows)
                            {
                                table.AddCell(row["Id"].ToString());    // Add ID (Primary Key)
                                table.AddCell(row["Name"].ToString());
                                table.AddCell(row["Grade"].ToString());
                                table.AddCell(row["Subject"].ToString());
                                table.AddCell(row["Marks"].ToString());
                            }

                            // Add the table to the document
                            document.Add(table);

                            // Close the document to save the PDF
                            document.Close();

                            // Inform the user
                            MessageBox.Show("PDF generated successfully! You can find it at: " + filePath);
                        }
                        else
                        {
                            MessageBox.Show("Failed to load student data.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No folder selected. PDF generation canceled.");
                    }
                }
            }
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            // Check if any row is selected in the DataGridView
            if (studentGridView.SelectedRows.Count > 0)
            {
                // Get the student ID and name from the selected row
                int selectedId = Convert.ToInt32(studentGridView.SelectedRows[0].Cells["Id"].Value);
                string selectedName = studentGridView.SelectedRows[0].Cells["Name"].Value.ToString();

                // Ask for confirmation before deleting the student
                DialogResult result = MessageBox.Show($"Are you sure you want to delete the student {selectedName}?", "Delete Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Integrated Security=True;";
                    DatabaseHelper db = new DatabaseHelper(connectionString);

                    try
                    {
                        // Call the method to delete the student by ID
                        bool success = db.DeleteStudentById(selectedId); // Make sure this method exists in DatabaseHelper

                        if (success)
                        {
                            // Remove the selected row from the DataGridView
                            studentGridView.Rows.RemoveAt(studentGridView.SelectedRows[0].Index);
                            MessageBox.Show("Student deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete the student.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting student: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a student to delete.");
            }
        }

        private void studentGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Make sure it's not the header row
            {
                DataGridViewRow row = studentGridView.Rows[e.RowIndex];

                // Set the values to the corresponding TextBoxes
                NameTB.Text = row.Cells["Name"].Value.ToString();
                GradeTB.Text = row.Cells["Grade"].Value.ToString();
                SubjectTB.Text = row.Cells["Subject"].Value.ToString();
                MarksTB.Text = row.Cells["Marks"].Value.ToString();

                // Store the ID in a hidden field or Tag property for later update
                UpdateBTN.Tag = row.Cells["Id"].Value;
            }
        }

        private void UpdateBTN_Click(object sender, EventArgs e)
        {
            if (UpdateBTN.Tag == null)
            {
                MessageBox.Show("Please select a record to update.");
                return;
            }

            int studentId = Convert.ToInt32(UpdateBTN.Tag);
            string name = NameTB.Text.Trim();
            string subject = SubjectTB.Text.Trim();
            string marks = MarksTB.Text.Trim();

            // Convert grade to int safely
            if (!int.TryParse(GradeTB.Text, out int grade))
            {
                MessageBox.Show("Please enter a valid grade number.");
                return;
            }

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Integrated Security=True";
            DatabaseHelper db = new DatabaseHelper(connectionString);

            bool success = db.UpdateStudent(studentId, name, grade, subject, marks);

            if (success)
            {
                MessageBox.Show("Student record updated successfully.");
                viewButton.PerformClick(); // Refresh the grid view
            }
            else
            {
                MessageBox.Show("Failed to update student record.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.Show();
        }
    }
}