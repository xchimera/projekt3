﻿namespace GUI
{
    partial class FrmRedigerFravær
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRedigerFravær));
            this.dtpFra = new System.Windows.Forms.DateTimePicker();
            this.btnCancelFravær = new System.Windows.Forms.Button();
            this.rdbFerie = new System.Windows.Forms.RadioButton();
            this.btnEditFravær = new System.Windows.Forms.Button();
            this.btnFraværNote = new System.Windows.Forms.Label();
            this.txtFraværNote = new System.Windows.Forms.TextBox();
            this.dtpTil = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbSyg = new System.Windows.Forms.RadioButton();
            this.rdbFri = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpFra
            // 
            this.dtpFra.Location = new System.Drawing.Point(199, 15);
            this.dtpFra.Name = "dtpFra";
            this.dtpFra.Size = new System.Drawing.Size(152, 20);
            this.dtpFra.TabIndex = 56;
            // 
            // btnCancelFravær
            // 
            this.btnCancelFravær.ForeColor = System.Drawing.Color.Black;
            this.btnCancelFravær.Location = new System.Drawing.Point(186, 197);
            this.btnCancelFravær.Name = "btnCancelFravær";
            this.btnCancelFravær.Size = new System.Drawing.Size(75, 23);
            this.btnCancelFravær.TabIndex = 55;
            this.btnCancelFravær.Text = "Annuler";
            this.btnCancelFravær.UseVisualStyleBackColor = true;
            this.btnCancelFravær.Click += new System.EventHandler(this.btnCancelFravær_Click_1);
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
            // btnEditFravær
            // 
            this.btnEditFravær.ForeColor = System.Drawing.Color.Black;
            this.btnEditFravær.Location = new System.Drawing.Point(104, 197);
            this.btnEditFravær.Name = "btnEditFravær";
            this.btnEditFravær.Size = new System.Drawing.Size(75, 23);
            this.btnEditFravær.TabIndex = 54;
            this.btnEditFravær.Text = "Redigér";
            this.btnEditFravær.UseVisualStyleBackColor = true;
            this.btnEditFravær.Click += new System.EventHandler(this.btnEditFravær_Click);
            // 
            // btnFraværNote
            // 
            this.btnFraværNote.AutoSize = true;
            this.btnFraværNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFraværNote.Location = new System.Drawing.Point(119, 81);
            this.btnFraværNote.Name = "btnFraværNote";
            this.btnFraværNote.Size = new System.Drawing.Size(34, 13);
            this.btnFraværNote.TabIndex = 53;
            this.btnFraværNote.Text = "Note";
            // 
            // txtFraværNote
            // 
            this.txtFraværNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFraværNote.Location = new System.Drawing.Point(199, 79);
            this.txtFraværNote.Multiline = true;
            this.txtFraværNote.Name = "txtFraværNote";
            this.txtFraværNote.Size = new System.Drawing.Size(152, 99);
            this.txtFraværNote.TabIndex = 52;
            // 
            // dtpTil
            // 
            this.dtpTil.Location = new System.Drawing.Point(199, 41);
            this.dtpTil.Name = "dtpTil";
            this.dtpTil.Size = new System.Drawing.Size(152, 20);
            this.dtpTil.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(119, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Slut Dato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Start Dato";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbFerie);
            this.groupBox1.Controls.Add(this.rdbFri);
            this.groupBox1.Controls.Add(this.rdbSyg);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(21, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(92, 125);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fravær";
            // 
            // FrmRedigerFravær
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(123)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(363, 237);
            this.Controls.Add(this.dtpFra);
            this.Controls.Add(this.btnCancelFravær);
            this.Controls.Add(this.btnEditFravær);
            this.Controls.Add(this.btnFraværNote);
            this.Controls.Add(this.txtFraværNote);
            this.Controls.Add(this.dtpTil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRedigerFravær";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rediger Fravær";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFra;
        private System.Windows.Forms.Button btnCancelFravær;
        private System.Windows.Forms.RadioButton rdbFerie;
        private System.Windows.Forms.Button btnEditFravær;
        private System.Windows.Forms.Label btnFraværNote;
        private System.Windows.Forms.TextBox txtFraværNote;
        private System.Windows.Forms.DateTimePicker dtpTil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbSyg;
        private System.Windows.Forms.RadioButton rdbFri;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}