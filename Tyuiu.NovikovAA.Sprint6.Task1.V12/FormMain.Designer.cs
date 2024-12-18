namespace Tyuiu.NovikovAA.Sprint6.Task1.V12
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
            button1 = new Button();
            textBoxStartStep = new TextBox();
            textBox1 = new TextBox();
            textBoxResult = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(568, 327);
            button1.Name = "button1";
            button1.Size = new Size(154, 87);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxStartStep
            // 
            textBoxStartStep.Location = new Point(69, 375);
            textBoxStartStep.Name = "textBoxStartStep";
            textBoxStartStep.Size = new Size(125, 27);
            textBoxStartStep.TabIndex = 1;
            textBoxStartStep.TextChanged += textBoxStartStep_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(306, 375);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(535, 12);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(224, 309);
            textBoxResult.TabIndex = 3;
            textBoxResult.TextChanged += textBoxResult_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 342);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 4;
            label1.Text = "Старт шага\r\n";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(318, 342);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 5;
            label2.Text = "Конец шага";
            label2.Click += label2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(44, 26);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(406, 235);
            textBox2.TabIndex = 6;
            textBox2.Text = "\r\nТУТ УСЛОВИЕ ЗАДАНИЯ ДОЛЖНО БЫТЬ\r\n";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxResult);
            Controls.Add(textBox1);
            Controls.Add(textBoxStartStep);
            Controls.Add(button1);
            Name = "FormMain";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBoxStartStep;
        private TextBox textBox1;
        private TextBox textBoxResult;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
    }
}
