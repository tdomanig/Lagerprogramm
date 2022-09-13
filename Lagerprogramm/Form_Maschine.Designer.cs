namespace Lagerprogramm
{
    partial class Form_Maschine
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maschineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maschinennummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baujahrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.herstellerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lagerDataSetMaschine = new Lagerprogramm.LagerDataSetMaschine();
            this.but_einlesen = new System.Windows.Forms.Button();
            this.but_Speichern = new System.Windows.Forms.Button();
            this.tb_Maschine = new System.Windows.Forms.TextBox();
            this.tb_Maschinenummer = new System.Windows.Forms.TextBox();
            this.tb_Baujahr = new System.Windows.Forms.TextBox();
            this.tb_Hersteller = new System.Windows.Forms.TextBox();
            this.tb_suche = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.but_Löschen = new System.Windows.Forms.Button();
            this.but_Hinzufügen = new System.Windows.Forms.Button();
            this.but_Suche = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lagerDataSetMaschine)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maschineDataGridViewTextBoxColumn,
            this.maschinennummerDataGridViewTextBoxColumn,
            this.baujahrDataGridViewTextBoxColumn,
            this.herstellerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(533, 307);
            this.dataGridView1.TabIndex = 0;
            // 
            // maschineDataGridViewTextBoxColumn
            // 
            this.maschineDataGridViewTextBoxColumn.DataPropertyName = "Maschine";
            this.maschineDataGridViewTextBoxColumn.HeaderText = "Maschine";
            this.maschineDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maschineDataGridViewTextBoxColumn.Name = "maschineDataGridViewTextBoxColumn";
            this.maschineDataGridViewTextBoxColumn.Width = 150;
            // 
            // maschinennummerDataGridViewTextBoxColumn
            // 
            this.maschinennummerDataGridViewTextBoxColumn.DataPropertyName = "Maschinennummer";
            this.maschinennummerDataGridViewTextBoxColumn.HeaderText = "Maschinennummer";
            this.maschinennummerDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maschinennummerDataGridViewTextBoxColumn.Name = "maschinennummerDataGridViewTextBoxColumn";
            this.maschinennummerDataGridViewTextBoxColumn.Width = 150;
            // 
            // baujahrDataGridViewTextBoxColumn
            // 
            this.baujahrDataGridViewTextBoxColumn.DataPropertyName = "Baujahr";
            this.baujahrDataGridViewTextBoxColumn.HeaderText = "Baujahr";
            this.baujahrDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.baujahrDataGridViewTextBoxColumn.Name = "baujahrDataGridViewTextBoxColumn";
            this.baujahrDataGridViewTextBoxColumn.Width = 150;
            // 
            // herstellerDataGridViewTextBoxColumn
            // 
            this.herstellerDataGridViewTextBoxColumn.DataPropertyName = "Hersteller";
            this.herstellerDataGridViewTextBoxColumn.HeaderText = "Hersteller";
            this.herstellerDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.herstellerDataGridViewTextBoxColumn.Name = "herstellerDataGridViewTextBoxColumn";
            this.herstellerDataGridViewTextBoxColumn.Width = 150;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Maschinen";
            this.bindingSource1.DataSource = this.lagerDataSetMaschine;
            // 
            // lagerDataSetMaschine
            // 
            this.lagerDataSetMaschine.DataSetName = "LagerDataSetMaschine";
            this.lagerDataSetMaschine.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // but_einlesen
            // 
            this.but_einlesen.Location = new System.Drawing.Point(59, 435);
            this.but_einlesen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.but_einlesen.Name = "but_einlesen";
            this.but_einlesen.Size = new System.Drawing.Size(67, 45);
            this.but_einlesen.TabIndex = 1;
            this.but_einlesen.Text = "Einlesen";
            this.but_einlesen.UseVisualStyleBackColor = true;
            this.but_einlesen.Click += new System.EventHandler(this.but_einlesen_Click);
            // 
            // but_Speichern
            // 
            this.but_Speichern.Location = new System.Drawing.Point(249, 435);
            this.but_Speichern.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.but_Speichern.Name = "but_Speichern";
            this.but_Speichern.Size = new System.Drawing.Size(71, 45);
            this.but_Speichern.TabIndex = 2;
            this.but_Speichern.Text = "Speichern";
            this.but_Speichern.UseVisualStyleBackColor = true;
            this.but_Speichern.Click += new System.EventHandler(this.but_Speichern_Click);
            // 
            // tb_Maschine
            // 
            this.tb_Maschine.Location = new System.Drawing.Point(648, 53);
            this.tb_Maschine.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Maschine.Name = "tb_Maschine";
            this.tb_Maschine.Size = new System.Drawing.Size(163, 20);
            this.tb_Maschine.TabIndex = 3;
            // 
            // tb_Maschinenummer
            // 
            this.tb_Maschinenummer.Location = new System.Drawing.Point(648, 108);
            this.tb_Maschinenummer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Maschinenummer.Name = "tb_Maschinenummer";
            this.tb_Maschinenummer.Size = new System.Drawing.Size(163, 20);
            this.tb_Maschinenummer.TabIndex = 4;
            // 
            // tb_Baujahr
            // 
            this.tb_Baujahr.Location = new System.Drawing.Point(648, 163);
            this.tb_Baujahr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Baujahr.Name = "tb_Baujahr";
            this.tb_Baujahr.Size = new System.Drawing.Size(163, 20);
            this.tb_Baujahr.TabIndex = 5;
            // 
            // tb_Hersteller
            // 
            this.tb_Hersteller.Location = new System.Drawing.Point(648, 218);
            this.tb_Hersteller.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Hersteller.Name = "tb_Hersteller";
            this.tb_Hersteller.Size = new System.Drawing.Size(163, 20);
            this.tb_Hersteller.TabIndex = 6;
            // 
            // tb_suche
            // 
            this.tb_suche.Location = new System.Drawing.Point(214, 344);
            this.tb_suche.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_suche.Name = "tb_suche";
            this.tb_suche.Size = new System.Drawing.Size(229, 20);
            this.tb_suche.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(753, 334);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(548, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Maschinennummer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 344);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Suche über Maschinennummer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(593, 220);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Hersteller";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(601, 167);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Baujahr";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(593, 53);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Maschine";
            // 
            // but_Löschen
            // 
            this.but_Löschen.Location = new System.Drawing.Point(443, 435);
            this.but_Löschen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.but_Löschen.Name = "but_Löschen";
            this.but_Löschen.Size = new System.Drawing.Size(71, 45);
            this.but_Löschen.TabIndex = 14;
            this.but_Löschen.Text = "Löschen";
            this.but_Löschen.UseVisualStyleBackColor = true;
            this.but_Löschen.Click += new System.EventHandler(this.but_Löschen_Click);
            // 
            // but_Hinzufügen
            // 
            this.but_Hinzufügen.Location = new System.Drawing.Point(636, 435);
            this.but_Hinzufügen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.but_Hinzufügen.Name = "but_Hinzufügen";
            this.but_Hinzufügen.Size = new System.Drawing.Size(71, 45);
            this.but_Hinzufügen.TabIndex = 15;
            this.but_Hinzufügen.Text = "Hinzufügen";
            this.but_Hinzufügen.UseVisualStyleBackColor = true;
            this.but_Hinzufügen.Click += new System.EventHandler(this.but_Hinzufügen_Click);
            // 
            // but_Suche
            // 
            this.but_Suche.Location = new System.Drawing.Point(460, 344);
            this.but_Suche.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.but_Suche.Name = "but_Suche";
            this.but_Suche.Size = new System.Drawing.Size(50, 18);
            this.but_Suche.TabIndex = 16;
            this.but_Suche.Text = "Suche";
            this.but_Suche.UseVisualStyleBackColor = true;
            this.but_Suche.Click += new System.EventHandler(this.but_Suche_Click);
            // 
            // Form_Maschine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 578);
            this.Controls.Add(this.but_Suche);
            this.Controls.Add(this.but_Hinzufügen);
            this.Controls.Add(this.but_Löschen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_suche);
            this.Controls.Add(this.tb_Hersteller);
            this.Controls.Add(this.tb_Baujahr);
            this.Controls.Add(this.tb_Maschinenummer);
            this.Controls.Add(this.tb_Maschine);
            this.Controls.Add(this.but_Speichern);
            this.Controls.Add(this.but_einlesen);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_Maschine";
            this.Text = "Form_Maschine";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Maschine_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lagerDataSetMaschine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button but_einlesen;
        private System.Windows.Forms.Button but_Speichern;
        private System.Windows.Forms.TextBox tb_Maschine;
        private System.Windows.Forms.TextBox tb_Maschinenummer;
        private System.Windows.Forms.TextBox tb_Baujahr;
        private System.Windows.Forms.TextBox tb_Hersteller;
        private System.Windows.Forms.TextBox tb_suche;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maschineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maschinennummerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baujahrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn herstellerDataGridViewTextBoxColumn;
        private LagerDataSetMaschine lagerDataSetMaschine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button but_Löschen;
        private System.Windows.Forms.Button but_Hinzufügen;
        private System.Windows.Forms.Button but_Suche;
    }
}