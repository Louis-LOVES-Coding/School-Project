namespace Football_Penalty_Shootout_Game
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
            this.topLeft = new System.Windows.Forms.PictureBox();
            this.left = new System.Windows.Forms.PictureBox();
            this.right = new System.Windows.Forms.PictureBox();
            this.topRight = new System.Windows.Forms.PictureBox();
            this.top = new System.Windows.Forms.PictureBox();
            this.goalKeeper = new System.Windows.Forms.PictureBox();
            this.football = new System.Windows.Forms.PictureBox();
            this.lblMissed = new System.Windows.Forms.Label();
            this.lblGoal = new System.Windows.Forms.Label();
            this.KeeperTimer = new System.Windows.Forms.Timer(this.components);
            this.lblResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.ballTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.topLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goalKeeper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.football)).BeginInit();
            this.SuspendLayout();
            // 
            // topLeft
            // 
            this.topLeft.BackColor = System.Drawing.Color.Transparent;
            this.topLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.topLeft.Image = global::Football_Penalty_Shootout_Game.Properties.Resources.target;
            this.topLeft.Location = new System.Drawing.Point(198, 83);
            this.topLeft.Name = "topLeft";
            this.topLeft.Size = new System.Drawing.Size(40, 38);
            this.topLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.topLeft.TabIndex = 1;
            this.topLeft.TabStop = false;
            this.topLeft.Tag = "topLeft";
            // 
            // left
            // 
            this.left.BackColor = System.Drawing.Color.Transparent;
            this.left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.left.Image = global::Football_Penalty_Shootout_Game.Properties.Resources.target;
            this.left.Location = new System.Drawing.Point(198, 238);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(40, 38);
            this.left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.left.TabIndex = 2;
            this.left.TabStop = false;
            this.left.Tag = "left";
            // 
            // right
            // 
            this.right.BackColor = System.Drawing.Color.Transparent;
            this.right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.right.Image = global::Football_Penalty_Shootout_Game.Properties.Resources.target;
            this.right.Location = new System.Drawing.Point(670, 238);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(40, 38);
            this.right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.right.TabIndex = 3;
            this.right.TabStop = false;
            this.right.Tag = "right";
            // 
            // topRight
            // 
            this.topRight.BackColor = System.Drawing.Color.Transparent;
            this.topRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.topRight.Image = global::Football_Penalty_Shootout_Game.Properties.Resources.target;
            this.topRight.Location = new System.Drawing.Point(670, 83);
            this.topRight.Name = "topRight";
            this.topRight.Size = new System.Drawing.Size(40, 38);
            this.topRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.topRight.TabIndex = 4;
            this.topRight.TabStop = false;
            this.topRight.Tag = "topRight";
            // 
            // top
            // 
            this.top.BackColor = System.Drawing.Color.Transparent;
            this.top.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.top.Image = global::Football_Penalty_Shootout_Game.Properties.Resources.target;
            this.top.Location = new System.Drawing.Point(433, 83);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(40, 38);
            this.top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.top.TabIndex = 5;
            this.top.TabStop = false;
            this.top.Tag = "top";
            // 
            // goalKeeper
            // 
            this.goalKeeper.BackColor = System.Drawing.Color.Transparent;
            this.goalKeeper.Image = global::Football_Penalty_Shootout_Game.Properties.Resources.stand_small;
            this.goalKeeper.Location = new System.Drawing.Point(395, 138);
            this.goalKeeper.Name = "goalKeeper";
            this.goalKeeper.Size = new System.Drawing.Size(106, 165);
            this.goalKeeper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.goalKeeper.TabIndex = 6;
            this.goalKeeper.TabStop = false;
            // 
            // football
            // 
            this.football.BackColor = System.Drawing.Color.Transparent;
            this.football.Image = global::Football_Penalty_Shootout_Game.Properties.Resources.ball;
            this.football.Location = new System.Drawing.Point(413, 461);
            this.football.Name = "football";
            this.football.Size = new System.Drawing.Size(88, 63);
            this.football.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.football.TabIndex = 7;
            this.football.TabStop = false;
            this.football.Tag = "football";
            // 
            // lblMissed
            // 
            this.lblMissed.AutoSize = true;
            this.lblMissed.BackColor = System.Drawing.Color.Transparent;
            this.lblMissed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMissed.ForeColor = System.Drawing.Color.White;
            this.lblMissed.Location = new System.Drawing.Point(12, 16);
            this.lblMissed.Name = "lblMissed";
            this.lblMissed.Size = new System.Drawing.Size(75, 24);
            this.lblMissed.TabIndex = 8;
            this.lblMissed.Text = "Miss: 0";
            // 
            // lblGoal
            // 
            this.lblGoal.AutoSize = true;
            this.lblGoal.BackColor = System.Drawing.Color.Transparent;
            this.lblGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoal.ForeColor = System.Drawing.Color.White;
            this.lblGoal.Location = new System.Drawing.Point(800, 16);
            this.lblGoal.Name = "lblGoal";
            this.lblGoal.Size = new System.Drawing.Size(76, 24);
            this.lblGoal.TabIndex = 10;
            this.lblGoal.Text = "Goal: 0";
            // 
            // KeeperTimer
            // 
            this.KeeperTimer.Interval = 20;
            this.KeeperTimer.Tag = "keeperTimer";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Red;
            this.lblResult.Location = new System.Drawing.Point(362, 359);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 75);
            this.lblResult.TabIndex = 11;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(356, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 75);
            this.label1.TabIndex = 11;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.White;
            this.lblTimer.Location = new System.Drawing.Point(786, 63);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(0, 24);
            this.lblTimer.TabIndex = 12;
            // 
            // ballTimer
            // 
            this.ballTimer.Interval = 20;
            this.ballTimer.Tag = "ballTimer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Football_Penalty_Shootout_Game.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(899, 678);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblGoal);
            this.Controls.Add(this.lblMissed);
            this.Controls.Add(this.football);
            this.Controls.Add(this.goalKeeper);
            this.Controls.Add(this.top);
            this.Controls.Add(this.topRight);
            this.Controls.Add(this.right);
            this.Controls.Add(this.left);
            this.Controls.Add(this.topLeft);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.topLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goalKeeper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.football)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox topLeft;
        private System.Windows.Forms.PictureBox left;
        private System.Windows.Forms.PictureBox right;
        private System.Windows.Forms.PictureBox topRight;
        private System.Windows.Forms.PictureBox top;
        private System.Windows.Forms.PictureBox goalKeeper;
        private System.Windows.Forms.PictureBox football;
        private System.Windows.Forms.Label lblMissed;
        private System.Windows.Forms.Label lblGoal;
        private System.Windows.Forms.Timer KeeperTimer;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer ballTimer;
    }
}

