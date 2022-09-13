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
    public partial class From_Baugruppe : Form
    {
        private LagerEntities1 dblager;
        BindingList<Baugruppen> BLBau;

        
        public From_Baugruppe()
        {
            InitializeComponent();
        }
        private void From_Baugruppe_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }
        private void but_einlesen_Click(object sender, EventArgs e)
        {
            dblager = new LagerEntities1();
            var Baugruppe = dblager.Baugruppen
                    .Select(p=>p)
                    .ToList();
            BLBau = dblager.Baugruppen.Local.ToBindingList();
            baugruppeBindingSource.DataSource = BLBau;
            dataGridView1.Refresh();
            
            Baugruppen aktbaugruppe = BLBau[dataGridView1.CurrentRow.Index];
            tb_Baugruppe.Text = aktbaugruppe.Baugruppe;
            tb_Baugruppenummer.Text = aktbaugruppe.Baugruppennummer;
            tb_Hersteller.Text = aktbaugruppe.Hersteller;
            tb_Maschine.Text = aktbaugruppe.Maschine;

        }

        private void but_Speichern_Click(object sender, EventArgs e)
        {
            Baugruppen aktbaugruppe = BLBau[dataGridView1.CurrentRow.Index];
            aktbaugruppe.Baugruppe = tb_Baugruppe.Text;
            aktbaugruppe.Baugruppennummer = tb_Baugruppenummer.Text;
            aktbaugruppe.Hersteller = tb_Hersteller.Text;
            aktbaugruppe.Maschine = tb_Maschine.Text;
            try
            {
                
                
                dblager.SaveChanges();
                dataGridView1.Refresh();
            }catch(Exception)
            {
                MessageBox.Show("Baugruppennummern können nicht geändert werden!!");

            }
            
        }

        private void but_löschen_Click(object sender, EventArgs e)
        {
            Baugruppen aktbaugruppe = BLBau[dataGridView1.CurrentRow.Index];
            if( MessageBox.Show($"Wollen sie den Eintrag : {aktbaugruppe.Baugruppe} wirklich löschen?","Warnung",MessageBoxButtons.OKCancel, MessageBoxIcon.Question)!= DialogResult.OK)
            {
                return;
            }
            else
            {
                try
                {
                    dblager.Baugruppen.Remove(aktbaugruppe);
                    dblager.SaveChanges();
                    dataGridView1.Refresh();
                }
                catch (Exception)
                {
                    MessageBox.Show("Baugruppe ist noch mit Artikel verbunden. Bitte zuerst die verbundenen Artikel löschen", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void but_Hinzufügen_Click(object sender, EventArgs e)
        {
            using (var db = new LagerEntities1())
            {
                Baugruppen c = new Baugruppen
                {
                    Baugruppe = tb_Baugruppe.Text,
                    Baugruppennummer = tb_Baugruppenummer.Text,
                    Hersteller = tb_Hersteller.Text,
                    Maschine = tb_Maschine.Text
                };
                dblager.Baugruppen.Add(c);
                dblager.SaveChanges();
            }
        }

        private void but_Suche_Click(object sender, EventArgs e)
        {
            try
            {
                dblager = new LagerEntities1();
                var Baugruppe = dblager.Baugruppen
                        .Where(p => p.Baugruppennummer == textBox1.Text)
                        .ToList();
                BLBau = dblager.Baugruppen.Local.ToBindingList();
                baugruppeBindingSource.DataSource = BLBau;
                dataGridView1.Refresh();

                Baugruppen aktbaugruppe = BLBau[dataGridView1.CurrentRow.Index];
                tb_Baugruppe.Text = aktbaugruppe.Baugruppe;
                tb_Baugruppenummer.Text = aktbaugruppe.Baugruppennummer;
                tb_Hersteller.Text = aktbaugruppe.Hersteller;
                tb_Maschine.Text = aktbaugruppe.Maschine;
            }
            catch (Exception)
            {
                MessageBox.Show("Baugruppe existiert nicht", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
