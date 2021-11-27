
namespace RoflanKurs
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
            this.timerLeft = new System.Windows.Forms.Timer(this.components);
            this.timerRight = new System.Windows.Forms.Timer(this.components);
            this.timerUp = new System.Windows.Forms.Timer(this.components);
            this.timerDown = new System.Windows.Forms.Timer(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.MainSpaceShip = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MainSpaceShip)).BeginInit();
            this.SuspendLayout();
            // 
            // timerLeft
            // 
            this.timerLeft.Interval = 5;
            this.timerLeft.Tick += new System.EventHandler(this.timerLeft_Tick);
            // 
            // timerRight
            // 
            this.timerRight.Interval = 5;
            this.timerRight.Tick += new System.EventHandler(this.timerRight_Tick);
            // 
            // timerUp
            // 
            this.timerUp.Interval = 5;
            this.timerUp.Tick += new System.EventHandler(this.timerUp_Tick);
            // 
            // timerDown
            // 
            this.timerDown.Interval = 5;
            this.timerDown.Tick += new System.EventHandler(this.timerDown_Tick);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainSpaceShip
            // 
            this.MainSpaceShip.BackColor = System.Drawing.Color.Transparent;
            this.MainSpaceShip.Image = global::RoflanKurs.Properties.Resources.kosmolet;
            this.MainSpaceShip.Location = new System.Drawing.Point(486, 356);
            this.MainSpaceShip.Name = "MainSpaceShip";
            this.MainSpaceShip.Size = new System.Drawing.Size(167, 210);
            this.MainSpaceShip.TabIndex = 0;
            this.MainSpaceShip.TabStop = false;
            this.MainSpaceShip.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.MainSpaceShip);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.MainSpaceShip)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox MainSpaceShip;
        private System.Windows.Forms.Timer timerLeft;
        private System.Windows.Forms.Timer timerRight;
        private System.Windows.Forms.Timer timerUp;
        private System.Windows.Forms.Timer timerDown;
    }
}

