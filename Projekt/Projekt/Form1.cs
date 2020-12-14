using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.Reflection;

namespace Projekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        private void CreateExcel()
        {
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWbook = xlApp.Workbooks.Add(Missing.Value);
            Excel.Worksheet xlSheet = xlWbook.ActiveSheet;

            xlApp.Visible = true;
            
            xlApp.UserControl = true;
        }
    }
}
