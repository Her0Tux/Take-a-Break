namespace Take_a_Break
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timelblh2 = new System.Windows.Forms.Label();
            this.breaklbl = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer15 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timers = new System.Windows.Forms.Timer(this.components);
            this.timelblh = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timelbls = new System.Windows.Forms.Label();
            this.timelblm = new System.Windows.Forms.Label();
            this.mynotifyicon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(12, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(434, 115);
            this.button1.TabIndex = 0;
            this.button1.Text = "Keep on working";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Miriam Fixed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time On Computer :";
            // 
            // timelblh2
            // 
            this.timelblh2.AutoSize = true;
            this.timelblh2.Font = new System.Drawing.Font("Miriam Fixed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.timelblh2.Location = new System.Drawing.Point(169, 55);
            this.timelblh2.Name = "timelblh2";
            this.timelblh2.Size = new System.Drawing.Size(36, 35);
            this.timelblh2.TabIndex = 2;
            this.timelblh2.Text = "0";
            // 
            // breaklbl
            // 
            this.breaklbl.AutoSize = true;
            this.breaklbl.Font = new System.Drawing.Font("Miriam Fixed", 14F);
            this.breaklbl.ForeColor = System.Drawing.Color.Red;
            this.breaklbl.Location = new System.Drawing.Point(32, 111);
            this.breaklbl.Name = "breaklbl";
            this.breaklbl.Size = new System.Drawing.Size(306, 19);
            this.breaklbl.TabIndex = 3;
            this.breaklbl.Text = "Take a break for 15 seconds";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(36, 142);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(384, 23);
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Value = 33;
            // 
            // timer15
            // 
            this.timer15.Interval = 1000;
            this.timer15.Tick += new System.EventHandler(this.timer15_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 60000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timers
            // 
            this.timers.Enabled = true;
            this.timers.Interval = 60000;
            this.timers.Tick += new System.EventHandler(this.timers_Tick);
            // 
            // timelblh
            // 
            this.timelblh.AutoSize = true;
            this.timelblh.Font = new System.Drawing.Font("Miriam Fixed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.timelblh.Location = new System.Drawing.Point(196, 55);
            this.timelblh.Name = "timelblh";
            this.timelblh.Size = new System.Drawing.Size(36, 35);
            this.timelblh.TabIndex = 5;
            this.timelblh.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Miriam Fixed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(221, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 35);
            this.label3.TabIndex = 7;
            this.label3.Text = ":";
            // 
            // timelbls
            // 
            this.timelbls.AutoSize = true;
            this.timelbls.Font = new System.Drawing.Font("Miriam Fixed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.timelbls.Location = new System.Drawing.Point(278, 55);
            this.timelbls.Name = "timelbls";
            this.timelbls.Size = new System.Drawing.Size(36, 35);
            this.timelbls.TabIndex = 9;
            this.timelbls.Text = "0";
            // 
            // timelblm
            // 
            this.timelblm.AutoSize = true;
            this.timelblm.Font = new System.Drawing.Font("Miriam Fixed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.timelblm.Location = new System.Drawing.Point(251, 55);
            this.timelblm.Name = "timelblm";
            this.timelblm.Size = new System.Drawing.Size(36, 35);
            this.timelblm.TabIndex = 8;
            this.timelblm.Text = "0";
            // 
            // mynotifyicon
            // 
            this.mynotifyicon.ContextMenuStrip = this.contextMenuStrip1;
            this.mynotifyicon.Icon = ((System.Drawing.Icon)(resources.GetObject("mynotifyicon.Icon")));
            this.mynotifyicon.Text = "Take a Break";
            this.mynotifyicon.Visible = true;
            this.mynotifyicon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.mynotifyicon_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 48);
            this.contextMenuStrip1.Text = "fdf";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(417, -1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "x";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(458, 301);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.timelbls);
            this.Controls.Add(this.timelblm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timelblh);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.breaklbl);
            this.Controls.Add(this.timelblh2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Take a Break - Yuval Gal";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label timelblh2;
        private System.Windows.Forms.Label breaklbl;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer15;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timers;
        private System.Windows.Forms.Label timelblh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label timelbls;
        private System.Windows.Forms.Label timelblm;
        private System.Windows.Forms.NotifyIcon mynotifyicon;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

