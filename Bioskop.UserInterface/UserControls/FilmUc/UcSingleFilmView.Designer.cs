using System.Windows.Forms;

namespace Bioskop.UserInterface.UserControls.Film
{
    partial class UcSingleFilmView
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNazivFilma = new System.Windows.Forms.TextBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.txtTrajanje = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dtpDatumPremijere = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbReziser = new System.Windows.Forms.ComboBox();
            this.cbZanr = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTrajanjeError = new System.Windows.Forms.Label();
            this.lblNazivError = new System.Windows.Forms.Label();
            this.btnIzmeniFilm = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.label1.Location = new System.Drawing.Point(49, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv filma";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.label2.Location = new System.Drawing.Point(49, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Opis filma";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.label3.Location = new System.Drawing.Point(49, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Trajanje u minutima";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.label4.Location = new System.Drawing.Point(49, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Datum premijere";
            // 
            // txtNazivFilma
            // 
            this.txtNazivFilma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNazivFilma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.txtNazivFilma.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNazivFilma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.txtNazivFilma.Location = new System.Drawing.Point(303, 178);
            this.txtNazivFilma.Name = "txtNazivFilma";
            this.txtNazivFilma.Size = new System.Drawing.Size(404, 32);
            this.txtNazivFilma.TabIndex = 1;
            // 
            // txtOpis
            // 
            this.txtOpis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOpis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.txtOpis.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.txtOpis.Location = new System.Drawing.Point(303, 238);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(404, 98);
            this.txtOpis.TabIndex = 1;
            // 
            // txtTrajanje
            // 
            this.txtTrajanje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTrajanje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.txtTrajanje.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrajanje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.txtTrajanje.Location = new System.Drawing.Point(303, 354);
            this.txtTrajanje.Name = "txtTrajanje";
            this.txtTrajanje.Size = new System.Drawing.Size(217, 32);
            this.txtTrajanje.TabIndex = 1;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDodaj.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(240, 662);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(248, 101);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Dodaj film";
            this.btnDodaj.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Bahnschrift", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.lblTitle.Location = new System.Drawing.Point(214, 63);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(301, 72);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Dodaj film";
            // 
            // dtpDatumPremijere
            // 
            this.dtpDatumPremijere.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDatumPremijere.CustomFormat = "dd. MMM yyyy.";
            this.dtpDatumPremijere.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatumPremijere.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumPremijere.Location = new System.Drawing.Point(303, 432);
            this.dtpDatumPremijere.Name = "dtpDatumPremijere";
            this.dtpDatumPremijere.Size = new System.Drawing.Size(404, 32);
            this.dtpDatumPremijere.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.label5.Location = new System.Drawing.Point(49, 525);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Reziser";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.label6.Location = new System.Drawing.Point(49, 582);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "Zanr";
            // 
            // cbReziser
            // 
            this.cbReziser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbReziser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.cbReziser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReziser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbReziser.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbReziser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.cbReziser.FormattingEnabled = true;
            this.cbReziser.Location = new System.Drawing.Point(303, 525);
            this.cbReziser.Name = "cbReziser";
            this.cbReziser.Size = new System.Drawing.Size(404, 32);
            this.cbReziser.TabIndex = 4;
            // 
            // cbZanr
            // 
            this.cbZanr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbZanr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.cbZanr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbZanr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbZanr.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbZanr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.cbZanr.FormattingEnabled = true;
            this.cbZanr.Location = new System.Drawing.Point(303, 582);
            this.cbZanr.Name = "cbZanr";
            this.cbZanr.Size = new System.Drawing.Size(404, 32);
            this.cbZanr.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.lblTrajanjeError);
            this.panel1.Controls.Add(this.lblNazivError);
            this.panel1.Controls.Add(this.btnIzmeniFilm);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbZanr);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.cbReziser);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpDatumPremijere);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnDodaj);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtTrajanje);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtOpis);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtNazivFilma);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 812);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblTrajanjeError
            // 
            this.lblTrajanjeError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTrajanjeError.AutoSize = true;
            this.lblTrajanjeError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.lblTrajanjeError.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrajanjeError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.lblTrajanjeError.Location = new System.Drawing.Point(299, 389);
            this.lblTrajanjeError.Name = "lblTrajanjeError";
            this.lblTrajanjeError.Size = new System.Drawing.Size(60, 22);
            this.lblTrajanjeError.TabIndex = 10;
            this.lblTrajanjeError.Text = "label5";
            this.lblTrajanjeError.Visible = false;
            // 
            // lblNazivError
            // 
            this.lblNazivError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNazivError.AutoSize = true;
            this.lblNazivError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.lblNazivError.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNazivError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.lblNazivError.Location = new System.Drawing.Point(299, 213);
            this.lblNazivError.Name = "lblNazivError";
            this.lblNazivError.Size = new System.Drawing.Size(60, 22);
            this.lblNazivError.TabIndex = 10;
            this.lblNazivError.Text = "label5";
            this.lblNazivError.Visible = false;
            // 
            // btnIzmeniFilm
            // 
            this.btnIzmeniFilm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIzmeniFilm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.btnIzmeniFilm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIzmeniFilm.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeniFilm.Location = new System.Drawing.Point(254, 662);
            this.btnIzmeniFilm.Name = "btnIzmeniFilm";
            this.btnIzmeniFilm.Size = new System.Drawing.Size(217, 101);
            this.btnIzmeniFilm.TabIndex = 6;
            this.btnIzmeniFilm.Text = "Izmeni film";
            this.btnIzmeniFilm.UseVisualStyleBackColor = false;
            // 
            // UcSingleFilmView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UcSingleFilmView";
            this.Size = new System.Drawing.Size(727, 812);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNazivFilma;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.TextBox txtTrajanje;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DateTimePicker dtpDatumPremijere;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbReziser;
        private System.Windows.Forms.ComboBox cbZanr;
        private Panel panel1;
        private Button btnIzmeniFilm;
        private Label lblTrajanjeError;
        private Label lblNazivError;

        public Button BtnDodaj { get { return btnDodaj; } }
        public Button BtnIzmei { get { return btnIzmeniFilm; } }
        public ComboBox CbReziseri { get { return cbReziser; } }

        public ComboBox CbZanrovi => cbZanr;

        public TextBox TxtNazivFilma => txtNazivFilma;
        public TextBox TxtOpis => txtOpis;
        public TextBox TxtTrajanje => txtTrajanje;

        public DateTimePicker DtpDatumPremijere => dtpDatumPremijere;
        public Label LblTitle { get { return lblTitle; } }

        public Label LblNazivError => lblNazivError;
        public Label LblTrajanjeError => lblTrajanjeError;
    }
}
