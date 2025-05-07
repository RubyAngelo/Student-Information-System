using Spire.Xls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARRAY
{
    internal class Mylogs
    {

    }
    public class Mylog
    {
        Workbook book = new Workbook();

        public void insertLogs(string user, string message)
        {
            book.LoadFromFile(@"C:\Users\ACT-STUDENT\Desktop\myfile (1).xlsx");
            Worksheet sh = book.Worksheets[1];
            int row = sh.Rows.Length + 1;
            sh.Range[row,1].Value = user;
            sh.Range[row, 2].Value = message;
            sh.Range[row, 3].Value = DateTime.Now.ToString("MM,dd,yy");
            sh.Range[row, 3].Value = DateTime.Now.ToString("hh:m:ss,tt");
            book.SaveToFile(@"C:\Users\ACT-STUDENT\Desktop\myfile.xlsx", ExcelVersion.Version2016);
        }
    }
}