namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.as2016procBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bILesDataDataSet = new WindowsFormsApp1.BILesDataDataSet();
            this.as2016procTableAdapter = new WindowsFormsApp1.BILesDataDataSetTableAdapters.As2016procTableAdapter();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.bILesDataDataSet1 = new WindowsFormsApp1.BILesDataDataSet1();
            this.pogoda2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pogoda2TableAdapter = new WindowsFormsApp1.BILesDataDataSet1TableAdapters.pogoda2TableAdapter();
            this.stacjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.predkoscwiatruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.as2016procBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bILesDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bILesDataDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pogoda2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stacjaDataGridViewTextBoxColumn,
            this.predkoscwiatruDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pogoda2BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(11, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 322);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // as2016procBindingSource
            // 
            this.as2016procBindingSource.DataMember = "As2016proc";
            this.as2016procBindingSource.DataSource = this.bILesDataDataSet;
            // 
            // bILesDataDataSet
            // 
            this.bILesDataDataSet.DataSetName = "BILesDataDataSet";
            this.bILesDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // as2016procTableAdapter
            // 
            this.as2016procTableAdapter.ClearBeforeFill = true;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.DataSource = this.pogoda2BindingSource;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(279, 92);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.Name = "Stacja";
            series2.XValueMember = "stacja";
            series2.YValueMembers = "0";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(509, 297);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(279, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(239, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(279, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // bILesDataDataSet1
            // 
            this.bILesDataDataSet1.DataSetName = "BILesDataDataSet1";
            this.bILesDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pogoda2BindingSource
            // 
            this.pogoda2BindingSource.DataMember = "pogoda2";
            this.pogoda2BindingSource.DataSource = this.bILesDataDataSet1;
            // 
            // pogoda2TableAdapter
            // 
            this.pogoda2TableAdapter.ClearBeforeFill = true;
            // 
            // stacjaDataGridViewTextBoxColumn
            // 
            this.stacjaDataGridViewTextBoxColumn.DataPropertyName = "stacja";
            this.stacjaDataGridViewTextBoxColumn.HeaderText = "stacja";
            this.stacjaDataGridViewTextBoxColumn.Name = "stacjaDataGridViewTextBoxColumn";
            // 
            // predkoscwiatruDataGridViewTextBoxColumn
            // 
            this.predkoscwiatruDataGridViewTextBoxColumn.DataPropertyName = "predkosc_wiatru";
            this.predkoscwiatruDataGridViewTextBoxColumn.HeaderText = "predkosc_wiatru";
            this.predkoscwiatruDataGridViewTextBoxColumn.Name = "predkoscwiatruDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.as2016procBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bILesDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bILesDataDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pogoda2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private BILesDataDataSet bILesDataDataSet;
        private System.Windows.Forms.BindingSource as2016procBindingSource;
        private BILesDataDataSetTableAdapters.As2016procTableAdapter as2016procTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button2;
        private BILesDataDataSet1 bILesDataDataSet1;
        private System.Windows.Forms.BindingSource pogoda2BindingSource;
        private BILesDataDataSet1TableAdapters.pogoda2TableAdapter pogoda2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stacjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn predkoscwiatruDataGridViewTextBoxColumn;
    }
}

