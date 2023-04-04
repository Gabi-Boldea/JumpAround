namespace Atestat_Boldea_Gabriel
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.player = new System.Windows.Forms.PictureBox();
            this.p1 = new System.Windows.Forms.PictureBox();
            this.p2 = new System.Windows.Forms.PictureBox();
            this.p3 = new System.Windows.Forms.PictureBox();
            this.p4 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.steag = new System.Windows.Forms.PictureBox();
            this.win = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.steag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.win)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Scor:";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::Atestat_Boldea_Gabriel.Properties.Resources.batman_1;
            this.player.Location = new System.Drawing.Point(119, 128);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(45, 48);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.Color.Transparent;
            this.p1.Image = global::Atestat_Boldea_Gabriel.Properties.Resources.platform;
            this.p1.Location = new System.Drawing.Point(104, 213);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(273, 28);
            this.p1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p1.TabIndex = 2;
            this.p1.TabStop = false;
            this.p1.Tag = "platform";
            this.p1.Click += new System.EventHandler(this.p1_Click);
            // 
            // p2
            // 
            this.p2.BackColor = System.Drawing.Color.Transparent;
            this.p2.Image = global::Atestat_Boldea_Gabriel.Properties.Resources.platform;
            this.p2.Location = new System.Drawing.Point(491, 213);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(273, 28);
            this.p2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p2.TabIndex = 3;
            this.p2.TabStop = false;
            this.p2.Tag = "platform";
            // 
            // p3
            // 
            this.p3.BackColor = System.Drawing.Color.Transparent;
            this.p3.Image = global::Atestat_Boldea_Gabriel.Properties.Resources.platform;
            this.p3.Location = new System.Drawing.Point(304, 26);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(273, 28);
            this.p3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p3.TabIndex = 4;
            this.p3.TabStop = false;
            this.p3.Tag = "platform";
            // 
            // p4
            // 
            this.p4.BackColor = System.Drawing.Color.Transparent;
            this.p4.Image = global::Atestat_Boldea_Gabriel.Properties.Resources.platform;
            this.p4.Location = new System.Drawing.Point(705, 26);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(273, 28);
            this.p4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p4.TabIndex = 5;
            this.p4.TabStop = false;
            this.p4.Tag = "platform";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // steag
            // 
            this.steag.BackColor = System.Drawing.Color.Transparent;
            this.steag.Image = global::Atestat_Boldea_Gabriel.Properties.Resources.flag_removebg_preview;
            this.steag.Location = new System.Drawing.Point(673, 245);
            this.steag.Name = "steag";
            this.steag.Size = new System.Drawing.Size(74, 48);
            this.steag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.steag.TabIndex = 6;
            this.steag.TabStop = false;
            this.steag.Tag = "flag";
            // 
            // win
            // 
            this.win.BackColor = System.Drawing.Color.Transparent;
            this.win.Image = global::Atestat_Boldea_Gabriel.Properties.Resources.win2_removebg_preview;
            this.win.Location = new System.Drawing.Point(277, 60);
            this.win.Name = "win";
            this.win.Size = new System.Drawing.Size(218, 147);
            this.win.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.win.TabIndex = 7;
            this.win.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Atestat_Boldea_Gabriel.Properties.Resources.city;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(642, 245);
            this.Controls.Add(this.win);
            this.Controls.Add(this.steag);
            this.Controls.Add(this.p4);
            this.Controls.Add(this.p3);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(795, 284);
            this.MinimumSize = new System.Drawing.Size(647, 284);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gravity Run";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.steag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.win)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox p1;
        private System.Windows.Forms.PictureBox p2;
        private System.Windows.Forms.PictureBox p3;
        private System.Windows.Forms.PictureBox p4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox steag;
        private System.Windows.Forms.PictureBox win;
    }
}

