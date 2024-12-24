namespace Tyuiu.NovikovAA.Sprint6.Task7.V9
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
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            buttonHelp = new Button();
            buttonOpenFile = new Button();
            dataGridViewInMatrix = new DataGridView();
            dataGridViewOutMatrix = new DataGridView();
            buttonDone = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInMatrix).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutMatrix).BeginInit();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(655, 28);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(94, 29);
            buttonHelp.TabIndex = 0;
            buttonHelp.Text = "HELP";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Location = new Point(12, 28);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(94, 29);
            buttonOpenFile.TabIndex = 1;
            buttonOpenFile.Text = "Open";
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // dataGridViewInMatrix
            // 
            dataGridViewInMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInMatrix.Location = new Point(54, 202);
            dataGridViewInMatrix.Name = "dataGridViewInMatrix";
            dataGridViewInMatrix.RowHeadersWidth = 51;
            dataGridViewInMatrix.Size = new Size(300, 188);
            dataGridViewInMatrix.TabIndex = 2;
            dataGridViewInMatrix.CellContentClick += dataGridViewInMatrix_CellContentClick;
            // 
            // dataGridViewOutMatrix
            // 
            dataGridViewOutMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutMatrix.Location = new Point(465, 202);
            dataGridViewOutMatrix.Name = "dataGridViewOutMatrix";
            dataGridViewOutMatrix.RowHeadersWidth = 51;
            dataGridViewOutMatrix.Size = new Size(300, 188);
            dataGridViewOutMatrix.TabIndex = 3;
            dataGridViewOutMatrix.CellContentClick += dataGridViewOutMatrix_CellContentClick;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(357, 53);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(94, 29);
            buttonDone.TabIndex = 4;
            buttonDone.Text = "button1";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += button1_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 451);
            Controls.Add(buttonDone);
            Controls.Add(dataGridViewOutMatrix);
            Controls.Add(dataGridViewInMatrix);
            Controls.Add(buttonOpenFile);
            Controls.Add(buttonHelp);
            Name = "FormMain";
            Text = "Form1";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewInMatrix).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutMatrix).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Button buttonHelp;
        private Button buttonOpenFile;
        private DataGridView dataGridViewInMatrix;
        private DataGridView dataGridViewOutMatrix;
        private Button buttonDone;
    }
}
