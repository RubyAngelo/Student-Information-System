using Spire.Xls;
using System.Data;
using System.Net;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Cryptography;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ARRAY
{
    public partial class Form1 : Form
    {
        Workbook book = new Workbook();
        Form2 form2 = new Form2();

        int i = 0;
        public Form1()
        {
            InitializeComponent();

        }

        public string checkEmpty()
        {
            string errors = "";
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    if (c.Text == "")
                    {
                        errors += c.Name + " is empty \n";
                    }
                }
            }
            return errors;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text.Trim();
                string dataG = "";
                string data1 = "";
                string Address = txtAddress.Text.Trim();
                string Email = txtEmail.Text.Trim();
                string favcolor = cmbColor.Text.Trim();
                string saying = txtSaying.Text.Trim();

                // Check if the name is empty
                if (string.IsNullOrEmpty(name))
                {
                    //MessageBox.Show("Name cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //return; // Exit the method
                }

                // Check if the name is a number
                if (int.TryParse(name, out _))
                {
                    //MessageBox.Show("Name cannot be a number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //return; // Exit the method
                }

                // Collect gender
                if (radFemale.Checked)
                {
                    dataG += radFemale.Text + " ";
                }
                else if (radMale.Checked)
                {
                    dataG += radMale.Text + " ";
                }

                // Check if gender is selected
                if (string.IsNullOrEmpty(dataG))
                {
                    //MessageBox.Show("Please select a gender.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //return; // Exit the method
                }

                // Collect hobbies
                if (chkBasketball.Checked)
                {
                    data1 += chkBasketball.Text + ", ";
                }
                if (chkVolleyball.Checked)
                {
                    data1 += chkVolleyball.Text + ", ";
                }
                if (chkBadminton.Checked)
                {
                    data1 += chkBadminton.Text + ", ";
                }

                // Check if hobbies are selected
                if (string.IsNullOrEmpty(data1))
                {
                    //MessageBox.Show("Please select at least one hobby.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //return; // Exit the method
                }

                // Check if favorite color is selected
                if (string.IsNullOrEmpty(favcolor))
                {
                    //MessageBox.Show("Please select a favorite color.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //return; // Exit the method
                }

                // Check if saying is empty
                if (string.IsNullOrEmpty(saying))
                {
                    //MessageBox.Show("Saying cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //return; // Exit the method
                }
                // Check if age is empty
                if (string.IsNullOrEmpty(txtAge.Text.Trim()))
                {
                    //MessageBox.Show("Age cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //return;
                }
                // Check if age is number
                if (!int.TryParse(txtAge.Text.Trim(), out int age))
                {
                    //MessageBox.Show("Age must be a number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //return;
                }
                if (string.IsNullOrEmpty(Address))
                {
                    //MessageBox.Show("Address cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //return;
                }
                // Check if Email is empty
                if (string.IsNullOrEmpty(Email))
                {
                    //MessageBox.Show("Email cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //return;
                }
                if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
                {
                    //MessageBox.Show("Invalid email format.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //return;
                }
                // Check if Birthdate is empty
                if (dtpBirthday.Value == DateTimePicker.MinimumDateTime)
                {
                    //MessageBox.Show("Please select a birthday.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //return;
                }
                lblMessage.Text = checkEmpty();
                if (lblMessage.Text == "")
                {
                    book.SaveToFile(@"C:\Users\ACT-STUDENT\Desktop\myfile (1)", ExcelVersion.Version2013);

                }
                else
                {

                    return;
                }
                MessageBox.Show("Successfully added");


                // Increment the counter (if needed)
                i++;
                book.LoadFromFile(@"C:\Users\ACT-STUDENT\Desktop\myfile (1).xlsx");
                Worksheet sheet = book.Worksheets[0];
                int row = sheet.Rows.Length + 1;

                sheet.Range[row, 1].Value = txtName.Text;
                sheet.Range[row, 2].Value = dataG;
                sheet.Range[row, 3].Value = data1;
                sheet.Range[row, 4].Value = txtAge.Text;
                sheet.Range[row, 5].Value = Address;
                sheet.Range[row, 6].Value = Email;
                sheet.Range[row, 7].Value = dtpBirthday.Text;
                sheet.Range[row, 8].Value = cmbColor.Text;
                sheet.Range[row, 9].Value = txtSaying.Text;

                book.SaveToFile(@"C:\Users\ACT-STUDENT\Desktop\myfile (1).xlsx");
                DataTable dt = sheet.ExportDataTable();
                form2.dataGridView1.DataSource = dt;

                // Insert data into form2
                //form2.insert(name, dataG, data1, favcolor, saying, txtAge.Text,Address, Email, dtpBirthday.Text);

                // Show success message


                // Reset the form
                btnAdd.Visible = false;
                btnSubmit.Visible = true;
                txtName.Clear();
                radMale.Checked = false;
                radFemale.Checked = false;
                chkBasketball.Checked = false;
                chkVolleyball.Checked = false;
                chkBadminton.Checked = false;
                txtAge.Clear();
                txtAddress.Clear();
                txtEmail.Clear();
                cmbColor.SelectedIndex = -1;
                txtSaying.Clear();
            }
            catch (Exception) // Catch any other exceptions
            {
                MessageBox.Show("An error occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string data = txtName.Text.Trim();
                string dataG = "";
                string data1 = "";
                string Address = txtAddress.Text.Trim();
                string Email = txtEmail.Text.Trim();
                string color = cmbColor.Text.Trim();
                string saying = txtSaying.Text.Trim();


                // Check if the name is empty
                if (string.IsNullOrEmpty(data))
                {
                    MessageBox.Show("Name cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Exit the method
                }

                // Check if the name is a number
                if (int.TryParse(data, out _))
                {
                    MessageBox.Show("Name cannot be a number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Exit the method
                }

                // Collect gender
                if (radFemale.Checked)
                {
                    dataG += radFemale.Text + " ";
                }
                else if (radMale.Checked)
                {
                    dataG += radMale.Text + " ";
                }

                // Check if gender is selected
                if (string.IsNullOrEmpty(dataG))
                {
                    MessageBox.Show("Please select a gender.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Exit the method
                }

                // Collect hobbies
                if (chkBasketball.Checked)
                {
                    data1 += chkBasketball.Text + ", ";
                }
                if (chkVolleyball.Checked)
                {
                    data1 += chkVolleyball.Text + ", ";
                }
                if (chkBadminton.Checked)
                {
                    data1 += chkBadminton.Text + ", ";
                }

                // Check if hobbies are selected
                if (string.IsNullOrEmpty(data1))
                {
                    MessageBox.Show("Please select at least one hobby.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Exit the method
                }

                // Check if favorite color is selected
                if (string.IsNullOrEmpty(color))
                {
                    MessageBox.Show("Please select a favorite color.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Exit the method
                }

                // Check if saying is empty
                if (string.IsNullOrEmpty(saying))
                {
                    MessageBox.Show("Saying cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Exit the method
                }
                // Check if age is empty
                if (string.IsNullOrEmpty(txtAge.Text.Trim()))
                {
                    MessageBox.Show("Age cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Check if age is number
                if (!int.TryParse(txtAge.Text.Trim(), out int age))
                {
                    MessageBox.Show("Age must be a number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(Address))
                {
                    MessageBox.Show("Address cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Check if Email is empty
                if (string.IsNullOrEmpty(Email))
                {
                    MessageBox.Show("Email cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
                {
                    MessageBox.Show("Invalid email format.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Check if Birthdate is empty
                if (dtpBirthday.Value == DateTimePicker.MinimumDateTime)
                {
                    MessageBox.Show("Please select a birthday.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                // Increment the counter (if needed)
                i++;
                book.LoadFromFile(@"C:\Users\ACT-STUDENT\Desktop\myfile (1).xlsx");
                Worksheet sheet = book.Worksheets[0];
                int row = sheet.Rows.Length + 2;

                sheet.Range[row, 1].Value = txtName.Text;
                sheet.Range[row, 2].Value = dataG;
                sheet.Range[row, 3].Value = data1;
                sheet.Range[row, 4].Value = txtAge.Text;
                sheet.Range[row, 5].Value = Address;
                sheet.Range[row, 6].Value = Email;
                sheet.Range[row, 7].Value = dtpBirthday.Text;
                sheet.Range[row, 8].Value = cmbColor.Text;
                sheet.Range[row, 9].Value = txtSaying.Text;

                book.SaveToFile(@"C:\Users\ACT-STUDENT\Desktop\myfile (1).xlsx");
                DataTable dt = sheet.ExportDataTable();
                form2.dataGridView1.DataSource = dt;
                // Insert data into form2
                form2.update(Convert.ToInt32(lblId.Text), txtName.Text, dataG, data1, color, saying, txtAge.Text, Address, Email, dtpBirthday.Text);

                // Show success message
                MessageBox.Show("Updated successfully");




            }
            catch (Exception) // Catch any other exceptions
            {
                MessageBox.Show("An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            form2.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
               txtBrowse.Text = file.FileName; 
            }
        }
    }
}
