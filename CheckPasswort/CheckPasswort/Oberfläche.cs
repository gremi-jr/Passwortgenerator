using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CheckPasswort
{
    public partial class Oberfläche : Form
    {
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private Label kopiertLabel;
        private Button btnKopieren;
        private Label passwortlabel;
        private Button btnErstellen;
        private NumericUpDown numericUpDown;
        private Label label1;
        private TabControl tabForm;
        private Button btnÜberprüfen;
        private TextBox txtBoxCheckup;
        private Label labelCheckUp;
        private CheckBox checkBoxKleinbuchstaben;
        private CheckBox checkBoxminBuchstaben;
        private CheckBox checkBoxZahlen;
        private CheckBox checkBoxSonderzeichen;
        private CheckBox checkBoxGroßbuchstaben;
        private Label label5;
        private MenuStrip menuStrip;

        public Oberfläche()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Oberfläche));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBoxKleinbuchstaben = new System.Windows.Forms.CheckBox();
            this.checkBoxminBuchstaben = new System.Windows.Forms.CheckBox();
            this.checkBoxZahlen = new System.Windows.Forms.CheckBox();
            this.checkBoxSonderzeichen = new System.Windows.Forms.CheckBox();
            this.checkBoxGroßbuchstaben = new System.Windows.Forms.CheckBox();
            this.btnÜberprüfen = new System.Windows.Forms.Button();
            this.txtBoxCheckup = new System.Windows.Forms.TextBox();
            this.labelCheckUp = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.kopiertLabel = new System.Windows.Forms.Label();
            this.btnKopieren = new System.Windows.Forms.Button();
            this.passwortlabel = new System.Windows.Forms.Label();
            this.btnErstellen = new System.Windows.Forms.Button();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tabForm = new System.Windows.Forms.TabControl();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.tabForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Navy;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(866, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.checkBoxKleinbuchstaben);
            this.tabPage2.Controls.Add(this.checkBoxminBuchstaben);
            this.tabPage2.Controls.Add(this.checkBoxZahlen);
            this.tabPage2.Controls.Add(this.checkBoxSonderzeichen);
            this.tabPage2.Controls.Add(this.checkBoxGroßbuchstaben);
            this.tabPage2.Controls.Add(this.btnÜberprüfen);
            this.tabPage2.Controls.Add(this.txtBoxCheckup);
            this.tabPage2.Controls.Add(this.labelCheckUp);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(858, 105);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Check-Up";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkBoxKleinbuchstaben
            // 
            this.checkBoxKleinbuchstaben.AutoCheck = false;
            this.checkBoxKleinbuchstaben.AutoSize = true;
            this.checkBoxKleinbuchstaben.Location = new System.Drawing.Point(744, 7);
            this.checkBoxKleinbuchstaben.Name = "checkBoxKleinbuchstaben";
            this.checkBoxKleinbuchstaben.Size = new System.Drawing.Size(105, 17);
            this.checkBoxKleinbuchstaben.TabIndex = 13;
            this.checkBoxKleinbuchstaben.Text = "Kleinbuchstaben";
            this.checkBoxKleinbuchstaben.UseVisualStyleBackColor = true;
            // 
            // checkBoxminBuchstaben
            // 
            this.checkBoxminBuchstaben.AutoCheck = false;
            this.checkBoxminBuchstaben.AutoSize = true;
            this.checkBoxminBuchstaben.Location = new System.Drawing.Point(633, 76);
            this.checkBoxminBuchstaben.Name = "checkBoxminBuchstaben";
            this.checkBoxminBuchstaben.Size = new System.Drawing.Size(120, 17);
            this.checkBoxminBuchstaben.TabIndex = 12;
            this.checkBoxminBuchstaben.Text = "mind. 8 Buchstaben";
            this.checkBoxminBuchstaben.UseVisualStyleBackColor = true;
            // 
            // checkBoxZahlen
            // 
            this.checkBoxZahlen.AutoCheck = false;
            this.checkBoxZahlen.AutoSize = true;
            this.checkBoxZahlen.Location = new System.Drawing.Point(633, 53);
            this.checkBoxZahlen.Name = "checkBoxZahlen";
            this.checkBoxZahlen.Size = new System.Drawing.Size(59, 17);
            this.checkBoxZahlen.TabIndex = 11;
            this.checkBoxZahlen.Text = "Zahlen";
            this.checkBoxZahlen.UseVisualStyleBackColor = true;
            // 
            // checkBoxSonderzeichen
            // 
            this.checkBoxSonderzeichen.AutoCheck = false;
            this.checkBoxSonderzeichen.AutoSize = true;
            this.checkBoxSonderzeichen.Location = new System.Drawing.Point(633, 30);
            this.checkBoxSonderzeichen.Name = "checkBoxSonderzeichen";
            this.checkBoxSonderzeichen.Size = new System.Drawing.Size(97, 17);
            this.checkBoxSonderzeichen.TabIndex = 10;
            this.checkBoxSonderzeichen.Text = "Sonderzeichen";
            this.checkBoxSonderzeichen.UseVisualStyleBackColor = true;
            // 
            // checkBoxGroßbuchstaben
            // 
            this.checkBoxGroßbuchstaben.AutoCheck = false;
            this.checkBoxGroßbuchstaben.AutoSize = true;
            this.checkBoxGroßbuchstaben.Location = new System.Drawing.Point(633, 7);
            this.checkBoxGroßbuchstaben.Name = "checkBoxGroßbuchstaben";
            this.checkBoxGroßbuchstaben.Size = new System.Drawing.Size(105, 17);
            this.checkBoxGroßbuchstaben.TabIndex = 9;
            this.checkBoxGroßbuchstaben.Text = "Großbuchstaben";
            this.checkBoxGroßbuchstaben.UseVisualStyleBackColor = true;
            // 
            // btnÜberprüfen
            // 
            this.btnÜberprüfen.Location = new System.Drawing.Point(9, 53);
            this.btnÜberprüfen.Name = "btnÜberprüfen";
            this.btnÜberprüfen.Size = new System.Drawing.Size(105, 23);
            this.btnÜberprüfen.TabIndex = 8;
            this.btnÜberprüfen.Text = "Überprüfen";
            this.btnÜberprüfen.UseVisualStyleBackColor = true;
            this.btnÜberprüfen.Click += new System.EventHandler(this.btnÜberprüfen_Click);
            // 
            // txtBoxCheckup
            // 
            this.txtBoxCheckup.Location = new System.Drawing.Point(207, 17);
            this.txtBoxCheckup.Name = "txtBoxCheckup";
            this.txtBoxCheckup.Size = new System.Drawing.Size(230, 20);
            this.txtBoxCheckup.TabIndex = 1;
            // 
            // labelCheckUp
            // 
            this.labelCheckUp.AutoSize = true;
            this.labelCheckUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelCheckUp.Location = new System.Drawing.Point(6, 16);
            this.labelCheckUp.Name = "labelCheckUp";
            this.labelCheckUp.Size = new System.Drawing.Size(195, 18);
            this.labelCheckUp.TabIndex = 0;
            this.labelCheckUp.Text = "Eigenes Passwort eingeben:";
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.kopiertLabel);
            this.tabPage1.Controls.Add(this.btnKopieren);
            this.tabPage1.Controls.Add(this.passwortlabel);
            this.tabPage1.Controls.Add(this.btnErstellen);
            this.tabPage1.Controls.Add(this.numericUpDown);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(858, 105);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Generator";
            // 
            // kopiertLabel
            // 
            this.kopiertLabel.AutoSize = true;
            this.kopiertLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.kopiertLabel.ForeColor = System.Drawing.Color.Lime;
            this.kopiertLabel.Location = new System.Drawing.Point(240, 61);
            this.kopiertLabel.Name = "kopiertLabel";
            this.kopiertLabel.Size = new System.Drawing.Size(0, 18);
            this.kopiertLabel.TabIndex = 6;
            // 
            // btnKopieren
            // 
            this.btnKopieren.Location = new System.Drawing.Point(119, 60);
            this.btnKopieren.Name = "btnKopieren";
            this.btnKopieren.Size = new System.Drawing.Size(105, 23);
            this.btnKopieren.TabIndex = 5;
            this.btnKopieren.Text = "Kopieren";
            this.btnKopieren.UseVisualStyleBackColor = true;
            this.btnKopieren.Click += new System.EventHandler(this.btnKopieren_Click);
            // 
            // passwortlabel
            // 
            this.passwortlabel.AutoSize = true;
            this.passwortlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.passwortlabel.Location = new System.Drawing.Point(264, 19);
            this.passwortlabel.Name = "passwortlabel";
            this.passwortlabel.Size = new System.Drawing.Size(0, 18);
            this.passwortlabel.TabIndex = 4;
            // 
            // btnErstellen
            // 
            this.btnErstellen.Location = new System.Drawing.Point(8, 60);
            this.btnErstellen.Name = "btnErstellen";
            this.btnErstellen.Size = new System.Drawing.Size(105, 23);
            this.btnErstellen.TabIndex = 2;
            this.btnErstellen.Text = "Erstellen";
            this.btnErstellen.UseVisualStyleBackColor = true;
            this.btnErstellen.Click += new System.EventHandler(this.btnErstellen_Click);
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(119, 21);
            this.numericUpDown.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown.TabIndex = 1;
            this.numericUpDown.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Passwortlänge:";
            // 
            // tabForm
            // 
            this.tabForm.Controls.Add(this.tabPage1);
            this.tabForm.Controls.Add(this.tabPage2);
            this.tabForm.Location = new System.Drawing.Point(0, 27);
            this.tabForm.Name = "tabForm";
            this.tabForm.SelectedIndex = 0;
            this.tabForm.Size = new System.Drawing.Size(866, 131);
            this.tabForm.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(10, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "©Timo Gremler";
            // 
            // Oberfläche
            // 
            this.ClientSize = new System.Drawing.Size(866, 170);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tabForm);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Oberfläche";
            this.Text = "Passwortgenerator";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.tabForm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        //Funktion zum erstellen eines Passwortes
        public static string PasswortGenerator(int generatorPasswordLänge)
        {
            string erlaubteBuchstaben = "abcdefghijkmnopqrstuvwxyzäöüABCDEFGHJKLMNOPQRSTUVWXYZÄÖÜ0123456789/,.;:_?!+%&()><=$'*-";
            char[] chars = new char[generatorPasswordLänge];
            Random zufallPasswort = new Random();

            for (int i = 0; i < generatorPasswordLänge; i++)
            {
                chars[i] = erlaubteBuchstaben[zufallPasswort.Next(0, erlaubteBuchstaben.Length)];
            }

            return new string(chars);
        }


        private void aboutToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            About aboutForm = new About();
            aboutForm.Show();
        }

        private void btnErstellen_Click(object sender, System.EventArgs e)
        {
            int passwortLänge = Convert.ToInt32(numericUpDown.Value);
            string passwort = PasswortGenerator(passwortLänge);
            passwortlabel.Text = passwort;
            kopiertLabel.Text = "";
        }

        private void btnKopieren_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(passwortlabel.Text);
                kopiertLabel.Text = "Ihr Passwort wurde in die Zwischenablage kopiert!";
            }
            catch
            {
                string mitteilung = "Bitte ein Passwort mit mehr als einen Buchstaben erstellen!";
                MessageBox.Show(mitteilung, "Achtung");
            }

        }

        private void btnÜberprüfen_Click(object sender, EventArgs e)
        {
           
            string passwort = txtBoxCheckup.Text;
            //Passwortlänge
            if (passwort.Length <= 7)
            {
                checkBoxminBuchstaben.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                checkBoxminBuchstaben.ForeColor = System.Drawing.Color.Green;
                checkBoxminBuchstaben.Checked = true;
            }
            //GROßBUCHSTABEN
            if (Regex.IsMatch(passwort, @"[A-Z_ÄÜÖ]"))
            {
                checkBoxGroßbuchstaben.ForeColor = System.Drawing.Color.Green;
                checkBoxGroßbuchstaben.Checked = true;

            }
            else
            {
                checkBoxGroßbuchstaben.ForeColor = System.Drawing.Color.Red;
            }
            //KLEINBUCHSTABEN
            if (Regex.IsMatch(passwort, @"[a-z_üäö]"))
            {
                checkBoxKleinbuchstaben.ForeColor = System.Drawing.Color.Green;
                checkBoxKleinbuchstaben.Checked = true;
            }
            else
            {
                checkBoxKleinbuchstaben.ForeColor = System.Drawing.Color.Red;
            }
            //SONDERZEICHEN
            if (Regex.IsMatch(passwort, @"[/,.;:_?!+%&()><=$'*-]"))
            {
                checkBoxSonderzeichen.ForeColor = System.Drawing.Color.Green;
                checkBoxSonderzeichen.Checked = true;

            }
            else
            {
                checkBoxSonderzeichen.ForeColor = System.Drawing.Color.Red;
            }
            //ZAHLEN
            if (Regex.IsMatch(passwort, @"[0-9]"))
            {
                checkBoxZahlen.ForeColor = System.Drawing.Color.Green;
                checkBoxZahlen.Checked = true;

            }
            else
            {
                checkBoxZahlen.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help helpForm = new Help();
            helpForm.Show();
        }
    }
}