using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            int sayac = 1, sayac2 = 0,a=0,l=-1,t=0,enbuyuk=0;
            List<int> dizi = new List<int>() { 15, 2, 5, 2, 16, 5, 7, 8,9,10,11,15,13,14,15,16,16 };
            List<int> tek_tekrar = new List<int>();
            int[,] dizi2 = new int[20,2];
            for (int i = 0; i < dizi.Count; i++)
            {
                l++;
                t++;
                tek_tekrar.Add(dizi[i]);
                for (int j = 0; j < dizi.Count; j++)
                {
                    if (i!=j)
                    {
                        if (dizi[i] == dizi[j])
                        {
                            dizi.RemoveAt(j);
                            j--;
                            a = dizi[i];
                            sayac++; 
                        }
                    }

                    if (j==dizi.Count-1)
                    {
                        for (int k=l ; k < t; k++)
                        {
                            for (int  p= 0; p < 2; p++)
                            {
                                sayac2++;
                                if (sayac2%2==0)
                                    dizi2[k, p] = a; 
                                else
                                    dizi2[k, p] = sayac; 
                            }
                        }
                        if (sayac>=enbuyuk)
                            enbuyuk = sayac;
                    }
                }
                sayac = 1;
            }
            if (enbuyuk==1)
                tek_tekrar.ForEach(yazdir => listBox1.Items.Add(yazdir + " 'Sayısı dizide 1 kez geçmektedir"));
            else
            {
                for (int i = 0; i < 20; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        if (j == 0)
                        {
                            if (enbuyuk == dizi2[i, j])
                                listBox1.Items.Add(dizi2[i, j + 1] + " 'Sayısı dizide " + dizi2[i, j] + " kez geçmektedir");
                        }
                    }
                }
            }
          
        }
    }
}
