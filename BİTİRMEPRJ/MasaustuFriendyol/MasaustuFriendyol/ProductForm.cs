using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace MasaustuFriendyol
{
    public partial class ProductForm : Form
    {
        MasaustuFriendyolDBEntities db = new MasaustuFriendyolDBEntities();
        int secilen;
        public ProductForm()
        {
            InitializeComponent();
        }
        private void ProductForm_Load(object sender, EventArgs e)
        {
            cb_categorySec.DisplayMember = "Name";
            cb_categorySec.ValueMember = "ID";
            cb_categorySec.DataSource = db.Categories.ToList();

            cb_markaSec.DisplayMember = "Name";
            cb_markaSec.ValueMember= "ID";
            cb_markaSec.DataSource = db.Brands.ToList();
            GridDoldur();

         
        }
        private void GridDoldur()
        {
            dataGridView1.DataSource = (from p in db.Products
                                        select new
                                        {
                                            UrunNo = p.ID,
                                            UrunAdı = p.Name,
                                            Aciklama = p.Description,
                                            Kategori = p.Categories.Name,
                                            Marka = p.Brands.Name,
                                            Stok = p.Stock,
                                            Fiyat = p.Price,
                                            Resim = p.ConverImage,
                                            Tarih = p.CreationDay,
                                            Satis = p.SellStatus == true ? "Satışta Değil" : "Satışta"
                                        }).ToList();
        }
   

        private void btn_productEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_productName.Text) && !string.IsNullOrEmpty(cb_categorySec.Text) && !string.IsNullOrEmpty(cb_markaSec.Text) && !string.IsNullOrEmpty(tb_stock.Text) && !string.IsNullOrEmpty(tb_price.Text))
            {

                Products p = new Products()
                {
                    Name = tb_productName.Text,
                    Category_ID = Convert.ToInt32(cb_categorySec.SelectedValue),
                    Brand_ID = Convert.ToInt32(cb_markaSec.SelectedValue),
                    Description = tb_productDes.Text,
                    Stock = Convert.ToDecimal(tb_stock.Text),
                    Price = Convert.ToDecimal(tb_price.Text),
                    SellStatus = !cb_durum.Checked,
                    CreationDay = DateTime.Now,
                    ConverImage = tb_Image.Text
                };
                try
                {
                    db.Products.Add(p);
                    db.SaveChanges();
                    MessageBox.Show("Ürün " + p.ID + " ile başarıyla eklendi", "Eklendi");
                }
                catch
                {
                    MessageBox.Show("Ürün eklenirken bir hata meydana geldi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                GridDoldur();
            }
            else
            {
                MessageBox.Show("Gerekli alanları doldurunuz","Hata",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = dataGridView1.HitTest(e.X, e.Y);
                dataGridView1.ClearSelection();
                if (hit.RowIndex != -1)
                {
                    dataGridView1.Rows[hit.RowIndex].Selected = true;
                    contextMenuStrip1.Show(dataGridView1, new Point(e.X, e.Y));
                    secilen = Convert.ToInt32(dataGridView1.Rows[hit.RowIndex].Cells[0].Value);
                }
            }
        }

        private void TSMI_guncelle_Click(object sender, EventArgs e)
        {
            Products p = db.Products.Find(secilen);
            tb_productID.Text = p.ID.ToString();
            tb_productName.Text = p.Name;
            tb_productDes.Text = p.Description;
            cb_categorySec.SelectedValue = p.Category_ID;
            cb_markaSec.SelectedValue = p.Brand_ID;
            tb_stock.Text = p.Stock.ToString();
            tb_price.Text = p.Price.ToString();
            tb_Image.Text = p.ProductImage.ToString();
            cb_durum.Checked = !p.SellStatus;
            btn_productEkle.Enabled = false;
            btn_productUpd.Enabled = true;
        }

        private void TSMI_sil_Click(object sender, EventArgs e)
        {
            try
            {
                Products p = db.Products.Find(secilen);
                db.Products.Remove(p);
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Hata var", "Hata");
            }
            GridDoldur();
        }

        private void btn_productUpd_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(tb_productName.Text) && !string.IsNullOrEmpty(cb_categorySec.Text) && !string.IsNullOrEmpty(cb_markaSec.Text) && !string.IsNullOrEmpty(tb_stock.Text) && !string.IsNullOrEmpty(tb_price.Text))
            {
                Products p = db.Products.Find(secilen);
                p.Name = tb_productName.Text;
                p.Description = tb_productDes.Text;
                p.Category_ID = Convert.ToInt32(cb_categorySec.SelectedValue);
                p.Brand_ID = Convert.ToInt32(cb_markaSec.SelectedValue);
                p.Description = tb_productDes.Text;
                p.Stock = Convert.ToDecimal(tb_stock.Text);
                p.Price = Convert.ToDecimal(tb_price.Text);
                p.CreationDay = DateTime.Now;
                p.SellStatus = !cb_durum.Checked;
                try
                {
                    db.SaveChanges();
                    btn_productEkle.Enabled = true;
                    btn_productUpd.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Ürün güncellenirken bir hata oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                GridDoldur();
            }
            else
            {
                MessageBox.Show("Güncelleme için gerekli alanları doldurunuz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            Products p = new Products();
            tb_productID.Text = "";
            tb_productName.Text = "";
            tb_productDes.Text = "";
            cb_categorySec.SelectedValue = "";
            cb_markaSec.SelectedValue = "";
            tb_stock.Text = "";
            tb_price.Text = "";
            cb_durum.Checked = !p.SellStatus;   
        }

        private void btn_xml_Click(object sender, EventArgs e)
        {
            Products p = new Products();

            XDocument xDoc = XDocument.Load("C:/Urunlerim/XmlUrun.xml");
            XElement rootElement = xDoc.Root;
            XElement yeniElement = new XElement("urun",Guid.NewGuid());
            XAttribute idAttribute = new XAttribute("id",tb_productID.Text);
            XElement isimElement = new XElement("name", tb_productName.Text);
            XElement descElement = new XElement("description", tb_productDes.Text);
            XElement stockElement = new XElement("stock",tb_stock.Text);
            XElement priceElement = new XElement("price", tb_price.Text);
            XElement imageElement = new XElement("image", tb_Image.Text);
            XElement creationElement = new XElement("creationDay", DateTime.Now);
            XElement sellElement = new XElement("sellStatus", cb_durum.Checked);
            XElement categoryElement = new XElement("category", cb_categorySec.SelectedValue);
            XElement brandElement = new XElement("brand", cb_markaSec.SelectedValue);

            yeniElement.Add(idAttribute, isimElement, descElement, stockElement, priceElement, categoryElement, creationElement, brandElement, sellElement, imageElement);
            rootElement.Add(yeniElement);
            rootElement.Save("C:/Urunlerim/XmlUrun.xml");
            MessageBox.Show("Dönüştürme başarılı","Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            tb_Image.Text = openFileDialog1.FileName;
        }

       
    }
}
