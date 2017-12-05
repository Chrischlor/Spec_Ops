namespace Brugergrænseflade
{
    partial class FormLogInd
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
            this.buttonLogInd = new System.Windows.Forms.Button();
            this.textBoxLIBrugernavn = new System.Windows.Forms.TextBox();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.labelLIBrugernavn = new System.Windows.Forms.Label();
            this.labelLIAdgangskode = new System.Windows.Forms.Label();
            this.textBoxLIAdgangskode = new System.Windows.Forms.TextBox();
            this.labelLISpecOptikAps = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLogInd
            // 
            this.buttonLogInd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogInd.Location = new System.Drawing.Point(12, 146);
            this.buttonLogInd.Name = "buttonLogInd";
            this.buttonLogInd.Size = new System.Drawing.Size(190, 36);
            this.buttonLogInd.TabIndex = 1;
            this.buttonLogInd.Text = "Log ind";
            this.buttonLogInd.UseVisualStyleBackColor = true;
            // 
            // textBoxLIBrugernavn
            // 
            this.textBoxLIBrugernavn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLIBrugernavn.Location = new System.Drawing.Point(108, 51);
            this.textBoxLIBrugernavn.Name = "textBoxLIBrugernavn";
            this.textBoxLIBrugernavn.Size = new System.Drawing.Size(100, 22);
            this.textBoxLIBrugernavn.TabIndex = 2;
            // 
            // labelLIBrugernavn
            // 
            this.labelLIBrugernavn.AutoSize = true;
            this.labelLIBrugernavn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLIBrugernavn.Location = new System.Drawing.Point(12, 54);
            this.labelLIBrugernavn.Name = "labelLIBrugernavn";
            this.labelLIBrugernavn.Size = new System.Drawing.Size(77, 16);
            this.labelLIBrugernavn.TabIndex = 3;
            this.labelLIBrugernavn.Text = "Brugernavn";
            // 
            // labelLIAdgangskode
            // 
            this.labelLIAdgangskode.AutoSize = true;
            this.labelLIAdgangskode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLIAdgangskode.Location = new System.Drawing.Point(8, 107);
            this.labelLIAdgangskode.Name = "labelLIAdgangskode";
            this.labelLIAdgangskode.Size = new System.Drawing.Size(94, 16);
            this.labelLIAdgangskode.TabIndex = 4;
            this.labelLIAdgangskode.Text = "Adgangskode";
            // 
            // textBoxLIAdgangskode
            // 
            this.textBoxLIAdgangskode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLIAdgangskode.Location = new System.Drawing.Point(108, 104);
            this.textBoxLIAdgangskode.Name = "textBoxLIAdgangskode";
            this.textBoxLIAdgangskode.Size = new System.Drawing.Size(100, 22);
            this.textBoxLIAdgangskode.TabIndex = 5;
            // 
            // labelLISpecOptikAps
            // 
            this.labelLISpecOptikAps.AutoSize = true;
            this.labelLISpecOptikAps.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLISpecOptikAps.Location = new System.Drawing.Point(56, 20);
            this.labelLISpecOptikAps.Name = "labelLISpecOptikAps";
            this.labelLISpecOptikAps.Size = new System.Drawing.Size(101, 16);
            this.labelLISpecOptikAps.TabIndex = 6;
            this.labelLISpecOptikAps.Text = "Spec Optik Aps";
            // 
            // FormLogInd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 194);
            this.Controls.Add(this.labelLISpecOptikAps);
            this.Controls.Add(this.textBoxLIAdgangskode);
            this.Controls.Add(this.labelLIAdgangskode);
            this.Controls.Add(this.labelLIBrugernavn);
            this.Controls.Add(this.textBoxLIBrugernavn);
            this.Controls.Add(this.buttonLogInd);
            this.Name = "FormLogInd";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogInd;
        private System.Windows.Forms.TextBox textBoxLIBrugernavn;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Label labelLIBrugernavn;
        private System.Windows.Forms.Label labelLIAdgangskode;
        private System.Windows.Forms.TextBox textBoxLIAdgangskode;
        private System.Windows.Forms.Label labelLISpecOptikAps;
    }
}

