using DataAccess;
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
    public partial class FormKunde : Form
    {
        List<Kunde> liKunde = null;
        DataTransfer dt = new DataTransfer();
        public FormKunde()
        {
            InitializeComponent();

        }

        private void buttonKundenAnzeigen_Click(object sender, EventArgs e)
        {
            liKunde = dt.GetAlleKunden();
            DatenBindung();
        }

        private void DatenBindung()
        {
            comboBoxKunden.DataSource = null;
            comboBoxKunden.DataSource = liKunde; // komplexe Datenbindung
            // einfache Datenbindung
            this.textBoxKundenId.DataBindings.Clear();
            this.textBoxKundenId.DataBindings.Add("Text", liKunde, "KundenID");
            this.textBoxKundenName.DataBindings.Clear();
            this.textBoxKundenName.DataBindings.Add("Text", liKunde, "Name");
            this.textBoxKundenVorname.DataBindings.Clear();
            this.textBoxKundenVorname.DataBindings.Add("Text", liKunde, "VName");
            this.textBoxKundenGebDatum.DataBindings.Clear();
            this.textBoxKundenGebDatum.DataBindings.Add("Text", liKunde, "GebDat");

        }

        private void buttonNeuerKunde_Click(object sender, EventArgs e)
        {
            FormNeuerKunde fnk = new FormNeuerKunde();
            fnk.ShowDialog();  // modales Anzeigen
            // List-Objekt hinzufügen fnk.NeuerKunde
            
            if (fnk.NeuerKunde != null)
            {
                liKunde.Add(fnk.NeuerKunde);
                if (dt.SaveKunde(fnk.NeuerKunde) == false)
                {
                    toolStripStatusLabel1.Text = "Fehler beim Speichern";
                }
                DatenBindung();
            }
            fnk = null;

        }
    }
}
