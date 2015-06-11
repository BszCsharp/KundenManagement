namespace KundenManagementGUI
{
    partial class FormNeuerKunde
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
            this.textBoxKundenGebDatum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxKundenVorname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxKundenName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxKundenId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxKundenGebDatum
            // 
            this.textBoxKundenGebDatum.Location = new System.Drawing.Point(102, 173);
            this.textBoxKundenGebDatum.Name = "textBoxKundenGebDatum";
            this.textBoxKundenGebDatum.Size = new System.Drawing.Size(166, 20);
            this.textBoxKundenGebDatum.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Geb-Datum";
            // 
            // textBoxKundenVorname
            // 
            this.textBoxKundenVorname.Location = new System.Drawing.Point(101, 123);
            this.textBoxKundenVorname.Name = "textBoxKundenVorname";
            this.textBoxKundenVorname.Size = new System.Drawing.Size(166, 20);
            this.textBoxKundenVorname.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Vorname";
            // 
            // textBoxKundenName
            // 
            this.textBoxKundenName.Location = new System.Drawing.Point(101, 85);
            this.textBoxKundenName.Name = "textBoxKundenName";
            this.textBoxKundenName.Size = new System.Drawing.Size(166, 20);
            this.textBoxKundenName.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Name";
            // 
            // textBoxKundenId
            // 
            this.textBoxKundenId.Location = new System.Drawing.Point(101, 46);
            this.textBoxKundenId.Name = "textBoxKundenId";
            this.textBoxKundenId.Size = new System.Drawing.Size(166, 20);
            this.textBoxKundenId.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "KundenID";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(40, 213);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(54, 30);
            this.buttonOK.TabIndex = 18;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(195, 213);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(72, 30);
            this.buttonCancel.TabIndex = 19;
            this.buttonCancel.Text = "Abbruch";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormNeuerKunde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 305);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxKundenGebDatum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxKundenVorname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxKundenName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxKundenId);
            this.Controls.Add(this.label1);
            this.Name = "FormNeuerKunde";
            this.Text = "neuer Kunde";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxKundenGebDatum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxKundenVorname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxKundenName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxKundenId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
    }
}