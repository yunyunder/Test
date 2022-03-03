namespace hw1
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputBox1 = new System.Windows.Forms.GroupBox();
            this.numBox2 = new System.Windows.Forms.TextBox();
            this.numBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.outputBox2 = new System.Windows.Forms.GroupBox();
            this.sumBox = new System.Windows.Forms.TextBox();
            this.sumButton = new System.Windows.Forms.Button();
            this.inputBox1.SuspendLayout();
            this.outputBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hello World!";
            // 
            // inputBox1
            // 
            this.inputBox1.Controls.Add(this.numBox2);
            this.inputBox1.Controls.Add(this.numBox1);
            this.inputBox1.Controls.Add(this.label2);
            this.inputBox1.Controls.Add(this.label3);
            this.inputBox1.Location = new System.Drawing.Point(59, 114);
            this.inputBox1.Name = "inputBox1";
            this.inputBox1.Size = new System.Drawing.Size(300, 228);
            this.inputBox1.TabIndex = 1;
            this.inputBox1.TabStop = false;
            this.inputBox1.Text = "Input Value";
            // 
            // numBox2
            // 
            this.numBox2.Location = new System.Drawing.Point(104, 134);
            this.numBox2.Name = "numBox2";
            this.numBox2.Size = new System.Drawing.Size(150, 30);
            this.numBox2.TabIndex = 4;
            this.numBox2.TextChanged += new System.EventHandler(this.numBox2_TextChanged);
            // 
            // numBox1
            // 
            this.numBox1.Location = new System.Drawing.Point(104, 55);
            this.numBox1.Name = "numBox1";
            this.numBox1.Size = new System.Drawing.Size(150, 30);
            this.numBox1.TabIndex = 3;
            this.numBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "No.1=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "No.2=";
            // 
            // outputBox2
            // 
            this.outputBox2.Controls.Add(this.sumBox);
            this.outputBox2.Controls.Add(this.sumButton);
            this.outputBox2.Location = new System.Drawing.Point(410, 123);
            this.outputBox2.Name = "outputBox2";
            this.outputBox2.Size = new System.Drawing.Size(300, 219);
            this.outputBox2.TabIndex = 0;
            this.outputBox2.TabStop = false;
            this.outputBox2.Text = "Output Summation";
            // 
            // sumBox
            // 
            this.sumBox.Location = new System.Drawing.Point(38, 99);
            this.sumBox.Name = "sumBox";
            this.sumBox.ReadOnly = true;
            this.sumBox.Size = new System.Drawing.Size(86, 30);
            this.sumBox.TabIndex = 1;
            this.sumBox.TextChanged += new System.EventHandler(this.sumBox_TextChanged);
            // 
            // sumButton
            // 
            this.sumButton.Location = new System.Drawing.Point(167, 95);
            this.sumButton.Name = "sumButton";
            this.sumButton.Size = new System.Drawing.Size(112, 34);
            this.sumButton.TabIndex = 0;
            this.sumButton.Text = "Sum";
            this.sumButton.UseVisualStyleBackColor = true;
            this.sumButton.Click += new System.EventHandler(this.sumButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputBox2);
            this.Controls.Add(this.inputBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.inputBox1.ResumeLayout(false);
            this.inputBox1.PerformLayout();
            this.outputBox2.ResumeLayout(false);
            this.outputBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox inputBox1;
        private TextBox numBox2;
        private TextBox numBox1;
        private Label label2;
        private Label label3;
        private GroupBox outputBox2;
        private TextBox sumBox;
        private Button sumButton;
    }
}