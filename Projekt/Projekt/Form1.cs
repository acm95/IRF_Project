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
using CsvHelper;

namespace Projekt
{
    public partial class Form1 : Form
    {

        List<Gyerekek> gyerekeks;    
        public Form1()
        {

            InitializeComponent();

            


        }

        
        
        private void button1_Click(object sender, EventArgs e)
        {
            CreateExcel();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //using (SaveFileDialog sdl = new SaveFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })
            //{
            //    if (sdl.ShowDialog() == DialogResult.OK)
            //    {
            //        using (var sw = new StreamWriter(sdl.FileName))
            //        {
            //            var writer = new CsvWriter(sw, System.Globalization.CultureInfo.CurrentCulture);
            //            writer.WriteHeader(typeof(Gyerekek));
            //            foreach (Gyerekek s in dataGridView1.DataSource as List<Gyerekek>)
            //            {
            //                writer.WriteRecord(s);
            //            }
            //        }
            //        MessageBox.Show("");
            //    }
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //openFileDialog1.ShowDialog();

            //textBox1.Text = openFileDialog1.FileName;
            //BindDataCSV(textBox1.Text);
            //string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Data\Names.txt");
            //string[] files = File.ReadAllLines(path);
        }

        //private void BindDataCSV(string filePath)
        //{
        //    DataTable dt = new DataTable();
        //    string[] lines = File.ReadAllLines(filePath);
        //    if (lines.Length>0)
        //    {
        //        string firstline = lines[0];
        //        string[] headerLabels = firstline.Split(',');
        //        foreach (string headerWord in headerLabels)
        //        {
        //            dt.Columns.Add(new DataColumn(headerWord));
        //        }
        //        for (int r = 1; r < lines.Length; r++)
        //        {
        //            string[] dataWords = lines[r].Split(',');
        //            DataRow dr = dt.NewRow();
        //            int columnIndex = 0;
        //            foreach (string headerWord in headerLabels)
        //            {
        //                dr[headerWord] = dataWords[columnIndex++];
        //            }
        //            dt.Rows.Add(dr);
        //        }
        //    }
        //    if (dt.Rows.Count>0)
        //    {
        //        dataGridView1.DataSource = dt;
        //    }
        //}

        

        

        private void CreateExcel()
        {
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWbook = xlApp.Workbooks.Add(Missing.Value);
            Excel.Worksheet xlSheet = xlWbook.ActiveSheet;

            string[] headers = new string[] 
            {
            "Vezetéknév",
             "Keresztnév",
             "Kor",
             "Csoport",
             "Betegség"
            };
            for (int i = 1; i < headers.Length + 1; i++)
            {
                xlSheet.Cells[1, i] = headers[i - 1];
            }
            object[,] values = new object[gyerekeks.Count, headers.Length];

            int counter = 0;
            foreach (Gyerekek gy in gyerekeks)
            {
                values[counter, 0] = gy.Vezeteknev;
                values[counter, 1] = gy.Keresztnev;
                values[counter, 2] = gy.Kor;
                values[counter, 3] = gy.Csoport;
                values[counter, 4] = gy.Betegség;
                counter++;
            }
            xlSheet.get_Range(
             GetCell(2, 1),
             GetCell(1 + values.GetLength(0), values.GetLength(1))).Value2 = values;
            Excel.Range headerRange = xlSheet.get_Range(GetCell(1, 1), GetCell(1, headers.Length));
            headerRange.Font.Bold = true;
            headerRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            headerRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            headerRange.EntireColumn.AutoFit();
            headerRange.RowHeight = 40;
            headerRange.Interior.Color = Color.LightBlue;
            headerRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);
            int lastRowID = xlSheet.UsedRange.Rows.Count;


            xlApp.Visible = true;
            xlApp.UserControl = true;
        }
        private string GetCell(int x, int y)
        {
            string ExcelCoordinate = "";
            int dividend = y;
            int modulo;

            while (dividend > 0)
            {
                modulo = (dividend - 1) % 26;
                ExcelCoordinate = Convert.ToChar(65 + modulo).ToString() + ExcelCoordinate;
                dividend = (int)((dividend - modulo) / 26);
            }
            ExcelCoordinate += x.ToString();

            return ExcelCoordinate;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new List<Gyerekek>();
        }

        
    }
}
