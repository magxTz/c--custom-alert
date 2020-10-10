using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagX_CustomAlerts
{
    public partial class AlertShow : Form
    {
        public AlertShow(string message,alertType type,string caption=" ")
        {
            InitializeComponent();
            switch (type)
            {
                case alertType.success:
                    if(caption==" ")
                        captionLbl.Text = type.ToString();
                    else
                        captionLbl.Text =caption;
                    msgLabel.Text = message;
                    this.BackColor = Color.FromArgb(38, 121, 81);
                    pictureBox1.Image = imageList1.Images[2];
                    break;
                case alertType.error:
                    if (caption == " ")
                        captionLbl.Text = type.ToString();
                    else
                        captionLbl.Text = caption;
                    captionLbl.Text = type.ToString();
                    msgLabel.Text = message;
                    this.BackColor = Color.FromArgb(212, 24, 16);
                    pictureBox1.Image = imageList1.Images[3];
                    break;
                case alertType.warning:
                    if (caption == " ")
                        captionLbl.Text = type.ToString();
                    else
                        captionLbl.Text = caption;
                    captionLbl.Text = type.ToString();
                    msgLabel.Text = message;
                    this.BackColor = Color.FromArgb(255, 128, 0);
                    pictureBox1.Image = imageList1.Images[1];
                    break;
                case alertType.information:
                    if (caption == " ")
                        captionLbl.Text = type.ToString();
                    else
                        captionLbl.Text = caption;
                    captionLbl.Text = type.ToString();
                    msgLabel.Text = message;
                    this.BackColor = Color.FromArgb(0, 120, 215);
                    pictureBox1.Image = imageList1.Images[0];
                    break;

            }
        }
        public enum alertType
        {
            warning,information,success,error
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            fadeout.Start();
            timeoutTimer.Stop();

        }

        private void AlertShow_Load(object sender, EventArgs e)
        {
            this.Top = intro.dragLimit - this.Height;
            this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width-30;
         
            show.Start();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timeout(object sender, EventArgs e)
        {
            fadeout.Start();
            timeoutTimer.Stop();
            
        }
  
        
        private void fadeout_Tick(object sender, EventArgs e)
        {  
            
            
            if (Opacity > 0)
            {
                this.Opacity -= .009;
                if (Opacity > 0.7)
                    this.Left -= 1;
                else
                    this.Left += 10;
            }
            else {
                fadeout.Stop();
                this.Close();
                intro.dragLimit -= (this.Height+1);
            }

               
            
        }
        int interval = 0;
        private void show_Tick(object sender, EventArgs e)
        {
            if (this.Top <intro.dragLimit-this.Height) 
            {
                this.Top += interval;
                interval += 2;
            }
            else
                show.Stop();
            
        }
    }
}
