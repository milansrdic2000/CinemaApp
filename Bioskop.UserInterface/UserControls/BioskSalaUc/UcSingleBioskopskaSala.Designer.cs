using System.Windows.Forms;

namespace Bioskop.UserInterface.UserControls.BioskSalaUc
{
    partial class UcSingleBioskopskaSala
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNazivSale = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvSedista = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRed = new System.Windows.Forms.TextBox();
            this.txtKolona = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDodajSediste = new System.Windows.Forms.Button();
            this.btnDodajSalu = new System.Windows.Forms.Button();
            this.btnIzmeniSalu = new System.Windows.Forms.Button();
            this.btnObrisiSediste = new System.Windows.Forms.Button();
            this.txtRedoviGenerisi = new System.Windows.Forms.TextBox();
            this.txtKolonaGenerisi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnGenerisiSedista = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblKolonaGenerisiError = new System.Windows.Forms.Label();
            this.lblKolonaError = new System.Windows.Forms.Label();
            this.lblRedError = new System.Windows.Forms.Label();
            this.lblRedGenerisiError = new System.Windows.Forms.Label();
            this.lblNazivError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSedista)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.label1.Location = new System.Drawing.Point(313, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bioskopska sala";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.label2.Location = new System.Drawing.Point(52, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naziv sale";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNazivSale
            // 
            this.txtNazivSale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNazivSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.txtNazivSale.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNazivSale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.txtNazivSale.Location = new System.Drawing.Point(217, 108);
            this.txtNazivSale.Name = "txtNazivSale";
            this.txtNazivSale.Size = new System.Drawing.Size(310, 35);
            this.txtNazivSale.TabIndex = 2;
            this.txtNazivSale.TextChanged += new System.EventHandler(this.txtNazivSale_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.label3.Location = new System.Drawing.Point(393, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sedista";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dgvSedista
            // 
            this.dgvSedista.AllowUserToAddRows = false;
            this.dgvSedista.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.dgvSedista.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSedista.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvSedista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSedista.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.dgvSedista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSedista.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSedista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSedista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSedista.ColumnHeadersHeight = 50;
            this.dgvSedista.EnableHeadersVisualStyles = false;
            this.dgvSedista.Location = new System.Drawing.Point(57, 388);
            this.dgvSedista.Name = "dgvSedista";
            this.dgvSedista.RowHeadersVisible = false;
            this.dgvSedista.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.dgvSedista.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSedista.RowTemplate.Height = 40;
            this.dgvSedista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSedista.Size = new System.Drawing.Size(480, 273);
            this.dgvSedista.TabIndex = 4;
            this.dgvSedista.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvSedista_CellValidating);
            this.dgvSedista.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSedista_CellValueChanged);
            this.dgvSedista.Validating += new System.ComponentModel.CancelEventHandler(this.dgvSedista_Validating);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.label4.Location = new System.Drawing.Point(131, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 34);
            this.label4.TabIndex = 1;
            this.label4.Text = "Lista trenutnih sedista";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.label5.Location = new System.Drawing.Point(615, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 34);
            this.label5.TabIndex = 1;
            this.label5.Text = "Dodaj novo sediste";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtRed
            // 
            this.txtRed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.txtRed.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.txtRed.Location = new System.Drawing.Point(679, 433);
            this.txtRed.Name = "txtRed";
            this.txtRed.Size = new System.Drawing.Size(188, 32);
            this.txtRed.TabIndex = 2;
            this.txtRed.TextChanged += new System.EventHandler(this.txtRed_TextChanged);
            // 
            // txtKolona
            // 
            this.txtKolona.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKolona.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.txtKolona.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKolona.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.txtKolona.Location = new System.Drawing.Point(679, 508);
            this.txtKolona.Name = "txtKolona";
            this.txtKolona.Size = new System.Drawing.Size(188, 32);
            this.txtKolona.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.label6.Location = new System.Drawing.Point(590, 441);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Red";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.label7.Location = new System.Drawing.Point(590, 516);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "Kolona";
            // 
            // btnDodajSediste
            // 
            this.btnDodajSediste.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDodajSediste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.btnDodajSediste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajSediste.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajSediste.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnDodajSediste.Location = new System.Drawing.Point(647, 588);
            this.btnDodajSediste.Name = "btnDodajSediste";
            this.btnDodajSediste.Size = new System.Drawing.Size(149, 62);
            this.btnDodajSediste.TabIndex = 5;
            this.btnDodajSediste.Text = "Dodaj sediste u salu";
            this.btnDodajSediste.UseVisualStyleBackColor = false;
            // 
            // btnDodajSalu
            // 
            this.btnDodajSalu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDodajSalu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.btnDodajSalu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajSalu.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajSalu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnDodajSalu.Location = new System.Drawing.Point(371, 741);
            this.btnDodajSalu.Name = "btnDodajSalu";
            this.btnDodajSalu.Size = new System.Drawing.Size(193, 68);
            this.btnDodajSalu.TabIndex = 5;
            this.btnDodajSalu.Text = "Sacuvaj bioskopsku salu";
            this.btnDodajSalu.UseVisualStyleBackColor = false;
            // 
            // btnIzmeniSalu
            // 
            this.btnIzmeniSalu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIzmeniSalu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.btnIzmeniSalu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzmeniSalu.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeniSalu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnIzmeniSalu.Location = new System.Drawing.Point(399, 741);
            this.btnIzmeniSalu.Name = "btnIzmeniSalu";
            this.btnIzmeniSalu.Size = new System.Drawing.Size(146, 68);
            this.btnIzmeniSalu.TabIndex = 6;
            this.btnIzmeniSalu.Text = "Izmeni salu";
            this.btnIzmeniSalu.UseVisualStyleBackColor = false;
            // 
            // btnObrisiSediste
            // 
            this.btnObrisiSediste.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnObrisiSediste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.btnObrisiSediste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisiSediste.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiSediste.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnObrisiSediste.Location = new System.Drawing.Point(208, 667);
            this.btnObrisiSediste.Name = "btnObrisiSediste";
            this.btnObrisiSediste.Size = new System.Drawing.Size(149, 62);
            this.btnObrisiSediste.TabIndex = 5;
            this.btnObrisiSediste.Text = "Obrisi sediste";
            this.btnObrisiSediste.UseVisualStyleBackColor = false;
            // 
            // txtRedoviGenerisi
            // 
            this.txtRedoviGenerisi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRedoviGenerisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.txtRedoviGenerisi.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRedoviGenerisi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.txtRedoviGenerisi.Location = new System.Drawing.Point(217, 215);
            this.txtRedoviGenerisi.Name = "txtRedoviGenerisi";
            this.txtRedoviGenerisi.Size = new System.Drawing.Size(87, 32);
            this.txtRedoviGenerisi.TabIndex = 8;
            this.txtRedoviGenerisi.TextChanged += new System.EventHandler(this.txtRedoviGenerisi_TextChanged);
            // 
            // txtKolonaGenerisi
            // 
            this.txtKolonaGenerisi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKolonaGenerisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.txtKolonaGenerisi.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKolonaGenerisi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.txtKolonaGenerisi.Location = new System.Drawing.Point(217, 280);
            this.txtKolonaGenerisi.Name = "txtKolonaGenerisi";
            this.txtKolonaGenerisi.Size = new System.Drawing.Size(87, 32);
            this.txtKolonaGenerisi.TabIndex = 8;
            this.txtKolonaGenerisi.TextChanged += new System.EventHandler(this.txtKolonaGenerisi_TextChanged);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.label11.Location = new System.Drawing.Point(53, 215);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 24);
            this.label11.TabIndex = 1;
            this.label11.Text = "Redova ukupno";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.label12.Location = new System.Drawing.Point(53, 280);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 24);
            this.label12.TabIndex = 1;
            this.label12.Text = "Kolona ukupno";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // btnGenerisiSedista
            // 
            this.btnGenerisiSedista.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGenerisiSedista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.btnGenerisiSedista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerisiSedista.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerisiSedista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnGenerisiSedista.Location = new System.Drawing.Point(379, 229);
            this.btnGenerisiSedista.Name = "btnGenerisiSedista";
            this.btnGenerisiSedista.Size = new System.Drawing.Size(148, 63);
            this.btnGenerisiSedista.TabIndex = 9;
            this.btnGenerisiSedista.Text = "Generisi sedista";
            this.btnGenerisiSedista.UseVisualStyleBackColor = false;
            this.btnGenerisiSedista.Click += new System.EventHandler(this.btnGenerisiSedista_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.lblKolonaGenerisiError);
            this.panel1.Controls.Add(this.lblKolonaError);
            this.panel1.Controls.Add(this.lblRedError);
            this.panel1.Controls.Add(this.lblRedGenerisiError);
            this.panel1.Controls.Add(this.lblNazivError);
            this.panel1.Controls.Add(this.dgvSedista);
            this.panel1.Controls.Add(this.btnGenerisiSedista);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtKolonaGenerisi);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtRedoviGenerisi);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnIzmeniSalu);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnDodajSalu);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnObrisiSediste);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btnDodajSediste);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtKolona);
            this.panel1.Controls.Add(this.txtRed);
            this.panel1.Controls.Add(this.txtNazivSale);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 834);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblKolonaGenerisiError
            // 
            this.lblKolonaGenerisiError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKolonaGenerisiError.AutoSize = true;
            this.lblKolonaGenerisiError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.lblKolonaGenerisiError.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKolonaGenerisiError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.lblKolonaGenerisiError.Location = new System.Drawing.Point(213, 315);
            this.lblKolonaGenerisiError.Name = "lblKolonaGenerisiError";
            this.lblKolonaGenerisiError.Size = new System.Drawing.Size(60, 22);
            this.lblKolonaGenerisiError.TabIndex = 11;
            this.lblKolonaGenerisiError.Text = "label5";
            this.lblKolonaGenerisiError.Visible = false;
            this.lblKolonaGenerisiError.Click += new System.EventHandler(this.lblNazivError_Click);
            // 
            // lblKolonaError
            // 
            this.lblKolonaError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKolonaError.AutoSize = true;
            this.lblKolonaError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.lblKolonaError.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKolonaError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.lblKolonaError.Location = new System.Drawing.Point(675, 543);
            this.lblKolonaError.Name = "lblKolonaError";
            this.lblKolonaError.Size = new System.Drawing.Size(60, 22);
            this.lblKolonaError.TabIndex = 11;
            this.lblKolonaError.Text = "label5";
            this.lblKolonaError.Visible = false;
            this.lblKolonaError.Click += new System.EventHandler(this.lblNazivError_Click);
            // 
            // lblRedError
            // 
            this.lblRedError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRedError.AutoSize = true;
            this.lblRedError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.lblRedError.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRedError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.lblRedError.Location = new System.Drawing.Point(675, 468);
            this.lblRedError.Name = "lblRedError";
            this.lblRedError.Size = new System.Drawing.Size(60, 22);
            this.lblRedError.TabIndex = 11;
            this.lblRedError.Text = "label5";
            this.lblRedError.Visible = false;
            this.lblRedError.Click += new System.EventHandler(this.lblNazivError_Click);
            // 
            // lblRedGenerisiError
            // 
            this.lblRedGenerisiError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRedGenerisiError.AutoSize = true;
            this.lblRedGenerisiError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.lblRedGenerisiError.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRedGenerisiError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.lblRedGenerisiError.Location = new System.Drawing.Point(213, 250);
            this.lblRedGenerisiError.Name = "lblRedGenerisiError";
            this.lblRedGenerisiError.Size = new System.Drawing.Size(60, 22);
            this.lblRedGenerisiError.TabIndex = 11;
            this.lblRedGenerisiError.Text = "label5";
            this.lblRedGenerisiError.Visible = false;
            this.lblRedGenerisiError.Click += new System.EventHandler(this.lblNazivError_Click);
            // 
            // lblNazivError
            // 
            this.lblNazivError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNazivError.AutoSize = true;
            this.lblNazivError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.lblNazivError.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNazivError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.lblNazivError.Location = new System.Drawing.Point(213, 146);
            this.lblNazivError.Name = "lblNazivError";
            this.lblNazivError.Size = new System.Drawing.Size(60, 22);
            this.lblNazivError.TabIndex = 11;
            this.lblNazivError.Text = "label5";
            this.lblNazivError.Visible = false;
            this.lblNazivError.Click += new System.EventHandler(this.lblNazivError_Click);
            // 
            // UcSingleBioskopskaSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UcSingleBioskopskaSala";
            this.Size = new System.Drawing.Size(887, 834);
            this.Load += new System.EventHandler(this.UcSingleBioskopskaSala_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSedista)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNazivSale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvSedista;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRed;
        private System.Windows.Forms.TextBox txtKolona;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDodajSediste;
        private System.Windows.Forms.Button btnDodajSalu;
        private System.Windows.Forms.Button btnIzmeniSalu;
        private System.Windows.Forms.Button btnObrisiSediste;
        private System.Windows.Forms.TextBox txtRedoviGenerisi;
        private System.Windows.Forms.TextBox txtKolonaGenerisi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnGenerisiSedista;
        private Panel panel1;
        private Label lblNazivError;
        private Label lblKolonaGenerisiError;
        private Label lblKolonaError;
        private Label lblRedError;
        private Label lblRedGenerisiError;

        public System.Windows.Forms.Button BtnDodajSedist => btnDodajSediste;

        public System.Windows.Forms.Button BtnDodajSalu => btnDodajSalu;

        public System.Windows.Forms.Button BtnIzmeniSalu => btnIzmeniSalu;

        public System.Windows.Forms.Button BtnObrisiSediste => btnObrisiSediste;

        public Button BtnGenerisiSediste => btnGenerisiSedista;
        public System.Windows.Forms.DataGridView DgvSedista => dgvSedista;

        public TextBox TxtRedoviGenerisani => txtRedoviGenerisi;
        public TextBox TxtKoloneGenerisane => txtKolonaGenerisi;

        public TextBox TxtRed => txtRed;
        public TextBox TxtKolona => txtKolona;

        public TextBox TxtNazivsale => txtNazivSale;
    }
}
