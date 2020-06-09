namespace JUMP_BALL
{
    partial class MaimForm
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
            this.MovingPnl = new System.Windows.Forms.Panel();
            this.BasketballPicBx = new System.Windows.Forms.PictureBox();
            this.UpPicBx = new System.Windows.Forms.PictureBox();
            this.LeftPicBx = new System.Windows.Forms.PictureBox();
            this.RightPicBx = new System.Windows.Forms.PictureBox();
            this.DownPicBx = new System.Windows.Forms.PictureBox();
            this.MovingPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BasketballPicBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpPicBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftPicBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightPicBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownPicBx)).BeginInit();
            this.SuspendLayout();
            // 
            // MovingPnl
            // 
            this.MovingPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MovingPnl.Controls.Add(this.BasketballPicBx);
            this.MovingPnl.Location = new System.Drawing.Point(417, 12);
            this.MovingPnl.Name = "MovingPnl";
            this.MovingPnl.Size = new System.Drawing.Size(348, 259);
            this.MovingPnl.TabIndex = 4;
            // 
            // BasketballPicBx
            // 
            this.BasketballPicBx.Image = global::JUMP_BALL.Properties.Resources.basketball;
            this.BasketballPicBx.Location = new System.Drawing.Point(134, 95);
            this.BasketballPicBx.Name = "BasketballPicBx";
            this.BasketballPicBx.Size = new System.Drawing.Size(100, 50);
            this.BasketballPicBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BasketballPicBx.TabIndex = 0;
            this.BasketballPicBx.TabStop = false;
            // 
            // UpPicBx
            // 
            this.UpPicBx.Image = global::JUMP_BALL.Properties.Resources.up;
            this.UpPicBx.Location = new System.Drawing.Point(174, 28);
            this.UpPicBx.Name = "UpPicBx";
            this.UpPicBx.Size = new System.Drawing.Size(100, 50);
            this.UpPicBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UpPicBx.TabIndex = 5;
            this.UpPicBx.TabStop = false;
            this.UpPicBx.Click += new System.EventHandler(this.UpPicBx_Click);
            // 
            // LeftPicBx
            // 
            this.LeftPicBx.Image = global::JUMP_BALL.Properties.Resources.left;
            this.LeftPicBx.Location = new System.Drawing.Point(75, 124);
            this.LeftPicBx.Name = "LeftPicBx";
            this.LeftPicBx.Size = new System.Drawing.Size(100, 50);
            this.LeftPicBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LeftPicBx.TabIndex = 3;
            this.LeftPicBx.TabStop = false;
            this.LeftPicBx.Click += new System.EventHandler(this.LeftPicBx_Click);
            // 
            // RightPicBx
            // 
            this.RightPicBx.Image = global::JUMP_BALL.Properties.Resources.right;
            this.RightPicBx.Location = new System.Drawing.Point(273, 124);
            this.RightPicBx.Name = "RightPicBx";
            this.RightPicBx.Size = new System.Drawing.Size(100, 50);
            this.RightPicBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RightPicBx.TabIndex = 2;
            this.RightPicBx.TabStop = false;
            this.RightPicBx.Click += new System.EventHandler(this.RightPicBx_Click);
            // 
            // DownPicBx
            // 
            this.DownPicBx.Image = global::JUMP_BALL.Properties.Resources.down;
            this.DownPicBx.Location = new System.Drawing.Point(174, 221);
            this.DownPicBx.Name = "DownPicBx";
            this.DownPicBx.Size = new System.Drawing.Size(100, 50);
            this.DownPicBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DownPicBx.TabIndex = 1;
            this.DownPicBx.TabStop = false;
            this.DownPicBx.Click += new System.EventHandler(this.DownPicBx_Click);
            // 
            // MaimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 497);
            this.Controls.Add(this.UpPicBx);
            this.Controls.Add(this.MovingPnl);
            this.Controls.Add(this.LeftPicBx);
            this.Controls.Add(this.RightPicBx);
            this.Controls.Add(this.DownPicBx);
            this.Name = "MaimForm";
            this.Text = "Shoot";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MaimForm_KeyDown);
            this.MovingPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BasketballPicBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpPicBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftPicBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightPicBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownPicBx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox DownPicBx;
        private System.Windows.Forms.PictureBox RightPicBx;
        private System.Windows.Forms.PictureBox LeftPicBx;
        private System.Windows.Forms.Panel MovingPnl;
        private System.Windows.Forms.PictureBox UpPicBx;
        private System.Windows.Forms.PictureBox BasketballPicBx;
    }
}

