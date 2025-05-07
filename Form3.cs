using Spire.Xls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ARRAY
{
    public partial class Form3 : Form
    {
        Workbook book = new Workbook();
        public Form3()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            book.LoadFromFile(@"C:\Users\ACT-STUDENT\Desktop\myfile (1).xlsx");
            Worksheet sheet = book.Worksheets[0];
            int row = sheet.Rows.Length;
            for (int i = 2; i <= row; i++)
            {
                string excelUser = sheet.Range[i, 10].Text;
                string excelPass = sheet.Range[i, 11].Text;
                if (excelUser == txtUser.Text || excelPass == txtPass.Text)
                {
                    MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form4 form4 = new Form4();
                    form4.Show();
                    this.Hide();
                    return;

                }


            }
            MessageBox.Show("Invalid Username or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShow.Checked)
            {
                txtPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '*';
            }
        }
    }
}
