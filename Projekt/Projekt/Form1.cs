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

        private List<Gyerekek> gyerekeks = new List<Gyerekek>();    
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

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Comma Seperated Values (*.csv)|*.csv";
            sfd.DefaultExt = "csv";
            sfd.AddExtension = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
                {
                    sw.Write("Vezeteknev");
                    sw.Write(";");
                    sw.Write("Keresztnev");
                    sw.Write(";");
                    sw.Write("Kor");
                    sw.Write(";");
                    sw.Write("Csoport");
                    sw.Write(";");
                    sw.Write("Betegseg");
                    sw.WriteLine();
                }
                MessageBox.Show("A nyereséglista fájlba írása sikeres volt!");
            }
            //using (SaveFileDialog sdl = new SaveFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })
            //{
            //    if (sdl.ShowDialog() == DialogResult.OK)
            //    {
            //using (var sw = new StreamWriter(sdl.FileName))
            //{
            //    var writer = new CsvWriter(sw, System.Globalization.CultureInfo.CurrentCulture);
            //    writer.WriteHeader(typeof(Gyerekek));
            //    foreach (Gyerekek s in dataGridView1.DataSource as List<Gyerekek>)
            //    {
            //        writer.WriteRecord(s);
            //    }
            //}
            //        MessageBox.Show("");
            //    }
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Application.StartupPath;
            ofd.Filter = "Comma Seperated Values (*.csv)|*.csv";
            ofd.DefaultExt = "csv";
            ofd.AddExtension = true;

            if (ofd.ShowDialog() != DialogResult.OK) return;

            using (StreamReader sr = new StreamReader(ofd.FileName, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    string[] sor = sr.ReadLine().Split(';');

                    Gyerekek gyerek = new Gyerekek();

                    gyerek.Vezeteknev = sor[0];
                    gyerek.Keresztnev = sor[1];
                    try
                    {
                        gyerek.Kor = int.Parse(sor[2]);
                    }
                    catch
                    {


                    }
                    
                    gyerek.Csoport = sor[3];
                    try
                    {
                        gyerek.Betegseg = bool.Parse(sor[4]);
                    }
                    catch
                    {


                    }
                    
                    
                    gyerekekBindingSource.Add(gyerek);


                }

            }
            
        }

        
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
            xlSheet.Cells[1, 1] = headers[0];
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
                values[counter, 4] = gy.Betegseg;
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
            headerRange.RowHeight = 50;
            headerRange.Interior.Color = Color.Blue;
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
            
        }

        
    }
}
