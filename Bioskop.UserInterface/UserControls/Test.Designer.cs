namespace Bioskop.UserInterface.UserControls
{
    partial class Test
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlSedista = new System.Windows.Forms.Panel();
            this.dgvSedistePrikaz = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlSedista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSedistePrikaz)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlSedista, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.44296F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.55704F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1047, 927);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.button1, 2);
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(3, 618);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1041, 306);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pnlSedista
            // 
            this.pnlSedista.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlSedista.Controls.Add(this.dgvSedistePrikaz);
            this.pnlSedista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSedista.Location = new System.Drawing.Point(3, 3);
            this.pnlSedista.Name = "pnlSedista";
            this.pnlSedista.Padding = new System.Windows.Forms.Padding(40);
            this.pnlSedista.Size = new System.Drawing.Size(1041, 609);
            this.pnlSedista.TabIndex = 2;
            // 
            // dgvSedistePrikaz
            // 
            this.dgvSedistePrikaz.AllowUserToAddRows = false;
            this.dgvSedistePrikaz.AllowUserToDeleteRows = false;
            this.dgvSedistePrikaz.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvSedistePrikaz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSedistePrikaz.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSedistePrikaz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSedistePrikaz.Location = new System.Drawing.Point(40, 40);
            this.dgvSedistePrikaz.Name = "dgvSedistePrikaz";
            this.dgvSedistePrikaz.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSedistePrikaz.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSedistePrikaz.RowHeadersWidth = 51;
            this.dgvSedistePrikaz.RowTemplate.Height = 24;
            this.dgvSedistePrikaz.Size = new System.Drawing.Size(961, 529);
            this.dgvSedistePrikaz.TabIndex = 0;
            this.dgvSedistePrikaz.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSedistePrikaz_CellMouseEnter);
            this.dgvSedistePrikaz.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSedistePrikaz_CellMouseLeave);
            this.dgvSedistePrikaz.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgvSedistePrikaz_ColumnWidthChanged);
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Test";
            this.Size = new System.Drawing.Size(1047, 927);
            this.Load += new System.EventHandler(this.Test_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlSedista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSedistePrikaz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlSedista;
        private System.Windows.Forms.DataGridView dgvSedistePrikaz;
    }
}
