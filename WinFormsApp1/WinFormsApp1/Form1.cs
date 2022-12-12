using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            ArrayList a = new ArrayList() { "A", "B", "C", "D", "E", "F", "G", "H" };
            ArrayList b = new ArrayList() { "1", "2", "3", "4", "5", "6", "7", "8" };
            int sayac = 0;
            etiket:
            try
            {
                sayac++;
                switch (sayac)
                {
                    case 1: listBox1.Items.Add(a[a.IndexOf(textBox1.Text.Substring(0, 1)) + 2].ToString() + b[b.IndexOf(textBox1.Text.Substring(1)) + 1]).ToString(); break;
                    case 2: listBox1.Items.Add(a[a.IndexOf(textBox1.Text.Substring(0, 1)) + 2].ToString() + b[b.IndexOf(textBox1.Text.Substring(1)) - 1]).ToString(); break;
                    case 3: listBox1.Items.Add(a[a.IndexOf(textBox1.Text.Substring(0, 1)) - 2].ToString() + b[b.IndexOf(textBox1.Text.Substring(1)) + 1]).ToString(); break;
                    case 4: listBox1.Items.Add(a[a.IndexOf(textBox1.Text.Substring(0, 1)) - 2].ToString() + b[b.IndexOf(textBox1.Text.Substring(1)) - 1]).ToString(); break;
                    case 5: listBox1.Items.Add(a[a.IndexOf(textBox1.Text.Substring(0, 1)) - 1].ToString() + b[b.IndexOf(textBox1.Text.Substring(1)) + 2]).ToString(); break;
                    case 6: listBox1.Items.Add(a[a.IndexOf(textBox1.Text.Substring(0, 1)) + 1].ToString() + b[b.IndexOf(textBox1.Text.Substring(1)) + 2]).ToString(); break;
                    case 7: listBox1.Items.Add(a[a.IndexOf(textBox1.Text.Substring(0, 1)) + 1].ToString() + b[b.IndexOf(textBox1.Text.Substring(1)) - 2]).ToString(); break;
                    case 8: listBox1.Items.Add(a[a.IndexOf(textBox1.Text.Substring(0, 1)) - 1].ToString() + b[b.IndexOf(textBox1.Text.Substring(1)) - 2]).ToString(); break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {
                goto etiket;
            }
            if (sayac != 9)
                goto etiket;
          
          
          
       
           
            
            
           
            
           
           
            
        }

    }
}
