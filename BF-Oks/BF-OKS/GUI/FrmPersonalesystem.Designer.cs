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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabKalender = new System.Windows.Forms.TabPage();
            this.evCalendar1 = new CalendarControl.EVCalendar();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.indsætNyhedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sletNyhedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabRegistrer_Fravær = new System.Windows.Forms.TabPage();
            this.lstKartotek = new System.Windows.Forms.ListView();
            this.CPR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Navn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adresse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Postnr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.By = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tlf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Afdeling = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRedigerMedarbejder = new System.Windows.Forms.Button();
            this.btnOpretMedarbejder = new System.Windows.Forms.Button();
            this.lstFravær = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dato_fra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dato_til = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.note = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txt_soeg = new System.Windows.Forms.ToolStripTextBox();
            this.RedigerFraværMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.redigérFraværToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabKalender.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tabRegistrer_Fravær.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.RedigerFraværMenu.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabKalender
            // 
            this.tabKalender.BackColor = System.Drawing.Color.Gainsboro;
            this.tabKalender.Controls.Add(this.evCalendar1);
            this.tabKalender.Location = new System.Drawing.Point(4, 22);
            this.tabKalender.Name = "tabKalender";
            this.tabKalender.Padding = new System.Windows.Forms.Padding(3);
            this.tabKalender.Size = new System.Drawing.Size(1001, 475);
            this.tabKalender.TabIndex = 1;
            this.tabKalender.Text = "Kalender";
            // 
            // evCalendar1
            // 
            this.evCalendar1.ContextMenuStrip = this.contextMenuStrip1;
            this.evCalendar1.DayContextMenu = null;
            this.evCalendar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.evCalendar1.EventContextMenu = null;
            this.evCalendar1.Location = new System.Drawing.Point(3, 3);
            this.evCalendar1.MinimumSize = new System.Drawing.Size(260, 260);
            this.evCalendar1.Name = "evCalendar1";
            this.evCalendar1.Size = new System.Drawing.Size(995, 469);
            this.evCalendar1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.indsætNyhedToolStripMenuItem,
            this.sletNyhedToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(147, 48);
            // 
            // indsætNyhedToolStripMenuItem
            // 
            this.indsætNyhedToolStripMenuItem.Name = "indsætNyhedToolStripMenuItem";
            this.indsætNyhedToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.indsætNyhedToolStripMenuItem.Text = "Indsæt nyhed";
            this.indsætNyhedToolStripMenuItem.Click += new System.EventHandler(this.indsætNyhedToolStripMenuItem_Click);
            // 
            // sletNyhedToolStripMenuItem
            // 
            this.sletNyhedToolStripMenuItem.Name = "sletNyhedToolStripMenuItem";
            this.sletNyhedToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.sletNyhedToolStripMenuItem.Text = "Slet Nyhed";
            // 
            // tabRegistrer_Fravær
            // 
            this.tabRegistrer_Fravær.BackColor = System.Drawing.Color.SlateGray;
            this.tabRegistrer_Fravær.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabRegistrer_Fravær.Controls.Add(this.lstKartotek);
            this.tabRegistrer_Fravær.Controls.Add(this.panel1);
            this.tabRegistrer_Fravær.Controls.Add(this.lstFravær);
            this.tabRegistrer_Fravær.Controls.Add(this.toolStrip1);
            this.tabRegistrer_Fravær.Location = new System.Drawing.Point(4, 22);
            this.tabRegistrer_Fravær.Name = "tabRegistrer_Fravær";
            this.tabRegistrer_Fravær.Size = new System.Drawing.Size(1001, 475);
            this.tabRegistrer_Fravær.TabIndex = 0;
            this.tabRegistrer_Fravær.Text = "Kartotek";
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
            this.lstKartotek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstKartotek.FullRowSelect = true;
            this.lstKartotek.GridLines = true;
            this.lstKartotek.Location = new System.Drawing.Point(0, 25);
            this.lstKartotek.Name = "lstKartotek";
            this.lstKartotek.Size = new System.Drawing.Size(997, 227);
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnRedigerMedarbejder);
            this.panel1.Controls.Add(this.btnOpretMedarbejder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 252);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(997, 42);
            this.panel1.TabIndex = 67;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 34);
            this.button1.TabIndex = 60;
            this.button1.Text = "Registrer fravær for medarbejder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRedigerMedarbejder
            // 
            this.btnRedigerMedarbejder.Location = new System.Drawing.Point(102, 3);
            this.btnRedigerMedarbejder.Name = "btnRedigerMedarbejder";
            this.btnRedigerMedarbejder.Size = new System.Drawing.Size(81, 34);
            this.btnRedigerMedarbejder.TabIndex = 61;
            this.btnRedigerMedarbejder.Text = "Rediger medarbejder";
            this.btnRedigerMedarbejder.UseVisualStyleBackColor = true;
            this.btnRedigerMedarbejder.Click += new System.EventHandler(this.btnRedigerMedarbejder_Click);
            // 
            // btnOpretMedarbejder
            // 
            this.btnOpretMedarbejder.Location = new System.Drawing.Point(189, 3);
            this.btnOpretMedarbejder.Name = "btnOpretMedarbejder";
            this.btnOpretMedarbejder.Size = new System.Drawing.Size(78, 34);
            this.btnOpretMedarbejder.TabIndex = 62;
            this.btnOpretMedarbejder.Text = "Opret Medarbejder";
            this.btnOpretMedarbejder.UseVisualStyleBackColor = true;
            this.btnOpretMedarbejder.Click += new System.EventHandler(this.btnOpretMedarbejder_Click);
            // 
            // lstFravær
            // 
            this.lstFravær.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.dato_fra,
            this.dato_til,
            this.type,
            this.note});
            this.lstFravær.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstFravær.FullRowSelect = true;
            this.lstFravær.Location = new System.Drawing.Point(0, 294);
            this.lstFravær.Name = "lstFravær";
            this.lstFravær.Size = new System.Drawing.Size(997, 177);
            this.lstFravær.TabIndex = 64;
            this.lstFravær.UseCompatibleStateImageBehavior = false;
            this.lstFravær.View = System.Windows.Forms.View.Details;
            this.lstFravær.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstFravær_MouseDown);
            // 
            // id
            // 
            this.id.Text = "ID";
            // 
            // dato_fra
            // 
            this.dato_fra.Text = "Dato fra";
            this.dato_fra.Width = 100;
            // 
            // dato_til
            // 
            this.dato_til.Text = "Dato til";
            this.dato_til.Width = 100;
            // 
            // type
            // 
            this.type.Text = "Type";
            this.type.Width = 146;
            // 
            // note
            // 
            this.note.Text = "Note";
            this.note.Width = 300;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.txt_soeg});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(997, 25);
            this.toolStrip1.TabIndex = 66;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(27, 22);
            this.toolStripLabel1.Text = "Søg";
            // 
            // txt_soeg
            // 
            this.txt_soeg.BackColor = System.Drawing.Color.White;
            this.txt_soeg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_soeg.Name = "txt_soeg";
            this.txt_soeg.Size = new System.Drawing.Size(150, 25);
            this.txt_soeg.TextChanged += new System.EventHandler(this.txtSøg_TextChanged);
            // 
            // RedigerFraværMenu
            // 
            this.RedigerFraværMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redigérFraværToolStripMenuItem});
            this.RedigerFraværMenu.Name = "RedigerFraværMenu";
            this.RedigerFraværMenu.Size = new System.Drawing.Size(154, 26);
            // 
            // redigérFraværToolStripMenuItem
            // 
            this.redigérFraværToolStripMenuItem.Name = "redigérFraværToolStripMenuItem";
            this.redigérFraværToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.redigérFraværToolStripMenuItem.Text = "Redigér Fravær";
            this.redigérFraværToolStripMenuItem.Click += new System.EventHandler(this.redigérFraværToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabRegistrer_Fravær);
            this.tabControl1.Controls.Add(this.tabKalender);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1009, 501);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage1.Controls.Add(this.chart1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1001, 475);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Statistik";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1001, 475);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 501);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Muu Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabKalender.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabRegistrer_Fravær.ResumeLayout(false);
            this.tabRegistrer_Fravær.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.RedigerFraværMenu.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRedigerMedarbejder;
        private System.Windows.Forms.Button btnOpretMedarbejder;
        private System.Windows.Forms.ListView lstFravær;
        private System.Windows.Forms.ColumnHeader dato_fra;
        private System.Windows.Forms.ColumnHeader dato_til;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.ColumnHeader note;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txt_soeg;
        private CalendarControl.EVCalendar evCalendar1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem indsætNyhedToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip RedigerFraværMenu;
        private System.Windows.Forms.ToolStripMenuItem redigérFraværToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sletNyhedToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

