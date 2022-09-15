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


namespace MasaustuFriendyol
{
    public partial class CategoryForm : Form
    {
        MasaustuFriendyolDBEntities db = new MasaustuFriendyolDBEntities();
        int secilen;
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void GridDoldur()
        {
            dataGridView1.DataSource = (from c in db.Categories
                                        select new
                                        {
                                            KategoriID = c.ID,
                                            KategoriAdı = c.Name,
                                            Açıklama = c.Description,
                                            Durum = c.Status == true ? "Aktif " : "Aktif Değil"

                                        }).ToList();
        }

        private void btn_catEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_categoryName.Text))
            {

                Categories c = new Categories()
                {
                    Name = tb_categoryName.Text,
                    Description = tb_categoryDesc.Text,
                    Status = cb_status.Checked
                };
                try
                {
                    db.Categories.Add(c);
                    db.SaveChanges();
                    MessageBox.Show("Kategori " + c.ID + " id ile başarıyla eklenmiştir", "Eklendi");
                }
                catch
                {
                    MessageBox.Show("Ürün eklenirken bir hata oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                GridDoldur();
            }
            else
            {
                MessageBox.Show("Kategori adı boş bırakılamaz","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }


            //Categories c = new Categories()
            //{
            //    Name = tb_categoryName.Text,
            //    Description = tb_categoryDesc.Text,
            //    Status = cb_status.Checked
            //};
            //try
            //{
            //    db.Categories.Add(c);
            //    db.SaveChanges();
            //    MessageBox.Show("Kategori " + c.ID + " id ile başarıyla eklenmiştir", "Eklendi");
            //}
            //catch
            //{
            //    MessageBox.Show("Ürün eklenirken bir hata oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //GridDoldur();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            GridDoldur();

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
            Categories c = db.Categories.Find(secilen);
            tb_ID.Text = c.ID.ToString();
            tb_categoryName.Text = c.Name;
            tb_categoryDesc.Text = c.Description;
            cb_status.Checked = !c.Status;
            btn_catEkle.Enabled = false;
            btn_catUpd.Enabled = true;
        }

        private void btn_catUpd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_categoryName.Text))
            {
                Categories c = db.Categories.Find(secilen);
                c.Name = tb_categoryName.Text;
                c.Description = tb_categoryDesc.Text;
                c.Status = cb_status.Checked;
                try
                {
                    db.SaveChanges();
                    btn_catEkle.Enabled = true;
                    btn_catUpd.Enabled = false;

                }
                catch
                {
                    MessageBox.Show("Ürün güncellenirken bir hat oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                GridDoldur();
            }
            else
            {
                MessageBox.Show("Güncellenmek için bir kategori adı giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TSMI_sil_Click(object sender, EventArgs e)
        {
            try
            {
                Categories c = db.Categories.Find(secilen);
                db.Categories.Remove(c);
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Hata oluştu", "Hata");
            }
            GridDoldur();
        }

      
        
      
    }
}
