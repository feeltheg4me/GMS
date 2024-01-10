namespace GymManagement.Forms
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoutButton = new System.Windows.Forms.Button();
            this.paymentsButton = new System.Windows.Forms.Button();
            this.materielsButton = new System.Windows.Forms.Button();
            this.staffButton = new System.Windows.Forms.Button();
            this.membersButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1236, 607);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.membersButton);
            this.panel1.Controls.Add(this.staffButton);
            this.panel1.Controls.Add(this.materielsButton);
            this.panel1.Controls.Add(this.paymentsButton);
            this.panel1.Controls.Add(this.logoutButton);
            this.panel1.Location = new System.Drawing.Point(44, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1148, 57);
            this.panel1.TabIndex = 1;
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(927, 9);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(213, 41);
            this.logoutButton.TabIndex = 0;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // paymentsButton
            // 
            this.paymentsButton.Location = new System.Drawing.Point(471, 9);
            this.paymentsButton.Name = "paymentsButton";
            this.paymentsButton.Size = new System.Drawing.Size(213, 41);
            this.paymentsButton.TabIndex = 1;
            this.paymentsButton.Text = "Payments";
            this.paymentsButton.UseVisualStyleBackColor = true;
            this.paymentsButton.Click += new System.EventHandler(this.paymentsButton_Click);
            // 
            // materielsButton
            // 
            this.materielsButton.Location = new System.Drawing.Point(699, 9);
            this.materielsButton.Name = "materielsButton";
            this.materielsButton.Size = new System.Drawing.Size(213, 41);
            this.materielsButton.TabIndex = 2;
            this.materielsButton.Text = "Materiels";
            this.materielsButton.UseVisualStyleBackColor = true;
            this.materielsButton.Click += new System.EventHandler(this.materielsButton_Click);
            // 
            // staffButton
            // 
            this.staffButton.Location = new System.Drawing.Point(240, 9);
            this.staffButton.Name = "staffButton";
            this.staffButton.Size = new System.Drawing.Size(213, 41);
            this.staffButton.TabIndex = 3;
            this.staffButton.Text = "Staff";
            this.staffButton.UseVisualStyleBackColor = true;
            this.staffButton.Click += new System.EventHandler(this.staffButton_Click);
            // 
            // membersButton
            // 
            this.membersButton.Location = new System.Drawing.Point(11, 9);
            this.membersButton.Name = "membersButton";
            this.membersButton.Size = new System.Drawing.Size(213, 41);
            this.membersButton.TabIndex = 4;
            this.membersButton.Text = "Members";
            this.membersButton.UseVisualStyleBackColor = true;
            this.membersButton.Click += new System.EventHandler(this.membersButton_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 603);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Home";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button membersButton;
        private System.Windows.Forms.Button staffButton;
        private System.Windows.Forms.Button materielsButton;
        private System.Windows.Forms.Button paymentsButton;
        private System.Windows.Forms.Button logoutButton;
    }
}