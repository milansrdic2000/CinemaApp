using System.Windows.Forms;

namespace Bioskop.UserInterface.UserControls
{
    partial class UcProfileView
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
            this.lblSifra = new System.Windows.Forms.Label();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbSifra = new System.Windows.Forms.TextBox();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.btnRegistrujSe = new System.Windows.Forms.Button();
            this.dtpDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.btnVratiSeNaLogin = new System.Windows.Forms.Button();
            this.lblPrezimeError = new System.Windows.Forms.Label();
            this.lblEmailError = new System.Windows.Forms.Label();
            this.lblImeError = new System.Windows.Forms.Label();
            this.lblDatumError = new System.Windows.Forms.Label();
            this.lblSifraError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.label1.Location = new System.Drawing.Point(99, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.label2.Location = new System.Drawing.Point(99, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.label3.Location = new System.Drawing.Point(99, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Datum rodjenja";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.label4.Location = new System.Drawing.Point(99, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Email";
            // 
            // lblSifra
            // 
            this.lblSifra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSifra.AutoSize = true;
            this.lblSifra.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSifra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.lblSifra.Location = new System.Drawing.Point(99, 473);
            this.lblSifra.Name = "lblSifra";
            this.lblSifra.Size = new System.Drawing.Size(61, 28);
            this.lblSifra.TabIndex = 0;
            this.lblSifra.Text = "Sifra";
            // 
            // tbIme
            // 
            this.tbIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbIme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.tbIme.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tbIme.Location = new System.Drawing.Point(306, 192);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(326, 32);
            this.tbIme.TabIndex = 1;
            // 
            // tbPrezime
            // 
            this.tbPrezime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPrezime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.tbPrezime.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrezime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tbPrezime.Location = new System.Drawing.Point(306, 266);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(326, 32);
            this.tbPrezime.TabIndex = 1;
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.tbEmail.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tbEmail.Location = new System.Drawing.Point(306, 403);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(326, 32);
            this.tbEmail.TabIndex = 1;
            // 
            // tbSifra
            // 
            this.tbSifra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbSifra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.tbSifra.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSifra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tbSifra.Location = new System.Drawing.Point(306, 473);
            this.tbSifra.Name = "tbSifra";
            this.tbSifra.PasswordChar = '*';
            this.tbSifra.Size = new System.Drawing.Size(326, 32);
            this.tbSifra.TabIndex = 1;
            // 
            // lblNaslov
            // 
            this.lblNaslov.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.lblNaslov.Location = new System.Drawing.Point(170, 69);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(363, 48);
            this.lblNaslov.TabIndex = 2;
            this.lblNaslov.Text = "PREGLED PROFILA";
            // 
            // btnRegistrujSe
            // 
            this.btnRegistrujSe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistrujSe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.btnRegistrujSe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrujSe.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrujSe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnRegistrujSe.Location = new System.Drawing.Point(163, 545);
            this.btnRegistrujSe.Name = "btnRegistrujSe";
            this.btnRegistrujSe.Size = new System.Drawing.Size(175, 63);
            this.btnRegistrujSe.TabIndex = 3;
            this.btnRegistrujSe.Text = "Registruj se";
            this.btnRegistrujSe.UseVisualStyleBackColor = false;
            // 
            // dtpDatumRodjenja
            // 
            this.dtpDatumRodjenja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDatumRodjenja.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.dtpDatumRodjenja.CustomFormat = "dd. MMM yyyy.";
            this.dtpDatumRodjenja.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatumRodjenja.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumRodjenja.Location = new System.Drawing.Point(306, 333);
            this.dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            this.dtpDatumRodjenja.Size = new System.Drawing.Size(326, 32);
            this.dtpDatumRodjenja.TabIndex = 4;
            // 
            // btnVratiSeNaLogin
            // 
            this.btnVratiSeNaLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVratiSeNaLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.btnVratiSeNaLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVratiSeNaLogin.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVratiSeNaLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnVratiSeNaLogin.Location = new System.Drawing.Point(371, 545);
            this.btnVratiSeNaLogin.Name = "btnVratiSeNaLogin";
            this.btnVratiSeNaLogin.Size = new System.Drawing.Size(177, 63);
            this.btnVratiSeNaLogin.TabIndex = 3;
            this.btnVratiSeNaLogin.Text = "Vrati se na login";
            this.btnVratiSeNaLogin.UseVisualStyleBackColor = false;
            // 
            // lblPrezimeError
            // 
            this.lblPrezimeError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrezimeError.AutoSize = true;
            this.lblPrezimeError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.lblPrezimeError.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrezimeError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.lblPrezimeError.Location = new System.Drawing.Point(302, 301);
            this.lblPrezimeError.Name = "lblPrezimeError";
            this.lblPrezimeError.Size = new System.Drawing.Size(60, 22);
            this.lblPrezimeError.TabIndex = 9;
            this.lblPrezimeError.Text = "label5";
            this.lblPrezimeError.Visible = false;
            this.lblPrezimeError.Click += new System.EventHandler(this.lblSifraError_Click);
            // 
            // lblEmailError
            // 
            this.lblEmailError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmailError.AutoSize = true;
            this.lblEmailError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.lblEmailError.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.lblEmailError.Location = new System.Drawing.Point(302, 438);
            this.lblEmailError.Name = "lblEmailError";
            this.lblEmailError.Size = new System.Drawing.Size(60, 22);
            this.lblEmailError.TabIndex = 8;
            this.lblEmailError.Text = "label4";
            this.lblEmailError.Visible = false;
            // 
            // lblImeError
            // 
            this.lblImeError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblImeError.AutoSize = true;
            this.lblImeError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.lblImeError.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImeError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.lblImeError.Location = new System.Drawing.Point(302, 227);
            this.lblImeError.Name = "lblImeError";
            this.lblImeError.Size = new System.Drawing.Size(60, 22);
            this.lblImeError.TabIndex = 9;
            this.lblImeError.Text = "label5";
            this.lblImeError.Visible = false;
            this.lblImeError.Click += new System.EventHandler(this.lblSifraError_Click);
            // 
            // lblDatumError
            // 
            this.lblDatumError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDatumError.AutoSize = true;
            this.lblDatumError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.lblDatumError.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatumError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.lblDatumError.Location = new System.Drawing.Point(302, 368);
            this.lblDatumError.Name = "lblDatumError";
            this.lblDatumError.Size = new System.Drawing.Size(60, 22);
            this.lblDatumError.TabIndex = 9;
            this.lblDatumError.Text = "label5";
            this.lblDatumError.Visible = false;
            this.lblDatumError.Click += new System.EventHandler(this.lblSifraError_Click);
            // 
            // lblSifrica
            // 
            this.lblSifraError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSifraError.AutoSize = true;
            this.lblSifraError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.lblSifraError.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSifraError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.lblSifraError.Location = new System.Drawing.Point(302, 508);
            this.lblSifraError.Name = "lblSifrica";
            this.lblSifraError.Size = new System.Drawing.Size(60, 22);
            this.lblSifraError.TabIndex = 8;
            this.lblSifraError.Text = "label4";
            this.lblSifraError.Visible = false;
            // 
            // UcProfileView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.lblDatumError);
            this.Controls.Add(this.lblImeError);
            this.Controls.Add(this.lblPrezimeError);
            this.Controls.Add(this.lblSifraError);
            this.Controls.Add(this.lblEmailError);
            this.Controls.Add(this.dtpDatumRodjenja);
            this.Controls.Add(this.btnVratiSeNaLogin);
            this.Controls.Add(this.btnRegistrujSe);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.tbSifra);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbPrezime);
            this.Controls.Add(this.tbIme);
            this.Controls.Add(this.lblSifra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UcProfileView";
            this.Size = new System.Drawing.Size(698, 632);
            this.Load += new System.EventHandler(this.UcProfileView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSifra;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbSifra;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Button btnRegistrujSe;
        private System.Windows.Forms.DateTimePicker dtpDatumRodjenja;
        private Button btnVratiSeNaLogin;
        private Label lblPrezimeError;
        private Label lblEmailError;
        private Label lblImeError;
        private Label lblDatumError;
        private Label lblSifraError;

        public TextBox TxtIme => tbIme;
        public TextBox TxtPrezime => tbPrezime;

        public TextBox TxtEmail => tbEmail;

        public TextBox TxtSifra => tbSifra;
        public DateTimePicker DtpDatumRodjenja => dtpDatumRodjenja;

        public Label LblSifra => lblSifra;
        public Label LblSifraError => lblSifraError;

        public Button BtnRegistrujSe => btnRegistrujSe;
        public Button BtnVratiSe => btnVratiSeNaLogin;
        public Label LblNaslov => lblNaslov;
    }
}
