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
    public partial class intro : Form
    {
        public static int dragLimit =30;
        public intro()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string msg = "The process is successful";
            MagX_Alert(msg, AlertShow.alertType.success);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string msg = "An error occured";
            MagX_Alert(msg, AlertShow.alertType.error);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string msg = "This is a Warning";
            MagX_Alert(msg, AlertShow.alertType.warning);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string msg = "" +
                "this is Information and the program is doing well as intend i am proud to be me This is Information and the program is doing well as intend i am proud to be me";
            MagX_Alert(msg, AlertShow.alertType.information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                double result = Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text);
                string msg = "The sum is :" + result;
                MagX_Alert(msg, AlertShow.alertType.success, "RESULT");
            }
            catch(Exception ex)
            {
                MagX_Alert(ex.ToString(), AlertShow.alertType.error);
            }
        }
        private void MagX_Alert(string message,AlertShow.alertType type, string caption = "") 
        {
            
            AlertShow alt = new AlertShow(message, type, caption);
            alt.Show();
            dragLimit += alt.Height + 1;
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
       
        }
    }
}
