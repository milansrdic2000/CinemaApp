using System.Windows.Forms;

namespace Bioskop.UserInterface.UserControls.RezervisanjeUc
{
    partial class UcRezervisanje
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tblLayout = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.ucAllFilmView1 = new Bioskop.UserInterface.UserControls.FilmUc.UcAllFilmView();
            this.pnlNavigationFooter = new System.Windows.Forms.Panel();
            this.tblLayoutNavigation = new System.Windows.Forms.TableLayoutPanel();
            this.pnlIzabraneStvari = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblUkupnaCena = new System.Windows.Forms.Label();
            this.lblBrojKarata = new System.Windows.Forms.Label();
            this.lblCena = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblIzabranaProjekcija = new System.Windows.Forms.Label();
            this.lblIzabraniFilm = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblKorak = new System.Windows.Forms.Label();
            this.btnVratiSe = new System.Windows.Forms.Button();
            this.tblLayout.SuspendLayout();
            this.pnlMainContent.SuspendLayout();
            this.pnlNavigationFooter.SuspendLayout();
            this.tblLayoutNavigation.SuspendLayout();
            this.pnlIzabraneStvari.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblLayout
            // 
            this.tblLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tblLayout.ColumnCount = 1;
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayout.Controls.Add(this.label1, 0, 0);
            this.tblLayout.Controls.Add(this.pnlMainContent, 0, 2);
            this.tblLayout.Controls.Add(this.pnlNavigationFooter, 0, 3);
            this.tblLayout.Controls.Add(this.panel1, 0, 1);
            this.tblLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayout.Location = new System.Drawing.Point(0, 0);
            this.tblLayout.Name = "tblLayout";
            this.tblLayout.RowCount = 4;
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayout.Size = new System.Drawing.Size(1046, 1056);
            this.tblLayout.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tblLayout.SetColumnSpan(this.label1, 2);
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1040, 105);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rezervisi svoje mesto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.Controls.Add(this.ucAllFilmView1);
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Location = new System.Drawing.Point(3, 213);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Size = new System.Drawing.Size(1040, 574);
            this.pnlMainContent.TabIndex = 2;
            // 
            // ucAllFilmView1
            // 
            this.ucAllFilmView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAllFilmView1.Location = new System.Drawing.Point(0, 0);
            this.ucAllFilmView1.Name = "ucAllFilmView1";
            this.ucAllFilmView1.Size = new System.Drawing.Size(1040, 574);
            this.ucAllFilmView1.TabIndex = 0;
            // 
            // pnlNavigationFooter
            // 
            this.pnlNavigationFooter.Controls.Add(this.tblLayoutNavigation);
            this.pnlNavigationFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNavigationFooter.Location = new System.Drawing.Point(3, 793);
            this.pnlNavigationFooter.Name = "pnlNavigationFooter";
            this.pnlNavigationFooter.Size = new System.Drawing.Size(1040, 260);
            this.pnlNavigationFooter.TabIndex = 3;
            // 
            // tblLayoutNavigation
            // 
            this.tblLayoutNavigation.ColumnCount = 2;
            this.tblLayoutNavigation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tblLayoutNavigation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblLayoutNavigation.Controls.Add(this.pnlIzabraneStvari, 0, 0);
            this.tblLayoutNavigation.Controls.Add(this.panel2, 1, 0);
            this.tblLayoutNavigation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutNavigation.Location = new System.Drawing.Point(0, 0);
            this.tblLayoutNavigation.Name = "tblLayoutNavigation";
            this.tblLayoutNavigation.RowCount = 1;
            this.tblLayoutNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutNavigation.Size = new System.Drawing.Size(1040, 260);
            this.tblLayoutNavigation.TabIndex = 1;
            // 
            // pnlIzabraneStvari
            // 
            this.pnlIzabraneStvari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.pnlIzabraneStvari.Controls.Add(this.label5);
            this.pnlIzabraneStvari.Controls.Add(this.label7);
            this.pnlIzabraneStvari.Controls.Add(this.label6);
            this.pnlIzabraneStvari.Controls.Add(this.lblUkupnaCena);
            this.pnlIzabraneStvari.Controls.Add(this.lblBrojKarata);
            this.pnlIzabraneStvari.Controls.Add(this.lblCena);
            this.pnlIzabraneStvari.Controls.Add(this.label3);
            this.pnlIzabraneStvari.Controls.Add(this.lblIzabranaProjekcija);
            this.pnlIzabraneStvari.Controls.Add(this.lblIzabraniFilm);
            this.pnlIzabraneStvari.Controls.Add(this.label4);
            this.pnlIzabraneStvari.Controls.Add(this.label2);
            this.pnlIzabraneStvari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlIzabraneStvari.Location = new System.Drawing.Point(3, 3);
            this.pnlIzabraneStvari.Name = "pnlIzabraneStvari";
            this.pnlIzabraneStvari.Size = new System.Drawing.Size(722, 254);
            this.pnlIzabraneStvari.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.label5.Location = new System.Drawing.Point(496, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ukupna cena:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.label7.Location = new System.Drawing.Point(496, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Broj karata:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.label6.Location = new System.Drawing.Point(40, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Cena projekcije:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUkupnaCena
            // 
            this.lblUkupnaCena.AutoSize = true;
            this.lblUkupnaCena.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUkupnaCena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.lblUkupnaCena.Location = new System.Drawing.Point(642, 123);
            this.lblUkupnaCena.Name = "lblUkupnaCena";
            this.lblUkupnaCena.Size = new System.Drawing.Size(18, 24);
            this.lblUkupnaCena.TabIndex = 0;
            this.lblUkupnaCena.Text = "/";
            // 
            // lblBrojKarata
            // 
            this.lblBrojKarata.AutoSize = true;
            this.lblBrojKarata.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojKarata.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.lblBrojKarata.Location = new System.Drawing.Point(642, 89);
            this.lblBrojKarata.Name = "lblBrojKarata";
            this.lblBrojKarata.Size = new System.Drawing.Size(18, 24);
            this.lblBrojKarata.TabIndex = 0;
            this.lblBrojKarata.Text = "/";
            // 
            // lblCena
            // 
            this.lblCena.AutoSize = true;
            this.lblCena.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.lblCena.Location = new System.Drawing.Point(200, 89);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(18, 24);
            this.lblCena.TabIndex = 0;
            this.lblCena.Text = "/";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.label3.Location = new System.Drawing.Point(40, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Projekcija:";
            // 
            // lblIzabranaProjekcija
            // 
            this.lblIzabranaProjekcija.AutoSize = true;
            this.lblIzabranaProjekcija.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIzabranaProjekcija.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.lblIzabranaProjekcija.Location = new System.Drawing.Point(162, 165);
            this.lblIzabranaProjekcija.Name = "lblIzabranaProjekcija";
            this.lblIzabranaProjekcija.Size = new System.Drawing.Size(18, 24);
            this.lblIzabranaProjekcija.TabIndex = 0;
            this.lblIzabranaProjekcija.Text = "/";
            // 
            // lblIzabraniFilm
            // 
            this.lblIzabraniFilm.AutoSize = true;
            this.lblIzabraniFilm.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIzabraniFilm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.lblIzabraniFilm.Location = new System.Drawing.Point(162, 132);
            this.lblIzabraniFilm.Name = "lblIzabraniFilm";
            this.lblIzabraniFilm.Size = new System.Drawing.Size(18, 24);
            this.lblIzabraniFilm.TabIndex = 0;
            this.lblIzabraniFilm.Text = "/";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.label4.Location = new System.Drawing.Point(317, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 34);
            this.label4.TabIndex = 0;
            this.label4.Text = "Podaci:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.label2.Location = new System.Drawing.Point(40, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Film:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(731, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(306, 254);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Bioskop.UserInterface.Properties.Resources.mojeZauzetoSediste;
            this.pictureBox3.Location = new System.Drawing.Point(214, 106);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(74, 83);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Bioskop.UserInterface.Properties.Resources.zauzetoSediste;
            this.pictureBox2.Location = new System.Drawing.Point(121, 106);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(74, 83);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bioskop.UserInterface.Properties.Resources.sediste;
            this.pictureBox1.Location = new System.Drawing.Point(18, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.label8.Location = new System.Drawing.Point(98, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 34);
            this.label8.TabIndex = 0;
            this.label8.Text = "Legenda";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.label11.Location = new System.Drawing.Point(225, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 24);
            this.label11.TabIndex = 0;
            this.label11.Text = "Moje";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.label10.Location = new System.Drawing.Point(117, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 24);
            this.label10.TabIndex = 0;
            this.label10.Text = "Zauzeto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.label9.Location = new System.Drawing.Point(14, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "Slobodno";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.lblKorak);
            this.panel1.Controls.Add(this.btnVratiSe);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 99);
            this.panel1.TabIndex = 4;
            // 
            // lblKorak
            // 
            this.lblKorak.AutoSize = true;
            this.lblKorak.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKorak.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.lblKorak.Location = new System.Drawing.Point(41, 25);
            this.lblKorak.Name = "lblKorak";
            this.lblKorak.Size = new System.Drawing.Size(95, 36);
            this.lblKorak.TabIndex = 0;
            this.lblKorak.Text = "Korak";
            // 
            // btnVratiSe
            // 
            this.btnVratiSe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVratiSe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.btnVratiSe.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVratiSe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnVratiSe.Location = new System.Drawing.Point(705, 25);
            this.btnVratiSe.Name = "btnVratiSe";
            this.btnVratiSe.Size = new System.Drawing.Size(233, 58);
            this.btnVratiSe.TabIndex = 0;
            this.btnVratiSe.Text = "Vrati se nazad";
            this.btnVratiSe.UseVisualStyleBackColor = false;
            // 
            // UcRezervisanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.tblLayout);
            this.Name = "UcRezervisanje";
            this.Size = new System.Drawing.Size(1046, 1056);
            this.Load += new System.EventHandler(this.UcRezervisanje_Load);
            this.tblLayout.ResumeLayout(false);
            this.pnlMainContent.ResumeLayout(false);
            this.pnlNavigationFooter.ResumeLayout(false);
            this.tblLayoutNavigation.ResumeLayout(false);
            this.pnlIzabraneStvari.ResumeLayout(false);
            this.pnlIzabraneStvari.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private TableLayoutPanel tblLayout;
        private Panel pnlMainContent;
        private FilmUc.UcAllFilmView ucAllFilmView1;
        private Panel pnlNavigationFooter;
        private Button btnVratiSe;
        private TableLayoutPanel tblLayoutNavigation;
        private Panel pnlIzabraneStvari;
        private Label label3;
        private Label lblIzabranaProjekcija;
        private Label lblIzabraniFilm;
        private Label label4;
        private Label label2;
        private Label label5;
        private Label label7;
        private Label label6;
        private Label lblUkupnaCena;
        private Label lblBrojKarata;
        private Label lblCena;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label8;
        private Label label11;
        private Label label10;
        private Label label9;
        private Panel panel1;
        private Label lblKorak;

        public Panel PnlMainContent => pnlMainContent;
        public Panel PnlNavigationFooter => pnlNavigationFooter;

        public Button BtnVratiSe => btnVratiSe;
        public Label LblKorak => lblKorak;

        public Label LblIzabraniFilm => lblIzabraniFilm;
        public Label LblIzabranaProjekcija => lblIzabranaProjekcija;

        public Label LblUkupnaCena => lblUkupnaCena;
        public Label LblBrojKarata => lblBrojKarata;
        public Label LblCena => lblCena;
    }
}
