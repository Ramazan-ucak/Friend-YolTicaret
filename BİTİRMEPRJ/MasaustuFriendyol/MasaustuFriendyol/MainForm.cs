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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }










        public void OpenForm(Form frm)
        {
            Form[] OpenForms = this.MdiChildren;
            bool isopen = false;
            foreach (Form item in OpenForms)
            {
                if (frm.GetType() == item.GetType())
                {
                    isopen = true;
                    item.Activate();
                }
            }
            if (isopen == false)
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void Tsmi_CategoryFormOpen_Click(object sender, EventArgs e)
        {
            OpenForm(new CategoryForm());
        }

        private void Tsmi_BrandFormOpen_Click(object sender, EventArgs e)
        {
            OpenForm(new BrandForm());
        }

        private void Tsmi_ProductFormOpen_Click(object sender, EventArgs e)
        {
            OpenForm(new ProductForm());
        }
    }

}
