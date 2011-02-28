namespace GUI
{
    partial class FrmFravær
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
            this.btnFraværNote = new System.Windows.Forms.Label();
            this.txtSlutDato = new System.Windows.Forms.TextBox();
            this.txtStartDato = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbFerie = new System.Windows.Forms.RadioButton();
            this.rdbFri = new System.Windows.Forms.RadioButton();
            this.rdbSyg = new System.Windows.Forms.RadioButton();
            this.btnSubmitFravær = new System.Windows.Forms.Button();
            this.txtFraværNote = new System.Windows.Forms.TextBox();
            this.btnCancelFravær = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFraværNote
            // 
            this.btnFraværNote.AutoSize = true;
            this.btnFraværNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFraværNote.Location = new System.Drawing.Point(5, 74);
            this.btnFraværNote.Name = "btnFraværNote";
            this.btnFraværNote.Size = new System.Drawing.Size(30, 13);
            this.btnFraværNote.TabIndex = 44;
            this.btnFraværNote.Text = "Note";
            // 
            // txtSlutDato
            // 
            this.txtSlutDato.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSlutDato.Location = new System.Drawing.Point(120, 44);
            this.txtSlutDato.Name = "txtSlutDato";
            this.txtSlutDato.Size = new System.Drawing.Size(152, 20);
            this.txtSlutDato.TabIndex = 41;
            // 
            // txtStartDato
            // 
            this.txtStartDato.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartDato.Location = new System.Drawing.Point(120, 12);
            this.txtStartDato.Name = "txtStartDato";
            this.txtStartDato.Size = new System.Drawing.Size(152, 20);
            this.txtStartDato.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Slut Dato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Start Dato";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbFerie);
            this.groupBox1.Controls.Add(this.rdbFri);
            this.groupBox1.Controls.Add(this.rdbSyg);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(-187, -3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 125);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fravær";
            // 
            // rdbFerie
            // 
            this.rdbFerie.AutoSize = true;
            this.rdbFerie.Location = new System.Drawing.Point(23, 85);
            this.rdbFerie.Name = "rdbFerie";
            this.rdbFerie.Size = new System.Drawing.Size(63, 24);
            this.rdbFerie.TabIndex = 11;
            this.rdbFerie.TabStop = true;
            this.rdbFerie.Text = "Ferie";
            this.rdbFerie.UseVisualStyleBackColor = true;
            // 
            // rdbFri
            // 
            this.rdbFri.AutoSize = true;
            this.rdbFri.Location = new System.Drawing.Point(23, 56);
            this.rdbFri.Name = "rdbFri";
            this.rdbFri.Size = new System.Drawing.Size(45, 24);
            this.rdbFri.TabIndex = 10;
            this.rdbFri.TabStop = true;
            this.rdbFri.Text = "Fri";
            this.rdbFri.UseVisualStyleBackColor = true;
            // 
            // rdbSyg
            // 
            this.rdbSyg.AutoSize = true;
            this.rdbSyg.Checked = true;
            this.rdbSyg.Location = new System.Drawing.Point(23, 26);
            this.rdbSyg.Name = "rdbSyg";
            this.rdbSyg.Size = new System.Drawing.Size(54, 24);
            this.rdbSyg.TabIndex = 9;
            this.rdbSyg.TabStop = true;
            this.rdbSyg.Text = "Syg";
            this.rdbSyg.UseVisualStyleBackColor = true;
            // 
            // btnSubmitFravær
            // 
            this.btnSubmitFravær.Location = new System.Drawing.Point(43, 191);
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
            this.txtFraværNote.Location = new System.Drawing.Point(120, 71);
            this.txtFraværNote.Multiline = true;
            this.txtFraværNote.Name = "txtFraværNote";
            this.txtFraværNote.Size = new System.Drawing.Size(152, 99);
            this.txtFraværNote.TabIndex = 43;
            // 
            // btnCancelFravær
            // 
            this.btnCancelFravær.Location = new System.Drawing.Point(125, 191);
            this.btnCancelFravær.Name = "btnCancelFravær";
            this.btnCancelFravær.Size = new System.Drawing.Size(75, 23);
            this.btnCancelFravær.TabIndex = 46;
            this.btnCancelFravær.Text = "Annuler";
            this.btnCancelFravær.UseVisualStyleBackColor = true;
            this.btnCancelFravær.Click += new System.EventHandler(this.btnCancelFravær_Click);
            // 
            // Fravær
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnCancelFravær);
            this.Controls.Add(this.btnSubmitFravær);
            this.Controls.Add(this.btnFraværNote);
            this.Controls.Add(this.txtFraværNote);
            this.Controls.Add(this.txtSlutDato);
            this.Controls.Add(this.txtStartDato);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Fravær";
            this.Text = "Fravær";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnFraværNote;
        private System.Windows.Forms.TextBox txtSlutDato;
        private System.Windows.Forms.TextBox txtStartDato;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbFerie;
        private System.Windows.Forms.RadioButton rdbFri;
        private System.Windows.Forms.RadioButton rdbSyg;
        private System.Windows.Forms.Button btnSubmitFravær;
        private System.Windows.Forms.TextBox txtFraværNote;
        private System.Windows.Forms.Button btnCancelFravær;
    }
}