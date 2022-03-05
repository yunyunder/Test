namespace hw5_marquee_and_animation_with_timers
{
    public partial class Form1 : Form
    {
        int index = 0;
        const int DEFAUT_INTERVAL = 101;
        int pictureBox_LocX;
        int pictureBox_LocY;
        public Form1()
        {
            InitializeComponent();
            pictureBox_LocX = this.Width / 2 - pictureBoxFrogs.Width / 2;
            pictureBox_LocY = this.Height / 2 - pictureBoxFrogs.Height / 2; 
            pictureBoxFrogs.Location = new Point(pictureBox_LocX, pictureBox_LocY);
        }

        private void pictFrogs_Click(object sender, EventArgs e)
        {

        }
        private void timerAnimation_Tick(object sender, EventArgs e)
        {
            int pictureNum = imageListFrog.Images.Count - 1;
            pictureBoxFrogs.Image = imageListFrog.Images[index];
            index++;
            if (index == pictureNum)
            {
                index = 0;
            }   
            
            if (pictureBox_LocX > -pictureBoxFrogs.Width)
            {
                pictureBox_LocX-=5;
            }
            else
            {
                pictureBox_LocX = this.Width;
            }
            pictureBoxFrogs.Location = new Point(pictureBox_LocX, pictureBox_LocY);
        }

        private void numericUpSpeed_ValueChanged(object sender, EventArgs e)
        {
            int  interval_speed = Convert.ToInt32(numericUpSpeed.Value);
            timer_Animation.Interval = DEFAUT_INTERVAL - interval_speed;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //numericUpSpeed.Value=100;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            if (timer_Animation.Enabled)
            {
                timer_Animation.Stop();
                timer_Animation.Enabled = false;
            }
            else
            {
                timer_Animation.Enabled = true;
                timer_Animation.Start();

            }
            
        }
    }
}