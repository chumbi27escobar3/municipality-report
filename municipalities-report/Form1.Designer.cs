
namespace municipalities_report
{
    partial class Statistics
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.file = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.ListView();
            this.codigoDepartamento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.codigoMunicipio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nombreDepartamento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nombreMunicipio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.alphabet = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // file
            // 
            this.file.AutoSize = true;
            this.file.Location = new System.Drawing.Point(148, 26);
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(35, 13);
            this.file.TabIndex = 1;
            this.file.Text = "label1";
            // 
            // data
            // 
            this.data.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codigoDepartamento,
            this.codigoMunicipio,
            this.nombreDepartamento,
            this.nombreMunicipio,
            this.tipo});
            this.data.HideSelection = false;
            this.data.Location = new System.Drawing.Point(28, 50);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(309, 388);
            this.data.TabIndex = 2;
            this.data.UseCompatibleStateImageBehavior = false;
            this.data.View = System.Windows.Forms.View.Details;
            this.data.SelectedIndexChanged += new System.EventHandler(this.data_SelectedIndexChanged);
            // 
            // codigoDepartamento
            // 
            this.codigoDepartamento.Text = "Codigo Departamento";
            // 
            // codigoMunicipio
            // 
            this.codigoMunicipio.Text = "Codigo Municipio";
            // 
            // nombreDepartamento
            // 
            this.nombreDepartamento.Text = "Nombre Deparatamento";
            // 
            // nombreMunicipio
            // 
            this.nombreMunicipio.Text = "Nombre Municipio";
            // 
            // tipo
            // 
            this.tipo.Text = "Tipo";
            // 
            // alphabet
            // 
            this.alphabet.FormattingEnabled = true;
            this.alphabet.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d",
            "e",
            "f",
            "g",
            "h",
            "i",
            "j",
            "k",
            "l",
            "m",
            "n",
            "o",
            "p",
            "q",
            "r",
            "s",
            "t",
            "u",
            "v",
            "w",
            "x",
            "y",
            "z"});
            this.alphabet.Location = new System.Drawing.Point(216, 23);
            this.alphabet.Name = "alphabet";
            this.alphabet.Size = new System.Drawing.Size(121, 21);
            this.alphabet.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(418, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Generate graphic";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(418, 68);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(370, 359);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.alphabet);
            this.Controls.Add(this.data);
            this.Controls.Add(this.file);
            this.Controls.Add(this.button1);
            this.Name = "Statistics";
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label file;
        private System.Windows.Forms.ListView data;
        private System.Windows.Forms.ComboBox alphabet;
        private System.Windows.Forms.ColumnHeader codigoDepartamento;
        private System.Windows.Forms.ColumnHeader codigoMunicipio;
        private System.Windows.Forms.ColumnHeader nombreDepartamento;
        private System.Windows.Forms.ColumnHeader nombreMunicipio;
        private System.Windows.Forms.ColumnHeader tipo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

