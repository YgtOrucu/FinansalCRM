using FinansalCRM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinansalCRM
{
    public partial class FrmHarcamalar : Form
    {
        private string user;
        FinancialCrmEntities crmEntities = new FinancialCrmEntities();
        public FrmHarcamalar()
        {
            InitializeComponent();
        }

        public FrmHarcamalar(string user)
        {
            InitializeComponent();
            this.user = user;
        }
        private void Temizle(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is TextBox)
                    ctrl.Text = string.Empty;

                if (ctrl.HasChildren)
                    Temizle(ctrl);
            }
        }

        void Listele()
        {
            var getvalues = crmEntities.Spendings.OrderByDescending(y=>y.SpendingDate).Select(x => new
            {
                x.SpendingID,
                x.SpendingTitle,
                x.SpendingAmount,
                x.SpendingDate,
                x.Categories.CategoryName
            }).ToList();
            dataGridView1.DataSource = getvalues;
        }

        private void Harcamalar_Load(object sender, EventArgs e)
        {
            #region KullanıcıBilgisiniAl
            lblUser.Text = user;
            #endregion

            #region timer Start
            timer1.Start();
            #endregion

            #region Kategorileri Getir
            var getCategory = crmEntities.Categories.Select(x => new
            {
                x.CategoryID,
                x.CategoryName
            }).ToList();
            cmbCategory.DataSource = getCategory;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryID";

            #endregion
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            lblDateTime.Text = dateTime.ToString("F");
        }

        private void btnBankalar_Click(object sender, EventArgs e)
        {
            FrmBanka frmBanka = new FrmBanka(user);
            frmBanka.Show();
            this.Hide();
        }

        private void btnKategoriler_Click(object sender, EventArgs e)
        {
            FrmKategoriler frmKategoriler = new FrmKategoriler(user);
            frmKategoriler.Show();
            this.Hide();
        }

        private void btnCıkısYap_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGetCategory_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cmbCategory.SelectedValue);

            var getvalues = crmEntities.Spendings.Where(x => x.CategoryID == id).OrderByDescending(y => y.SpendingDate).Select(z => new
            {
                z.SpendingTitle,
                z.SpendingAmount,
                z.SpendingDate,
                z.Categories.CategoryName
            }).ToList();
            dataGridView1.DataSource = getvalues;
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();  
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Spendings spendings = new Spendings
            {
                SpendingTitle = txtTitle.Text,
                SpendingAmount = decimal.Parse(txtTutar.Text),
                SpendingDate = dtDate.Value,
                CategoryID = Convert.ToInt32(cmbCategory.SelectedValue)
            };
            crmEntities.Spendings.Add(spendings);
            crmEntities.SaveChanges();
            MessageBox.Show("Ekleme İşlemi Başarılı", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Temizle(this);
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var getDeletedValue = crmEntities.Spendings.Find(id);
            crmEntities.Spendings.Remove(getDeletedValue);
            crmEntities.SaveChanges();
            MessageBox.Show("Silme İşlemi Başarılı", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Temizle(this);
            Listele();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var getDeletedValue = crmEntities.Spendings.Find(id);

            getDeletedValue.SpendingTitle = txtTitle.Text;
            getDeletedValue.SpendingAmount = decimal.Parse(txtTutar.Text);
            getDeletedValue.SpendingDate = dtDate.Value;
            getDeletedValue.CategoryID = Convert.ToInt32(cmbCategory.SelectedValue);

            crmEntities.SaveChanges();
            MessageBox.Show("Güncelleme İşlemi Başarılı", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Temizle(this);
            Listele();
        }

        private void btnBankaHaraketleri_Click(object sender, EventArgs e)
        {
            FrmBankaHaraketleri frmBankaHaraketleri = new FrmBankaHaraketleri(user);
            frmBankaHaraketleri.Show();
            this.Hide();
        }

        private void btnGelirGider_Click(object sender, EventArgs e)
        {
            FrmGelirGider frmGelirGider = new FrmGelirGider(user);
            frmGelirGider.Show();
            this.Hide();
        }

        private void btnİstatistik_Click(object sender, EventArgs e)
        {
            Frmİstatistik frmİstatistik = new Frmİstatistik(user);
            frmİstatistik.Show();
            this.Hide();
        }
    }
}
