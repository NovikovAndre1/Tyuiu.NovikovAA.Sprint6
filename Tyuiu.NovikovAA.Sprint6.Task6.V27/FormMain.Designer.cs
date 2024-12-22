namespace Tyuiu.NovikovAA.Sprint6.Task6.V27
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            buttonDone = new Button();
            textBoxResult = new TextBox();
            splitContainer1 = new SplitContainer();
            textBoxLoadFromFile = new TextBox();
            groupBoxOutPutData = new GroupBox();
            buttonOpenFile = new Button();
            openFileDialogTask = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            buttonHelp = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBoxOutPutData.SuspendLayout();
            SuspendLayout();
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(162, 12);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(100, 72);
            buttonDone.TabIndex = 0;
            buttonDone.Text = "button1";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(3, 105);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(657, 362);
            textBoxResult.TabIndex = 1;
            textBoxResult.TextChanged += textBoxResult_TextChanged;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(12, 149);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(textBoxLoadFromFile);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(textBoxResult);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(1078, 470);
            splitContainer1.SplitterDistance = 359;
            splitContainer1.TabIndex = 2;
            // 
            // textBoxLoadFromFile
            // 
            textBoxLoadFromFile.Location = new Point(3, 105);
            textBoxLoadFromFile.Multiline = true;
            textBoxLoadFromFile.Name = "textBoxLoadFromFile";
            textBoxLoadFromFile.Size = new Size(353, 362);
            textBoxLoadFromFile.TabIndex = 0;
            textBoxLoadFromFile.TextChanged += textBoxLoadFromFile_TextChanged;
            // 
            // groupBoxOutPutData
            // 
            groupBoxOutPutData.Controls.Add(label1);
            groupBoxOutPutData.Location = new Point(162, 122);
            groupBoxOutPutData.Name = "groupBoxOutPutData";
            groupBoxOutPutData.Size = new Size(658, 126);
            groupBoxOutPutData.TabIndex = 0;
            groupBoxOutPutData.TabStop = false;
            groupBoxOutPutData.Text = "Условие";
            groupBoxOutPutData.Enter += groupBoxOutPutData_Enter;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Location = new Point(12, 12);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(119, 72);
            buttonOpenFile.TabIndex = 3;
            buttonOpenFile.Text = "but";
            toolTip1.SetToolTip(buttonOpenFile, "ТУТ ТИПО ПОЯВЛЯЕТСЯ ПОДСКАЗКА");
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(874, 15);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(94, 69);
            buttonHelp.TabIndex = 4;
            buttonHelp.Text = "button";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 41);
            label1.Name = "label1";
            label1.Size = new Size(633, 60);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 631);
            Controls.Add(groupBoxOutPutData);
            Controls.Add(buttonHelp);
            Controls.Add(buttonOpenFile);
            Controls.Add(splitContainer1);
            Controls.Add(buttonDone);
            Name = "FormMain";
            Text = "Form1";
            toolTip1.SetToolTip(this, "ТУТ ТИПО ПОЯВЛЯЕТСЯ ПОДСКАЗКА\r\n");
            Load += FormMain_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBoxOutPutData.ResumeLayout(false);
            groupBoxOutPutData.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDone;
        private TextBox textBoxResult;
        private SplitContainer splitContainer1;
        private Button buttonOpenFile;
        private ToolTip toolTip1;
        private OpenFileDialog openFileDialogTask;
        private Button buttonHelp;
        private TextBox textBoxLoadFromFile;
        private GroupBox groupBoxOutPutData;
        private Label label1;
    }
}
