namespace Lagerprogramm
{
    partial class Barcodegenerator1
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
            this.picBarcode = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.but_gen = new System.Windows.Forms.Button();
            this.but_print = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBarcode)).BeginInit();
            this.SuspendLayout();
            // 
            // picBarcode
            // 
            this.picBarcode.Location = new System.Drawing.Point(39, 74);
            this.picBarcode.Margin = new System.Windows.Forms.Padding(2);
            this.picBarcode.MaximumSize = new System.Drawing.Size(267, 50);
            this.picBarcode.MinimumSize = new System.Drawing.Size(267, 16);
            this.picBarcode.Name = "picBarcode";
            this.picBarcode.Size = new System.Drawing.Size(267, 50);
            this.picBarcode.TabIndex = 1;
            this.picBarcode.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 235);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(326, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // but_gen
            // 
            this.but_gen.Location = new System.Drawing.Point(17, 322);
            this.but_gen.Margin = new System.Windows.Forms.Padding(2);
            this.but_gen.Name = "but_gen";
            this.but_gen.Size = new System.Drawing.Size(111, 34);
            this.but_gen.TabIndex = 3;
            this.but_gen.Text = "Generieren";
            this.but_gen.UseVisualStyleBackColor = true;
            this.but_gen.Click += new System.EventHandler(this.but_gen_Click);
            // 
            // but_print
            // 
            this.but_print.Location = new System.Drawing.Point(232, 322);
            this.but_print.Margin = new System.Windows.Forms.Padding(2);
            this.but_print.Name = "but_print";
            this.but_print.Size = new System.Drawing.Size(111, 34);
            this.but_print.TabIndex = 4;
            this.but_print.Text = "Barcode Drucken";
            this.but_print.UseVisualStyleBackColor = true;
            this.but_print.Click += new System.EventHandler(this.but_print_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(390, 239);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Artikelnummer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Barcode";
            // 
            // Barcodegenerator1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but_print);
            this.Controls.Add(this.but_gen);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.picBarcode);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Barcodegenerator1";
            this.Text = "Barcodegenerator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Barcodegenerator1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.picBarcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBarcode;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button but_gen;
        private System.Windows.Forms.Button but_print;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}