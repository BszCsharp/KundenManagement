﻿using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KundenManagementGUI
{
    public partial class FormNeuerKunde : Form
    {
        Kunde neuerKunde = null;

        public Kunde NeuerKunde
        {
            get { return neuerKunde; }
            set { neuerKunde = value; }
        }

        public FormNeuerKunde()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            // neues Kundenobjekt
            neuerKunde = new Kunde();
            // aus Textboxen versorgen
            try
            {
                neuerKunde.KundenID = textBoxKundenId.Text;
                neuerKunde.Name = textBoxKundenName.Text;
                neuerKunde.VName = textBoxKundenVorname.Text;
                neuerKunde.GebDat = textBoxKundenGebDatum.Text;
            }
            catch (Exception)
            {

                neuerKunde = null;
            }
            this.Close();
           
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            neuerKunde = null;
            this.Close();
        }   
    }
}
