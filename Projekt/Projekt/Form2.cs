using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class Form2 : Form
    {
        private List<Gyerekek> gyerekeks = new List<Gyerekek>();
        
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rng = new Random();
            int randomszam = 0;
            randomszam = rng.Next(0,5);

            if (randomszam==0)
            {
                
                MessageBox.Show("A gyerek az A csoportba került.");
            }
            else if (randomszam == 1)
            {
                
                MessageBox.Show("A gyerek a B csoportba került.");
            }
            else if (randomszam == 2)
            {
                
                MessageBox.Show("A gyerek a C csoportba került.");
            }
            else if (randomszam == 3)
            {
                
                MessageBox.Show("A gyerek a D csoportba került.");
            }
            else
            {
                
                MessageBox.Show("A gyerek az E csoportba került.");
            }
            
        }
    }
}
