namespace GUI
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.listView4 = new System.Windows.Forms.ListView();
            this.columnHeader28 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label15 = new System.Windows.Forms.Label();
            this.listView5 = new System.Windows.Forms.ListView();
            this.columnHeader29 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label16 = new System.Windows.Forms.Label();
            this.listView6 = new System.Windows.Forms.ListView();
            this.columnHeader30 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabKalender = new System.Windows.Forms.TabPage();
            this.tabRegistrer_Fravær = new System.Windows.Forms.TabPage();
            this.btnOpretMedarbejder = new System.Windows.Forms.Button();
            this.btnRedigerMedarbejder = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lstKartotek = new System.Windows.Forms.ListView();
            this.CPR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Navn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adresse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Postnr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.By = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tlf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Afdeling = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.btnVisFravær = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3.SuspendLayout();
            this.tabRegistrer_Fravær.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.listView4);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.listView5);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.listView6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1073, 555);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "Vis Fravær for medarbejder";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(628, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 24);
            this.label14.TabIndex = 11;
            this.label14.Text = "Ferie";
            // 
            // listView4
            // 
            this.listView4.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader28});
            this.listView4.Location = new System.Drawing.Point(632, 94);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(209, 333);
            this.listView4.TabIndex = 10;
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader28
            // 
            this.columnHeader28.Text = "Dato";
            this.columnHeader28.Width = 204;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(368, 56);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 24);
            this.label15.TabIndex = 9;
            this.label15.Text = "Fri dage";
            // 
            // listView5
            // 
            this.listView5.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader29});
            this.listView5.Location = new System.Drawing.Point(372, 94);
            this.listView5.Name = "listView5";
            this.listView5.Size = new System.Drawing.Size(209, 333);
            this.listView5.TabIndex = 8;
            this.listView5.UseCompatibleStateImageBehavior = false;
            this.listView5.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader29
            // 
            this.columnHeader29.Text = "Dato";
            this.columnHeader29.Width = 204;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(105, 56);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 24);
            this.label16.TabIndex = 7;
            this.label16.Text = "Syg dage";
            // 
            // listView6
            // 
            this.listView6.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader30});
            this.listView6.Location = new System.Drawing.Point(109, 94);
            this.listView6.Name = "listView6";
            this.listView6.Size = new System.Drawing.Size(209, 333);
            this.listView6.TabIndex = 6;
            this.listView6.UseCompatibleStateImageBehavior = false;
            this.listView6.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader30
            // 
            this.columnHeader30.Text = "Dato";
            this.columnHeader30.Width = 204;
            // 
            // tabKalender
            // 
            this.tabKalender.BackColor = System.Drawing.Color.Gainsboro;
            this.tabKalender.Location = new System.Drawing.Point(4, 22);
            this.tabKalender.Name = "tabKalender";
            this.tabKalender.Padding = new System.Windows.Forms.Padding(3);
            this.tabKalender.Size = new System.Drawing.Size(1073, 555);
            this.tabKalender.TabIndex = 1;
            this.tabKalender.Text = "Kalender";
            // 
            // tabRegistrer_Fravær
            // 
            this.tabRegistrer_Fravær.BackColor = System.Drawing.Color.Gainsboro;
            this.tabRegistrer_Fravær.Controls.Add(this.listView1);
            this.tabRegistrer_Fravær.Controls.Add(this.btnVisFravær);
            this.tabRegistrer_Fravær.Controls.Add(this.btnOpretMedarbejder);
            this.tabRegistrer_Fravær.Controls.Add(this.btnRedigerMedarbejder);
            this.tabRegistrer_Fravær.Controls.Add(this.button1);
            this.tabRegistrer_Fravær.Controls.Add(this.textBox1);
            this.tabRegistrer_Fravær.Controls.Add(this.label4);
            this.tabRegistrer_Fravær.Controls.Add(this.lstKartotek);
            this.tabRegistrer_Fravær.Location = new System.Drawing.Point(4, 22);
            this.tabRegistrer_Fravær.Name = "tabRegistrer_Fravær";
            this.tabRegistrer_Fravær.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegistrer_Fravær.Size = new System.Drawing.Size(1073, 555);
            this.tabRegistrer_Fravær.TabIndex = 0;
            this.tabRegistrer_Fravær.Text = "Registrer Fravær";
            // 
            // btnOpretMedarbejder
            // 
            this.btnOpretMedarbejder.Location = new System.Drawing.Point(193, 376);
            this.btnOpretMedarbejder.Name = "btnOpretMedarbejder";
            this.btnOpretMedarbejder.Size = new System.Drawing.Size(78, 34);
            this.btnOpretMedarbejder.TabIndex = 62;
            this.btnOpretMedarbejder.Text = "Opret Medarbejder";
            this.btnOpretMedarbejder.UseVisualStyleBackColor = true;
            this.btnOpretMedarbejder.Click += new System.EventHandler(this.btnOpretMedarbejder_Click);
            // 
            // btnRedigerMedarbejder
            // 
            this.btnRedigerMedarbejder.Location = new System.Drawing.Point(106, 376);
            this.btnRedigerMedarbejder.Name = "btnRedigerMedarbejder";
            this.btnRedigerMedarbejder.Size = new System.Drawing.Size(81, 34);
            this.btnRedigerMedarbejder.TabIndex = 61;
            this.btnRedigerMedarbejder.Text = "Rediger medarbejder";
            this.btnRedigerMedarbejder.UseVisualStyleBackColor = true;
            this.btnRedigerMedarbejder.Click += new System.EventHandler(this.btnRedigerMedarbejder_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 34);
            this.button1.TabIndex = 60;
            this.button1.Text = "Registrer fravær for medarbejder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(73, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 20);
            this.textBox1.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 58;
            this.label4.Text = "Søg";
            // 
            // lstKartotek
            // 
            this.lstKartotek.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CPR,
            this.Navn,
            this.Adresse,
            this.Postnr,
            this.By,
            this.Tlf,
            this.Afdeling});
            this.lstKartotek.FullRowSelect = true;
            this.lstKartotek.GridLines = true;
            this.lstKartotek.Location = new System.Drawing.Point(7, 36);
            this.lstKartotek.Name = "lstKartotek";
            this.lstKartotek.Size = new System.Drawing.Size(1063, 334);
            this.lstKartotek.TabIndex = 34;
            this.lstKartotek.UseCompatibleStateImageBehavior = false;
            this.lstKartotek.View = System.Windows.Forms.View.Details;
            this.lstKartotek.SelectedIndexChanged += new System.EventHandler(this.lstKartotek_SelectedIndexChanged);
            // 
            // CPR
            // 
            this.CPR.Text = "CPR Nummer";
            this.CPR.Width = 120;
            // 
            // Navn
            // 
            this.Navn.Text = "Navn";
            this.Navn.Width = 94;
            // 
            // Adresse
            // 
            this.Adresse.Text = "Adresse";
            this.Adresse.Width = 120;
            // 
            // Postnr
            // 
            this.Postnr.Text = "Post nr.";
            this.Postnr.Width = 66;
            // 
            // By
            // 
            this.By.Text = "By";
            this.By.Width = 100;
            // 
            // Tlf
            // 
            this.Tlf.Text = "Telefon nr.";
            this.Tlf.Width = 88;
            // 
            // Afdeling
            // 
            this.Afdeling.Text = "Afdeling nr.";
            this.Afdeling.Width = 71;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabRegistrer_Fravær);
            this.tabControl1.Controls.Add(this.tabKalender);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1081, 581);
            this.tabControl1.TabIndex = 9;
            // 
            // btnVisFravær
            // 
            this.btnVisFravær.Location = new System.Drawing.Point(278, 376);
            this.btnVisFravær.Name = "btnVisFravær";
            this.btnVisFravær.Size = new System.Drawing.Size(75, 23);
            this.btnVisFravær.TabIndex = 63;
            this.btnVisFravær.Text = "Vis fravær";
            this.btnVisFravær.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.Location = new System.Drawing.Point(3, 416);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1067, 136);
            this.listView1.TabIndex = 64;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 146;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 146;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Width = 146;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 583);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabRegistrer_Fravær.ResumeLayout(false);
            this.tabRegistrer_Fravær.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.ColumnHeader columnHeader28;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListView listView5;
        private System.Windows.Forms.ColumnHeader columnHeader29;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ListView listView6;
        private System.Windows.Forms.ColumnHeader columnHeader30;
        private System.Windows.Forms.TabPage tabKalender;
        private System.Windows.Forms.TabPage tabRegistrer_Fravær;
        private System.Windows.Forms.ListView lstKartotek;
        private System.Windows.Forms.ColumnHeader CPR;
        private System.Windows.Forms.ColumnHeader Navn;
        private System.Windows.Forms.ColumnHeader Adresse;
        private System.Windows.Forms.ColumnHeader Postnr;
        private System.Windows.Forms.ColumnHeader By;
        private System.Windows.Forms.ColumnHeader Tlf;
        private System.Windows.Forms.ColumnHeader Afdeling;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRedigerMedarbejder;
        private System.Windows.Forms.Button btnOpretMedarbejder;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnVisFravær;
    }
}

