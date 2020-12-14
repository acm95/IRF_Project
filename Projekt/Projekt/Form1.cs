using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Projekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        public class Reader
        {
            static void Main(string[] args)
            {
                    StreamReader reader = new StreamReader("C:\\Sample.txt", Encoding.Default);
                string szoveg;
                while (!reader.EndOfStream)
                {
                    szoveg = reader.ReadLine();
                    Console.WriteLine(szoveg);
                }
                    
            }
        }
    }
}
