namespace Transaksi_PreOrder
{
    partial class FormPelanggan
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtAlamat = new System.Windows.Forms.RichTextBox();
            this.txtKdPel = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtHp = new System.Windows.Forms.TextBox();
            this.txtKec = new System.Windows.Forms.TextBox();
            this.txtKab = new System.Windows.Forms.TextBox();
            this.txtProv = new System.Windows.Forms.TextBox();
            this.txtPos = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnSelesai = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.txtAlamat, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtKdPel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNama, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtHp, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtKec, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtKab, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtProv, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtPos, 4, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(25, 91);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1008, 259);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(204, 195);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(246, 61);
            this.txtAlamat.TabIndex = 0;
            this.txtAlamat.Text = "";
            // 
            // txtKdPel
            // 
            this.txtKdPel.Location = new System.Drawing.Point(204, 3);
            this.txtKdPel.Name = "txtKdPel";
            this.txtKdPel.Size = new System.Drawing.Size(100, 20);
            this.txtKdPel.TabIndex = 1;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(204, 67);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(100, 20);
            this.txtNama.TabIndex = 2;
            // 
            // txtHp
            // 
            this.txtHp.Location = new System.Drawing.Point(204, 131);
            this.txtHp.Name = "txtHp";
            this.txtHp.Size = new System.Drawing.Size(100, 20);
            this.txtHp.TabIndex = 3;
            // 
            // txtKec
            // 
            this.txtKec.Location = new System.Drawing.Point(757, 3);
            this.txtKec.Name = "txtKec";
            this.txtKec.Size = new System.Drawing.Size(100, 20);
            this.txtKec.TabIndex = 4;
            // 
            // txtKab
            // 
            this.txtKab.Location = new System.Drawing.Point(757, 67);
            this.txtKab.Name = "txtKab";
            this.txtKab.Size = new System.Drawing.Size(100, 20);
            this.txtKab.TabIndex = 5;
            // 
            // txtProv
            // 
            this.txtProv.Location = new System.Drawing.Point(757, 131);
            this.txtProv.Name = "txtProv";
            this.txtProv.Size = new System.Drawing.Size(100, 20);
            this.txtProv.TabIndex = 6;
            // 
            // txtPos
            // 
            this.txtPos.Location = new System.Drawing.Point(757, 195);
            this.txtPos.Name = "txtPos";
            this.txtPos.Size = new System.Drawing.Size(100, 20);
            this.txtPos.TabIndex = 7;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(125, 415);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 2;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnSelesai
            // 
            this.btnSelesai.Location = new System.Drawing.Point(230, 415);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(75, 23);
            this.btnSelesai.TabIndex = 3;
            this.btnSelesai.Text = "button3";
            this.btnSelesai.UseVisualStyleBackColor = true;
            // 
            // FormPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 450);
            this.Controls.Add(this.btnSelesai);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormPelanggan";
            this.Text = "FormPelanggan";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox txtAlamat;
        private System.Windows.Forms.TextBox txtKdPel;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtHp;
        private System.Windows.Forms.TextBox txtKec;
        private System.Windows.Forms.TextBox txtKab;
        private System.Windows.Forms.TextBox txtProv;
        private System.Windows.Forms.TextBox txtPos;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnSelesai;
    }
}