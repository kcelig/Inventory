namespace Inventory
{
    partial class frmFilmovi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFilmovi));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.txtRedatelj = new System.Windows.Forms.TextBox();
            this.cboZanr = new System.Windows.Forms.ComboBox();
            this.chkRating = new System.Windows.Forms.CheckBox();
            this.txtTrajanje = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpGodinaProizvodnje = new System.Windows.Forms.DateTimePicker();
            this.txtGlavneUloge = new System.Windows.Forms.TextBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.lblSlika = new System.Windows.Forms.Label();
            this.btnSlika = new System.Windows.Forms.Button();
            this.picSlikaFilma = new System.Windows.Forms.PictureBox();
            this.tlbFilm = new System.Windows.Forms.ToolStrip();
            this.tlbNovi = new System.Windows.Forms.ToolStripButton();
            this.tlbBrisi = new System.Windows.Forms.ToolStripButton();
            this.tlbSpremi = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tlbPrethodni = new System.Windows.Forms.ToolStripButton();
            this.tlbSljedeci = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tlbIspis = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tlbIzlaz = new System.Windows.Forms.ToolStripButton();
            this.dlgOtvori = new System.Windows.Forms.OpenFileDialog();
            this.dlgPregled = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picSlikaFilma)).BeginInit();
            this.tlbFilm.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naslov filma";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Žanr";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Redatelj";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Trajanje";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Glavne uloge";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Opis radnje";
            // 
            // txtNaslov
            // 
            this.txtNaslov.Location = new System.Drawing.Point(137, 48);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(473, 20);
            this.txtNaslov.TabIndex = 0;
            // 
            // txtRedatelj
            // 
            this.txtRedatelj.Location = new System.Drawing.Point(137, 109);
            this.txtRedatelj.Name = "txtRedatelj";
            this.txtRedatelj.Size = new System.Drawing.Size(313, 20);
            this.txtRedatelj.TabIndex = 3;
            // 
            // cboZanr
            // 
            this.cboZanr.FormattingEnabled = true;
            this.cboZanr.Items.AddRange(new object[] {
            "Akcija",
            "Drama",
            "Horror",
            "Komedija",
            "Krimi",
            "SF"});
            this.cboZanr.Location = new System.Drawing.Point(455, 77);
            this.cboZanr.Name = "cboZanr";
            this.cboZanr.Size = new System.Drawing.Size(155, 21);
            this.cboZanr.Sorted = true;
            this.cboZanr.TabIndex = 1;
            this.cboZanr.Leave += new System.EventHandler(this.cboZanr_Leave);
            // 
            // chkRating
            // 
            this.chkRating.AutoSize = true;
            this.chkRating.Location = new System.Drawing.Point(554, 111);
            this.chkRating.Name = "chkRating";
            this.chkRating.Size = new System.Drawing.Size(56, 17);
            this.chkRating.TabIndex = 2;
            this.chkRating.Text = "PG-12";
            this.chkRating.UseVisualStyleBackColor = true;
            // 
            // txtTrajanje
            // 
            this.txtTrajanje.Location = new System.Drawing.Point(315, 77);
            this.txtTrajanje.Name = "txtTrajanje";
            this.txtTrajanje.Size = new System.Drawing.Size(76, 20);
            this.txtTrajanje.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Godina proizvodnje";
            // 
            // dtpGodinaProizvodnje
            // 
            this.dtpGodinaProizvodnje.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpGodinaProizvodnje.Location = new System.Drawing.Point(137, 77);
            this.dtpGodinaProizvodnje.Name = "dtpGodinaProizvodnje";
            this.dtpGodinaProizvodnje.Size = new System.Drawing.Size(98, 20);
            this.dtpGodinaProizvodnje.TabIndex = 5;
            this.dtpGodinaProizvodnje.Value = new System.DateTime(2020, 4, 18, 0, 0, 0, 0);
            // 
            // txtGlavneUloge
            // 
            this.txtGlavneUloge.Location = new System.Drawing.Point(137, 140);
            this.txtGlavneUloge.Name = "txtGlavneUloge";
            this.txtGlavneUloge.Size = new System.Drawing.Size(473, 20);
            this.txtGlavneUloge.TabIndex = 6;
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(137, 176);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(473, 80);
            this.txtOpis.TabIndex = 7;
            // 
            // lblSlika
            // 
            this.lblSlika.BackColor = System.Drawing.Color.LightYellow;
            this.lblSlika.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSlika.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSlika.Location = new System.Drawing.Point(137, 270);
            this.lblSlika.Name = "lblSlika";
            this.lblSlika.Size = new System.Drawing.Size(436, 23);
            this.lblSlika.TabIndex = 0;
            // 
            // btnSlika
            // 
            this.btnSlika.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSlika.Location = new System.Drawing.Point(579, 270);
            this.btnSlika.Name = "btnSlika";
            this.btnSlika.Size = new System.Drawing.Size(31, 23);
            this.btnSlika.TabIndex = 8;
            this.btnSlika.Text = "...";
            this.btnSlika.UseVisualStyleBackColor = true;
            this.btnSlika.Click += new System.EventHandler(this.btnSlika_Click);
            // 
            // picSlikaFilma
            // 
            this.picSlikaFilma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSlikaFilma.Location = new System.Drawing.Point(137, 310);
            this.picSlikaFilma.Name = "picSlikaFilma";
            this.picSlikaFilma.Size = new System.Drawing.Size(473, 258);
            this.picSlikaFilma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSlikaFilma.TabIndex = 7;
            this.picSlikaFilma.TabStop = false;
            // 
            // tlbFilm
            // 
            this.tlbFilm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlbNovi,
            this.tlbBrisi,
            this.tlbSpremi,
            this.toolStripSeparator1,
            this.tlbPrethodni,
            this.tlbSljedeci,
            this.toolStripSeparator2,
            this.tlbIspis,
            this.toolStripSeparator3,
            this.tlbIzlaz});
            this.tlbFilm.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tlbFilm.Location = new System.Drawing.Point(0, 0);
            this.tlbFilm.Name = "tlbFilm";
            this.tlbFilm.Size = new System.Drawing.Size(628, 38);
            this.tlbFilm.TabIndex = 8;
            this.tlbFilm.Text = "toolStrip1";
            // 
            // tlbNovi
            // 
            this.tlbNovi.Image = ((System.Drawing.Image)(resources.GetObject("tlbNovi.Image")));
            this.tlbNovi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlbNovi.Name = "tlbNovi";
            this.tlbNovi.Size = new System.Drawing.Size(36, 35);
            this.tlbNovi.Text = "Novi";
            this.tlbNovi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tlbNovi.ToolTipText = "Dodaj novi predmet";
            this.tlbNovi.Click += new System.EventHandler(this.tlbNovi_Click);
            // 
            // tlbBrisi
            // 
            this.tlbBrisi.Image = ((System.Drawing.Image)(resources.GetObject("tlbBrisi.Image")));
            this.tlbBrisi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlbBrisi.Name = "tlbBrisi";
            this.tlbBrisi.Size = new System.Drawing.Size(33, 35);
            this.tlbBrisi.Text = "Briši";
            this.tlbBrisi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tlbBrisi.Click += new System.EventHandler(this.tlbBrisi_Click);
            // 
            // tlbSpremi
            // 
            this.tlbSpremi.Image = ((System.Drawing.Image)(resources.GetObject("tlbSpremi.Image")));
            this.tlbSpremi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlbSpremi.Name = "tlbSpremi";
            this.tlbSpremi.Size = new System.Drawing.Size(48, 35);
            this.tlbSpremi.Text = "Spremi";
            this.tlbSpremi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tlbSpremi.Click += new System.EventHandler(this.tlbSpremi_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // tlbPrethodni
            // 
            this.tlbPrethodni.Image = ((System.Drawing.Image)(resources.GetObject("tlbPrethodni.Image")));
            this.tlbPrethodni.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlbPrethodni.Name = "tlbPrethodni";
            this.tlbPrethodni.Size = new System.Drawing.Size(63, 35);
            this.tlbPrethodni.Text = "Prethodni";
            this.tlbPrethodni.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tlbPrethodni.Click += new System.EventHandler(this.tlbPrethodni_Click);
            // 
            // tlbSljedeci
            // 
            this.tlbSljedeci.Image = ((System.Drawing.Image)(resources.GetObject("tlbSljedeci.Image")));
            this.tlbSljedeci.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlbSljedeci.Name = "tlbSljedeci";
            this.tlbSljedeci.Size = new System.Drawing.Size(51, 35);
            this.tlbSljedeci.Text = "Sljedeći";
            this.tlbSljedeci.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tlbSljedeci.Click += new System.EventHandler(this.tblSljedeci_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // tlbIspis
            // 
            this.tlbIspis.Image = ((System.Drawing.Image)(resources.GetObject("tlbIspis.Image")));
            this.tlbIspis.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlbIspis.Name = "tlbIspis";
            this.tlbIspis.Size = new System.Drawing.Size(34, 35);
            this.tlbIspis.Text = "Ispis";
            this.tlbIspis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tlbIspis.Click += new System.EventHandler(this.tblIspis_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 38);
            // 
            // tlbIzlaz
            // 
            this.tlbIzlaz.Image = ((System.Drawing.Image)(resources.GetObject("tlbIzlaz.Image")));
            this.tlbIzlaz.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlbIzlaz.Name = "tlbIzlaz";
            this.tlbIzlaz.Size = new System.Drawing.Size(33, 35);
            this.tlbIzlaz.Text = "Izlaz";
            this.tlbIzlaz.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tlbIzlaz.Click += new System.EventHandler(this.tblIzlaz_Click);
            // 
            // dlgOtvori
            // 
            this.dlgOtvori.DefaultExt = "jpg";
            this.dlgOtvori.FileName = "openFileDialog1";
            this.dlgOtvori.Filter = "JPEG Files (*.jpg)|*.jpg";
            this.dlgOtvori.Title = "Otvorite slikovnu datoteku";
            // 
            // dlgPregled
            // 
            this.dlgPregled.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.dlgPregled.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.dlgPregled.ClientSize = new System.Drawing.Size(400, 300);
            this.dlgPregled.Enabled = true;
            this.dlgPregled.Icon = ((System.Drawing.Icon)(resources.GetObject("dlgPregled.Icon")));
            this.dlgPregled.Name = "dlgPreview";
            this.dlgPregled.Visible = false;
            // 
            // frmFilmovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 580);
            this.Controls.Add(this.tlbFilm);
            this.Controls.Add(this.picSlikaFilma);
            this.Controls.Add(this.btnSlika);
            this.Controls.Add(this.dtpGodinaProizvodnje);
            this.Controls.Add(this.chkRating);
            this.Controls.Add(this.cboZanr);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.txtGlavneUloge);
            this.Controls.Add(this.txtTrajanje);
            this.Controls.Add(this.txtRedatelj);
            this.Controls.Add(this.txtNaslov);
            this.Controls.Add(this.lblSlika);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmFilmovi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Katalog filmova";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFilmovi_FormClosing);
            this.Load += new System.EventHandler(this.frmFilmovi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSlikaFilma)).EndInit();
            this.tlbFilm.ResumeLayout(false);
            this.tlbFilm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.TextBox txtRedatelj;
        private System.Windows.Forms.ComboBox cboZanr;
        private System.Windows.Forms.CheckBox chkRating;
        private System.Windows.Forms.TextBox txtTrajanje;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpGodinaProizvodnje;
        private System.Windows.Forms.TextBox txtGlavneUloge;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label lblSlika;
        private System.Windows.Forms.Button btnSlika;
        private System.Windows.Forms.PictureBox picSlikaFilma;
        private System.Windows.Forms.ToolStrip tlbFilm;
        private System.Windows.Forms.ToolStripButton tlbNovi;
        private System.Windows.Forms.ToolStripButton tlbBrisi;
        private System.Windows.Forms.ToolStripButton tlbSpremi;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tlbPrethodni;
        private System.Windows.Forms.ToolStripButton tlbSljedeci;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tlbIspis;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tlbIzlaz;
        private System.Windows.Forms.OpenFileDialog dlgOtvori;
        private System.Windows.Forms.PrintPreviewDialog dlgPregled;
    }
}

