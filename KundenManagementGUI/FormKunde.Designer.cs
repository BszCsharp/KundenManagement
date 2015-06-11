namespace KundenManagementGUI
{
    partial class FormKunde
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonKundenAnzeigen = new System.Windows.Forms.Button();
            this.comboBoxKunden = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxKundenId = new System.Windows.Forms.TextBox();
            this.textBoxKundenName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxKundenVorname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxKundenGebDatum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonNeuerKunde = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonKundenAnzeigen
            // 
            this.buttonKundenAnzeigen.Location = new System.Drawing.Point(51, 26);
            this.buttonKundenAnzeigen.Name = "buttonKundenAnzeigen";
            this.buttonKundenAnzeigen.Size = new System.Drawing.Size(232, 26);
            this.buttonKundenAnzeigen.TabIndex = 0;
            this.buttonKundenAnzeigen.Text = "Kunden anzeigen";
            this.buttonKundenAnzeigen.UseVisualStyleBackColor = true;
            this.buttonKundenAnzeigen.Click += new System.EventHandler(this.buttonKundenAnzeigen_Click);
            // 
            // comboBoxKunden
            // 
            this.comboBoxKunden.FormattingEnabled = true;
            this.comboBoxKunden.Location = new System.Drawing.Point(50, 69);
            this.comboBoxKunden.Name = "comboBoxKunden";
            this.comboBoxKunden.Size = new System.Drawing.Size(232, 21);
            this.comboBoxKunden.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "KundenID";
            // 
            // textBoxKundenId
            // 
            this.textBoxKundenId.Location = new System.Drawing.Point(115, 112);
            this.textBoxKundenId.Name = "textBoxKundenId";
            this.textBoxKundenId.Size = new System.Drawing.Size(166, 20);
            this.textBoxKundenId.TabIndex = 3;
            // 
            // textBoxKundenName
            // 
            this.textBoxKundenName.Location = new System.Drawing.Point(115, 151);
            this.textBoxKundenName.Name = "textBoxKundenName";
            this.textBoxKundenName.Size = new System.Drawing.Size(166, 20);
            this.textBoxKundenName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // textBoxKundenVorname
            // 
            this.textBoxKundenVorname.Location = new System.Drawing.Point(115, 189);
            this.textBoxKundenVorname.Name = "textBoxKundenVorname";
            this.textBoxKundenVorname.Size = new System.Drawing.Size(166, 20);
            this.textBoxKundenVorname.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Vorname";
            // 
            // textBoxKundenGebDatum
            // 
            this.textBoxKundenGebDatum.Location = new System.Drawing.Point(116, 239);
            this.textBoxKundenGebDatum.Name = "textBoxKundenGebDatum";
            this.textBoxKundenGebDatum.Size = new System.Drawing.Size(166, 20);
            this.textBoxKundenGebDatum.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Geb-Datum";
            // 
            // buttonNeuerKunde
            // 
            this.buttonNeuerKunde.Location = new System.Drawing.Point(57, 285);
            this.buttonNeuerKunde.Name = "buttonNeuerKunde";
            this.buttonNeuerKunde.Size = new System.Drawing.Size(89, 27);
            this.buttonNeuerKunde.TabIndex = 10;
            this.buttonNeuerKunde.Text = "Neu";
            this.buttonNeuerKunde.UseVisualStyleBackColor = true;
            this.buttonNeuerKunde.Click += new System.EventHandler(this.buttonNeuerKunde_Click);
            // 
            // FormKunde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 428);
            this.Controls.Add(this.buttonNeuerKunde);
            this.Controls.Add(this.textBoxKundenGebDatum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxKundenVorname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxKundenName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxKundenId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxKunden);
            this.Controls.Add(this.buttonKundenAnzeigen);
            this.Name = "FormKunde";
            this.Text = "Kundenverwaltung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonKundenAnzeigen;
        private System.Windows.Forms.ComboBox comboBoxKunden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxKundenId;
        private System.Windows.Forms.TextBox textBoxKundenName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxKundenVorname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxKundenGebDatum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonNeuerKunde;
    }
}

