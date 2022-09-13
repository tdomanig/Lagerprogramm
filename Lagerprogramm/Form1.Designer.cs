namespace Lagerprogramm
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ersatzteileBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.lagerDataSet1 = new Lagerprogramm.LagerDataSet();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datenbankÖffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datenbankSpeichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artikelLöschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artikelLöschenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.extrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barcodescannerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maschinenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baugruppenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optonienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programmendeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.but_einlesen = new System.Windows.Forms.Button();
            this.tb_suche = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Artikelnummer = new System.Windows.Forms.TextBox();
            this.tb_Maschinennummer = new System.Windows.Forms.TextBox();
            this.tb_Lagerplatz = new System.Windows.Forms.TextBox();
            this.tb_Artikelbezeichnung = new System.Windows.Forms.TextBox();
            this.tb_Baugruppennummer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.updownAnzahl = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_baugr_nr = new System.Windows.Forms.RadioButton();
            this.rb_ma_nr = new System.Windows.Forms.RadioButton();
            this.rb_add_artikel = new System.Windows.Forms.RadioButton();
            this.rb_aus = new System.Windows.Forms.RadioButton();
            this.rb_a_art = new System.Windows.Forms.RadioButton();
            this.rb_ä_Bar = new System.Windows.Forms.RadioButton();
            this.lbl_Barcode = new System.Windows.Forms.Label();
            this.lbl_Artikelbezeichnung = new System.Windows.Forms.Label();
            this.lbl_Artikelnummer = new System.Windows.Forms.Label();
            this.lbl_lagerplatz = new System.Windows.Forms.Label();
            this.lbl_Bau_Nr = new System.Windows.Forms.Label();
            this.lbl_Ma_Nr = new System.Windows.Forms.Label();
            this.but_Suche = new System.Windows.Forms.Button();
            this.but_Leser = new System.Windows.Forms.Button();
            this.but_Ausbuchen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ersatzteileBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lagerDataSet1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownAnzahl)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView1.DataSource = this.ersatzteileBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(48, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1366, 635);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Artikelbezeichnung";
            this.dataGridViewTextBoxColumn1.HeaderText = "Artikelbezeichnung";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Artikelnummer";
            this.dataGridViewTextBoxColumn2.HeaderText = "Artikelnummer";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Lagerplatz";
            this.dataGridViewTextBoxColumn3.HeaderText = "Lagerplatz";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Anzahl";
            this.dataGridViewTextBoxColumn4.HeaderText = "Anzahl";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Baugruppennummer";
            this.dataGridViewTextBoxColumn5.HeaderText = "Baugruppennummer";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Maschinenummer";
            this.dataGridViewTextBoxColumn6.HeaderText = "Maschinenummer";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // ersatzteileBindingSource2
            // 
            this.ersatzteileBindingSource2.DataMember = "Ersatzteile";
            this.ersatzteileBindingSource2.DataSource = this.lagerDataSet1;
            // 
            // lagerDataSet1
            // 
            this.lagerDataSet1.DataSetName = "LagerDataSet";
            this.lagerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.extrasToolStripMenuItem,
            this.optonienToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2386, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datenbankÖffnenToolStripMenuItem,
            this.datenbankSpeichernToolStripMenuItem,
            this.artikelLöschenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // datenbankÖffnenToolStripMenuItem
            // 
            this.datenbankÖffnenToolStripMenuItem.Name = "datenbankÖffnenToolStripMenuItem";
            this.datenbankÖffnenToolStripMenuItem.Size = new System.Drawing.Size(282, 34);
            this.datenbankÖffnenToolStripMenuItem.Text = "Datenbank öffnen";
            this.datenbankÖffnenToolStripMenuItem.Click += new System.EventHandler(this.datenbankÖffnenToolStripMenuItem_Click);
            // 
            // datenbankSpeichernToolStripMenuItem
            // 
            this.datenbankSpeichernToolStripMenuItem.Name = "datenbankSpeichernToolStripMenuItem";
            this.datenbankSpeichernToolStripMenuItem.Size = new System.Drawing.Size(282, 34);
            this.datenbankSpeichernToolStripMenuItem.Text = "Datenbank Speichern";
            this.datenbankSpeichernToolStripMenuItem.Click += new System.EventHandler(this.datenbankSpeichernToolStripMenuItem_Click);
            // 
            // artikelLöschenToolStripMenuItem
            // 
            this.artikelLöschenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artikelLöschenToolStripMenuItem1});
            this.artikelLöschenToolStripMenuItem.Name = "artikelLöschenToolStripMenuItem";
            this.artikelLöschenToolStripMenuItem.Size = new System.Drawing.Size(282, 34);
            this.artikelLöschenToolStripMenuItem.Text = "Artikeloptionen";
            // 
            // artikelLöschenToolStripMenuItem1
            // 
            this.artikelLöschenToolStripMenuItem1.Name = "artikelLöschenToolStripMenuItem1";
            this.artikelLöschenToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.artikelLöschenToolStripMenuItem1.Text = "Artikel löschen";
            this.artikelLöschenToolStripMenuItem1.Click += new System.EventHandler(this.artikelLöschenToolStripMenuItem1_Click);
            // 
            // extrasToolStripMenuItem
            // 
            this.extrasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barcodescannerToolStripMenuItem,
            this.maschinenToolStripMenuItem,
            this.baugruppenToolStripMenuItem});
            this.extrasToolStripMenuItem.Name = "extrasToolStripMenuItem";
            this.extrasToolStripMenuItem.Size = new System.Drawing.Size(74, 29);
            this.extrasToolStripMenuItem.Text = "Extras";
            // 
            // barcodescannerToolStripMenuItem
            // 
            this.barcodescannerToolStripMenuItem.Name = "barcodescannerToolStripMenuItem";
            this.barcodescannerToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.barcodescannerToolStripMenuItem.Text = "Barcodegenerator";
            this.barcodescannerToolStripMenuItem.Click += new System.EventHandler(this.barcodescannerToolStripMenuItem_Click);
            // 
            // maschinenToolStripMenuItem
            // 
            this.maschinenToolStripMenuItem.Name = "maschinenToolStripMenuItem";
            this.maschinenToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.maschinenToolStripMenuItem.Text = "Maschinen";
            this.maschinenToolStripMenuItem.Click += new System.EventHandler(this.maschinenToolStripMenuItem_Click);
            // 
            // baugruppenToolStripMenuItem
            // 
            this.baugruppenToolStripMenuItem.Name = "baugruppenToolStripMenuItem";
            this.baugruppenToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.baugruppenToolStripMenuItem.Text = "Baugruppen";
            this.baugruppenToolStripMenuItem.Click += new System.EventHandler(this.baugruppenToolStripMenuItem_Click);
            // 
            // optonienToolStripMenuItem
            // 
            this.optonienToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programmendeToolStripMenuItem});
            this.optonienToolStripMenuItem.Name = "optonienToolStripMenuItem";
            this.optonienToolStripMenuItem.Size = new System.Drawing.Size(103, 29);
            this.optonienToolStripMenuItem.Text = "Optionen";
            // 
            // programmendeToolStripMenuItem
            // 
            this.programmendeToolStripMenuItem.Name = "programmendeToolStripMenuItem";
            this.programmendeToolStripMenuItem.Size = new System.Drawing.Size(238, 34);
            this.programmendeToolStripMenuItem.Text = "Programmende";
            this.programmendeToolStripMenuItem.Click += new System.EventHandler(this.programmendeToolStripMenuItem_Click);
            // 
            // but_einlesen
            // 
            this.but_einlesen.Location = new System.Drawing.Point(48, 778);
            this.but_einlesen.Name = "but_einlesen";
            this.but_einlesen.Size = new System.Drawing.Size(120, 58);
            this.but_einlesen.TabIndex = 2;
            this.but_einlesen.Text = "Aktualisieren";
            this.but_einlesen.UseVisualStyleBackColor = true;
            this.but_einlesen.Click += new System.EventHandler(this.but_einlesen_Click);
            // 
            // tb_suche
            // 
            this.tb_suche.Location = new System.Drawing.Point(1579, 114);
            this.tb_suche.Name = "tb_suche";
            this.tb_suche.Size = new System.Drawing.Size(334, 26);
            this.tb_suche.TabIndex = 3;
            this.tb_suche.TextChanged += new System.EventHandler(this.tb_suche_TextChanged);
            this.tb_suche.Leave += new System.EventHandler(this.tb_suche_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(1488, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Suchleiste";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Artikelnummer
            // 
            this.tb_Artikelnummer.Location = new System.Drawing.Point(1579, 296);
            this.tb_Artikelnummer.Name = "tb_Artikelnummer";
            this.tb_Artikelnummer.Size = new System.Drawing.Size(334, 26);
            this.tb_Artikelnummer.TabIndex = 8;
            // 
            // tb_Maschinennummer
            // 
            this.tb_Maschinennummer.Location = new System.Drawing.Point(1579, 660);
            this.tb_Maschinennummer.Name = "tb_Maschinennummer";
            this.tb_Maschinennummer.Size = new System.Drawing.Size(334, 26);
            this.tb_Maschinennummer.TabIndex = 9;
            // 
            // tb_Lagerplatz
            // 
            this.tb_Lagerplatz.Location = new System.Drawing.Point(1579, 387);
            this.tb_Lagerplatz.Name = "tb_Lagerplatz";
            this.tb_Lagerplatz.Size = new System.Drawing.Size(334, 26);
            this.tb_Lagerplatz.TabIndex = 10;
            // 
            // tb_Artikelbezeichnung
            // 
            this.tb_Artikelbezeichnung.Location = new System.Drawing.Point(1579, 205);
            this.tb_Artikelbezeichnung.Name = "tb_Artikelbezeichnung";
            this.tb_Artikelbezeichnung.Size = new System.Drawing.Size(334, 26);
            this.tb_Artikelbezeichnung.TabIndex = 11;
            // 
            // tb_Baugruppennummer
            // 
            this.tb_Baugruppennummer.Location = new System.Drawing.Point(1579, 569);
            this.tb_Baugruppennummer.Name = "tb_Baugruppennummer";
            this.tb_Baugruppennummer.Size = new System.Drawing.Size(334, 26);
            this.tb_Baugruppennummer.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(1427, 660);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "Maschinennummer";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(1416, 569);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Baugruppennummer";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(1513, 482);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 22);
            this.label4.TabIndex = 16;
            this.label4.Text = "Anzahl";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(1487, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 22);
            this.label5.TabIndex = 17;
            this.label5.Text = "Lagerplatz";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(1460, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 22);
            this.label6.TabIndex = 18;
            this.label6.Text = "Artikelnummer";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(1427, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 22);
            this.label7.TabIndex = 19;
            this.label7.Text = "Artikelbezeichnung";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updownAnzahl
            // 
            this.updownAnzahl.Location = new System.Drawing.Point(1579, 478);
            this.updownAnzahl.Name = "updownAnzahl";
            this.updownAnzahl.Size = new System.Drawing.Size(334, 26);
            this.updownAnzahl.TabIndex = 20;
            this.updownAnzahl.ValueChanged += new System.EventHandler(this.updownAnzahl_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_baugr_nr);
            this.groupBox1.Controls.Add(this.rb_ma_nr);
            this.groupBox1.Controls.Add(this.rb_add_artikel);
            this.groupBox1.Controls.Add(this.rb_aus);
            this.groupBox1.Controls.Add(this.rb_a_art);
            this.groupBox1.Controls.Add(this.rb_ä_Bar);
            this.groupBox1.Location = new System.Drawing.Point(1427, 711);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(919, 170);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bitte Auswählen";
            // 
            // rb_baugr_nr
            // 
            this.rb_baugr_nr.AutoSize = true;
            this.rb_baugr_nr.Location = new System.Drawing.Point(435, 67);
            this.rb_baugr_nr.Name = "rb_baugr_nr";
            this.rb_baugr_nr.Size = new System.Drawing.Size(294, 24);
            this.rb_baugr_nr.TabIndex = 27;
            this.rb_baugr_nr.TabStop = true;
            this.rb_baugr_nr.Text = "Datenbankausgabe durch Baugr.Nr.:";
            this.rb_baugr_nr.UseVisualStyleBackColor = true;
            this.rb_baugr_nr.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb_ma_nr
            // 
            this.rb_ma_nr.AutoSize = true;
            this.rb_ma_nr.Location = new System.Drawing.Point(435, 34);
            this.rb_ma_nr.Name = "rb_ma_nr";
            this.rb_ma_nr.Size = new System.Drawing.Size(273, 24);
            this.rb_ma_nr.TabIndex = 26;
            this.rb_ma_nr.TabStop = true;
            this.rb_ma_nr.Text = "Datenbankausgabe durch Ma.Nr.:";
            this.rb_ma_nr.UseVisualStyleBackColor = true;
            this.rb_ma_nr.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb_add_artikel
            // 
            this.rb_add_artikel.AutoSize = true;
            this.rb_add_artikel.Location = new System.Drawing.Point(6, 131);
            this.rb_add_artikel.Name = "rb_add_artikel";
            this.rb_add_artikel.Size = new System.Drawing.Size(164, 24);
            this.rb_add_artikel.TabIndex = 25;
            this.rb_add_artikel.TabStop = true;
            this.rb_add_artikel.Text = "Artikel Hinzufügen";
            this.rb_add_artikel.UseVisualStyleBackColor = true;
            this.rb_add_artikel.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb_aus
            // 
            this.rb_aus.AutoSize = true;
            this.rb_aus.Location = new System.Drawing.Point(6, 35);
            this.rb_aus.Name = "rb_aus";
            this.rb_aus.Size = new System.Drawing.Size(261, 24);
            this.rb_aus.TabIndex = 24;
            this.rb_aus.TabStop = true;
            this.rb_aus.Text = "Artikel ausbuchen über Barcode";
            this.rb_aus.UseVisualStyleBackColor = true;
            this.rb_aus.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb_a_art
            // 
            this.rb_a_art.AutoSize = true;
            this.rb_a_art.Location = new System.Drawing.Point(6, 101);
            this.rb_a_art.Name = "rb_a_art";
            this.rb_a_art.Size = new System.Drawing.Size(271, 24);
            this.rb_a_art.TabIndex = 23;
            this.rb_a_art.TabStop = true;
            this.rb_a_art.Text = "Ändern über Artikelnummersuche";
            this.rb_a_art.UseVisualStyleBackColor = true;
            this.rb_a_art.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb_ä_Bar
            // 
            this.rb_ä_Bar.AutoSize = true;
            this.rb_ä_Bar.Location = new System.Drawing.Point(6, 67);
            this.rb_ä_Bar.Name = "rb_ä_Bar";
            this.rb_ä_Bar.Size = new System.Drawing.Size(229, 24);
            this.rb_ä_Bar.TabIndex = 22;
            this.rb_ä_Bar.TabStop = true;
            this.rb_ä_Bar.Text = "Ändern über Barcodesuche";
            this.rb_ä_Bar.UseVisualStyleBackColor = true;
            this.rb_ä_Bar.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // lbl_Barcode
            // 
            this.lbl_Barcode.AutoSize = true;
            this.lbl_Barcode.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl_Barcode.Location = new System.Drawing.Point(1579, 110);
            this.lbl_Barcode.MinimumSize = new System.Drawing.Size(334, 30);
            this.lbl_Barcode.Name = "lbl_Barcode";
            this.lbl_Barcode.Size = new System.Drawing.Size(334, 30);
            this.lbl_Barcode.TabIndex = 22;
            // 
            // lbl_Artikelbezeichnung
            // 
            this.lbl_Artikelbezeichnung.AutoSize = true;
            this.lbl_Artikelbezeichnung.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl_Artikelbezeichnung.Location = new System.Drawing.Point(1579, 205);
            this.lbl_Artikelbezeichnung.MinimumSize = new System.Drawing.Size(334, 30);
            this.lbl_Artikelbezeichnung.Name = "lbl_Artikelbezeichnung";
            this.lbl_Artikelbezeichnung.Size = new System.Drawing.Size(334, 30);
            this.lbl_Artikelbezeichnung.TabIndex = 23;
            // 
            // lbl_Artikelnummer
            // 
            this.lbl_Artikelnummer.AutoSize = true;
            this.lbl_Artikelnummer.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl_Artikelnummer.Location = new System.Drawing.Point(1579, 296);
            this.lbl_Artikelnummer.MinimumSize = new System.Drawing.Size(334, 30);
            this.lbl_Artikelnummer.Name = "lbl_Artikelnummer";
            this.lbl_Artikelnummer.Size = new System.Drawing.Size(334, 30);
            this.lbl_Artikelnummer.TabIndex = 24;
            // 
            // lbl_lagerplatz
            // 
            this.lbl_lagerplatz.AutoSize = true;
            this.lbl_lagerplatz.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl_lagerplatz.Location = new System.Drawing.Point(1579, 387);
            this.lbl_lagerplatz.MinimumSize = new System.Drawing.Size(334, 30);
            this.lbl_lagerplatz.Name = "lbl_lagerplatz";
            this.lbl_lagerplatz.Size = new System.Drawing.Size(334, 30);
            this.lbl_lagerplatz.TabIndex = 25;
            // 
            // lbl_Bau_Nr
            // 
            this.lbl_Bau_Nr.AutoSize = true;
            this.lbl_Bau_Nr.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl_Bau_Nr.Location = new System.Drawing.Point(1579, 569);
            this.lbl_Bau_Nr.MinimumSize = new System.Drawing.Size(334, 30);
            this.lbl_Bau_Nr.Name = "lbl_Bau_Nr";
            this.lbl_Bau_Nr.Size = new System.Drawing.Size(334, 30);
            this.lbl_Bau_Nr.TabIndex = 26;
            // 
            // lbl_Ma_Nr
            // 
            this.lbl_Ma_Nr.AutoSize = true;
            this.lbl_Ma_Nr.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl_Ma_Nr.Location = new System.Drawing.Point(1579, 660);
            this.lbl_Ma_Nr.MinimumSize = new System.Drawing.Size(334, 30);
            this.lbl_Ma_Nr.Name = "lbl_Ma_Nr";
            this.lbl_Ma_Nr.Size = new System.Drawing.Size(334, 30);
            this.lbl_Ma_Nr.TabIndex = 27;
            // 
            // but_Suche
            // 
            this.but_Suche.Location = new System.Drawing.Point(315, 778);
            this.but_Suche.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.but_Suche.Name = "but_Suche";
            this.but_Suche.Size = new System.Drawing.Size(112, 58);
            this.but_Suche.TabIndex = 28;
            this.but_Suche.Text = "Suche";
            this.but_Suche.UseVisualStyleBackColor = true;
            this.but_Suche.Click += new System.EventHandler(this.but_Suche_Click);
            // 
            // but_Leser
            // 
            this.but_Leser.Location = new System.Drawing.Point(555, 778);
            this.but_Leser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.but_Leser.Name = "but_Leser";
            this.but_Leser.Size = new System.Drawing.Size(112, 58);
            this.but_Leser.TabIndex = 29;
            this.but_Leser.Text = "Leser aktivieren";
            this.but_Leser.UseVisualStyleBackColor = true;
            this.but_Leser.Click += new System.EventHandler(this.but_Leser_Click);
            // 
            // but_Ausbuchen
            // 
            this.but_Ausbuchen.Location = new System.Drawing.Point(798, 778);
            this.but_Ausbuchen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.but_Ausbuchen.Name = "but_Ausbuchen";
            this.but_Ausbuchen.Size = new System.Drawing.Size(112, 58);
            this.but_Ausbuchen.TabIndex = 30;
            this.but_Ausbuchen.Text = "Anzahl Buchen";
            this.but_Ausbuchen.UseVisualStyleBackColor = true;
            this.but_Ausbuchen.Click += new System.EventHandler(this.but_Ausbuchen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2386, 902);
            this.Controls.Add(this.but_Ausbuchen);
            this.Controls.Add(this.but_Leser);
            this.Controls.Add(this.but_Suche);
            this.Controls.Add(this.lbl_Ma_Nr);
            this.Controls.Add(this.lbl_Bau_Nr);
            this.Controls.Add(this.lbl_lagerplatz);
            this.Controls.Add(this.lbl_Artikelnummer);
            this.Controls.Add(this.lbl_Artikelbezeichnung);
            this.Controls.Add(this.lbl_Barcode);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.updownAnzahl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Baugruppennummer);
            this.Controls.Add(this.tb_Artikelbezeichnung);
            this.Controls.Add(this.tb_Lagerplatz);
            this.Controls.Add(this.tb_Maschinennummer);
            this.Controls.Add(this.tb_Artikelnummer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_suche);
            this.Controls.Add(this.but_einlesen);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Lagerprogramm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ersatzteileBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lagerDataSet1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownAnzahl)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem extrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optonienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barcodescannerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programmendeToolStripMenuItem;
        private System.Windows.Forms.Button but_einlesen;
        private System.Windows.Forms.TextBox tb_suche;
        private System.Windows.Forms.Label label1;
        private Lagerprogramm.LagerDataSet lagerDataSet;
      
        private System.Windows.Forms.DataGridViewTextBoxColumn baugruppennummerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maschineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baugruppeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artikelbezeichnungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artikelnummerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lagerplatzDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anzahlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maschinenummerDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ersatzteileBindingSource2;
        private System.Windows.Forms.ToolStripMenuItem maschinenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baugruppenToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private LagerDataSet lagerDataSet1;
        private System.Windows.Forms.TextBox tb_Artikelnummer;
        private System.Windows.Forms.TextBox tb_Maschinennummer;
        private System.Windows.Forms.TextBox tb_Lagerplatz;
        private System.Windows.Forms.TextBox tb_Artikelbezeichnung;
        private System.Windows.Forms.TextBox tb_Baugruppennummer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown updownAnzahl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_aus;
        private System.Windows.Forms.RadioButton rb_a_art;
        private System.Windows.Forms.RadioButton rb_ä_Bar;
        private System.Windows.Forms.Label lbl_Barcode;
        private System.Windows.Forms.Label lbl_Artikelbezeichnung;
        private System.Windows.Forms.Label lbl_Artikelnummer;
        private System.Windows.Forms.Label lbl_lagerplatz;
        private System.Windows.Forms.Label lbl_Bau_Nr;
        private System.Windows.Forms.Label lbl_Ma_Nr;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datenbankÖffnenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datenbankSpeichernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artikelLöschenToolStripMenuItem;
        private System.Windows.Forms.Button but_Suche;
        private System.Windows.Forms.ToolStripMenuItem artikelLöschenToolStripMenuItem1;
        private System.Windows.Forms.RadioButton rb_add_artikel;
        private System.Windows.Forms.Button but_Leser;
        private System.Windows.Forms.Button but_Ausbuchen;
        private System.Windows.Forms.RadioButton rb_baugr_nr;
        private System.Windows.Forms.RadioButton rb_ma_nr;
    }
}

