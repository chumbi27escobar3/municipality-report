﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security;

namespace municipalities_report
{
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Titles.Add("Tipos de municipios");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var sr = new StreamReader(openFileDialog1.FileName);
                                    
                    List<string> lista = File.ReadAllLines(openFileDialog1.FileName).ToList();
                    
                    foreach (string d in lista)
                    {
                        string[] items = d.Split(new char[] { ',' },
                               StringSplitOptions.RemoveEmptyEntries);
                        data.Items.Add(new ListViewItem(items));
                    }
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }   
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            getMunicipalityType();
        }

        private void data_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void getMunicipalityType(){
            int cM = 0, cI=0, cA=0;
            foreach (ListViewItem item in data.Items)
            {
                label1.Text = item.SubItems[4].Text;
            }
            for (int i = 0; i < data.Items.Count; i++)
            {
                var colCount = data.Items[1].SubItems[4].Text;
                label1.Text = Convert.ToString(colCount);
                if (data.Items[i].SubItems[4].Text.Equals("Municipio"))
                {
                    cM++;
                }if (data.Items[i].SubItems[4].Text.Equals("Isla"))
                {
                    cI++;
                }if (data.Items[i].SubItems[4].Text.Equals("Área no municipalizada"))
                {
                    cA++;
                }
            }
            chart1.Series["Series1"].Points.AddXY("Municipio", cM);
            chart1.Series["Series1"].Points.AddXY("Isla", cI);
            chart1.Series["Series1"].Points.AddXY("Área no municipalizada", cA);
        }
    }
}
