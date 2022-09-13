using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Lagerprogramm
{
    
    public partial class Barcodegenerator1 : Form
    {
        Print print = new Print();
        Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
        public Barcodegenerator1()
        {
            InitializeComponent();
            but_gen.BackColor = Color.Red;
            


        }

        private void but_gen_Click(object sender, EventArgs e)
        {
            print.eingabe = textBox1.Text;
            if (print.eingabe != "") { picBarcode.Image = barcode.Draw(print.eingabe,50); }

        }

        private void Barcodegenerator1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                but_gen.BackColor = Color.Green;
            }
            else
            {
                but_gen.BackColor = Color.Red;
            }

            
        }

        private void but_print_Click(object sender, EventArgs e)
        {
            print.eingabe = textBox1.Text+"&";
            if (print.eingabe != "") { picBarcode.Image = barcode.Draw(print.eingabe, 50); }

            PrintDocument printDocument1 = new PrintDocument();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(picBarcode.Image, 0, 0);
        }
    }
}
