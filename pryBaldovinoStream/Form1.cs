using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace pryBaldovinoStream
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("Data.txt", false);

            sw.WriteLine("2154\n1549\n1873");
            sw.Close();
            sw.Dispose();


            StreamWriter sw2 = new StreamWriter("Romanos.txt", false);

            sw2.WriteLine("Decimal   Romano\n2154     MMCLIV\n1549     MDXLIX\n1873     MDCCCLXXIII");
            sw2.Close();
            sw2.Dispose();

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "Data.txt";
            openFileDialog1.Filter = "Archivos de texto | *.txt | Archivos pdf | *.pdf";
            openFileDialog1.ShowDialog();
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }
    }
}
