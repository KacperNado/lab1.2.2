namespace lab1._2._2
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
            txtSecNo = new TextBox();
            txtResult = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtFirstNo = new TextBox();
            SuspendLayout();
            // 
            // txtSecNo
            // 
            txtSecNo.Location = new Point(287, 110);
            txtSecNo.Name = "txtSecNo";
            txtSecNo.Size = new Size(192, 23);
            txtSecNo.TabIndex = 1;
            txtSecNo.Tag = "txtSecNo";
            txtSecNo.TextChanged += textBox2_TextChanged;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(287, 203);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(192, 23);
            txtResult.TabIndex = 2;
            txtResult.Tag = "txtResult";
            txtResult.TextChanged += textBox3_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(287, 174);
            button1.Name = "button1";
            button1.Size = new Size(86, 23);
            button1.TabIndex = 3;
            button1.Text = "Dodaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(394, 174);
            button2.Name = "button2";
            button2.Size = new Size(85, 23);
            button2.TabIndex = 4;
            button2.Text = "Odejmij";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(205, 61);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 5;
            label1.Text = "First Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(188, 118);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 6;
            label2.Text = "Second Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(242, 211);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 7;
            label3.Text = "Result";
            // 
            // txtFirstNo
            // 
            txtFirstNo.Location = new Point(287, 65);
            txtFirstNo.Name = "txtFirstNo";
            txtFirstNo.Size = new Size(192, 23);
            txtFirstNo.TabIndex = 9;
            txtFirstNo.Tag = "txtFirstNo";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtFirstNo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtResult);
            Controls.Add(txtSecNo);
            Name = "Form1";
            Text = "Form1";
            ParentChanged += Form1_ParentChanged;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtSecNo;
        private TextBox txtResult;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtFirstNo;
    }
}
