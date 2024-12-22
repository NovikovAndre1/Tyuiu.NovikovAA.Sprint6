namespace Tyuiu.NovikovAA.Sprint6.Task5.V20
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            buttonOpenFile = new Button();
            buttonDone = new Button();
            dataGridViewNums = new DataGridView();
            chartDiag = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            buttonHelp = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartDiag).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.BackColor = Color.Lime;
            buttonOpenFile.Location = new Point(909, 27);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(121, 111);
            buttonOpenFile.TabIndex = 0;
            buttonOpenFile.Text = "Blokknot";
            buttonOpenFile.UseVisualStyleBackColor = false;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.Cyan;
            buttonDone.Location = new Point(701, 27);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(139, 111);
            buttonDone.TabIndex = 1;
            buttonDone.Text = "button1";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // dataGridViewNums
            // 
            dataGridViewNums.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNums.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridViewNums.Location = new Point(28, 202);
            dataGridViewNums.Name = "dataGridViewNums";
            dataGridViewNums.RowHeadersWidth = 51;
            dataGridViewNums.Size = new Size(177, 442);
            dataGridViewNums.TabIndex = 2;
            dataGridViewNums.CellContentClick += dataGridViewNums_CellContentClick;
            // 
            // chartDiag
            // 
            chartArea1.Name = "ChartArea1";
            chartDiag.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartDiag.Legends.Add(legend1);
            chartDiag.Location = new Point(358, 202);
            chartDiag.Name = "chartDiag";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartDiag.Series.Add(series1);
            chartDiag.Size = new Size(690, 442);
            chartDiag.TabIndex = 3;
            chartDiag.Text = "chart1";
            chartDiag.Click += chartDiag_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(577, 176);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(16, 26);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(546, 135);
            textBox1.TabIndex = 0;
            textBox1.Text = "Прочитать данные из файла InPutFileTask5V20.txt. \r\nВывести в dataGridView. Вывести все числа, кратные 2. \r\nПостроить диаграмму по этим значениям";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = Color.Yellow;
            buttonHelp.Location = new Point(1100, 27);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(114, 111);
            buttonHelp.TabIndex = 5;
            buttonHelp.Text = "HELP\r\n";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // Column1
            // 
            Column1.HeaderText = "X";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 50;
            // 
            // Column2
            // 
            Column2.HeaderText = "f(x)";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 50;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1254, 677);
            Controls.Add(buttonHelp);
            Controls.Add(groupBox1);
            Controls.Add(chartDiag);
            Controls.Add(dataGridViewNums);
            Controls.Add(buttonDone);
            Controls.Add(buttonOpenFile);
            Name = "FormMain";
            Text = "Form1";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartDiag).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonOpenFile;
        private Button buttonDone;
        private DataGridView dataGridViewNums;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag;
        private GroupBox groupBox1;
        private Button buttonHelp;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}
