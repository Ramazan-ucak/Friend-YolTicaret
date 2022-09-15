namespace MasaustuFriendyol
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_CategoryFormOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_BrandFormOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_ProductFormOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.işlemlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1190, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kapatToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.kapatToolStripMenuItem.Text = "Kapat";
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsmi_CategoryFormOpen,
            this.Tsmi_BrandFormOpen,
            this.Tsmi_ProductFormOpen});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.işlemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // Tsmi_CategoryFormOpen
            // 
            this.Tsmi_CategoryFormOpen.Name = "Tsmi_CategoryFormOpen";
            this.Tsmi_CategoryFormOpen.Size = new System.Drawing.Size(224, 26);
            this.Tsmi_CategoryFormOpen.Text = "Kategori İşlemleri";
            this.Tsmi_CategoryFormOpen.Click += new System.EventHandler(this.Tsmi_CategoryFormOpen_Click);
            // 
            // Tsmi_BrandFormOpen
            // 
            this.Tsmi_BrandFormOpen.Name = "Tsmi_BrandFormOpen";
            this.Tsmi_BrandFormOpen.Size = new System.Drawing.Size(224, 26);
            this.Tsmi_BrandFormOpen.Text = "Markaİşlemleri";
            this.Tsmi_BrandFormOpen.Click += new System.EventHandler(this.Tsmi_BrandFormOpen_Click);
            // 
            // Tsmi_ProductFormOpen
            // 
            this.Tsmi_ProductFormOpen.Name = "Tsmi_ProductFormOpen";
            this.Tsmi_ProductFormOpen.Size = new System.Drawing.Size(224, 26);
            this.Tsmi_ProductFormOpen.Text = "Ürün İşlemleri";
            this.Tsmi_ProductFormOpen.Click += new System.EventHandler(this.Tsmi_ProductFormOpen_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 481);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Frientyol Ana Bayii";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_CategoryFormOpen;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_BrandFormOpen;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_ProductFormOpen;
    }
}