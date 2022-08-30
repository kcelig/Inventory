using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;

namespace Inventory
{
    public partial class frmFilmovi : Form
    {

        const int brojFilmova = 1000;
        int brojUnosa;
        Film[] filmovi = new Film[brojFilmova];

        public frmFilmovi()
        {
            InitializeComponent();
        }

        
        int trenutniUnos;

        private void frmFilmovi_Load(object sender, EventArgs e)
        {

            //int n;
            //open file for entries
            try
            {
                StreamReader dat = new StreamReader(Application.StartupPath + "\\filmovi.txt");
                brojUnosa = Convert.ToInt32(dat.ReadLine());
                if (brojUnosa != 0)
                {
                    for (int i = 0; i < brojUnosa; i++)
                    {
                        filmovi[i] = new Film();
                        filmovi[i].Naslov = dat.ReadLine();
                        filmovi[i].Zanr = dat.ReadLine();
                        filmovi[i].Redatelj = dat.ReadLine();
                        filmovi[i].Rating = Convert.ToBoolean(dat.ReadLine());
                        filmovi[i].Trajanje = dat.ReadLine();
                        filmovi[i].GodinaProizvodnje = Convert.ToDateTime(dat.ReadLine());
                        filmovi[i].GlavneUloge = dat.ReadLine();
                        filmovi[i].Opis = dat.ReadLine();
                        filmovi[i].Slika = dat.ReadLine();
                    }

                }
                //read in combo box elements
                /*
                n = Convert.ToInt32(dat.ReadLine());
                if (n != 0)
                {
                    for (int i = 0; i < n; i++)
                    {
                        cboZanr.Items.Add(dat.ReadLine());
                    }
                }
                 * 
                 * */
                dat.Close();
                trenutniUnos = 1;
                PrikaziUnos(trenutniUnos);
            }
            catch {
                brojUnosa = 0;
                trenutniUnos = 0;
            }

            if (brojUnosa == 0) {
                tlbNovi.Enabled = false;
                tlbBrisi.Enabled = false;
                tlbSljedeci.Enabled = false;
                tlbIspis.Enabled = false;
                tlbPrethodni.Enabled = false;
            }

        }


        private void PrikaziUnos(int j)
        {

            // display entry j (1 to numberEntries)

            txtNaslov.Text = filmovi[j - 1].Naslov;
            cboZanr.Text = filmovi[j - 1].Zanr;
            chkRating.Checked = filmovi[j - 1].Rating;
            txtRedatelj.Text = filmovi[j - 1].Redatelj;
            txtTrajanje.Text = filmovi[j - 1].Trajanje;
            dtpGodinaProizvodnje.Value = filmovi[j - 1].GodinaProizvodnje;
            txtGlavneUloge.Text = filmovi[j - 1].GlavneUloge;
            txtOpis.Text = filmovi[j - 1].Opis;
            PrikaziSliku(filmovi[j - 1].Slika);
            tlbSljedeci.Enabled = true;
            tlbPrethodni.Enabled = true;
            if (j == 1)
                tlbPrethodni.Enabled = false;
            if (j == brojUnosa)
                tlbSljedeci.Enabled = false;
            txtNaslov.Focus();

        }


        private void PrikaziSliku(string slika)
        {

            if (slika != "")
            {
                try
                {
                    lblSlika.Text = slika;
                    picSlikaFilma.Image = Image.FromFile(slika);
                }

                catch
                {
                    lblSlika.Text = "";
                    picSlikaFilma.Image = null;
                }
            }

            else
            {
                lblSlika.Text = "";
                picSlikaFilma.Image = null;
            }
        }








        private void tlbPrethodni_Click(object sender, EventArgs e)
        {
            trenutniUnos--;
            PrikaziUnos(trenutniUnos);
        }

        private void tblSljedeci_Click(object sender, EventArgs e)
        {
            trenutniUnos++;
            PrikaziUnos(trenutniUnos);
        }

        private void tblIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void frmFilmovi_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*
            if (MessageBox.Show("Are you sure you want to exit?\r\nAny unsaved changes will be lost.", "Exit Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                e.Cancel = true;

             * 
             */
              
            // write entries back to file
            StreamWriter dat = new StreamWriter(Application.StartupPath + "\\filmovi.txt");
            dat.WriteLine(brojUnosa);
            if (brojUnosa != 0)
            {
                for (int i = 0; i < brojUnosa; i++)
                {
                    dat.WriteLine(filmovi[i].Naslov);
                    dat.WriteLine(filmovi[i].Zanr);
                    dat.WriteLine(filmovi[i].Redatelj);
                    dat.WriteLine(filmovi[i].Rating);
                    dat.WriteLine(filmovi[i].Trajanje);
                    dat.WriteLine(filmovi[i].GodinaProizvodnje);
                    dat.WriteLine(filmovi[i].GlavneUloge);
                    dat.WriteLine(filmovi[i].Opis);
                    dat.WriteLine(filmovi[i].Slika);
                }
            }

            // write combo box entries
            dat.WriteLine(cboZanr.Items.Count);
            if (cboZanr.Items.Count != 0)
            {
                for (int i = 0; i < cboZanr.Items.Count; i++)
                    dat.WriteLine(cboZanr.Items[i]);
            }
            dat.Close();
        }


        private void cboZanr_Leave(object sender, EventArgs e)
        {
            if (cboZanr.Text.Trim() == "")
                return;
            if (cboZanr.Items.Count != 0)
            {
                for (int i = 0; i < cboZanr.Items.Count; i++)
                {
                    if (cboZanr.Text == cboZanr.Items[i].ToString())
                        return;
                }
            }

            // If not found, add to list box
            cboZanr.Items.Add(cboZanr.Text);

        }

        private void btnSlika_Click(object sender, EventArgs e)
        {
            if (dlgOtvori.ShowDialog() == DialogResult.OK)
                PrikaziSliku(dlgOtvori.FileName);
        }

        private void OcistiFormu()
        {

            // blank input screen
            tlbNovi.Enabled = false;
            tlbBrisi.Enabled = false;
            tlbSpremi.Enabled = true;
            tlbPrethodni.Enabled = false;
            tlbSljedeci.Enabled = false;
            tlbIspis.Enabled = false;
            txtNaslov.Text = "";
            cboZanr.Text = "";
            chkRating.Checked = false;
            txtRedatelj.Text = "";
            txtTrajanje.Text = "";
            dtpGodinaProizvodnje.Value = DateTime.Today;
            txtGlavneUloge.Text = "";
            txtOpis.Text = "";
            lblSlika.Text = "";
            picSlikaFilma.Image = null;
            txtNaslov.Focus();
        }


        private void tlbNovi_Click(object sender, EventArgs e)
        {
            OcistiFormu();
        }


        private void tlbSpremi_Click(object sender, EventArgs e)
        {
            // check for description
            txtNaslov.Text = txtNaslov.Text.Trim();
            if (txtNaslov.Text == "")
            {
                MessageBox.Show("Niste unijeli naslov filma!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNaslov.Focus();
                return;
            }

            if (tlbNovi.Enabled)
            {

                // delete edit entry then resave

                BrisiUnos(trenutniUnos);

            }



            // capitalize first letter
            txtNaslov.Text = txtNaslov.Text.Substring(0,1).ToUpper() + txtNaslov.Text.Substring(1, txtNaslov.Text.Length - 1);
            txtNaslov.Refresh();
            brojUnosa++;

            // determine new current entry location based on description
            trenutniUnos = 1;

            if (brojUnosa != 1)
            {
                do
                {
                    if (txtNaslov.Text.CompareTo(filmovi[trenutniUnos - 1].Naslov) < 0)
                        break;
                    trenutniUnos++;
                }
                while (trenutniUnos < brojUnosa);
            }

            // move all entries below new value down one position unless at end

            if (trenutniUnos != brojUnosa)
            {
                for (int i = brojUnosa; i >= trenutniUnos + 1; i--)
                {
                    filmovi[i - 1] = filmovi[i - 2];
                    filmovi[i - 2] = new Film();
                }
            }
            filmovi[trenutniUnos - 1] = new Film();
            filmovi[trenutniUnos - 1].Naslov = txtNaslov.Text; filmovi[trenutniUnos - 1].Zanr = cboZanr.Text;
            filmovi[trenutniUnos - 1].Rating = chkRating.Checked; filmovi[trenutniUnos - 1].Redatelj = txtRedatelj.Text;
            filmovi[trenutniUnos - 1].Trajanje = txtTrajanje.Text;
            filmovi[trenutniUnos - 1].GodinaProizvodnje = dtpGodinaProizvodnje.Value;
            filmovi[trenutniUnos - 1].GlavneUloge = txtGlavneUloge.Text;
            filmovi[trenutniUnos - 1].Slika = lblSlika.Text;
            filmovi[trenutniUnos - 1].Opis = txtOpis.Text;
            PrikaziUnos(trenutniUnos);
            if (brojUnosa < brojFilmova)
                tlbNovi.Enabled = true;
            else
                tlbNovi.Enabled = false;
            tlbBrisi.Enabled = true;
            tlbIspis.Enabled = true;
        }

        private void tlbBrisi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this item?", "Delete Inventory Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)

                return;

            BrisiUnos(trenutniUnos);

            if (brojUnosa == 0)
            {

                trenutniUnos = 0;

                OcistiFormu();

            }

            else
            {

                trenutniUnos--;

                if (trenutniUnos == 0)

                    trenutniUnos = 1;

                PrikaziUnos(trenutniUnos);

            }

        }


        private void BrisiUnos(int j)

{

// delete entry j

if (j != brojUnosa)

{

// move all entries under j up one level

for (int i = j; i < brojUnosa; i++)

{

filmovi[i - 1] = new Film();

filmovi[i - 1] = filmovi[i];
}

}

brojUnosa--;

}







        int brojStranica;

        PrintDocument dokument;

        const int unosaPoStranici = 2;

        private void tblIspis_Click(object sender, EventArgs e)
        {
            // do printing

            brojStranica = 1;

            // create document

            dokument = new PrintDocument();

            dokument.DocumentName = "Filmovi";

            dokument.PrintPage += new PrintPageEventHandler(this.IspisStranice);

            dlgPregled.Document = dokument;

            dlgPregled.ShowDialog();

            dokument.Dispose();
        }


        private void IspisStranice(object sender, PrintPageEventArgs e)

{

Font printFont;

int y, i, iEnd;

Image slikaFilma;

float ratio;

// here you decide what goes on each page and draw it

printFont = new Font("Arial", 14, FontStyle.Bold);

e.Graphics.DrawString("Filmovi - Stranica " + brojStranica.ToString(), printFont, Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top);

// starting y position

printFont = new Font("Arial", 12, FontStyle.Regular);

y = (int)(e.MarginBounds.Top + 3 * printFont.GetHeight());

iEnd = unosaPoStranici * brojStranica;

if (iEnd > brojUnosa)

iEnd = brojUnosa;

for (i = 1 + unosaPoStranici * (brojStranica - 1); i <= iEnd; i++)

{

    // dividing line

    e.Graphics.DrawLine(Pens.Black, e.MarginBounds.Left, y, e.MarginBounds.Right, y);

    printFont = new Font("Arial", 12, FontStyle.Bold);

    e.Graphics.DrawString(filmovi[i - 1].Naslov, printFont, Brushes.Black, e.MarginBounds.X, y);

    y += (int)(printFont.GetHeight());

    printFont = new Font("Arial", 12, FontStyle.Regular);

    e.Graphics.DrawString("Žanr: " + filmovi[i - 1].Zanr, printFont, Brushes.Black, e.MarginBounds.X + 25, y);

    y += (int)(printFont.GetHeight());

    if (filmovi[i - 1].Rating)

        e.Graphics.DrawString("Film je prikladan za djecu mlađu od 12 godina.", printFont, Brushes.Black, e.MarginBounds.X + 25, y);

    else

        e.Graphics.DrawString("Film nije prikladan za djecu mlađu od 12 godina.", printFont, Brushes.Black, e.MarginBounds.X + 25, y);

    y += (int)(printFont.GetHeight());

    e.Graphics.DrawString("Redatelj: " + filmovi[i - 1].Redatelj, printFont, Brushes.Black, e.MarginBounds.X + 25, y);

    y += (int)(printFont.GetHeight());

    e.Graphics.DrawString("Trajanje: " + String.Format("{0:f2}", filmovi[i - 1].Trajanje) + ", Godina: " + filmovi[i - 1].GodinaProizvodnje.ToShortDateString(), printFont, Brushes.Black, e.MarginBounds.X + 25, y);

    y += (int)(printFont.GetHeight());

    e.Graphics.DrawString("Uloge: " + filmovi[i - 1].GlavneUloge, printFont, Brushes.Black, e.MarginBounds.X + 25, y);

    y += (int)(printFont.GetHeight());

    e.Graphics.DrawString("Opis: " + filmovi[i - 1].Opis, printFont, Brushes.Black, e.MarginBounds.X + 25, y);

    y += (int)(printFont.GetHeight());

    try
    {

        // maintain original width/height ratio

        slikaFilma = Image.FromFile(filmovi[i - 1].Slika);

        ratio = (float)(slikaFilma.Width) / slikaFilma.Height;

        e.Graphics.DrawImage(slikaFilma, e.MarginBounds.X + 25, y, 200 * ratio, 200);

    }

    catch
    {

        // have place to go in case image file doesn't open

    }

    y += 2 * (int)(printFont.GetHeight()) + 200;

}

brojStranica++;

if (iEnd != brojUnosa)

    e.HasMorePages = true;

else
{

    e.HasMorePages = false;

    brojStranica = 1;

}

}











    }


}
