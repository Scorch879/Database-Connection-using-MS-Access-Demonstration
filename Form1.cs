using System.Data;
using System.Data.OleDb;

namespace Week8Activity
{
    public partial class Form1 : Form
    {
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow;

        public Form1()
        {
            InitializeComponent();
        }

        private void loadDatabtn_Click(object sender, EventArgs e)
        {
            try
            {
                myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Master Kermit\\Downloads\\Week8Assignment.accdb");
                da = new OleDbDataAdapter("SELECT StudentTable.StudentId, StudentTable.LastName, StudentTable.FirstName, StudentTable.Course, StudentTable.YearLevel, SubjectsEnrolledTable.CourseNum1, SubjectsEnrolledTable.CourseNum2, FinalGradeTable.FG1, FinalGradeTable.FG2 FROM(StudentTable INNER JOIN SubjectsEnrolledTable ON StudentTable.StudentId = SubjectsEnrolledTable.StudentId) INNER JOIN FinalGradeTable ON SubjectsEnrolledTable.StudentId = FinalGradeTable.StudentId; ", myConn);
                ds = new DataSet();
                myConn.Open();
                da.Fill(ds, "Query1");
                dgvTable.DataSource = ds.Tables["Query1"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error caught: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            myConn.Close();
        }
        private void testConnection_Click(object sender, EventArgs e)
        {
            try
            {
                myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Master Kermit\\Downloads\\Week8Assignment.accdb");
                ds = new DataSet();
                myConn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error caught: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            myConn.Close();
            MessageBox.Show("Connected Sucessfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGrid_Click(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dgvTable.Rows[indexRow];
            studentIDtbx.Text = row.Cells[0].Value.ToString();
            lastNametbx.Text = row.Cells[1].Value.ToString();
            firstNametbx.Text = row.Cells[2].Value.ToString();
            courseTbx.Text = row.Cells[3].Value.ToString();
            yrTbx.Text = row.Cells[4].Value.ToString();
            courseNum1Tbx.Text = row.Cells[5].Value.ToString();
            courseNum2Tbx.Text = row.Cells[6].Value.ToString();
            fg1Tbx.Text = row.Cells[7].Value.ToString();
            fg2Tbx.Text = row.Cells[8].Value.ToString();
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (myConn == null)
                {
                    MessageBox.Show("There is no loaded data yet", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (lastNametbx.Text == "" || firstNametbx.Text == "" || courseTbx.Text == "" ||
                       courseNum1Tbx.Text == "" || courseNum2Tbx.Text == "" || fg1Tbx.Text == "" ||
                       fg2Tbx.Text == "")
                {
                    MessageBox.Show("Empty inputs. Please fill all the necessary information.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    myConn.Close();
                    return;
                }

                myConn.Open();

                string lastName = lastNametbx.Text.Trim().ToLower();
                string firstName = firstNametbx.Text.Trim().ToLower();

                string checkQuery = "SELECT COUNT(*) FROM StudentQuery WHERE LCase(Trim(LastName)) = ? AND LCase(Trim(FirstName)) = ?";
                using (OleDbCommand checkCmd = new OleDbCommand(checkQuery, myConn))
                {
                    checkCmd.Parameters.AddWithValue("?", lastNametbx.Text);
                    checkCmd.Parameters.AddWithValue("?", firstNametbx.Text);

                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Duplicate entry! This student already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        myConn.Close();
                        return;
                    }
                }

                string query = "INSERT INTO StudentQuery (LastName, FirstName, Course, YearLevel, CourseNum1, CourseNum2, FG1, FG2) " +
                               "VALUES (?, ?, ?, ?, ?, ?, ?, ?)";

                using (OleDbCommand cmd = new OleDbCommand(query, myConn))
                {

                    cmd.Parameters.AddWithValue("?", lastNametbx.Text.ToUpper().Trim());
                    cmd.Parameters.AddWithValue("?", firstNametbx.Text.ToUpper().Trim());
                    cmd.Parameters.AddWithValue("?", courseTbx.Text.ToUpper().Trim());
                    cmd.Parameters.AddWithValue("?", int.Parse(yrTbx.Text));
                    cmd.Parameters.AddWithValue("?", courseNum1Tbx.Text.ToUpper().Trim());
                    cmd.Parameters.AddWithValue("?", courseNum2Tbx.Text.ToUpper().Trim());
                    cmd.Parameters.AddWithValue("?", fg1Tbx.Text.ToUpper().Trim());
                    cmd.Parameters.AddWithValue("?", fg2Tbx.Text.ToUpper().Trim());

                    cmd.ExecuteNonQuery();
                }

                myConn.Close();
                MessageBox.Show("Records inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                if (myConn == null)
                {
                    MessageBox.Show("There is no loaded data yet", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                myConn.Close();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            int rowsAffected = 0;
            try
            {
                if (myConn == null)
                {
                    MessageBox.Show("There is no loaded data yet", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (dgvTable.CurrentRow == null)
                {
                    MessageBox.Show("No record selected for updating!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (lastNametbx.Text == "" || firstNametbx.Text == "" || courseTbx.Text == "" ||
                       courseNum1Tbx.Text == "" || courseNum2Tbx.Text == "" || fg1Tbx.Text == "" ||
                       fg2Tbx.Text == "")
                {
                    MessageBox.Show("Empty inputs. Please fill all the necessary information.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    myConn.Close();
                    return;
                }

                myConn.Open();

                int studentId = Convert.ToInt32(dgvTable.CurrentRow.Cells[0].Value);
                string lastName = lastNametbx.Text.Trim().ToLower();
                string firstName = firstNametbx.Text.Trim().ToLower();

                // Check for duplicates (excluding the current student)
                string checkQuery = "SELECT COUNT(*) FROM StudentQuery WHERE LCase(Trim(LastName)) = ? AND LCase(Trim(FirstName)) = ? AND StudentId <> ?";
                using (OleDbCommand checkCmd = new OleDbCommand(checkQuery, myConn))
                {
                    checkCmd.Parameters.AddWithValue("?", lastName);
                    checkCmd.Parameters.AddWithValue("?", firstName);
                    checkCmd.Parameters.AddWithValue("?", studentId);

                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("This makes a duplicate entry! This student already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        myConn.Close();
                        return;
                    }
                }

                myConn.Close();
                myConn.Open();

                string query = "UPDATE StudentQuery SET LastName = ?, FirstName = ?, Course = ?, " +
                               "[YearLevel] = ?, CourseNum1 = ?, CourseNum2 = ?, FG1 = ?, FG2 = ? " +
                               "WHERE StudentId = ?";

                using (OleDbCommand cmd = new OleDbCommand(query, myConn))
                {

                    cmd.Parameters.AddWithValue("?", lastNametbx.Text.ToUpper().Trim());
                    cmd.Parameters.AddWithValue("?", firstNametbx.Text.ToUpper().Trim());
                    cmd.Parameters.AddWithValue("?", courseTbx.Text.ToUpper().Trim());

                    if (!int.TryParse(yrTbx.Text.Trim(), out int yearLevel))
                    {
                        MessageBox.Show("Invalid Year Level. Please enter a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        myConn.Close();
                        return;
                    }
                    cmd.Parameters.AddWithValue("?", yearLevel);

                    cmd.Parameters.AddWithValue("?", courseNum1Tbx.Text.ToUpper().Trim());
                    cmd.Parameters.AddWithValue("?", courseNum2Tbx.Text.ToUpper().Trim());
                    cmd.Parameters.AddWithValue("?", fg1Tbx.Text.ToUpper().Trim());
                    cmd.Parameters.AddWithValue("?", fg2Tbx.Text.ToUpper().Trim());
                    cmd.Parameters.AddWithValue("?", studentId);

                    rowsAffected = cmd.ExecuteNonQuery();
                }

                myConn.Close();

                if (rowsAffected > 0)
                    MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No record found with the given ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input format. Please check your data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                if (myConn.State == ConnectionState.Open)
                    myConn.Close();
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (myConn == null)
                {
                    MessageBox.Show("There is no loaded data yet", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (dgvTable.CurrentRow == null)
                {
                    MessageBox.Show("No record selected.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Form2 confirmForm = new Form2();
                if (confirmForm.ShowDialog() != DialogResult.Yes)
                {
                    return; // User canceled the deletion
                }

                int studentId = Convert.ToInt32(dgvTable.CurrentRow.Cells[0].Value);
                myConn.Open();

                using (OleDbCommand cmd = new OleDbCommand("DELETE FROM FinalGradeTable WHERE StudentId = @id", myConn))
                {
                    cmd.Parameters.AddWithValue("@id", studentId);
                    cmd.ExecuteNonQuery();
                }

                using (OleDbCommand cmd = new OleDbCommand("DELETE FROM SubjectsEnrolledTable WHERE StudentId = @id", myConn))
                {
                    cmd.Parameters.AddWithValue("@id", studentId);
                    cmd.ExecuteNonQuery();
                }

                using (OleDbCommand cmd = new OleDbCommand("DELETE FROM StudentTable WHERE StudentId = @id", myConn))
                {
                    cmd.Parameters.AddWithValue("@id", studentId);
                    cmd.ExecuteNonQuery();
                }

                myConn.Close();
                MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                if (myConn == null)
                {
                    MessageBox.Show("There is no loaded data yet", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (myConn.State == ConnectionState.Open)
                    myConn.Close();
                MessageBox.Show("Error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}