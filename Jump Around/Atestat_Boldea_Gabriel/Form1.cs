using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atestat_Boldea_Gabriel
{
    public partial class Form1 : Form
    {
        #region .. Double Buffered function ..
        public static void SetDoubleBuffered(System.Windows.Forms.Control c)
        {
            if (System.Windows.Forms.SystemInformation.TerminalServerSession)
                return;
            System.Reflection.PropertyInfo aProp = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            aProp.SetValue(c, true, null);
        }
        #endregion

        #region .. code for Flickering ..
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        #endregion

        bool landed = false;
        int gravity = 10;
        int score = 0;
        int platformSpeed = 13;
        bool st = false;
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            steag.Visible = false;
            win.Visible = false;
        }

        private void reset()
        {
            score = 0;
            p1.Width = 273;
            p2.Width = 273;
            p3.Width = 273;
            p4.Width = 273;
            player.Left = 147;
            player.Top = 131;

            p1.Left = 104;
            p1.Top = 213;

            p2.Left = 491;
            p2.Top = 213;

            p3.Left = 304;
            p3.Top = 26;

            p4.Left = 702;
            p4.Top = 26;

            steag.Visible = false;
            steag.Left = -100;
            st = false;

            win.Visible = false;

            timer1.Start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && landed == true)
            {
                gravity = -gravity;
                landed = false;
            }

            if (e.KeyCode == Keys.Escape)
                Application.Exit();

            if (e.KeyCode == Keys.R)
            {
                reset();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            player.Top += gravity;
            player.Left = 80;
            label1.Text = "Score: " + score;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "platform")
                {
                    x.Left -= platformSpeed;

                    if (x.Left < -500)
                    {
                        x.Width = rnd.Next(100, 300);
                        x.Left = 475;
                        score++;
                    }
                }

                if (player.Bounds.IntersectsWith(p2.Bounds) ||
                    player.Bounds.IntersectsWith(p1.Bounds))
                {
                    landed = true;
                    player.Top = p2.Top - player.Height;
                    player.Image = Properties.Resources.batman_1;
                }

                if (player.Bounds.IntersectsWith(p3.Bounds) ||
                    player.Bounds.IntersectsWith(p4.Bounds))
                {
                    landed = true;
                    player.Top = p3.Top + p3.Height;
                    player.Image = Properties.Resources.batman_2;
                }

                if (player.Top < -40 || player.Top > ClientSize.Height)
                {
                    timer1.Stop();
                    label1.Text += " -- Press R to reset";
                }
            }
            if (score % 50 == 0 && score!=0 && !st)
            {
                st=true;
                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox && x.Tag == "flag")
                    {
                        x.Visible = true;
                        //x.Left = 600;
                        //x.Top = 130;
                            x.Left = rnd.Next(500, 700);
                            x.Top = rnd.Next(55, 170);
                    }
                }
            }
            if(st)
            {
                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox && x.Tag == "flag")
                    {
                        x.Left -= platformSpeed;
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            timer1.Stop();
                            label1.Text += " -- Press R to reset";
                            win.Visible = true;
                        }
                        if(x.Right<0)
                        {
                            st = false;
                            x.Visible = false;
                        }
                    }
                }
            }
        }

        private void p1_Click(object sender, EventArgs e)
        {

        }
    }
}
