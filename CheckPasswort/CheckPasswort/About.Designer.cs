namespace CheckPasswort
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.programmname = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.githublink = new System.Windows.Forms.LinkLabel();
            this.linklabelWebsite = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // programmname
            // 
            this.programmname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.programmname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.programmname.Location = new System.Drawing.Point(47, 9);
            this.programmname.Name = "programmname";
            this.programmname.Size = new System.Drawing.Size(168, 23);
            this.programmname.TabIndex = 0;
            this.programmname.Text = "Passwortgenerator";
            this.programmname.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.name.Location = new System.Drawing.Point(47, 64);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(168, 27);
            this.name.TabIndex = 1;
            this.name.Text = "Timo Gremler";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.email.Location = new System.Drawing.Point(47, 32);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(168, 32);
            this.email.TabIndex = 2;
            this.email.Text = "info@timogremler.de";
            this.email.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // githublink
            // 
            this.githublink.AutoSize = true;
            this.githublink.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.githublink.Location = new System.Drawing.Point(47, 103);
            this.githublink.Name = "githublink";
            this.githublink.Size = new System.Drawing.Size(54, 18);
            this.githublink.TabIndex = 3;
            this.githublink.TabStop = true;
            this.githublink.Text = "GitHub";
            this.githublink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.githublink_LinkClicked);
            // 
            // linklabelWebsite
            // 
            this.linklabelWebsite.AutoSize = true;
            this.linklabelWebsite.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.linklabelWebsite.Location = new System.Drawing.Point(153, 103);
            this.linklabelWebsite.Name = "linklabelWebsite";
            this.linklabelWebsite.Size = new System.Drawing.Size(62, 18);
            this.linklabelWebsite.TabIndex = 5;
            this.linklabelWebsite.TabStop = true;
            this.linklabelWebsite.Text = "Website";
            this.linklabelWebsite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(12, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "©Timo Gremler";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 162);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.linklabelWebsite);
            this.Controls.Add(this.githublink);
            this.Controls.Add(this.email);
            this.Controls.Add(this.name);
            this.Controls.Add(this.programmname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label programmname;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.LinkLabel githublink;
        private System.Windows.Forms.LinkLabel linklabelWebsite;
        private System.Windows.Forms.Label label5;
    }
}