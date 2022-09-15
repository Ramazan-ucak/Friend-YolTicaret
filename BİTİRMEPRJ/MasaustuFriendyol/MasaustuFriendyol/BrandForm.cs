using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasaustuFriendyol
{
    public partial class BrandForm : Form
    {
        MasaustuFriendyolDBEntities db = new MasaustuFriendyolDBEntities();
        int secilen;
        public BrandForm()
        {
            InitializeComponent();
        }
        private void GridDoldur()
        {
            dataGridView1.DataSource = (from b in db.Brands
                                        select new
                                        {
                                            MarkaID = b.ID.ToString(),
                                            MarkaAdı = b.Name,
                                            Durum = b.Status == true ? "Aktif" : "Aktif değil"
                                        }).ToList();
        }
        private void BrandForm_Load(object sender, EventArgs e)
        {
            GridDoldur();
        }

        private void btn_brandEkle_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(tb_brandName.Text))
            {
                Brands b = new Brands()
                {
                    Name = tb_brandName.Text,
                    Status = cb_status.Checked
                };
                try
                {
                    db.Brands.Add(b);
                    db.SaveChanges();
                    MessageBox.Show("Marka başarıyla eklenmiştir", "Eklendi");
                }
                catch
                {
                    MessageBox.Show("Marka eklenirken bir hata meydana geldi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                GridDoldur();
            }
            else
            {
                MessageBox.Show("Marka ismini giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Brands b = db.Brands.Find(secilen);
            tb_brandID.Text = b.ID.ToString();
            tb_brandName.Text = b.Name;
            cb_status.Checked = !b.Status;
            btn_brandEkle.Enabled = false;
            btn_brandUpd.Enabled = true;
        }

        private void btn_brandUpd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_brandName.Text))
            {
                Brands b = db.Brands.Find(secilen);
                b.Name = tb_brandName.Text;
                b.Status = cb_status.Checked;
                try
                {
                    db.SaveChanges();
                    btn_brandEkle.Enabled = true;
                    btn_brandUpd.Enabled = false;

                }
                catch
                {
                    MessageBox.Show("Ürün güncellenirken bir hat oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                GridDoldur();
            }
            else
            {
                MessageBox.Show("Güncellemek için Marka ismini doldurunuz","Hata",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void TSMI_sil_Click(object sender, EventArgs e)
        {
            try
            {
                Brands b = db.Brands.Find(secilen);
                db.Brands.Remove(b);
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
