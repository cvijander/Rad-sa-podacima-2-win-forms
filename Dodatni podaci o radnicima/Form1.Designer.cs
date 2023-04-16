namespace Dodatni_podaci_o_radnicima
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.prikaziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radnikePripravnikezaposleniKraceOdGodinuDanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.prikazatiNajvecuINajmanjuPlatuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pronadjiRadnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.prikazatiSveRadnikeCijePrezimeSadrziSlovoOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1045, 560);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pripravnici";
            this.groupBox1.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikaziToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1085, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // prikaziToolStripMenuItem
            // 
            this.prikaziToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.radnikePripravnikezaposleniKraceOdGodinuDanaToolStripMenuItem,
            this.prikazatiNajvecuINajmanjuPlatuToolStripMenuItem,
            this.pronadjiRadnikaToolStripMenuItem,
            this.prikazatiSveRadnikeCijePrezimeSadrziSlovoOToolStripMenuItem});
            this.prikaziToolStripMenuItem.Name = "prikaziToolStripMenuItem";
            this.prikaziToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.prikaziToolStripMenuItem.Text = "Prikazi";
            // 
            // radnikePripravnikezaposleniKraceOdGodinuDanaToolStripMenuItem
            // 
            this.radnikePripravnikezaposleniKraceOdGodinuDanaToolStripMenuItem.Name = "radnikePripravnikezaposleniKraceOdGodinuDanaToolStripMenuItem";
            this.radnikePripravnikezaposleniKraceOdGodinuDanaToolStripMenuItem.Size = new System.Drawing.Size(356, 22);
            this.radnikePripravnikezaposleniKraceOdGodinuDanaToolStripMenuItem.Text = "Radnike pripravnike (zaposleni krace od godinu dana)";
            this.radnikePripravnikezaposleniKraceOdGodinuDanaToolStripMenuItem.Click += new System.EventHandler(this.radnikePripravnikezaposleniKraceOdGodinuDanaToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1039, 541);
            this.dataGridView1.TabIndex = 0;
            // 
            // prikazatiNajvecuINajmanjuPlatuToolStripMenuItem
            // 
            this.prikazatiNajvecuINajmanjuPlatuToolStripMenuItem.Name = "prikazatiNajvecuINajmanjuPlatuToolStripMenuItem";
            this.prikazatiNajvecuINajmanjuPlatuToolStripMenuItem.Size = new System.Drawing.Size(356, 22);
            this.prikazatiNajvecuINajmanjuPlatuToolStripMenuItem.Text = "Prikazati najvecu i najmanju platu";
            this.prikazatiNajvecuINajmanjuPlatuToolStripMenuItem.Click += new System.EventHandler(this.prikazatiNajvecuINajmanjuPlatuToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1045, 560);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Najveca i najmanja plata";
            this.groupBox2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Najveca plata: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Najmanja plata:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(290, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 44);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.DoubleClick += new System.EventHandler(this.textBox1_DoubleClick);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(290, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(214, 44);
            this.textBox2.TabIndex = 3;
            this.textBox2.DoubleClick += new System.EventHandler(this.textBox2_DoubleClick);
            // 
            // pronadjiRadnikaToolStripMenuItem
            // 
            this.pronadjiRadnikaToolStripMenuItem.Name = "pronadjiRadnikaToolStripMenuItem";
            this.pronadjiRadnikaToolStripMenuItem.Size = new System.Drawing.Size(356, 22);
            this.pronadjiRadnikaToolStripMenuItem.Text = "Prikazati sve radnike cije ime pocinje na slovo M";
            this.pronadjiRadnikaToolStripMenuItem.Click += new System.EventHandler(this.pronadjiRadnikaToolStripMenuItem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Location = new System.Drawing.Point(12, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1045, 560);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pocinje na slovo M";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1039, 541);
            this.dataGridView2.TabIndex = 0;
            // 
            // prikazatiSveRadnikeCijePrezimeSadrziSlovoOToolStripMenuItem
            // 
            this.prikazatiSveRadnikeCijePrezimeSadrziSlovoOToolStripMenuItem.Name = "prikazatiSveRadnikeCijePrezimeSadrziSlovoOToolStripMenuItem";
            this.prikazatiSveRadnikeCijePrezimeSadrziSlovoOToolStripMenuItem.Size = new System.Drawing.Size(356, 22);
            this.prikazatiSveRadnikeCijePrezimeSadrziSlovoOToolStripMenuItem.Text = "Prikazati sve radnike cije prezime sadrzi slovo O";
            this.prikazatiSveRadnikeCijePrezimeSadrziSlovoOToolStripMenuItem.Click += new System.EventHandler(this.prikazatiSveRadnikeCijePrezimeSadrziSlovoOToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 627);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Dodatni podaci";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem prikaziToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radnikePripravnikezaposleniKraceOdGodinuDanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikazatiNajvecuINajmanjuPlatuToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem pronadjiRadnikaToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ToolStripMenuItem prikazatiSveRadnikeCijePrezimeSadrziSlovoOToolStripMenuItem;
    }
}

