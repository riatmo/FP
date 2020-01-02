namespace Transaksi_PreOrder
{
    partial class FormPembayaran
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtCPdetailpesanan = new System.Windows.Forms.TextBox();
            this.btnCariPesanan = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblKodePsn = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txtKdTpembeli = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKdTatasnama = new System.Windows.Forms.TextBox();
            this.cmbPilihPembayaran = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbPesanan = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvwDPTranspem = new System.Windows.Forms.ListView();
            this.btnSelesaiTP = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSisPem = new System.Windows.Forms.Label();
            this.txtTotTag = new System.Windows.Forms.TextBox();
            this.txtJumPem = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnTambahTP = new System.Windows.Forms.Button();
            this.btnHapusTP = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 56);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(283, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRANSAKSI PEMBAYARAN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(830, 66);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 74);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.47486F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.52515F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(826, 163);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.65614F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.34387F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 305F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel2.Controls.Add(this.txtCPdetailpesanan, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCariPesanan, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label8, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblKodePsn, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(820, 38);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // txtCPdetailpesanan
            // 
            this.txtCPdetailpesanan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCPdetailpesanan.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPdetailpesanan.Location = new System.Drawing.Point(3, 8);
            this.txtCPdetailpesanan.Name = "txtCPdetailpesanan";
            this.txtCPdetailpesanan.Size = new System.Drawing.Size(288, 21);
            this.txtCPdetailpesanan.TabIndex = 0;
            this.txtCPdetailpesanan.Text = "Masukkan Kode Detail Pesanan ...";
            // 
            // btnCariPesanan
            // 
            this.btnCariPesanan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCariPesanan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(0)))));
            this.btnCariPesanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCariPesanan.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCariPesanan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCariPesanan.Location = new System.Drawing.Point(297, 4);
            this.btnCariPesanan.Name = "btnCariPesanan";
            this.btnCariPesanan.Size = new System.Drawing.Size(99, 30);
            this.btnCariPesanan.TabIndex = 1;
            this.btnCariPesanan.Text = "Cari";
            this.btnCariPesanan.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(616, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Kode Pesanan";
            // 
            // lblKodePsn
            // 
            this.lblKodePsn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKodePsn.AutoSize = true;
            this.lblKodePsn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKodePsn.Location = new System.Drawing.Point(762, 11);
            this.lblKodePsn.Name = "lblKodePsn";
            this.lblKodePsn.Size = new System.Drawing.Size(0, 15);
            this.lblKodePsn.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 47);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.96774F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.03226F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(820, 113);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "DATA TRANSAKSI";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.98503F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.30468F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.88411F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.82617F));
            this.tableLayoutPanel4.Controls.Add(this.txtKdTpembeli, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.txtKdTatasnama, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.cmbPilihPembayaran, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.label10, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this.cmbPesanan, 3, 2);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 26);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.82759F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.17241F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(814, 84);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // txtKdTpembeli
            // 
            this.txtKdTpembeli.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtKdTpembeli.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKdTpembeli.Location = new System.Drawing.Point(92, 3);
            this.txtKdTpembeli.Name = "txtKdTpembeli";
            this.txtKdTpembeli.ReadOnly = true;
            this.txtKdTpembeli.Size = new System.Drawing.Size(260, 21);
            this.txtKdTpembeli.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kode Pembeli";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Atas Nama";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Pembayaran";
            // 
            // txtKdTatasnama
            // 
            this.txtKdTatasnama.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtKdTatasnama.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKdTatasnama.Location = new System.Drawing.Point(92, 30);
            this.txtKdTatasnama.Name = "txtKdTatasnama";
            this.txtKdTatasnama.ReadOnly = true;
            this.txtKdTatasnama.Size = new System.Drawing.Size(260, 21);
            this.txtKdTatasnama.TabIndex = 12;
            // 
            // cmbPilihPembayaran
            // 
            this.cmbPilihPembayaran.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbPilihPembayaran.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbPilihPembayaran.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPilihPembayaran.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cmbPilihPembayaran.FormattingEnabled = true;
            this.cmbPilihPembayaran.Items.AddRange(new object[] {
            "Tunai",
            "Transfer"});
            this.cmbPilihPembayaran.Location = new System.Drawing.Point(92, 59);
            this.cmbPilihPembayaran.Name = "cmbPilihPembayaran";
            this.cmbPilihPembayaran.Size = new System.Drawing.Size(121, 24);
            this.cmbPilihPembayaran.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(411, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Status Pesanan";
            // 
            // cmbPesanan
            // 
            this.cmbPesanan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbPesanan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbPesanan.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPesanan.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cmbPesanan.FormattingEnabled = true;
            this.cmbPesanan.Items.AddRange(new object[] {
            "Tunda",
            "Proses",
            "Selesai"});
            this.cmbPesanan.Location = new System.Drawing.Point(572, 59);
            this.cmbPesanan.Name = "cmbPesanan";
            this.cmbPesanan.Size = new System.Drawing.Size(121, 24);
            this.cmbPesanan.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvwDPTranspem);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 240);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(826, 105);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[ Data Pesanan ]";
            // 
            // lvwDPTranspem
            // 
            this.lvwDPTranspem.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwDPTranspem.HideSelection = false;
            this.lvwDPTranspem.Location = new System.Drawing.Point(3, 19);
            this.lvwDPTranspem.Name = "lvwDPTranspem";
            this.lvwDPTranspem.Size = new System.Drawing.Size(820, 80);
            this.lvwDPTranspem.TabIndex = 0;
            this.lvwDPTranspem.UseCompatibleStateImageBehavior = false;
            // 
            // btnSelesaiTP
            // 
            this.btnSelesaiTP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSelesaiTP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(0)))));
            this.btnSelesaiTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelesaiTP.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelesaiTP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSelesaiTP.Location = new System.Drawing.Point(628, 463);
            this.btnSelesaiTP.Name = "btnSelesaiTP";
            this.btnSelesaiTP.Size = new System.Drawing.Size(200, 23);
            this.btnSelesaiTP.TabIndex = 1;
            this.btnSelesaiTP.Text = "Selesai";
            this.btnSelesaiTP.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.tableLayoutPanel5);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(2, 351);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(826, 99);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.95122F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.04878F));
            this.tableLayoutPanel5.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.txtSisPem, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.txtTotTag, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.txtJumPem, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.textBox4, 1, 2);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(820, 96);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(488, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total Tagihan Rp.";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(450, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Jumlah Pembayaran Rp.";
            // 
            // txtSisPem
            // 
            this.txtSisPem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtSisPem.AutoSize = true;
            this.txtSisPem.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSisPem.Location = new System.Drawing.Point(467, 72);
            this.txtSisPem.Name = "txtSisPem";
            this.txtSisPem.Size = new System.Drawing.Size(119, 15);
            this.txtSisPem.TabIndex = 0;
            this.txtSisPem.Text = "Sisa Pembayaran Rp.";
            // 
            // txtTotTag
            // 
            this.txtTotTag.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTotTag.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotTag.Location = new System.Drawing.Point(592, 5);
            this.txtTotTag.Name = "txtTotTag";
            this.txtTotTag.ReadOnly = true;
            this.txtTotTag.Size = new System.Drawing.Size(225, 21);
            this.txtTotTag.TabIndex = 12;
            // 
            // txtJumPem
            // 
            this.txtJumPem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtJumPem.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJumPem.Location = new System.Drawing.Point(592, 37);
            this.txtJumPem.Name = "txtJumPem";
            this.txtJumPem.ReadOnly = true;
            this.txtJumPem.Size = new System.Drawing.Size(225, 21);
            this.txtJumPem.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(592, 69);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(225, 21);
            this.textBox4.TabIndex = 12;
            // 
            // btnTambahTP
            // 
            this.btnTambahTP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnTambahTP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(0)))));
            this.btnTambahTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambahTP.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambahTP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTambahTP.Location = new System.Drawing.Point(2, 461);
            this.btnTambahTP.Name = "btnTambahTP";
            this.btnTambahTP.Size = new System.Drawing.Size(200, 24);
            this.btnTambahTP.TabIndex = 1;
            this.btnTambahTP.Text = "Tambah";
            this.btnTambahTP.UseVisualStyleBackColor = false;
            this.btnTambahTP.Click += new System.EventHandler(this.btnTambahTP_Click);
            // 
            // btnHapusTP
            // 
            this.btnHapusTP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnHapusTP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(0)))));
            this.btnHapusTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapusTP.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapusTP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHapusTP.Location = new System.Drawing.Point(223, 461);
            this.btnHapusTP.Name = "btnHapusTP";
            this.btnHapusTP.Size = new System.Drawing.Size(200, 24);
            this.btnHapusTP.TabIndex = 1;
            this.btnHapusTP.Text = "Hapus";
            this.btnHapusTP.UseVisualStyleBackColor = false;
            // 
            // FormPembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 496);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnHapusTP);
            this.Controls.Add(this.btnTambahTP);
            this.Controls.Add(this.btnSelesaiTP);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.MaximizeBox = false;
            this.Name = "FormPembayaran";
            this.Text = "Pembayaran";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtCPdetailpesanan;
        private System.Windows.Forms.Button btnCariPesanan;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKdTpembeli;
        private System.Windows.Forms.TextBox txtKdTatasnama;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvwDPTranspem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSelesaiTP;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtSisPem;
        private System.Windows.Forms.TextBox txtTotTag;
        private System.Windows.Forms.TextBox txtJumPem;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnTambahTP;
        private System.Windows.Forms.Button btnHapusTP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblKodePsn;
        private System.Windows.Forms.ComboBox cmbPilihPembayaran;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbPesanan;
    }
}