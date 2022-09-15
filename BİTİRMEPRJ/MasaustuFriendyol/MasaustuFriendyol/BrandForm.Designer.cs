namespace MasaustuFriendyol
{
    partial class BrandForm
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
            this.cb_status = new System.Windows.Forms.CheckBox();
            this.btn_brandUpd = new System.Windows.Forms.Button();
            this.btn_brandEkle = new System.Windows.Forms.Button();
            this.tb_brandName = new System.Windows.Forms.TextBox();
            this.tb_brandID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMI_guncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_sil = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_status);
            this.groupBox1.Controls.Add(this.btn_brandUpd);
            this.groupBox1.Controls.Add(this.btn_brandEkle);
            this.groupBox1.Controls.Add(this.tb_brandName);
            this.groupBox1.Controls.Add(this.tb_brandID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1201, 243);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Marka İşlemleri";
            // 
            // cb_status
            // 
            this.cb_status.AutoSize = true;
            this.cb_status.Location = new System.Drawing.Point(99, 129);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(68, 20);
            this.cb_status.TabIndex = 13;
            this.cb_status.Text = "Durum";
            this.cb_status.UseVisualStyleBackColor = true;
            // 
            // btn_brandUpd
            // 
            this.btn_brandUpd.Location = new System.Drawing.Point(352, 109);
            this.btn_brandUpd.Name = "btn_brandUpd";
            this.btn_brandUpd.Size = new System.Drawing.Size(148, 23);
            this.btn_brandUpd.TabIndex = 12;
            this.btn_brandUpd.Text = "Güncelle";
            this.btn_brandUpd.UseVisualStyleBackColor = true;
            this.btn_brandUpd.Click += new System.EventHandler(this.btn_brandUpd_Click);
            // 
            // btn_brandEkle
            // 
            this.btn_brandEkle.Location = new System.Drawing.Point(352, 157);
            this.btn_brandEkle.Name = "btn_brandEkle";
            this.btn_brandEkle.Size = new System.Drawing.Size(148, 23);
            this.btn_brandEkle.TabIndex = 11;
            this.btn_brandEkle.Text = "Ekle";
            this.btn_brandEkle.UseVisualStyleBackColor = true;
            this.btn_brandEkle.Click += new System.EventHandler(this.btn_brandEkle_Click);
            // 
            // tb_brandName
            // 
            this.tb_brandName.Location = new System.Drawing.Point(99, 76);
            this.tb_brandName.Name = "tb_brandName";
            this.tb_brandName.Size = new System.Drawing.Size(212, 22);
            this.tb_brandName.TabIndex = 9;
            // 
            // tb_brandID
            // 
            this.tb_brandID.Enabled = false;
            this.tb_brandID.Location = new System.Drawing.Point(99, 29);
            this.tb_brandID.Name = "tb_brandID";
            this.tb_brandID.Size = new System.Drawing.Size(212, 22);
            this.tb_brandID.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "İsim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 263);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1201, 287);
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
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 80);
            // 
            // TSMI_guncelle
            // 
            this.TSMI_guncelle.Name = "TSMI_guncelle";
            this.TSMI_guncelle.Size = new System.Drawing.Size(210, 24);
            this.TSMI_guncelle.Text = "Güncelle";
            this.TSMI_guncelle.Click += new System.EventHandler(this.TSMI_guncelle_Click);
            // 
            // TSMI_sil
            // 
            this.TSMI_sil.Name = "TSMI_sil";
            this.TSMI_sil.Size = new System.Drawing.Size(210, 24);
            this.TSMI_sil.Text = "Sil";
            this.TSMI_sil.Click += new System.EventHandler(this.TSMI_sil_Click);
            // 
            // BrandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 562);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "BrandForm";
            this.Text = "BrandForm";
            this.Load += new System.EventHandler(this.BrandForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cb_status;
        private System.Windows.Forms.Button btn_brandUpd;
        private System.Windows.Forms.Button btn_brandEkle;
        private System.Windows.Forms.TextBox tb_brandName;
        private System.Windows.Forms.TextBox tb_brandID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_guncelle;
        private System.Windows.Forms.ToolStripMenuItem TSMI_sil;
    }
}