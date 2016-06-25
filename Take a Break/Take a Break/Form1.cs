using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;
using System.Media;

namespace Take_a_Break
{
    public partial class Form1 : Form
    {
        RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
        private int scheck = 0;

        public Form1()
        {
            reg.SetValue("My app", Application.ExecutablePath.ToString());
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Visible = false;
            progressBar1.Visible = false;
            breaklbl.Visible = false;
            this.Height = 135;
        }

        private void timers_Tick(object sender, EventArgs e)
        {
           
            timelbls.Text = Convert.ToString(int.Parse(timelbls.Text) + 1);
            if (timelbls.Text == "10")
            {
                timelblm.Text = Convert.ToString(int.Parse(timelblm.Text) + 1);
                timelbls.Text = "0";
            }
            if (timelblm.Text == "6")
            {
                timelblh.Text = Convert.ToString(int.Parse(timelblh.Text) + 1);
                timelblm.Text = "0";
                scheck++;
            }
            if (timelblh.Text == "10")
            {
                timelblh2.Text = Convert.ToString(int.Parse(timelblh2.Text) + 1);
                timelblh.Text = "0";
            }
            //timer 15 minutes
            if (timelbls.Text == "5" && timelblm.Text == "1" || timelbls.Text == "0" && timelblm.Text == "3" || timelbls.Text == "5" && timelblm.Text == "4" || timelbls.Text == "0" && timelblm.Text == "6")
            {
                button1.Visible = true;
                progressBar1.Visible = true;
                breaklbl.Visible = true;
                breaklbl.Text = "Go look at a far object for 20 seconds";
                progressBar1.Value = 0;
                this.Height = 340;
                this.Show();
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                timers.Stop();
                button2.Hide();
                timer15.Start();
            }
            //timer 2 hours
            if (scheck==2)
            {
                button1.Visible = true;
                progressBar1.Visible = true;
                breaklbl.Visible = true;
                breaklbl.Text = "Take a break for 10 minutes";
                progressBar1.Value = 0;
                this.Height = 340;
                scheck = 0;
                this.Show();
                this.WindowState = FormWindowState.Normal;
                timers.Stop();
                button2.Hide();
                timer2.Start();
            }
        }

        private void timer15_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value!=100 && breaklbl.Text == "Go look at a far object for 20 seconds")
            {
                progressBar1.Value += 5;
            }
            else
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.beep_07);
                player.Play();
                timer15.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != 100 && breaklbl.Text == "Take a break for 10 minutes")
            {
                progressBar1.Value += 10;
            }
            else
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.beep_07);
                player.Play();
                timer2.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value == 100 && breaklbl.Text == "Go look at a far object for 20 seconds"|| progressBar1.Value == 100 && breaklbl.Text == "Take a break for 10 minutes")
            {
                button1.Visible = false;
                progressBar1.Visible = false;
                breaklbl.Visible = false;
                this.Height = 135;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                timers.Start();
                button2.Show();
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                mynotifyicon.Visible = true;
                this.Hide();
            }

            else if (FormWindowState.Normal == this.WindowState)
            {
                mynotifyicon.Visible = false;
            }
        }

        private void mynotifyicon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Aboutbox = new AboutBox1();
            Aboutbox.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
