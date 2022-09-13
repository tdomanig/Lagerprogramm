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

namespace Lagerprogramm
{
   
    public partial class Form_Maschine : Form
    {
        private LagerEntities1 dblager;
        BindingList<Maschinen> BLmasch;
        public Form_Maschine()
        {
            InitializeComponent();
        }
        private void Form_Maschine_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();

        }
        private void but_einlesen_Click(object sender, EventArgs e)
        {
            dblager = new LagerEntities1();

            var Maschine = dblager.Maschinen
                .Select(p => p)
                .ToList();
                            
            
                            
                
            BLmasch = dblager.Maschinen.Local.ToBindingList();
            bindingSource1.DataSource = BLmasch;
            dataGridView1.Refresh();
            
            Maschinen aktMaschine = BLmasch[dataGridView1.CurrentRow.Index];
            tb_Maschine.Text = aktMaschine.Maschine;
            tb_Maschinenummer.Text = aktMaschine.Maschinennummer;
            tb_Baujahr.Text = aktMaschine.Baujahr.Value.ToString("dd.MM.yyyy");
            tb_Hersteller.Text = aktMaschine.Hersteller;
        }

        private void but_Speichern_Click(object sender, EventArgs e)
        {
            Maschinen aktMaschine = BLmasch[dataGridView1.CurrentRow.Index];
            aktMaschine.Maschine = tb_Maschine.Text;
            aktMaschine.Maschinennummer = tb_Maschinenummer.Text;
            aktMaschine.Baujahr = Convert.ToDateTime(tb_Baujahr.Text);
            aktMaschine.Hersteller = tb_Hersteller.Text;
            try
            {
                dblager.SaveChanges();
                dataGridView1.Refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("Maschinennummern können nicht geändert werden! Bitte die eingetragene Maschinenummer eintragen!","Fehler",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void but_Löschen_Click(object sender, EventArgs e)
        {
            Maschinen aktMaschine = BLmasch[dataGridView1.CurrentRow.Index];
            if (MessageBox.Show($"Wollen sie den Eintrag : {aktMaschine.Maschine} wirklich löschen?", "Warnung", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
            {
                return;
            }
            else
            {
                try
                {
                    dblager.Maschinen.Remove(aktMaschine);
                    dblager.SaveChanges();
                    dataGridView1.Refresh();
                }
                catch (Exception)
                {
                    MessageBox.Show("Maschine ist noch mit einem Artikel verbunden. Bitte die verbundenen Artikel löschen", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void but_Hinzufügen_Click(object sender, EventArgs e)
        {
            using (var db =new LagerEntities1())
            {
                Maschinen c = new Maschinen
                {
                    Maschine = tb_Maschine.Text,
                    Maschinennummer = tb_Maschinenummer.Text,
                    Baujahr = Convert.ToDateTime(tb_Baujahr.Text),
                    Hersteller = tb_Hersteller.Text


                };
                dblager.Maschinen.Add(c);
            }
            try
            {
                
                dblager.SaveChanges();
                dataGridView1.Refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("Speichern fehlfeschlagen!");
            }
        }

        private void but_Suche_Click(object sender, EventArgs e)
        {
            Maschinen aktmasch;
            dblager = new LagerEntities1();

            try
            {
                var Maschine = dblager.Maschinen
                .Where(p => p.Maschinennummer == tb_suche.Text)
                .ToList();




                BLmasch = dblager.Maschinen.Local.ToBindingList();
                bindingSource1.DataSource = BLmasch;
                dataGridView1.Refresh();

                Maschinen aktMaschine = BLmasch[dataGridView1.CurrentRow.Index];
                tb_Maschine.Text = aktMaschine.Maschine;
                tb_Maschinenummer.Text = aktMaschine.Maschinennummer;
                tb_Baujahr.Text = aktMaschine.Baujahr.Value.ToString("dd.MM.yyyy");
                tb_Hersteller.Text = aktMaschine.Hersteller;
            }
            catch (Exception)
            {
                MessageBox.Show("Maschine konnte nicht gefunden werden", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
