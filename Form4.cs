using Microsoft.VisualBasic.ApplicationServices;
using Spire.Xls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace ARRAY
{
    public partial class Form4 : Form
    {
        Workbook book = new Workbook();
        Form2 form2 = new Form2();
        public Form4()
        {
            InitializeComponent();
       
            
        }
        public int ShowCount (int columnIndex, string val)
        {
            book.LoadFromFile(@"C:\Users\ACT-STUDENT\Desktop\myfile.xlsx");
            Worksheet sh = book.Worksheets[0];
            int row = sh.Rows.Length;
            int count = 0;
            for (int i = 2; i <= row; i++) 
            {
                if (sh.Range[i,count].Value == val)
                {
                    count++;
                }
            }
            return count;
        }


        
        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnActiveS_Click(object sender, EventArgs e)
        {
            form2.Show();
        }
    }
}
