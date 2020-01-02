namespace Transaksi_PreOrder.View
{
    partial class FormPembelian
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.datePesananPbl = new System.Windows.Forms.DateTimePicker();
            this.txtKdPembelian = new System.Windows.Forms.TextBox();
            this.txtKDprodusen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKdPesanan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtADMIN = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNamaBrg = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtHargaPbl = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtQtyPbl = new System.Windows.Forms.TextBox();
            this.txtSubPbl = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTambahPbl = new System.Windows.Forms.Button();
            this.lvwPembelian = new System.Windows.Forms.ListView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCariPembelian = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKdBarang = new System.Windows.Forms.TextBox();
            this.btnSelesaiPbl = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 42);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(335, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "PEMBELIAN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 66);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 246F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(789, 375);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.15646F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.84354F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.datePesananPbl, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtKdPembelian, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtKDprodusen, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtKdPesanan, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtADMIN, 4, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(783, 87);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kode Pembelian";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(354, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tanggal Pembelian";
            // 
            // datePesananPbl
            // 
            this.datePesananPbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.datePesananPbl.Location = new System.Drawing.Point(475, 11);
            this.datePesananPbl.Name = "datePesananPbl";
            this.datePesananPbl.Size = new System.Drawing.Size(169, 20);
            this.datePesananPbl.TabIndex = 17;
            // 
            // txtKdPembelian
            // 
            this.txtKdPembelian.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKdPembelian.Location = new System.Drawing.Point(147, 11);
            this.txtKdPembelian.Name = "txtKdPembelian";
            this.txtKdPembelian.Size = new System.Drawing.Size(201, 20);
            this.txtKdPembelian.TabIndex = 18;
            // 
            // txtKDprodusen
            // 
            this.txtKDprodusen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKDprodusen.Location = new System.Drawing.Point(475, 55);
            this.txtKDprodusen.Name = "txtKDprodusen";
            this.txtKDprodusen.Size = new System.Drawing.Size(169, 20);
            this.txtKDprodusen.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kode Pesanan";
            // 
            // txtKdPesanan
            // 
            this.txtKdPesanan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKdPesanan.Location = new System.Drawing.Point(147, 55);
            this.txtKdPesanan.Name = "txtKdPesanan";
            this.txtKdPesanan.Size = new System.Drawing.Size(201, 20);
            this.txtKdPesanan.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(354, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kode Produsen";
            // 
            // txtADMIN
            // 
            this.txtADMIN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtADMIN.AutoSize = true;
            this.txtADMIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtADMIN.Location = new System.Drawing.Point(650, 11);
            this.txtADMIN.Name = "txtADMIN";
            this.txtADMIN.Size = new System.Drawing.Size(130, 20);
            this.txtADMIN.TabIndex = 21;
            this.txtADMIN.Text = "AD001";
            this.txtADMIN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lvwPembelian, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 132);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(783, 240);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 9;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.54546F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel5.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.txtNamaBrg, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label13, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.txtHargaPbl, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.label14, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.txtQtyPbl, 5, 0);
            this.tableLayoutPanel5.Controls.Add(this.txtSubPbl, 7, 0);
            this.tableLayoutPanel5.Controls.Add(this.label6, 6, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnTambahPbl, 8, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(777, 30);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Nama Barang";
            // 
            // txtNamaBrg
            // 
            this.txtNamaBrg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNamaBrg.Location = new System.Drawing.Point(121, 5);
            this.txtNamaBrg.Name = "txtNamaBrg";
            this.txtNamaBrg.Size = new System.Drawing.Size(136, 20);
            this.txtNamaBrg.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(263, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 15);
            this.label13.TabIndex = 0;
            this.label13.Text = "Harga";
            // 
            // txtHargaPbl
            // 
            this.txtHargaPbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHargaPbl.Location = new System.Drawing.Point(310, 5);
            this.txtHargaPbl.Name = "txtHargaPbl";
            this.txtHargaPbl.Size = new System.Drawing.Size(117, 20);
            this.txtHargaPbl.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(433, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 15);
            this.label14.TabIndex = 0;
            this.label14.Text = "Qty";
            // 
            // txtQtyPbl
            // 
            this.txtQtyPbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQtyPbl.Location = new System.Drawing.Point(464, 5);
            this.txtQtyPbl.Name = "txtQtyPbl";
            this.txtQtyPbl.Size = new System.Drawing.Size(48, 20);
            this.txtQtyPbl.TabIndex = 18;
            // 
            // txtSubPbl
            // 
            this.txtSubPbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubPbl.Location = new System.Drawing.Point(580, 5);
            this.txtSubPbl.Name = "txtSubPbl";
            this.txtSubPbl.Size = new System.Drawing.Size(125, 20);
            this.txtSubPbl.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(518, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sub Total";
            // 
            // btnTambahPbl
            // 
            this.btnTambahPbl.Location = new System.Drawing.Point(711, 3);
            this.btnTambahPbl.Name = "btnTambahPbl";
            this.btnTambahPbl.Size = new System.Drawing.Size(62, 23);
            this.btnTambahPbl.TabIndex = 19;
            this.btnTambahPbl.Text = "Tambah";
            this.btnTambahPbl.UseVisualStyleBackColor = true;
            this.btnTambahPbl.Click += new System.EventHandler(this.btnTambahPbl_Click);
            // 
            // lvwPembelian
            // 
            this.lvwPembelian.HideSelection = false;
            this.lvwPembelian.Location = new System.Drawing.Point(3, 39);
            this.lvwPembelian.Name = "lvwPembelian";
            this.lvwPembelian.Size = new System.Drawing.Size(777, 198);
            this.lvwPembelian.TabIndex = 2;
            this.lvwPembelian.UseCompatibleStateImageBehavior = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.4966F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.5034F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel3.Controls.Add(this.btnCariPembelian, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtKdBarang, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 96);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(437, 30);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // btnCariPembelian
            // 
            this.btnCariPembelian.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCariPembelian.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(0)))));
            this.btnCariPembelian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCariPembelian.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCariPembelian.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCariPembelian.Location = new System.Drawing.Point(355, 3);
            this.btnCariPembelian.Name = "btnCariPembelian";
            this.btnCariPembelian.Size = new System.Drawing.Size(78, 24);
            this.btnCariPembelian.TabIndex = 3;
            this.btnCariPembelian.Text = "Cari";
            this.btnCariPembelian.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Kode Barang";
            // 
            // txtKdBarang
            // 
            this.txtKdBarang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKdBarang.Location = new System.Drawing.Point(149, 5);
            this.txtKdBarang.Name = "txtKdBarang";
            this.txtKdBarang.Size = new System.Drawing.Size(200, 20);
            this.txtKdBarang.TabIndex = 18;
            // 
            // btnSelesaiPbl
            // 
            this.btnSelesaiPbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSelesaiPbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(0)))));
            this.btnSelesaiPbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelesaiPbl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelesaiPbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSelesaiPbl.Location = new System.Drawing.Point(700, 447);
            this.btnSelesaiPbl.Name = "btnSelesaiPbl";
            this.btnSelesaiPbl.Size = new System.Drawing.Size(98, 30);
            this.btnSelesaiPbl.TabIndex = 3;
            this.btnSelesaiPbl.Text = "Selesai";
            this.btnSelesaiPbl.UseVisualStyleBackColor = false;
            // 
            // btnBatal
            // 
            this.btnBatal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBatal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(0)))));
            this.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatal.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBatal.Location = new System.Drawing.Point(596, 447);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(98, 30);
            this.btnBatal.TabIndex = 3;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = false;
            // 
            // FormPembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 489);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSelesaiPbl);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "FormPembelian";
            this.Text = "FormPembelian";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker datePesananPbl;
        private System.Windows.Forms.TextBox txtKdPembelian;
        private System.Windows.Forms.TextBox txtKDprodusen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKdPesanan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSelesaiPbl;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtHargaPbl;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtQtyPbl;
        private System.Windows.Forms.TextBox txtSubPbl;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNamaBrg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTambahPbl;
        private System.Windows.Forms.ListView lvwPembelian;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnCariPembelian;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKdBarang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtADMIN;
    }
}