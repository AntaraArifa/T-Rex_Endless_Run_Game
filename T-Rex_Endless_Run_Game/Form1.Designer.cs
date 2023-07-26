namespace T_Rex_Endless_Run_Game
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
            this.floor = new System.Windows.Forms.PictureBox();
            this.Trex = new System.Windows.Forms.PictureBox();
            this.obstacle1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtscore = new System.Windows.Forms.Label();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.show = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // floor
            // 
            this.floor.BackColor = System.Drawing.Color.Navy;
            this.floor.Location = new System.Drawing.Point(-5, 471);
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(921, 74);
            this.floor.TabIndex = 0;
            this.floor.TabStop = false;
            this.floor.Click += new System.EventHandler(this.floor_Click);
            // 
            // Trex
            // 
            this.Trex.BackgroundImage = global::T_Rex_Endless_Run_Game.Properties.Resources.running;
            this.Trex.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Trex.Location = new System.Drawing.Point(115, 405);
            this.Trex.Name = "Trex";
            this.Trex.Size = new System.Drawing.Size(55, 65);
            this.Trex.TabIndex = 1;
            this.Trex.TabStop = false;
            this.Trex.Click += new System.EventHandler(this.Trex_Click);
            // 
            // obstacle1
            // 
            this.obstacle1.BackgroundImage = global::T_Rex_Endless_Run_Game.Properties.Resources.obstacle_1;
            this.obstacle1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.obstacle1.Location = new System.Drawing.Point(333, 435);
            this.obstacle1.Name = "obstacle1";
            this.obstacle1.Size = new System.Drawing.Size(25, 35);
            this.obstacle1.TabIndex = 2;
            this.obstacle1.TabStop = false;
            this.obstacle1.Tag = "obstacle1";
            this.obstacle1.Click += new System.EventHandler(this.obstacle1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::T_Rex_Endless_Run_Game.Properties.Resources.obstacle_2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(591, 430);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 40);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "obstacle2";
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtscore
            // 
            this.txtscore.AutoSize = true;
            this.txtscore.BackColor = System.Drawing.Color.AliceBlue;
            this.txtscore.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtscore.Location = new System.Drawing.Point(3, 3);
            this.txtscore.Name = "txtscore";
            this.txtscore.Size = new System.Drawing.Size(93, 26);
            this.txtscore.TabIndex = 4;
            this.txtscore.Text = "Score : 0";
            this.txtscore.Click += new System.EventHandler(this.txtscore_Click);
            // 
            // gametimer
            // 
            this.gametimer.Enabled = true;
            this.gametimer.Interval = 20;
            this.gametimer.Tick += new System.EventHandler(this.gameevent);
            // 
            // show
            // 
            this.show.AutoSize = true;
            this.show.BackColor = System.Drawing.Color.AliceBlue;
            this.show.Font = new System.Drawing.Font("Microsoft PhagsPa", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show.Location = new System.Drawing.Point(328, 234);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(80, 37);
            this.show.TabIndex = 5;
            this.show.Text = "label";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(907, 543);
            this.Controls.Add(this.show);
            this.Controls.Add(this.txtscore);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.obstacle1);
            this.Controls.Add(this.Trex);
            this.Controls.Add(this.floor);
            this.Name = "Form1";
            this.Text = "T-Rex_Endless_Run_Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.floor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox floor;
        private System.Windows.Forms.PictureBox Trex;
        private System.Windows.Forms.PictureBox obstacle1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtscore;
        private System.Windows.Forms.Timer gametimer;
        private System.Windows.Forms.Label show;
    }
}

