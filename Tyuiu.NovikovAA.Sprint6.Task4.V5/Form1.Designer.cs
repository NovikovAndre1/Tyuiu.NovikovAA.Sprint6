namespace Tyuiu.NovikovAA.Sprint6.Task4.V5
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            button1 = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            textBoxStartStep = new TextBox();
            textBoxStopStep = new TextBox();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            buttonSave = new Button();
            label2 = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(894, 29);
            button1.Name = "button1";
            button1.Size = new Size(94, 74);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(26, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(440, 91);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 35);
            label1.Name = "label1";
            label1.Size = new Size(317, 40);
            label1.TabIndex = 0;
            label1.Text = "ТУТ ТИПО КАКОЕ ТО СЛОЖНОЕ УСЛОВИЕ \r\nДЛЯ КОТОРОГО СОЗДАНА ЭТА ПРОГРАММА\r\n";
            label1.Click += label1_Click;
            // 
            // textBoxStartStep
            // 
            textBoxStartStep.Location = new Point(525, 76);
            textBoxStartStep.Name = "textBoxStartStep";
            textBoxStartStep.Size = new Size(125, 27);
            textBoxStartStep.TabIndex = 2;
            textBoxStartStep.TextChanged += textBoxStartStep_TextChanged;
            // 
            // textBoxStopStep
            // 
            textBoxStopStep.Location = new Point(718, 76);
            textBoxStopStep.Name = "textBoxStopStep";
            textBoxStopStep.Size = new Size(125, 27);
            textBoxStopStep.TabIndex = 3;
            textBoxStopStep.TextChanged += textBoxStopStep_TextChanged;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea2);
            chart1.Cursor = Cursors.IBeam;
            legend2.Name = "Legend1";
            chart1.Legends.Add(legend2);
            chart1.Location = new Point(307, 151);
            chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart1.Series.Add(series2);
            chart1.Size = new Size(658, 375);
            chart1.TabIndex = 4;
            chart1.Text = "chart1";
            chart1.Click += chart1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridView1.Location = new Point(35, 174);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(153, 367);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            Column2.Width = 125;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(1035, 29);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 74);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "button2";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(549, 47);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 7;
            label2.Text = "Начало";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(763, 47);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 8;
            label3.Text = "Конец";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1224, 575);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonSave);
            Controls.Add(dataGridView1);
            Controls.Add(chart1);
            Controls.Add(textBoxStopStep);
            Controls.Add(textBoxStartStep);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private GroupBox groupBox1;
        private TextBox textBoxStartStep;
        private TextBox textBoxStopStep;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Label label1;
        private Button buttonSave;
        private Label label2;
        private Label label3;
    }
}
