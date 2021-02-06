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
            data.View = View.Details;
            data.Columns.Add("REGION");
            data.Columns.Add("CODIGO DANE");
            data.Columns.Add("DEPARTAMENTO");
            data.Columns.Add("Total Hours");
            data.Columns.Add("MUNICIPIO");

            // Auto-size the columns
            for (int i = 0; i < data.Columns.Count; i++)
            {
                data.Columns[i].Width = -2;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var sr = new StreamReader(openFileDialog1.FileName);
                    //file.Text = openFileDialog1.FileName;
                    file.Text = sr.ReadToEnd();
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
