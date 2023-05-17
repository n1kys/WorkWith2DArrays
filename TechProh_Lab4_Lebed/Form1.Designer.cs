namespace TechProg_Lab4_Lebed
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
            generateButton = new Button();
            aboutAuthor = new Button();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            maxUpDown3 = new NumericUpDown();
            minUpDown2 = new NumericUpDown();
            sizeUpDown1 = new NumericUpDown();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)maxUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sizeUpDown1).BeginInit();
            SuspendLayout();
            // 
            // generateButton
            // 
            generateButton.Location = new Point(12, 130);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(108, 23);
            generateButton.TabIndex = 0;
            generateButton.Text = "Generate";
            generateButton.UseVisualStyleBackColor = true;
            generateButton.Click += generateButton_Click;
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
            groupBox1.Controls.Add(maxUpDown3);
            groupBox1.Controls.Add(minUpDown2);
            groupBox1.Controls.Add(sizeUpDown1);
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
            // maxUpDown3
            // 
            maxUpDown3.Location = new Point(124, 80);
            maxUpDown3.Name = "maxUpDown3";
            maxUpDown3.Size = new Size(92, 23);
            maxUpDown3.TabIndex = 2;
            // 
            // minUpDown2
            // 
            minUpDown2.Location = new Point(124, 51);
            minUpDown2.Name = "minUpDown2";
            minUpDown2.Size = new Size(92, 23);
            minUpDown2.TabIndex = 1;
            // 
            // sizeUpDown1
            // 
            sizeUpDown1.Location = new Point(124, 22);
            sizeUpDown1.Name = "sizeUpDown1";
            sizeUpDown1.Size = new Size(92, 23);
            sizeUpDown1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(244, 163);
            Controls.Add(groupBox1);
            Controls.Add(aboutAuthor);
            Controls.Add(generateButton);
            Name = "Form1";
            Text = "2DArraysProgram";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)maxUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)minUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)sizeUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button generateButton;
        private Button aboutAuthor;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown maxUpDown3;
        private NumericUpDown minUpDown2;
        private NumericUpDown sizeUpDown1;
    }
}