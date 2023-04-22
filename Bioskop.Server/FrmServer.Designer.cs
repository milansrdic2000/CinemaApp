namespace Bioskop.Server
{
    partial class FrmServer
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
            this.lblPovezaniKlijenti = new System.Windows.Forms.Label();
            this.dgvPovezaniKlijenti = new System.Windows.Forms.DataGridView();
            this.btnPokreniServer = new System.Windows.Forms.Button();
            this.btnZaustaviServer = new System.Windows.Forms.Button();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPovezaniKlijenti)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPovezaniKlijenti
            // 
            this.lblPovezaniKlijenti.AutoSize = true;
            this.lblPovezaniKlijenti.BackColor = System.Drawing.Color.Transparent;
            this.lblPovezaniKlijenti.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPovezaniKlijenti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.lblPovezaniKlijenti.Location = new System.Drawing.Point(303, 9);
            this.lblPovezaniKlijenti.Name = "lblPovezaniKlijenti";
            this.lblPovezaniKlijenti.Padding = new System.Windows.Forms.Padding(15);
            this.lblPovezaniKlijenti.Size = new System.Drawing.Size(186, 54);
            this.lblPovezaniKlijenti.TabIndex = 1;
            this.lblPovezaniKlijenti.Text = "Povezani kljienti";
            this.lblPovezaniKlijenti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvPovezaniKlijenti
            // 
            this.dgvPovezaniKlijenti.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.dgvPovezaniKlijenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPovezaniKlijenti.Location = new System.Drawing.Point(0, 67);
            this.dgvPovezaniKlijenti.Name = "dgvPovezaniKlijenti";
            this.dgvPovezaniKlijenti.RowHeadersWidth = 51;
            this.dgvPovezaniKlijenti.RowTemplate.Height = 24;
            this.dgvPovezaniKlijenti.Size = new System.Drawing.Size(800, 263);
            this.dgvPovezaniKlijenti.TabIndex = 2;
            // 
            // btnPokreniServer
            // 
            this.btnPokreniServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.btnPokreniServer.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPokreniServer.Location = new System.Drawing.Point(43, 357);
            this.btnPokreniServer.Name = "btnPokreniServer";
            this.btnPokreniServer.Size = new System.Drawing.Size(157, 81);
            this.btnPokreniServer.TabIndex = 3;
            this.btnPokreniServer.Text = "Pokreni server";
            this.btnPokreniServer.UseVisualStyleBackColor = false;
            this.btnPokreniServer.Click += new System.EventHandler(this.btnPokreniServer_Click);
            // 
            // btnZaustaviServer
            // 
            this.btnZaustaviServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.btnZaustaviServer.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZaustaviServer.Location = new System.Drawing.Point(250, 357);
            this.btnZaustaviServer.Name = "btnZaustaviServer";
            this.btnZaustaviServer.Size = new System.Drawing.Size(157, 81);
            this.btnZaustaviServer.TabIndex = 3;
            this.btnZaustaviServer.Text = "Zaustavi server";
            this.btnZaustaviServer.UseVisualStyleBackColor = false;
            this.btnZaustaviServer.Click += new System.EventHandler(this.btnZaustaviServer_Click);
            // 
            // tbStatus
            // 
            this.tbStatus.BackColor = System.Drawing.Color.Red;
            this.tbStatus.Location = new System.Drawing.Point(577, 389);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(199, 22);
            this.tbStatus.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(176)))), ((int)(((byte)(122)))));
            this.label1.Location = new System.Drawing.Point(456, 370);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(15);
            this.label1.Size = new System.Drawing.Size(103, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Status:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.btnZaustaviServer);
            this.Controls.Add(this.btnPokreniServer);
            this.Controls.Add(this.dgvPovezaniKlijenti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPovezaniKlijenti);
            this.Name = "FrmServer";
            this.Text = "Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmServer_FormClosed);
            this.Load += new System.EventHandler(this.FrmServer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPovezaniKlijenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPovezaniKlijenti;
        private System.Windows.Forms.DataGridView dgvPovezaniKlijenti;
        private System.Windows.Forms.Button btnPokreniServer;
        private System.Windows.Forms.Button btnZaustaviServer;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.Label label1;
    }
}

