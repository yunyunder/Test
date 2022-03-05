namespace hw5_marquee_and_animation_with_timers
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelSpeed = new System.Windows.Forms.Label();
            this.numericUpSpeed = new System.Windows.Forms.NumericUpDown();
            this.pictureBoxFrogs = new System.Windows.Forms.PictureBox();
            this.timer_Animation = new System.Windows.Forms.Timer(this.components);
            this.imageListFrog = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFrogs)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSpeed.Location = new System.Drawing.Point(63, 85);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(91, 30);
            this.labelSpeed.TabIndex = 0;
            this.labelSpeed.Text = "Speed:";
            // 
            // numericUpSpeed
            // 
            this.numericUpSpeed.Location = new System.Drawing.Point(160, 85);
            this.numericUpSpeed.Name = "numericUpSpeed";
            this.numericUpSpeed.Size = new System.Drawing.Size(88, 30);
            this.numericUpSpeed.TabIndex = 1;
            this.numericUpSpeed.ValueChanged += new System.EventHandler(this.numericUpSpeed_ValueChanged);
            // 
            // pictureBoxFrogs
            // 
            this.pictureBoxFrogs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxFrogs.Location = new System.Drawing.Point(252, 157);
            this.pictureBoxFrogs.Name = "pictureBoxFrogs";
            this.pictureBoxFrogs.Size = new System.Drawing.Size(262, 210);
            this.pictureBoxFrogs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFrogs.TabIndex = 2;
            this.pictureBoxFrogs.TabStop = false;
            this.pictureBoxFrogs.Click += new System.EventHandler(this.pictFrogs_Click);
            // 
            // timer_Animation
            // 
            this.timer_Animation.Tick += new System.EventHandler(this.timerAnimation_Tick);
            // 
            // imageListFrog
            // 
            this.imageListFrog.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListFrog.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListFrog.ImageStream")));
            this.imageListFrog.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListFrog.Images.SetKeyName(0, "p1.gif");
            this.imageListFrog.Images.SetKeyName(1, "p2.gif");
            this.imageListFrog.Images.SetKeyName(2, "p3.gif");
            this.imageListFrog.Images.SetKeyName(3, "p4.gif");
            this.imageListFrog.Images.SetKeyName(4, "p5.gif");
            this.imageListFrog.Images.SetKeyName(5, "p6.gif");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxFrogs);
            this.Controls.Add(this.numericUpSpeed);
            this.Controls.Add(this.labelSpeed);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFrogs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelSpeed;
        private NumericUpDown numericUpSpeed;
        private PictureBox pictureBoxFrogs;
        private System.Windows.Forms.Timer timer_Animation;
        private ImageList imageListFrog;
    }
}