﻿namespace BombsAway
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer_Gravity = new System.Windows.Forms.Timer(this.components);
            this.timer_Jump = new System.Windows.Forms.Timer(this.components);
            this.timer_Anim = new System.Windows.Forms.Timer(this.components);
            this.timer_Sec = new System.Windows.Forms.Timer(this.components);
            this.WorldFloor = new System.Windows.Forms.Panel();
            this.WorldFrame = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pb_NPC2 = new System.Windows.Forms.PictureBox();
            this.pb_NPC1 = new System.Windows.Forms.PictureBox();
            this.label_Dead = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Score = new System.Windows.Forms.Label();
            this.pb_Player = new System.Windows.Forms.PictureBox();
            this.enemytimer = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.WorldFrame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_NPC2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_NPC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Player)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.debugToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(110, 26);
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onToolStripMenuItem,
            this.offToolStripMenuItem});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // onToolStripMenuItem
            // 
            this.onToolStripMenuItem.Name = "onToolStripMenuItem";
            this.onToolStripMenuItem.Size = new System.Drawing.Size(91, 22);
            this.onToolStripMenuItem.Text = "On";
            this.onToolStripMenuItem.Click += new System.EventHandler(this.onToolStripMenuItem_Click);
            // 
            // offToolStripMenuItem
            // 
            this.offToolStripMenuItem.Name = "offToolStripMenuItem";
            this.offToolStripMenuItem.Size = new System.Drawing.Size(91, 22);
            this.offToolStripMenuItem.Text = "Off";
            this.offToolStripMenuItem.Click += new System.EventHandler(this.offToolStripMenuItem_Click);
            // 
            // timer_Gravity
            // 
            this.timer_Gravity.Enabled = true;
            this.timer_Gravity.Interval = 1;
            this.timer_Gravity.Tick += new System.EventHandler(this.timer_Gravity_Tick);
            // 
            // timer_Jump
            // 
            this.timer_Jump.Enabled = true;
            this.timer_Jump.Interval = 1;
            this.timer_Jump.Tick += new System.EventHandler(this.timer_Jump_Tick);
            // 
            // timer_Anim
            // 
            this.timer_Anim.Enabled = true;
            this.timer_Anim.Interval = 1;
            this.timer_Anim.Tick += new System.EventHandler(this.timer_Anim_Tick);
            // 
            // timer_Sec
            // 
            this.timer_Sec.Enabled = true;
            this.timer_Sec.Interval = 1000;
            this.timer_Sec.Tick += new System.EventHandler(this.timer_Sec_Tick);
            // 
            // WorldFloor
            // 
            this.WorldFloor.BackgroundImage = global::BombsAway.Properties.Resources.floor;
            this.WorldFloor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.WorldFloor.Location = new System.Drawing.Point(0, 240);
            this.WorldFloor.Name = "WorldFloor";
            this.WorldFloor.Size = new System.Drawing.Size(656, 32);
            this.WorldFloor.TabIndex = 1;
            // 
            // WorldFrame
            // 
            this.WorldFrame.BackColor = System.Drawing.Color.SkyBlue;
            this.WorldFrame.BackgroundImage = global::BombsAway.World.beach_background;
            this.WorldFrame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WorldFrame.ContextMenuStrip = this.contextMenuStrip1;
            this.WorldFrame.Controls.Add(this.label1);
            this.WorldFrame.Controls.Add(this.pb_NPC2);
            this.WorldFrame.Controls.Add(this.pb_NPC1);
            this.WorldFrame.Controls.Add(this.label_Dead);
            this.WorldFrame.Controls.Add(this.label2);
            this.WorldFrame.Controls.Add(this.label_Score);
            this.WorldFrame.Controls.Add(this.pb_Player);
            this.WorldFrame.Dock = System.Windows.Forms.DockStyle.Top;
            this.WorldFrame.Location = new System.Drawing.Point(0, 0);
            this.WorldFrame.Name = "WorldFrame";
            this.WorldFrame.Size = new System.Drawing.Size(656, 241);
            this.WorldFrame.TabIndex = 0;
            this.WorldFrame.Paint += new System.Windows.Forms.PaintEventHandler(this.WorldFrame_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Time Left:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pb_NPC2
            // 
            this.pb_NPC2.BackColor = System.Drawing.Color.Transparent;
            this.pb_NPC2.BackgroundImage = global::BombsAway.World.beach_background;
            this.pb_NPC2.Image = global::BombsAway.Enemy.Enemy_left;
            this.pb_NPC2.Location = new System.Drawing.Point(85, 131);
            this.pb_NPC2.Name = "pb_NPC2";
            this.pb_NPC2.Size = new System.Drawing.Size(43, 52);
            this.pb_NPC2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_NPC2.TabIndex = 10;
            this.pb_NPC2.TabStop = false;
            // 
            // pb_NPC1
            // 
            this.pb_NPC1.BackColor = System.Drawing.Color.Transparent;
            this.pb_NPC1.Image = global::BombsAway.Properties.Resources.Enemy_right;
            this.pb_NPC1.Location = new System.Drawing.Point(513, 156);
            this.pb_NPC1.Name = "pb_NPC1";
            this.pb_NPC1.Size = new System.Drawing.Size(43, 52);
            this.pb_NPC1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_NPC1.TabIndex = 9;
            this.pb_NPC1.TabStop = false;
            // 
            // label_Dead
            // 
            this.label_Dead.AutoSize = true;
            this.label_Dead.BackColor = System.Drawing.Color.Transparent;
            this.label_Dead.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Dead.Location = new System.Drawing.Point(236, 113);
            this.label_Dead.Name = "label_Dead";
            this.label_Dead.Size = new System.Drawing.Size(61, 13);
            this.label_Dead.TabIndex = 1;
            label_Dead.Text = "You died. Press Space to restart.";
            this.label_Dead.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(4, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Highscore: 0";
            // 
            // label_Score
            // 
            this.label_Score.AutoSize = true;
            this.label_Score.BackColor = System.Drawing.Color.Transparent;
            this.label_Score.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Score.Location = new System.Drawing.Point(4, 9);
            this.label_Score.Name = "label_Score";
            this.label_Score.Size = new System.Drawing.Size(55, 13);
            this.label_Score.TabIndex = 2;
            this.label_Score.Text = "Score: 0";
            // 
            // pb_Player
            // 
            this.pb_Player.BackColor = System.Drawing.Color.Transparent;
            this.pb_Player.Image = global::BombsAway.Character.stand_r;
            this.pb_Player.Location = new System.Drawing.Point(250, 131);
            this.pb_Player.Name = "pb_Player";
            this.pb_Player.Size = new System.Drawing.Size(32, 50);
            this.pb_Player.TabIndex = 0;
            this.pb_Player.TabStop = false;
            // 
            // enemytimer
            // 
            this.enemytimer.Interval = 1000;
            this.enemytimer.Tick += new System.EventHandler(this.enemytimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 272);
            this.Controls.Add(this.WorldFloor);
            this.Controls.Add(this.WorldFrame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.contextMenuStrip1.ResumeLayout(false);
            this.WorldFrame.ResumeLayout(false);
            this.WorldFrame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_NPC2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_NPC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel WorldFrame;
        private System.Windows.Forms.Panel WorldFloor;
        private System.Windows.Forms.PictureBox pb_Player;
        private System.Windows.Forms.Timer timer_Gravity;
        private System.Windows.Forms.Timer timer_Jump;
        private System.Windows.Forms.Timer timer_Anim;
        //private System.Windows.Forms.Timer timer_Randombomb;
        //private System.Windows.Forms.Timer timer_BombFailsafe;
        private System.Windows.Forms.Label label_Dead;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.Label label_Score;
        private System.Windows.Forms.Timer timer_Sec;
        //private System.Windows.Forms.Label label1;
        //private System.Windows.Forms.Timer timerBoomRemove;
        private System.Windows.Forms.Label label2;
        //private System.Windows.Forms.PictureBox pb_Pipe;
        //private System.Windows.Forms.Label debug_Log;
        //private System.Windows.Forms.PictureBox pb_Block1;
        //private System.Windows.Forms.PictureBox pb_Block2;
        /*private System.Windows.Forms.Label debug_Godmode;
        private System.Windows.Forms.Label debug_NoBombs;
        private System.Windows.Forms.Label debug_MGravity;
        private System.Windows.Forms.Label debug_PGravity;
        private System.Windows.Forms.Label debug_MSpeed;
        private System.Windows.Forms.Label debug_PSpeed;
        private System.Windows.Forms.Label debug_MJump;
        private System.Windows.Forms.Label debug_PJump;*/
        private System.Windows.Forms.ToolStripMenuItem onToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem offToolStripMenuItem;
        private System.Windows.Forms.PictureBox pb_NPC1;
        private System.Windows.Forms.PictureBox pb_NPC2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer enemytimer;
    }
}

