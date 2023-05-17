namespace TechProg_Lab4_Lebed
{
    partial class WorkWithArray
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            resultText = new Label();
            groupBox3 = new GroupBox();
            multiplyButton = new RadioButton();
            sortButton = new RadioButton();
            indexesButton = new RadioButton();
            groupBox4 = new GroupBox();
            button6 = new Button();
            button5 = new Button();
            clearButton = new Button();
            button3 = new Button();
            button2 = new Button();
            runButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(340, 258);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(6, 22);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(372, 240);
            dataGridView2.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(12, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(353, 298);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Started Array";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(resultText);
            groupBox2.Controls.Add(dataGridView2);
            groupBox2.Location = new Point(389, 9);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(390, 298);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Result";
            // 
            // resultText
            // 
            resultText.AutoSize = true;
            resultText.Location = new Point(10, 273);
            resultText.Name = "resultText";
            resultText.Size = new Size(0, 15);
            resultText.TabIndex = 6;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(multiplyButton);
            groupBox3.Controls.Add(sortButton);
            groupBox3.Controls.Add(indexesButton);
            groupBox3.Location = new Point(12, 313);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(353, 129);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Actions";
            // 
            // multiplyButton
            // 
            multiplyButton.AutoSize = true;
            multiplyButton.Location = new Point(6, 94);
            multiplyButton.Name = "multiplyButton";
            multiplyButton.Size = new Size(288, 19);
            multiplyButton.TabIndex = 7;
            multiplyButton.TabStop = true;
            multiplyButton.Text = "Multiply elements of the array miltiply of 3 by (-h)";
            multiplyButton.UseVisualStyleBackColor = true;
            // 
            // sortButton
            // 
            sortButton.AutoSize = true;
            sortButton.Location = new Point(6, 61);
            sortButton.Name = "sortButton";
            sortButton.Size = new Size(337, 19);
            sortButton.TabIndex = 6;
            sortButton.TabStop = true;
            sortButton.Text = "Sort the elements of the array columns in descending order";
            sortButton.UseVisualStyleBackColor = true;
            // 
            // indexesButton
            // 
            indexesButton.AutoSize = true;
            indexesButton.Location = new Point(6, 26);
            indexesButton.Name = "indexesButton";
            indexesButton.Size = new Size(152, 19);
            indexesButton.TabIndex = 5;
            indexesButton.TabStop = true;
            indexesButton.Text = "Index's of the d element";
            indexesButton.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(button6);
            groupBox4.Controls.Add(button5);
            groupBox4.Controls.Add(clearButton);
            groupBox4.Controls.Add(button3);
            groupBox4.Controls.Add(button2);
            groupBox4.Controls.Add(runButton);
            groupBox4.Location = new Point(389, 313);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(390, 129);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Controls";
            // 
            // button6
            // 
            button6.Location = new Point(264, 78);
            button6.Name = "button6";
            button6.Size = new Size(114, 35);
            button6.TabIndex = 11;
            button6.Text = "Write f2";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(138, 78);
            button5.Name = "button5";
            button5.Size = new Size(105, 35);
            button5.TabIndex = 10;
            button5.Text = "Write f1";
            button5.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(6, 78);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(116, 35);
            clearButton.TabIndex = 9;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // button3
            // 
            button3.Location = new Point(264, 26);
            button3.Name = "button3";
            button3.Size = new Size(114, 33);
            button3.TabIndex = 8;
            button3.Text = "Read f2";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(138, 26);
            button2.Name = "button2";
            button2.Size = new Size(105, 33);
            button2.TabIndex = 7;
            button2.Text = "Read f1";
            button2.UseVisualStyleBackColor = true;
            // 
            // runButton
            // 
            runButton.Location = new Point(6, 26);
            runButton.Name = "runButton";
            runButton.Size = new Size(116, 33);
            runButton.TabIndex = 6;
            runButton.Text = "Run";
            runButton.UseVisualStyleBackColor = true;
            runButton.Click += runButton_Click;
            // 
            // WorkWithArray
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 454);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "WorkWithArray";
            Text = "WorkWithArray";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private RadioButton multiplyButton;
        private RadioButton sortButton;
        private RadioButton indexesButton;
        private GroupBox groupBox4;
        private Button button6;
        private Button button5;
        private Button clearButton;
        private Button button3;
        private Button button2;
        private Button runButton;
        private Label resultText;
    }
}