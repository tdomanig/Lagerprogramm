using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Drawing.Drawing2D;

namespace Lagerprogramm
{
   

    public partial class Form1 : Form
    {

        private LagerEntities1 dblager;
        BindingList<Ersatzteile> BLAusgabe;
        Artikel artikel = new Artikel();

        public Form1()
        {
            InitializeComponent();
            lbl_Artikelbezeichnung.Visible = true;
            lbl_Artikelnummer.Visible = true;
            lbl_Barcode.Visible = true;
            lbl_Bau_Nr.Visible = true;
            lbl_lagerplatz.Visible = true;
            lbl_Ma_Nr.Visible = true;
            but_Suche.Enabled = false; ;
            but_Ausbuchen.Enabled = false;

        }
        
        

        private void programmendeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void barcodescannerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Barcodegenerator1 gen = new Barcodegenerator1();
            gen.Show();
            this.Hide();
        }

       
        private void baugruppenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            From_Baugruppe bau = new From_Baugruppe();
            bau.Show();
            this.Hide();
        }

        private void maschinenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Maschine masch = new Form_Maschine();
            masch.Show();
            this.Hide();

        }

        private void but_einlesen_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            lbl_Artikelnummer.Text = "";
            tb_Artikelbezeichnung.Text = "";
            tb_Baugruppennummer.Text = "";
            tb_Lagerplatz.Text = "";
            tb_Maschinennummer.Text = "";
            lbl_Artikelbezeichnung.Text = "";
            tb_Artikelnummer.Text = "";
            lbl_Bau_Nr.Text = "";
            lbl_lagerplatz.Text ="";
            lbl_Ma_Nr.Text = "";
            tb_suche.Text = "";
            updownAnzahl.Value = 0;
            but_Suche.BackColor = Color.Red;


        }

        private void updownAnzahl_ValueChanged(object sender, EventArgs e)
        {
            updownAnzahl.Maximum = 100;
            updownAnzahl.Minimum = 0;
        }

        private void artikelLöschenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ersatzteile aktartikel = BLAusgabe[dataGridView1.CurrentRow.Index];

            if (MessageBox.Show($"Wollen sie den Eintrag : {aktartikel.Artikelnummer} wirklich löschen?", "Warnung", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
            {
                return;
            }
            else
            {
                dblager.Ersatzteile.Remove(aktartikel);
                dblager.SaveChanges();
                dataGridView1.Refresh();
            }
        }

        private void datenbankSpeichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dblager.SaveChanges();
                dataGridView1.Refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("Keine Datenbank geöffnet!");
            }
           
        }

        private void datenbankÖffnenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dblager = new LagerEntities1();

                var Ersatzteile = dblager.Ersatzteile
                    .Select(p => p)
                    .ToList();
                BLAusgabe = dblager.Ersatzteile.Local.ToBindingList();
                ersatzteileBindingSource2.DataSource = BLAusgabe;
                dataGridView1.Refresh();            
        }

        private void but_Suche_Click(object sender, EventArgs e)
        {
            if (rb_aus.Checked && tb_suche.Text != "")
            {
                but_Ausbuchen.Enabled = true;
            }
            Ersatzteile aktartikel;
            dblager = new LagerEntities1();
            try
            {
                if (rb_aus.Checked||rb_ä_Bar.Checked)
                {
                    var Ersatzteile = dblager.Ersatzteile
                  .Where(p => p.Artikelnummer == lbl_Barcode.Text)
                  .ToList();
                }
                
                else if(rb_ma_nr.Checked)
                {
                    var Ersatzteile = dblager.Ersatzteile
                     .Where(p => p.Maschinenummer == tb_suche.Text)
                     .ToList();
                }
                else if (rb_baugr_nr.Checked)
                {
                    var Ersatzteile = dblager.Ersatzteile
                     .Where(p => p.Baugruppennummer == tb_suche.Text)
                     .ToList();
                }
                else
                {
                    var Ersatzteile = dblager.Ersatzteile
                         .Where(p => p.Artikelnummer == tb_suche.Text)
                         .ToList();
                }


               
                BLAusgabe = dblager.Ersatzteile.Local.ToBindingList();
                ersatzteileBindingSource2.DataSource = BLAusgabe;
                dataGridView1.Refresh();
                 aktartikel = BLAusgabe[dataGridView1.CurrentRow.Index];
                artikel.Artikelbez = aktartikel.Artikelbezeichnung;
                artikel.Artnr = aktartikel.Artikelnummer;
                artikel.lagerpl = aktartikel.Lagerplatz;
                artikel.stückzahl = aktartikel.Anzahl;
                artikel.Baugruppennr = aktartikel.Baugruppennummer;
                artikel.Manr = aktartikel.Maschinenummer;
                updownAnzahl.Value = artikel.stückzahl;
            }
            catch (Exception)
            {
                MessageBox.Show("Artikel konnte nicht gefunden werden","Fehler",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (rb_aus.Checked)
            {
                lbl_Artikelbezeichnung.Text = artikel.Artikelbez;
                lbl_Artikelnummer.Text = artikel.Artnr;
                lbl_Bau_Nr.Text = artikel.Baugruppennr;
                lbl_lagerplatz.Text = artikel.lagerpl;
                lbl_Ma_Nr.Text = artikel.Manr;
            }
            if (rb_a_art.Checked||rb_ä_Bar.Checked)
            {
                lbl_Artikelnummer.Text = artikel.Artnr;
                tb_Artikelbezeichnung.Text = artikel.Artikelbez;
                tb_Baugruppennummer.Text = artikel.Baugruppennr;
                tb_Lagerplatz.Text = artikel.lagerpl;
                tb_Maschinennummer.Text = artikel.Manr;
            }
           



        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_aus.Checked)
            {
                lbl_Artikelbezeichnung.Visible = true;
                lbl_Artikelnummer.Visible = true;
                lbl_Barcode.Visible = true;
                lbl_Bau_Nr.Visible = true;
                lbl_lagerplatz.Visible = true;
                lbl_Ma_Nr.Visible = true;
                but_Suche.BackColor = Color.Red;
                but_Leser.Enabled = true;
                but_Leser.BackColor = Color.Red;
                but_Ausbuchen.Text = "Anzahl Buchen";
                but_Suche.Text = "Initialisieren";
                but_Leser.Text = "Leser aktivieren";
                but_Suche.Enabled = true;
                
            }
            if (rb_ä_Bar.Checked)
            {
                lbl_Artikelbezeichnung.Visible = false;
                lbl_Artikelnummer.Visible = true;
                lbl_Barcode.Visible = true;
                lbl_Bau_Nr.Visible = false;
                lbl_lagerplatz.Visible = false;
                lbl_Ma_Nr.Visible = false;
                but_Suche.BackColor = Color.Red;
                but_Ausbuchen.Text = "Speichern";
                but_Leser.Enabled = true;
                but_Leser.BackColor = Color.Red;
                but_Suche.Text = "Initialisieren";
                but_Leser.Text = "Leser aktivieren";
                but_Ausbuchen.Enabled = false;
            }
            if (rb_a_art.Checked)
            {
                lbl_Artikelbezeichnung.Visible = false;
                lbl_Artikelnummer.Visible = true;
                lbl_Barcode.Visible = false;
                lbl_Bau_Nr.Visible = false;
                lbl_lagerplatz.Visible = false;
                lbl_Ma_Nr.Visible = false;
                but_Suche.BackColor = Color.Red;
                but_Ausbuchen.Text = "Speichern";
                but_Leser.Enabled = false; ;
                but_Leser.BackColor = Color.Gray;
                but_Suche.Text = "Suche";
                but_Leser.Text = "Leser aktivieren";
                but_Ausbuchen.Enabled = false;
            }

            if (rb_add_artikel.Checked)
            {
                lbl_Artikelbezeichnung.Visible = false;
                lbl_Artikelnummer.Visible = false;
                lbl_Barcode.Visible = false;
                lbl_Bau_Nr.Visible = false;
                lbl_lagerplatz.Visible = false;
                lbl_Ma_Nr.Visible = false;
                but_Suche.Enabled = false;
                but_Suche.BackColor = Color.Gray;
                but_Leser.Enabled = false ;
                but_Leser.BackColor = Color.Gray;
                but_Ausbuchen.Text = "Hinzufügen";
                but_Leser.Text = "Leser aktivieren";
                but_Ausbuchen.Enabled = false;
                lbl_Barcode.Visible = true;
                but_Ausbuchen.Enabled = true;
            }
          
           if (rb_baugr_nr.Checked)
            {
                lbl_Artikelbezeichnung.Visible = true;
                lbl_Artikelnummer.Visible = true;
                lbl_Barcode.Visible = true;
                lbl_Bau_Nr.Visible = true;
                lbl_lagerplatz.Visible = true;
                lbl_Ma_Nr.Visible = true;
                but_Suche.BackColor = Color.Red;
                but_Leser.Enabled = true;
                but_Leser.BackColor = Color.Red;
                but_Ausbuchen.Text = "Ausbuchen";
                but_Suche.Text = "Suche";
                but_Leser.Text = "Leser aktivieren";
                but_Suche.Enabled = true;

            }
            if (rb_ma_nr.Checked)
            {
                lbl_Artikelbezeichnung.Visible = true;
                lbl_Artikelnummer.Visible = true;
                lbl_Barcode.Visible = true;
                lbl_Bau_Nr.Visible = true;
                lbl_lagerplatz.Visible = true;
                lbl_Ma_Nr.Visible = true;
                but_Suche.BackColor = Color.Red;
                but_Leser.Enabled = true;
                but_Leser.BackColor = Color.Red;
                but_Ausbuchen.Text = "Ausbuchen";
                but_Suche.Text = "Suche";
                but_Leser.Text = "Leser aktivieren";
                but_Suche.Enabled = true;
            }
        }

        private void but_Leser_Click(object sender, EventArgs e)
        {
            tb_suche.Enabled = true;
            tb_suche.Focus();
            if (tb_suche.Focused == true)
            {
                but_Leser.Text = "Leser aktiv";
                but_Leser.BackColor = Color.Green;

            }
        }

        private void tb_suche_Leave(object sender, EventArgs e)
        {
            if (tb_suche.Focused == false)
            {
                but_Leser.Text = "Leser aktivieren";
                but_Leser.BackColor = Color.Red;
            }
        }

        private void but_Ausbuchen_Click(object sender, EventArgs e)
        {
            if (rb_aus.Checked)
            {
                Ersatzteile aktartikel = BLAusgabe[dataGridView1.CurrentRow.Index];
                aktartikel.Anzahl = Convert.ToInt32(updownAnzahl.Value);
                dblager.SaveChanges();
            }

           
            if (  rb_a_art.Checked || rb_ä_Bar.Checked)
            {
                Ersatzteile aktartikel = BLAusgabe[dataGridView1.CurrentRow.Index];
                aktartikel.Anzahl = Convert.ToInt32(updownAnzahl.Value);
                aktartikel.Artikelbezeichnung = tb_Artikelbezeichnung.Text;
                aktartikel.Baugruppennummer = tb_Baugruppennummer.Text;
                aktartikel.Lagerplatz = tb_Lagerplatz.Text;
                aktartikel.Maschinenummer = tb_Maschinennummer.Text;
                dblager.SaveChanges();

            }
            
            if (rb_add_artikel.Checked)
            {
                using (var db = new LagerEntities1())
                {
                    Ersatzteile ers = new Ersatzteile
                    {
                        Artikelbezeichnung = tb_Artikelbezeichnung.Text,
                        Artikelnummer = tb_Artikelnummer.Text,
                        Anzahl = Convert.ToInt32(updownAnzahl.Value),
                        Baugruppennummer = tb_Baugruppennummer.Text,
                        Lagerplatz = tb_Lagerplatz.Text,
                        Maschinenummer = tb_Maschinennummer.Text
                        


                    };
                    
                    try
                    {
                        dblager.Ersatzteile.Add(ers);
                        dblager.SaveChanges();
                        
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Artikel bereits vorhanden? Falsche Maschinennummer? Falsche Baugruppennummer?Datenbank nicht geladen?", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
            
        }

        private void tb_suche_TextChanged(object sender, EventArgs e)
        {
            if (tb_suche.Text != ""&&rb_aus.Checked||rb_ä_Bar.Checked)
            {
                but_Suche.BackColor = Color.Green;
                but_Suche.Enabled = true;
                but_Ausbuchen.Enabled = true;
            }
            if (tb_suche.Text.Contains("/")&& (rb_aus.Checked||rb_ä_Bar.Checked))
            {
                but_Suche.BackColor = Color.Green;
                tb_suche.Enabled = false;
                but_Suche.Enabled = true;
            }
            lbl_Barcode.Text = tb_suche.Text.Replace("/", "");

            if (lbl_Barcode.Text != "")
            {
                but_Leser.BackColor = Color.Red;
                
            }
            
        }
    }
}
