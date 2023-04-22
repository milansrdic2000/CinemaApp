using System.Windows.Forms;

namespace Bioskop.UserInterface.UserControls.ProjekcijeUc
{
    partial class UcAllProjekcijeFilma
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
            this.dgvListProjekcija = new System.Windows.Forms.DataGridView();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIzmeniProjekciju = new System.Windows.Forms.Button();
            this.pnlPretraziPomoc = new System.Windows.Forms.Panel();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProjekcija)).BeginInit();
            this.tlpMain.SuspendLayout();
            this.pnlPretraziPomoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListProjekcija
            // 
            this.dgvListProjekcija.AllowUserToAddRows = false;
            this.dgvListProjekcija.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.dgvListProjekcija.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListProjekcija.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListProjekcija.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.dgvListProjekcija.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListProjekcija.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvListProjekcija.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListProjekcija.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListProjekcija.ColumnHeadersHeight = 50;
            this.tlpMain.SetColumnSpan(this.dgvListProjekcija, 2);
            this.dgvListProjekcija.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListProjekcija.EnableHeadersVisualStyles = false;
            this.dgvListProjekcija.Location = new System.Drawing.Point(3, 78);
            this.dgvListProjekcija.Name = "dgvListProjekcija";
            this.dgvListProjekcija.ReadOnly = true;
            this.dgvListProjekcija.RowHeadersVisible = false;
            this.dgvListProjekcija.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.dgvListProjekcija.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListProjekcija.RowTemplate.Height = 40;
            this.dgvListProjekcija.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListProjekcija.Size = new System.Drawing.Size(862, 521);
            this.dgvListProjekcija.TabIndex = 1;
            // 
            // tlpMain
            // 
            this.tlpMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Controls.Add(this.dgvListProjekcija, 0, 1);
            this.tlpMain.Controls.Add(this.label1, 0, 0);
            this.tlpMain.Controls.Add(this.btnIzmeniProjekciju, 0, 2);
            this.tlpMain.Controls.Add(this.pnlPretraziPomoc, 1, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(868, 754);
            this.tlpMain.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.tlpMain.SetColumnSpan(this.label1, 2);
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.label1.Location = new System.Drawing.Point(238, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 57);
            this.label1.TabIndex = 3;
            this.label1.Text = "Izaberi projekciju";
            // 
            // btnIzmeniProjekciju
            // 
            this.btnIzmeniProjekciju.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIzmeniProjekciju.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.btnIzmeniProjekciju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzmeniProjekciju.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeniProjekciju.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnIzmeniProjekciju.Location = new System.Drawing.Point(90, 642);
            this.btnIzmeniProjekciju.Name = "btnIzmeniProjekciju";
            this.btnIzmeniProjekciju.Size = new System.Drawing.Size(253, 72);
            this.btnIzmeniProjekciju.TabIndex = 4;
            this.btnIzmeniProjekciju.Text = "Izmeni projekciju";
            this.btnIzmeniProjekciju.UseVisualStyleBackColor = false;
            // 
            // pnlPretraziPomoc
            // 
            this.pnlPretraziPomoc.Controls.Add(this.txtPretraga);
            this.pnlPretraziPomoc.Controls.Add(this.label2);
            this.pnlPretraziPomoc.Controls.Add(this.label4);
            this.pnlPretraziPomoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPretraziPomoc.Location = new System.Drawing.Point(437, 605);
            this.pnlPretraziPomoc.Name = "pnlPretraziPomoc";
            this.pnlPretraziPomoc.Size = new System.Drawing.Size(428, 146);
            this.pnlPretraziPomoc.TabIndex = 5;
            // 
            // txtPretraga
            // 
            this.txtPretraga.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPretraga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.txtPretraga.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPretraga.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.txtPretraga.Location = new System.Drawing.Point(136, 81);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(272, 31);
            this.txtPretraga.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.label2.Location = new System.Drawing.Point(25, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ime filma";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.label4.Location = new System.Drawing.Point(150, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 45);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pretrazi";
            // 
            // UcAllProjekcijeFilma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.tlpMain);
            this.Name = "UcAllProjekcijeFilma";
            this.Size = new System.Drawing.Size(868, 754);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProjekcija)).EndInit();
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.pnlPretraziPomoc.ResumeLayout(false);
            this.pnlPretraziPomoc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvListProjekcija;
        private TableLayoutPanel tlpMain;
        private Label label1;
        private Button btnIzmeniProjekciju;
        private Panel pnlPretraziPomoc;
        private TextBox txtPretraga;
        private Label label2;
        private Label label4;

        public DataGridView DgvListProjekcija => dgvListProjekcija;
        public Button BtnIzmeniProjekciju => btnIzmeniProjekciju;

        public TextBox TxtPretraga => txtPretraga;

        public Panel PnlPretrazi => pnlPretraziPomoc;

        public TableLayoutPanel TlpMain => tlpMain;
    }
}
