namespace TechProh_Lab4_Lebed
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
            button1 = new Button();
            aboutAuthor = new Button();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            numericUpDown3 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 130);
            button1.Name = "button1";
            button1.Size = new Size(108, 23);
            button1.TabIndex = 0;
            button1.Text = "Generate";
            button1.UseVisualStyleBackColor = true;
            // 
            // aboutAuthor
            // 
            aboutAuthor.Location = new Point(126, 130);
            aboutAuthor.Name = "aboutAuthor";
            aboutAuthor.Size = new Size(108, 23);
            aboutAuthor.TabIndex = 1;
            aboutAuthor.Text = "About author";
            aboutAuthor.UseVisualStyleBackColor = true;
            aboutAuthor.Click += aboutAuthor_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(numericUpDown3);
            groupBox1.Controls.Add(numericUpDown2);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(222, 112);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Input data";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 82);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 4;
            label3.Text = "Max";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 53);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 3;
            label2.Text = "Min";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 24);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 3;
            label1.Text = "Size of array";
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(124, 80);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(92, 23);
            numericUpDown3.TabIndex = 2;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(124, 51);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(92, 23);
            numericUpDown2.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(124, 22);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(92, 23);
            numericUpDown1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(244, 163);
            Controls.Add(groupBox1);
            Controls.Add(aboutAuthor);
            Controls.Add(button1);
            Name = "Form1";
            Text = "2DArraysProgram";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button aboutAuthor;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
    }
}