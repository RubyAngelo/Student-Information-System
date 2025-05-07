using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Spire.Xls;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
namespace ARRAY
{
    

    public partial class Form2 : Form
    {
        Spire.Xls.Workbook book = new Spire.Xls.Workbook();

        public Form2()
        {
            InitializeComponent();
        }

        public void bookLoadFromFile()
        {
            book.LoadFromFile(@"C:\Users\ACT-STUDENT\Desktop\myfile.xlsx");
            Worksheet sheet = book.Worksheets[0];
            DataTable dt = sheet.ExportDataTable();
            dataGridView1.DataSource = dt;
        }
        public void insert(string data, string dataG, string data1,string color, string saying, string txtAge,string Address, string Email, string dtpBirthday)
        {
            int i = dataGridView1.Rows.Add(data, dataG, data1, color, saying, txtAge ,Address, Email) ;

            dataGridView1.Rows[i].Cells[0].Value = data;
            dataGridView1.Rows[i].Cells[1].Value = dataG;
            dataGridView1.Rows[i].Cells[2].Value = data1;
            dataGridView1.Rows[i].Cells[3].Value = txtAge;
            dataGridView1.Rows[i].Cells[4].Value = Address;
            dataGridView1.Rows[i].Cells[5].Value = Email;
            dataGridView1.Rows[i].Cells[6].Value = dtpBirthday;
            dataGridView1.Rows[i].Cells[7].Value = color;
            dataGridView1.Rows[i].Cells[8].Value = saying;

        }
        public void update(int Id, string data, string dataG, string data1, string color, string saying, string txtAge,string Address, string Email, string dtpBirthday)
        {


            dataGridView1.Rows[Id].Cells[0].Value = data;
            dataGridView1.Rows[Id].Cells[1].Value = dataG;
            dataGridView1.Rows[Id].Cells[2].Value = data1;
            dataGridView1.Rows[Id].Cells[3].Value = txtAge;
            dataGridView1.Rows[Id].Cells[4].Value = Address;
            dataGridView1.Rows[Id].Cells[5].Value = Email;
            dataGridView1.Rows[Id].Cells[6].Value = dtpBirthday;
            dataGridView1.Rows[Id].Cells[7].Value = color;
            dataGridView1.Rows[Id].Cells[8].Value = saying;

        }

        


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            book.LoadFromFile(@"C:\Users\ACT-STUDENT\Desktop\myfile.xlsx");
            Worksheet sh = book.Worksheets[0];
            int row = sh.Range.Row + 1; // range row is not final 
            sh.Range[row, 5].Value = "0";
            //try
            //{
            //    foreach (DataGridViewRow row in dataGridView1.Rows)
            //        dataGridView1.Rows.RemoveAt(row.Index);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        public void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            //if (e.RowIndex >= 0)
            //{
            //    Form1 form1 = new Form1();

            //    // Pass data from DataGridView to Form1
            //    form1.txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            //    form1.txtAge.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            //    form1.txtAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            //    form1.txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            //    form1.dtpBirthday.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString());
            //    form1.cmbColor.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            //    form1.txtSaying.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();

            //    // Gender selection
            //    if (dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() == "Male")
            //        form1.radMale.Checked = true;
            //    else
            //        form1.radFemale.Checked = true;

            //    // Hobbies selection
            //    string hobbies = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            //    form1.chkBasketball.Checked = hobbies.Contains("Basketball");
            //    form1.chkVolleyball.Checked = hobbies.Contains("Volleyball");
            //    form1.chkBadminton.Checked = hobbies.Contains("Badminton");

            //    form1.Show(); // Open Form1
            //}
            //int r = dataGridView1.CurrentCell.RowIndex;
            //Form1 f1 = (Form1)System.Windows.Forms.Application.OpenForms["Form1"];
            //f1.txtName.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();

            //string dataG = dataGridView1.Rows[r].Cells[1].Value.ToString();
            //if (dataG == "Male")
            //{
            //    f1.radMale.Checked = true;
            //}
            //else
            //{
            //    f1.radMale.Checked = false;
            //}
            //if (dataG == "Female")
            //{
            //    f1.radFemale.Checked = true;
            //}
            //else
            //{
            //    f1.radFemale.Checked = false;
            //}

            //string hobbies = dataGridView1.Rows[r].Cells[2].Value.ToString();
            //string[] h = hobbies.Split(',');
            //foreach (string val in h)
            //{
            //    if (val.Trim() == "Basketball")
            //    {
            //        f1.chkBasketball.Checked = true;
            //    }
            //    if (val.Trim() == "Volleyball")
            //    {
            //        f1.chkVolleyball.Checked = true;
            //    }
            //    if (val.Trim() == "Badminton")
            //    {
            //        f1.chkBadminton.Checked = true;
            //    }

            //}


            //f1.cmbColor.SelectedItem = dataGridView1.Rows[r].Cells[3].Value.ToString();
            //f1.txtSaying.Text = dataGridView1.Rows[r].Cells[4].Value.ToString();
            //f1.lblId.Text = r.ToString();
            //f1.btnSubmit.Visible = false;
            //f1.btnAdd.Visible = true;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            dataGridView1.ClearSelection();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value.Equals(search))
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
         
        }
    }
}
