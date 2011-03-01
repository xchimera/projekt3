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
            this.tabKalender = new System.Windows.Forms.TabPage();
            this.tabRegistrer_Fravær = new System.Windows.Forms.TabPage();
            this.lstFravær = new System.Windows.Forms.ListView();
            this.dato_fra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dato_til = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnOpretMedarbejder = new System.Windows.Forms.Button();
            this.btnRedigerMedarbejder = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSøg = new System.Windows.Forms.TextBox();
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
            this.note = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabRegistrer_Fravær.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
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
            this.tabRegistrer_Fravær.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(122)))), ((int)(((byte)(173)))));
            this.tabRegistrer_Fravær.Controls.Add(this.lstFravær);
            this.tabRegistrer_Fravær.Controls.Add(this.btnOpretMedarbejder);
            this.tabRegistrer_Fravær.Controls.Add(this.btnRedigerMedarbejder);
            this.tabRegistrer_Fravær.Controls.Add(this.button1);
            this.tabRegistrer_Fravær.Controls.Add(this.txtSøg);
            this.tabRegistrer_Fravær.Controls.Add(this.label4);
            this.tabRegistrer_Fravær.Controls.Add(this.lstKartotek);
            this.tabRegistrer_Fravær.Location = new System.Drawing.Point(4, 22);
            this.tabRegistrer_Fravær.Name = "tabRegistrer_Fravær";
            this.tabRegistrer_Fravær.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegistrer_Fravær.Size = new System.Drawing.Size(1073, 555);
            this.tabRegistrer_Fravær.TabIndex = 0;
            this.tabRegistrer_Fravær.Text = "Registrer Fravær";
            // 
            // lstFravær
            // 
            this.lstFravær.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dato_fra,
            this.dato_til,
            this.type,
            this.note});
            this.lstFravær.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstFravær.Location = new System.Drawing.Point(3, 416);
            this.lstFravær.Name = "lstFravær";
            this.lstFravær.Size = new System.Drawing.Size(1067, 136);
            this.lstFravær.TabIndex = 64;
            this.lstFravær.UseCompatibleStateImageBehavior = false;
            this.lstFravær.View = System.Windows.Forms.View.Details;
            // 
            // dato_fra
            // 
            this.dato_fra.Text = "Dato fra";
            this.dato_fra.Width = 146;
            // 
            // dato_til
            // 
            this.dato_til.Text = "Dato til";
            this.dato_til.Width = 146;
            // 
            // type
            // 
            this.type.Text = "Type";
            this.type.Width = 146;
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
            // txtSøg
            // 
            this.txtSøg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSøg.Location = new System.Drawing.Point(73, 10);
            this.txtSøg.Name = "txtSøg";
            this.txtSøg.Size = new System.Drawing.Size(134, 20);
            this.txtSøg.TabIndex = 59;
            this.txtSøg.TextChanged += new System.EventHandler(this.txtSøg_TextChanged);
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
            this.tabControl1.Location = new System.Drawing.Point(1, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1081, 581);
            this.tabControl1.TabIndex = 9;
            // 
            // note
            // 
            this.note.Text = "Note";
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
            this.tabRegistrer_Fravær.ResumeLayout(false);
            this.tabRegistrer_Fravær.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.TextBox txtSøg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRedigerMedarbejder;
        private System.Windows.Forms.Button btnOpretMedarbejder;
        private System.Windows.Forms.ListView lstFravær;
        private System.Windows.Forms.ColumnHeader dato_fra;
        private System.Windows.Forms.ColumnHeader dato_til;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.ColumnHeader note;
    }
}

