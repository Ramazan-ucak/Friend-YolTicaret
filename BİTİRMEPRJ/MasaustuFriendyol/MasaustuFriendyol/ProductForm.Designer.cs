namespace MasaustuFriendyol
{
    partial class ProductForm
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_xml = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.tb_tarih = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_productEkle = new System.Windows.Forms.Button();
            this.btn_productUpd = new System.Windows.Forms.Button();
            this.cb_durum = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_markaSec = new System.Windows.Forms.ComboBox();
            this.cb_categorySec = new System.Windows.Forms.ComboBox();
            this.tb_productDes = new System.Windows.Forms.TextBox();
            this.tb_productName = new System.Windows.Forms.TextBox();
            this.tb_Image = new System.Windows.Forms.TextBox();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.tb_stock = new System.Windows.Forms.TextBox();
            this.tb_productID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMI_guncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_sil = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btn_xml);
            this.groupBox1.Controls.Add(this.btn_temizle);
            this.groupBox1.Controls.Add(this.tb_tarih);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btn_productEkle);
            this.groupBox1.Controls.Add(this.btn_productUpd);
            this.groupBox1.Controls.Add(this.cb_durum);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cb_markaSec);
            this.groupBox1.Controls.Add(this.cb_categorySec);
            this.groupBox1.Controls.Add(this.tb_productDes);
            this.groupBox1.Controls.Add(this.tb_productName);
            this.groupBox1.Controls.Add(this.tb_Image);
            this.groupBox1.Controls.Add(this.tb_price);
            this.groupBox1.Controls.Add(this.tb_stock);
            this.groupBox1.Controls.Add(this.tb_productID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1178, 277);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Bilgileri";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(949, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(710, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_xml
            // 
            this.btn_xml.Location = new System.Drawing.Point(974, 48);
            this.btn_xml.Name = "btn_xml";
            this.btn_xml.Size = new System.Drawing.Size(75, 23);
            this.btn_xml.TabIndex = 10;
            this.btn_xml.Text = "Xml";
            this.btn_xml.UseVisualStyleBackColor = true;
            this.btn_xml.Click += new System.EventHandler(this.btn_xml_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(772, 180);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(110, 23);
            this.btn_temizle.TabIndex = 9;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // tb_tarih
            // 
            this.tb_tarih.Location = new System.Drawing.Point(499, 183);
            this.tb_tarih.Name = "tb_tarih";
            this.tb_tarih.Size = new System.Drawing.Size(205, 22);
            this.tb_tarih.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(426, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 16);
            this.label10.TabIndex = 7;
            this.label10.Text = "Oluşturma";
            // 
            // btn_productEkle
            // 
            this.btn_productEkle.Location = new System.Drawing.Point(772, 86);
            this.btn_productEkle.Name = "btn_productEkle";
            this.btn_productEkle.Size = new System.Drawing.Size(110, 23);
            this.btn_productEkle.TabIndex = 6;
            this.btn_productEkle.Text = "Ekle";
            this.btn_productEkle.UseVisualStyleBackColor = true;
            this.btn_productEkle.Click += new System.EventHandler(this.btn_productEkle_Click);
            // 
            // btn_productUpd
            // 
            this.btn_productUpd.Location = new System.Drawing.Point(772, 48);
            this.btn_productUpd.Name = "btn_productUpd";
            this.btn_productUpd.Size = new System.Drawing.Size(110, 23);
            this.btn_productUpd.TabIndex = 5;
            this.btn_productUpd.Text = "Güncelle";
            this.btn_productUpd.UseVisualStyleBackColor = true;
            this.btn_productUpd.Click += new System.EventHandler(this.btn_productUpd_Click);
            // 
            // cb_durum
            // 
            this.cb_durum.AutoSize = true;
            this.cb_durum.Location = new System.Drawing.Point(522, 226);
            this.cb_durum.Name = "cb_durum";
            this.cb_durum.Size = new System.Drawing.Size(70, 20);
            this.cb_durum.TabIndex = 4;
            this.cb_durum.Text = "Satışta";
            this.cb_durum.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(428, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "Satış Durum";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(428, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Image";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(428, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Fiyat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(428, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Stok";
            // 
            // cb_markaSec
            // 
            this.cb_markaSec.FormattingEnabled = true;
            this.cb_markaSec.Location = new System.Drawing.Point(124, 224);
            this.cb_markaSec.Name = "cb_markaSec";
            this.cb_markaSec.Size = new System.Drawing.Size(205, 24);
            this.cb_markaSec.TabIndex = 2;
            // 
            // cb_categorySec
            // 
            this.cb_categorySec.FormattingEnabled = true;
            this.cb_categorySec.Location = new System.Drawing.Point(124, 175);
            this.cb_categorySec.Name = "cb_categorySec";
            this.cb_categorySec.Size = new System.Drawing.Size(205, 24);
            this.cb_categorySec.TabIndex = 2;
            // 
            // tb_productDes
            // 
            this.tb_productDes.Location = new System.Drawing.Point(124, 133);
            this.tb_productDes.Name = "tb_productDes";
            this.tb_productDes.Size = new System.Drawing.Size(205, 22);
            this.tb_productDes.TabIndex = 1;
            // 
            // tb_productName
            // 
            this.tb_productName.Location = new System.Drawing.Point(124, 94);
            this.tb_productName.Name = "tb_productName";
            this.tb_productName.Size = new System.Drawing.Size(205, 22);
            this.tb_productName.TabIndex = 1;
            // 
            // tb_Image
            // 
            this.tb_Image.Location = new System.Drawing.Point(499, 133);
            this.tb_Image.Name = "tb_Image";
            this.tb_Image.Size = new System.Drawing.Size(205, 22);
            this.tb_Image.TabIndex = 1;
            // 
            // tb_price
            // 
            this.tb_price.Location = new System.Drawing.Point(499, 91);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(205, 22);
            this.tb_price.TabIndex = 1;
            // 
            // tb_stock
            // 
            this.tb_stock.Location = new System.Drawing.Point(499, 50);
            this.tb_stock.Name = "tb_stock";
            this.tb_stock.Size = new System.Drawing.Size(205, 22);
            this.tb_stock.TabIndex = 1;
            // 
            // tb_productID
            // 
            this.tb_productID.Enabled = false;
            this.tb_productID.Location = new System.Drawing.Point(124, 45);
            this.tb_productID.Name = "tb_productID";
            this.tb_productID.Size = new System.Drawing.Size(205, 22);
            this.tb_productID.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Marka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kategori";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Açıklama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ürün Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 312);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1189, 248);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_guncelle,
            this.TSMI_sil});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(136, 52);
            // 
            // TSMI_guncelle
            // 
            this.TSMI_guncelle.Name = "TSMI_guncelle";
            this.TSMI_guncelle.Size = new System.Drawing.Size(135, 24);
            this.TSMI_guncelle.Text = "Güncelle";
            this.TSMI_guncelle.Click += new System.EventHandler(this.TSMI_guncelle_Click);
            // 
            // TSMI_sil
            // 
            this.TSMI_sil.Name = "TSMI_sil";
            this.TSMI_sil.Size = new System.Drawing.Size(135, 24);
            this.TSMI_sil.Text = "Sil";
            this.TSMI_sil.Click += new System.EventHandler(this.TSMI_sil_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 572);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_markaSec;
        private System.Windows.Forms.ComboBox cb_categorySec;
        private System.Windows.Forms.TextBox tb_productDes;
        private System.Windows.Forms.TextBox tb_productName;
        private System.Windows.Forms.TextBox tb_Image;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.TextBox tb_stock;
        private System.Windows.Forms.TextBox tb_productID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cb_durum;
        private System.Windows.Forms.Button btn_productEkle;
        private System.Windows.Forms.Button btn_productUpd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_guncelle;
        private System.Windows.Forms.ToolStripMenuItem TSMI_sil;
        private System.Windows.Forms.TextBox tb_tarih;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_xml;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}