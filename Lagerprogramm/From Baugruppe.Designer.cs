namespace Lagerprogramm
{
    partial class From_Baugruppe
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
            this.components = new System.ComponentModel.Container();
            this.baugruppeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lagerDataSetBaugruppe = new Lagerprogramm.LagerDataSetBaugruppe();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.but_einlesen = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.baugruppeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baugruppennummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maschineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.herstellerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.but_Speichern = new System.Windows.Forms.Button();
            this.tb_Baugruppe = new System.Windows.Forms.TextBox();
            this.tb_Baugruppenummer = new System.Windows.Forms.TextBox();
            this.tb_Maschine = new System.Windows.Forms.TextBox();
            this.tb_Hersteller = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.but_löschen = new System.Windows.Forms.Button();
            this.but_Hinzufügen = new System.Windows.Forms.Button();
            this.but_Suche = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.baugruppeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lagerDataSetBaugruppe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // baugruppeBindingSource
            // 
            this.baugruppeBindingSource.DataMember = "Baugruppen";
            this.baugruppeBindingSource.DataSource = this.lagerDataSetBaugruppe;
            // 
            // lagerDataSetBaugruppe
            // 
            this.lagerDataSetBaugruppe.DataSetName = "LagerDataSetBaugruppe";
            this.lagerDataSetBaugruppe.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(310, 624);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(373, 26);
            this.textBox1.TabIndex = 1;
            // 
            // but_einlesen
            // 
            this.but_einlesen.Location = new System.Drawing.Point(81, 771);
            this.but_einlesen.Name = "but_einlesen";
            this.but_einlesen.Size = new System.Drawing.Size(103, 49);
            this.but_einlesen.TabIndex = 2;
            this.but_einlesen.Text = "Einlesen";
            this.but_einlesen.UseVisualStyleBackColor = true;
            this.but_einlesen.Click += new System.EventHandler(this.but_einlesen_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.baugruppeDataGridViewTextBoxColumn,
            this.baugruppennummerDataGridViewTextBoxColumn,
            this.maschineDataGridViewTextBoxColumn,
            this.herstellerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.baugruppeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(31, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(796, 530);
            this.dataGridView1.TabIndex = 0;
            // 
            // baugruppeDataGridViewTextBoxColumn
            // 
            this.baugruppeDataGridViewTextBoxColumn.DataPropertyName = "Baugruppe";
            this.baugruppeDataGridViewTextBoxColumn.HeaderText = "Baugruppe";
            this.baugruppeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.baugruppeDataGridViewTextBoxColumn.Name = "baugruppeDataGridViewTextBoxColumn";
            this.baugruppeDataGridViewTextBoxColumn.Width = 150;
            // 
            // baugruppennummerDataGridViewTextBoxColumn
            // 
            this.baugruppennummerDataGridViewTextBoxColumn.DataPropertyName = "Baugruppennummer";
            this.baugruppennummerDataGridViewTextBoxColumn.HeaderText = "Baugruppennummer";
            this.baugruppennummerDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.baugruppennummerDataGridViewTextBoxColumn.Name = "baugruppennummerDataGridViewTextBoxColumn";
            this.baugruppennummerDataGridViewTextBoxColumn.Width = 150;
            // 
            // maschineDataGridViewTextBoxColumn
            // 
            this.maschineDataGridViewTextBoxColumn.DataPropertyName = "Maschine";
            this.maschineDataGridViewTextBoxColumn.HeaderText = "Maschine";
            this.maschineDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maschineDataGridViewTextBoxColumn.Name = "maschineDataGridViewTextBoxColumn";
            this.maschineDataGridViewTextBoxColumn.Width = 150;
            // 
            // herstellerDataGridViewTextBoxColumn
            // 
            this.herstellerDataGridViewTextBoxColumn.DataPropertyName = "Hersteller";
            this.herstellerDataGridViewTextBoxColumn.HeaderText = "Hersteller";
            this.herstellerDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.herstellerDataGridViewTextBoxColumn.Name = "herstellerDataGridViewTextBoxColumn";
            this.herstellerDataGridViewTextBoxColumn.Width = 150;
            // 
            // but_Speichern
            // 
            this.but_Speichern.Location = new System.Drawing.Point(310, 771);
            this.but_Speichern.Name = "but_Speichern";
            this.but_Speichern.Size = new System.Drawing.Size(110, 49);
            this.but_Speichern.TabIndex = 3;
            this.but_Speichern.Text = "Speichern";
            this.but_Speichern.UseVisualStyleBackColor = true;
            this.but_Speichern.Click += new System.EventHandler(this.but_Speichern_Click);
            // 
            // tb_Baugruppe
            // 
            this.tb_Baugruppe.Location = new System.Drawing.Point(994, 91);
            this.tb_Baugruppe.Name = "tb_Baugruppe";
            this.tb_Baugruppe.Size = new System.Drawing.Size(373, 26);
            this.tb_Baugruppe.TabIndex = 4;
            // 
            // tb_Baugruppenummer
            // 
            this.tb_Baugruppenummer.Location = new System.Drawing.Point(994, 194);
            this.tb_Baugruppenummer.Name = "tb_Baugruppenummer";
            this.tb_Baugruppenummer.Size = new System.Drawing.Size(373, 26);
            this.tb_Baugruppenummer.TabIndex = 5;
            // 
            // tb_Maschine
            // 
            this.tb_Maschine.Location = new System.Drawing.Point(994, 297);
            this.tb_Maschine.Name = "tb_Maschine";
            this.tb_Maschine.Size = new System.Drawing.Size(373, 26);
            this.tb_Maschine.TabIndex = 6;
            // 
            // tb_Hersteller
            // 
            this.tb_Hersteller.Location = new System.Drawing.Point(994, 400);
            this.tb_Hersteller.Name = "tb_Hersteller";
            this.tb_Hersteller.Size = new System.Drawing.Size(373, 26);
            this.tb_Hersteller.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(833, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Baugruppennummer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(881, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Baugruppe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(881, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Maschine";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(881, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Hersteller";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 624);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Suche über Baugruppennummer";
            // 
            // but_löschen
            // 
            this.but_löschen.Location = new System.Drawing.Point(546, 771);
            this.but_löschen.Name = "but_löschen";
            this.but_löschen.Size = new System.Drawing.Size(112, 49);
            this.but_löschen.TabIndex = 14;
            this.but_löschen.Text = "Löschen";
            this.but_löschen.UseVisualStyleBackColor = true;
            this.but_löschen.Click += new System.EventHandler(this.but_löschen_Click);
            // 
            // but_Hinzufügen
            // 
            this.but_Hinzufügen.Location = new System.Drawing.Point(784, 771);
            this.but_Hinzufügen.Name = "but_Hinzufügen";
            this.but_Hinzufügen.Size = new System.Drawing.Size(112, 49);
            this.but_Hinzufügen.TabIndex = 15;
            this.but_Hinzufügen.Text = "Hinzufügen";
            this.but_Hinzufügen.UseVisualStyleBackColor = true;
            this.but_Hinzufügen.Click += new System.EventHandler(this.but_Hinzufügen_Click);
            // 
            // but_Suche
            // 
            this.but_Suche.Location = new System.Drawing.Point(749, 626);
            this.but_Suche.Name = "but_Suche";
            this.but_Suche.Size = new System.Drawing.Size(75, 24);
            this.but_Suche.TabIndex = 16;
            this.but_Suche.Text = "Suche";
            this.but_Suche.UseVisualStyleBackColor = true;
            this.but_Suche.Click += new System.EventHandler(this.but_Suche_Click);
            // 
            // From_Baugruppe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1940, 919);
            this.Controls.Add(this.but_Suche);
            this.Controls.Add(this.but_Hinzufügen);
            this.Controls.Add(this.but_löschen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Hersteller);
            this.Controls.Add(this.tb_Maschine);
            this.Controls.Add(this.tb_Baugruppenummer);
            this.Controls.Add(this.tb_Baugruppe);
            this.Controls.Add(this.but_Speichern);
            this.Controls.Add(this.but_einlesen);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "From_Baugruppe";
            this.Text = "From_Baugruppe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.From_Baugruppe_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.baugruppeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lagerDataSetBaugruppe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource baugruppeBindingSource;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button but_einlesen;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button but_Speichern;
        private System.Windows.Forms.TextBox tb_Baugruppe;
        private System.Windows.Forms.TextBox tb_Baugruppenummer;
        private System.Windows.Forms.TextBox tb_Maschine;
        private System.Windows.Forms.TextBox tb_Hersteller;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private LagerDataSetBaugruppe lagerDataSetBaugruppe;
        private System.Windows.Forms.DataGridViewTextBoxColumn baugruppeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baugruppennummerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maschineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn herstellerDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button but_löschen;
        private System.Windows.Forms.Button but_Hinzufügen;
        private System.Windows.Forms.Button but_Suche;
    }
}