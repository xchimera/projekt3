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
            this.tabRediger_Katotek = new System.Windows.Forms.TabPage();
            this.txtSøg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBy = new System.Windows.Forms.TextBox();
            this.txtCPR = new System.Windows.Forms.TextBox();
            this.txtAfdeling = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtPostnr = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtFornavn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRediger = new System.Windows.Forms.Button();
            this.btnSlet = new System.Windows.Forms.Button();
            this.btnOpret = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstRediger = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader27 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabKalender = new System.Windows.Forms.TabPage();
            this.tabRegistrer_Fravær = new System.Windows.Forms.TabPage();
            this.btnOpretMedarbejder = new System.Windows.Forms.Button();
            this.btnRedigerMedarbejder = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnVisFraværMedarbejder = new System.Windows.Forms.Button();
            this.lstKartotek = new System.Windows.Forms.ListView();
            this.CPR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Navn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adresse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Postnr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.By = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tlf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Afdeling = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3.SuspendLayout();
            this.tabRediger_Katotek.SuspendLayout();
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
            // tabRediger_Katotek
            // 
            this.tabRediger_Katotek.BackColor = System.Drawing.Color.Gainsboro;
            this.tabRediger_Katotek.Controls.Add(this.txtSøg);
            this.tabRediger_Katotek.Controls.Add(this.label1);
            this.tabRediger_Katotek.Controls.Add(this.txtBy);
            this.tabRediger_Katotek.Controls.Add(this.txtCPR);
            this.tabRediger_Katotek.Controls.Add(this.txtAfdeling);
            this.tabRediger_Katotek.Controls.Add(this.txtTelefon);
            this.tabRediger_Katotek.Controls.Add(this.txtPostnr);
            this.tabRediger_Katotek.Controls.Add(this.txtAdresse);
            this.tabRediger_Katotek.Controls.Add(this.txtFornavn);
            this.tabRediger_Katotek.Controls.Add(this.label6);
            this.tabRediger_Katotek.Controls.Add(this.btnRediger);
            this.tabRediger_Katotek.Controls.Add(this.btnSlet);
            this.tabRediger_Katotek.Controls.Add(this.btnOpret);
            this.tabRediger_Katotek.Controls.Add(this.label11);
            this.tabRediger_Katotek.Controls.Add(this.label12);
            this.tabRediger_Katotek.Controls.Add(this.label13);
            this.tabRediger_Katotek.Controls.Add(this.label9);
            this.tabRediger_Katotek.Controls.Add(this.label10);
            this.tabRediger_Katotek.Controls.Add(this.label5);
            this.tabRediger_Katotek.Controls.Add(this.lstRediger);
            this.tabRediger_Katotek.Location = new System.Drawing.Point(4, 22);
            this.tabRediger_Katotek.Name = "tabRediger_Katotek";
            this.tabRediger_Katotek.Padding = new System.Windows.Forms.Padding(3);
            this.tabRediger_Katotek.Size = new System.Drawing.Size(1073, 555);
            this.tabRediger_Katotek.TabIndex = 3;
            this.tabRediger_Katotek.Text = "Rediger Katotek";
            // 
            // txtSøg
            // 
            this.txtSøg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSøg.Location = new System.Drawing.Point(664, 132);
            this.txtSøg.Name = "txtSøg";
            this.txtSøg.Size = new System.Drawing.Size(134, 29);
            this.txtSøg.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(613, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 24);
            this.label1.TabIndex = 56;
            this.label1.Text = "Søg";
            // 
            // txtBy
            // 
            this.txtBy.Location = new System.Drawing.Point(402, 33);
            this.txtBy.Name = "txtBy";
            this.txtBy.Size = new System.Drawing.Size(100, 20);
            this.txtBy.TabIndex = 55;
            // 
            // txtCPR
            // 
            this.txtCPR.Location = new System.Drawing.Point(402, 63);
            this.txtCPR.Name = "txtCPR";
            this.txtCPR.Size = new System.Drawing.Size(100, 20);
            this.txtCPR.TabIndex = 49;
            // 
            // txtAfdeling
            // 
            this.txtAfdeling.Location = new System.Drawing.Point(643, 35);
            this.txtAfdeling.Name = "txtAfdeling";
            this.txtAfdeling.Size = new System.Drawing.Size(100, 20);
            this.txtAfdeling.TabIndex = 48;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(402, 94);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 20);
            this.txtTelefon.TabIndex = 47;
            // 
            // txtPostnr
            // 
            this.txtPostnr.Location = new System.Drawing.Point(151, 93);
            this.txtPostnr.Name = "txtPostnr";
            this.txtPostnr.Size = new System.Drawing.Size(100, 20);
            this.txtPostnr.TabIndex = 42;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(151, 64);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(100, 20);
            this.txtAdresse.TabIndex = 41;
            // 
            // txtFornavn
            // 
            this.txtFornavn.Location = new System.Drawing.Point(151, 35);
            this.txtFornavn.Name = "txtFornavn";
            this.txtFornavn.Size = new System.Drawing.Size(100, 20);
            this.txtFornavn.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(321, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 17);
            this.label6.TabIndex = 54;
            this.label6.Text = "By";
            // 
            // btnRediger
            // 
            this.btnRediger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRediger.Location = new System.Drawing.Point(198, 132);
            this.btnRediger.Name = "btnRediger";
            this.btnRediger.Size = new System.Drawing.Size(111, 34);
            this.btnRediger.TabIndex = 53;
            this.btnRediger.Text = "Rediger";
            this.btnRediger.UseVisualStyleBackColor = true;
            this.btnRediger.Click += new System.EventHandler(this.btnRediger_Click);
            // 
            // btnSlet
            // 
            this.btnSlet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSlet.Location = new System.Drawing.Point(337, 132);
            this.btnSlet.Name = "btnSlet";
            this.btnSlet.Size = new System.Drawing.Size(111, 34);
            this.btnSlet.TabIndex = 52;
            this.btnSlet.Text = "Slet";
            this.btnSlet.UseVisualStyleBackColor = true;
            // 
            // btnOpret
            // 
            this.btnOpret.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpret.Location = new System.Drawing.Point(53, 132);
            this.btnOpret.Name = "btnOpret";
            this.btnOpret.Size = new System.Drawing.Size(111, 34);
            this.btnOpret.TabIndex = 50;
            this.btnOpret.Text = "Opret";
            this.btnOpret.UseVisualStyleBackColor = true;
            this.btnOpret.Click += new System.EventHandler(this.btnOpret_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(321, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 17);
            this.label11.TabIndex = 46;
            this.label11.Text = "CPR nr.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(562, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 17);
            this.label12.TabIndex = 45;
            this.label12.Text = "Afdeling";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(321, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 17);
            this.label13.TabIndex = 44;
            this.label13.Text = "Telefon nr.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(50, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 17);
            this.label9.TabIndex = 39;
            this.label9.Text = "Post nr.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(50, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 17);
            this.label10.TabIndex = 38;
            this.label10.Text = "Adresse";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Fornavn";
            // 
            // lstRediger
            // 
            this.lstRediger.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader19,
            this.columnHeader22,
            this.columnHeader23,
            this.columnHeader24,
            this.columnHeader25,
            this.columnHeader27});
            this.lstRediger.FullRowSelect = true;
            this.lstRediger.Location = new System.Drawing.Point(53, 191);
            this.lstRediger.Name = "lstRediger";
            this.lstRediger.Size = new System.Drawing.Size(817, 303);
            this.lstRediger.TabIndex = 31;
            this.lstRediger.UseCompatibleStateImageBehavior = false;
            this.lstRediger.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "CPR";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Navn";
            this.columnHeader19.Width = 95;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "Adresse";
            this.columnHeader22.Width = 120;
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "Post nr.";
            this.columnHeader23.Width = 66;
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "By";
            this.columnHeader24.Width = 120;
            // 
            // columnHeader25
            // 
            this.columnHeader25.Text = "Telefon nr.";
            this.columnHeader25.Width = 88;
            // 
            // columnHeader27
            // 
            this.columnHeader27.Text = "Afdeling nr.";
            this.columnHeader27.Width = 70;
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
            this.tabRegistrer_Fravær.Controls.Add(this.btnOpretMedarbejder);
            this.tabRegistrer_Fravær.Controls.Add(this.btnRedigerMedarbejder);
            this.tabRegistrer_Fravær.Controls.Add(this.button1);
            this.tabRegistrer_Fravær.Controls.Add(this.textBox1);
            this.tabRegistrer_Fravær.Controls.Add(this.label4);
            this.tabRegistrer_Fravær.Controls.Add(this.btnVisFraværMedarbejder);
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
            this.btnOpretMedarbejder.Location = new System.Drawing.Point(230, 426);
            this.btnOpretMedarbejder.Name = "btnOpretMedarbejder";
            this.btnOpretMedarbejder.Size = new System.Drawing.Size(78, 34);
            this.btnOpretMedarbejder.TabIndex = 62;
            this.btnOpretMedarbejder.Text = "Opret Medarbejder";
            this.btnOpretMedarbejder.UseVisualStyleBackColor = true;
            this.btnOpretMedarbejder.Click += new System.EventHandler(this.btnOpretMedarbejder_Click);
            // 
            // btnRedigerMedarbejder
            // 
            this.btnRedigerMedarbejder.Location = new System.Drawing.Point(143, 426);
            this.btnRedigerMedarbejder.Name = "btnRedigerMedarbejder";
            this.btnRedigerMedarbejder.Size = new System.Drawing.Size(81, 34);
            this.btnRedigerMedarbejder.TabIndex = 61;
            this.btnRedigerMedarbejder.Text = "Rediger medarbejder";
            this.btnRedigerMedarbejder.UseVisualStyleBackColor = true;
            this.btnRedigerMedarbejder.Click += new System.EventHandler(this.btnRedigerMedarbejder_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 34);
            this.button1.TabIndex = 60;
            this.button1.Text = "Registrer fravær for medarbejder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(91, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 29);
            this.textBox1.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 24);
            this.label4.TabIndex = 58;
            this.label4.Text = "Søg";
            // 
            // btnVisFraværMedarbejder
            // 
            this.btnVisFraværMedarbejder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisFraværMedarbejder.Location = new System.Drawing.Point(576, 12);
            this.btnVisFraværMedarbejder.Name = "btnVisFraværMedarbejder";
            this.btnVisFraværMedarbejder.Size = new System.Drawing.Size(285, 48);
            this.btnVisFraværMedarbejder.TabIndex = 37;
            this.btnVisFraværMedarbejder.Text = "Vis fravær for medarbejder";
            this.btnVisFraværMedarbejder.UseVisualStyleBackColor = true;
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
            this.lstKartotek.Location = new System.Drawing.Point(44, 80);
            this.lstKartotek.Name = "lstKartotek";
            this.lstKartotek.Size = new System.Drawing.Size(817, 303);
            this.lstKartotek.TabIndex = 34;
            this.lstKartotek.UseCompatibleStateImageBehavior = false;
            this.lstKartotek.View = System.Windows.Forms.View.Details;
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
            this.tabControl1.Controls.Add(this.tabRediger_Katotek);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1081, 581);
            this.tabControl1.TabIndex = 9;
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
            this.tabRediger_Katotek.ResumeLayout(false);
            this.tabRediger_Katotek.PerformLayout();
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
        private System.Windows.Forms.TabPage tabRediger_Katotek;
        private System.Windows.Forms.TextBox txtSøg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBy;
        private System.Windows.Forms.TextBox txtCPR;
        private System.Windows.Forms.TextBox txtAfdeling;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtPostnr;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.TextBox txtFornavn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRediger;
        private System.Windows.Forms.Button btnSlet;
        private System.Windows.Forms.Button btnOpret;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabKalender;
        private System.Windows.Forms.TabPage tabRegistrer_Fravær;
        private System.Windows.Forms.Button btnVisFraværMedarbejder;
        private System.Windows.Forms.ListView lstKartotek;
        private System.Windows.Forms.ColumnHeader CPR;
        private System.Windows.Forms.ColumnHeader Navn;
        private System.Windows.Forms.ColumnHeader Adresse;
        private System.Windows.Forms.ColumnHeader Postnr;
        private System.Windows.Forms.ColumnHeader By;
        private System.Windows.Forms.ColumnHeader Tlf;
        private System.Windows.Forms.ColumnHeader Afdeling;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ListView lstRediger;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ColumnHeader columnHeader24;
        private System.Windows.Forms.ColumnHeader columnHeader25;
        private System.Windows.Forms.ColumnHeader columnHeader27;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRedigerMedarbejder;
        private System.Windows.Forms.Button btnOpretMedarbejder;
    }
}

