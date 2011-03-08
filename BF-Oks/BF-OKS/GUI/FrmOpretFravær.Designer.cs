namespace GUI
{
    partial class FrmOpretFravær
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOpretFravær));
            this.btnFraværNote = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbFerie = new System.Windows.Forms.RadioButton();
            this.rdbFri = new System.Windows.Forms.RadioButton();
            this.rdbSyg = new System.Windows.Forms.RadioButton();
            this.btnSubmitFravær = new System.Windows.Forms.Button();
            this.txtFraværNote = new System.Windows.Forms.TextBox();
            this.btnCancelFravær = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFraværNote
            // 
            this.btnFraværNote.AutoSize = true;
            this.btnFraværNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFraværNote.Location = new System.Drawing.Point(108, 77);
            this.btnFraværNote.Name = "btnFraværNote";
            this.btnFraværNote.Size = new System.Drawing.Size(34, 13);
            this.btnFraværNote.TabIndex = 44;
            this.btnFraværNote.Text = "Note";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Slut Dato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Start Dato";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbFerie);
            this.groupBox1.Controls.Add(this.rdbFri);
            this.groupBox1.Controls.Add(this.rdbSyg);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Cornsilk;
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(86, 113);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fravær";
            // 
            // rdbFerie
            // 
            this.rdbFerie.AutoSize = true;
            this.rdbFerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFerie.Location = new System.Drawing.Point(23, 85);
            this.rdbFerie.Name = "rdbFerie";
            this.rdbFerie.Size = new System.Drawing.Size(53, 17);
            this.rdbFerie.TabIndex = 11;
            this.rdbFerie.TabStop = true;
            this.rdbFerie.Text = "Ferie";
            this.rdbFerie.UseVisualStyleBackColor = true;
            // 
            // rdbFri
            // 
            this.rdbFri.AutoSize = true;
            this.rdbFri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFri.Location = new System.Drawing.Point(23, 56);
            this.rdbFri.Name = "rdbFri";
            this.rdbFri.Size = new System.Drawing.Size(39, 17);
            this.rdbFri.TabIndex = 10;
            this.rdbFri.TabStop = true;
            this.rdbFri.Text = "Fri";
            this.rdbFri.UseVisualStyleBackColor = true;
            // 
            // rdbSyg
            // 
            this.rdbSyg.AutoSize = true;
            this.rdbSyg.Checked = true;
            this.rdbSyg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSyg.Location = new System.Drawing.Point(23, 26);
            this.rdbSyg.Name = "rdbSyg";
            this.rdbSyg.Size = new System.Drawing.Size(46, 17);
            this.rdbSyg.TabIndex = 9;
            this.rdbSyg.TabStop = true;
            this.rdbSyg.Text = "Syg";
            this.rdbSyg.UseVisualStyleBackColor = true;
            // 
            // btnSubmitFravær
            // 
            this.btnSubmitFravær.ForeColor = System.Drawing.Color.Black;
            this.btnSubmitFravær.Location = new System.Drawing.Point(146, 194);
            this.btnSubmitFravær.Name = "btnSubmitFravær";
            this.btnSubmitFravær.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitFravær.TabIndex = 45;
            this.btnSubmitFravær.Text = "Indsæt";
            this.btnSubmitFravær.UseVisualStyleBackColor = true;
            this.btnSubmitFravær.Click += new System.EventHandler(this.btnSubmitFravær_Click);
            // 
            // txtFraværNote
            // 
            this.txtFraværNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFraværNote.Location = new System.Drawing.Point(188, 75);
            this.txtFraværNote.Multiline = true;
            this.txtFraværNote.Name = "txtFraværNote";
            this.txtFraværNote.Size = new System.Drawing.Size(152, 99);
            this.txtFraværNote.TabIndex = 43;
            // 
            // btnCancelFravær
            // 
            this.btnCancelFravær.ForeColor = System.Drawing.Color.Black;
            this.btnCancelFravær.Location = new System.Drawing.Point(228, 194);
            this.btnCancelFravær.Name = "btnCancelFravær";
            this.btnCancelFravær.Size = new System.Drawing.Size(75, 23);
            this.btnCancelFravær.TabIndex = 46;
            this.btnCancelFravær.Text = "Annuler";
            this.btnCancelFravær.UseVisualStyleBackColor = true;
            this.btnCancelFravær.Click += new System.EventHandler(this.btnCancelFravær_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(188, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(152, 20);
            this.dateTimePicker1.TabIndex = 47;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(188, 37);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(152, 20);
            this.dateTimePicker2.TabIndex = 48;
            // 
            // FrmOpretFravær
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(123)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(353, 230);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnCancelFravær);
            this.Controls.Add(this.btnSubmitFravær);
            this.Controls.Add(this.btnFraværNote);
            this.Controls.Add(this.txtFraværNote);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Cornsilk;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOpretFravær";
            this.Text = "Opret Fravær";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnFraværNote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbFerie;
        private System.Windows.Forms.RadioButton rdbFri;
        private System.Windows.Forms.RadioButton rdbSyg;
        private System.Windows.Forms.Button btnSubmitFravær;
        private System.Windows.Forms.TextBox txtFraværNote;
        private System.Windows.Forms.Button btnCancelFravær;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}