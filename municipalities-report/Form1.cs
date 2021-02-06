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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var sr = new StreamReader(openFileDialog1.FileName);
                    //file.Text = openFileDialog1.FileName;
                    String line1 = sr.ReadLine();
                    char deter = ',';
                    String[] line2 = line1.Split(deter);
                    String codDep = line2[0], demp = line2[1], codMuni = line2[2], nameDep = line2[3], nameMuni = line2[4], tipoMIA = line2[5];
                    data = new ListView();
                    data.Items.Add(codDep);
                    data.Items.Add(demp);
                    data.Items.Add(codMuni);
                    data.Items.Add(nameDep);
                    data.Items.Add(nameMuni);
                    data.Items.Add(tipoMIA);
                    String linee = sr.ReadLine();
                    while (!String.IsNullOrEmpty(linee))
                    {
                        String[] line3 = linee.Split(deter);
                        codDep = line3[0];
                        demp = line3[1];
                        codMuni = line3[2];
                        nameDep = line3[3];
                        nameMuni = line3[4];
                        tipoMIA = line3[5]; 
                    }

                    data.Items.Add(codDep);
                    //file.Text = sr.ReadToEnd();

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
    }
}
