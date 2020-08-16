namespace Revolver_assignment_1
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
            this.startbtn = new System.Windows.Forms.Button();
            this.loadBtn = new System.Windows.Forms.Button();
            this.spinButton = new System.Windows.Forms.Button();
            this.shootBtn = new System.Windows.Forms.Button();
            this.ShotAwayBtn = new System.Windows.Forms.Button();
            this.GunBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GunBox)).BeginInit();
            this.SuspendLayout();
            // 
            // startbtn
            // 
            this.startbtn.BackColor = System.Drawing.Color.Red;
            this.startbtn.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.startbtn.Location = new System.Drawing.Point(103, 12);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(152, 62);
            this.startbtn.TabIndex = 0;
            this.startbtn.Text = "Game Start";
            this.startbtn.UseVisualStyleBackColor = false;
            this.startbtn.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // loadBtn
            // 
            this.loadBtn.BackColor = System.Drawing.Color.Red;
            this.loadBtn.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loadBtn.Location = new System.Drawing.Point(302, 12);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(152, 62);
            this.loadBtn.TabIndex = 1;
            this.loadBtn.Text = "Load Game";
            this.loadBtn.UseVisualStyleBackColor = false;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // spinButton
            // 
            this.spinButton.BackColor = System.Drawing.Color.Red;
            this.spinButton.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.spinButton.Location = new System.Drawing.Point(511, 12);
            this.spinButton.Name = "spinButton";
            this.spinButton.Size = new System.Drawing.Size(152, 62);
            this.spinButton.TabIndex = 2;
            this.spinButton.Text = "Spin Gun";
            this.spinButton.UseVisualStyleBackColor = false;
            this.spinButton.Click += new System.EventHandler(this.spinButton_Click);
            // 
            // shootBtn
            // 
            this.shootBtn.BackColor = System.Drawing.Color.Red;
            this.shootBtn.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shootBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.shootBtn.Location = new System.Drawing.Point(183, 101);
            this.shootBtn.Name = "shootBtn";
            this.shootBtn.Size = new System.Drawing.Size(152, 62);
            this.shootBtn.TabIndex = 3;
            this.shootBtn.Text = "Shoot Gun";
            this.shootBtn.UseVisualStyleBackColor = false;
            this.shootBtn.Click += new System.EventHandler(this.shootBtn_Click);
            // 
            // ShotAwayBtn
            // 
            this.ShotAwayBtn.BackColor = System.Drawing.Color.Red;
            this.ShotAwayBtn.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShotAwayBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ShotAwayBtn.Location = new System.Drawing.Point(413, 101);
            this.ShotAwayBtn.Name = "ShotAwayBtn";
            this.ShotAwayBtn.Size = new System.Drawing.Size(185, 62);
            this.ShotAwayBtn.TabIndex = 4;
            this.ShotAwayBtn.Text = "Shoot AwayGun";
            this.ShotAwayBtn.UseVisualStyleBackColor = false;
            this.ShotAwayBtn.Click += new System.EventHandler(this.ShotAwayBtn_Click);
            // 
            // GunBox
            // 
            this.GunBox.Location = new System.Drawing.Point(32, 193);
            this.GunBox.Name = "GunBox";
            this.GunBox.Size = new System.Drawing.Size(777, 285);
            this.GunBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GunBox.TabIndex = 5;
            this.GunBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(833, 492);
            this.Controls.Add(this.GunBox);
            this.Controls.Add(this.ShotAwayBtn);
            this.Controls.Add(this.shootBtn);
            this.Controls.Add(this.spinButton);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.startbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GunBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startbtn;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button spinButton;
        private System.Windows.Forms.Button ShotAwayBtn;
        public System.Windows.Forms.PictureBox GunBox;
        public System.Windows.Forms.Button shootBtn;
    }
}

