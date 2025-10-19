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
    public partial class FrmKategoriler : Form
    {
        FinancialCrmEntities crmEntities = new FinancialCrmEntities();
        private string _username;
        public FrmKategoriler(string username)
        {
            InitializeComponent();
            _username = username;
        }

        public FrmKategoriler()
        {
            InitializeComponent();
        }

        void GetList()
        {
            var values = crmEntities.Categories.Select(x => new
            {
                x.CategoryID,
                x.CategoryName
            }).ToList();
            dataGridView1.DataSource = values;
        }

        private void FrmKategoriler_Load(object sender, EventArgs e)
        {
            #region KullanıcıBilgisiniAl
            lblUser.Text = _username;
            #endregion

            #region timer Start
            timer1.Start();
            #endregion
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            lblDateTime.Text = dateTime.ToString("F");
        }

        private void btnBankalar_Click(object sender, EventArgs e)
        {
            FrmBanka frmBanka = new FrmBanka(_username);
            frmBanka.Show();
            this.Hide();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            GetList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Categories categories = new Categories
            {
                CategoryName = txtKategoriName.Text
            };
            crmEntities.Categories.Add(categories);
            crmEntities.SaveChanges();
            MessageBox.Show("Ekleme İşlemi Başarılı", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtId.Text = "";
            txtKategoriName.Text = "";
            GetList();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int ıd = int.Parse(txtId.Text);
            var getDeleteCategory = crmEntities.Categories.Find(ıd);

            crmEntities.Categories.Remove(getDeleteCategory);
            crmEntities.SaveChanges();
            MessageBox.Show("Silme İşlemi Başarılı", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtId.Text = "";
            txtKategoriName.Text = "";
            GetList();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            int ıd = int.Parse(txtId.Text);
            var getDeleteCategory = crmEntities.Categories.Find(ıd);

            getDeleteCategory.CategoryName = txtKategoriName.Text;
            crmEntities.SaveChanges();
            MessageBox.Show("Güncelleme İşlemi Başarılı", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtId.Text = "";
            txtKategoriName.Text = "";
            GetList();
        }

        private void btnHarcamalar_Click(object sender, EventArgs e)
        {
            FrmHarcamalar frmHarcamalar = new FrmHarcamalar(_username);
            frmHarcamalar.Show();
            this.Hide();
        }

        private void btnCıkısYap_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBankaHaraketleri_Click(object sender, EventArgs e)
        {
            FrmBankaHaraketleri frmBankaHaraketleri = new FrmBankaHaraketleri(_username);
            frmBankaHaraketleri.Show();
            this.Hide();
        }

        private void btnGelirGider_Click(object sender, EventArgs e)
        {
            FrmGelirGider frmGelirGider = new FrmGelirGider(_username);
            frmGelirGider.Show();
            this.Hide();
        }

        private void btnİstatistik_Click(object sender, EventArgs e)
        {
            Frmİstatistik frmİstatistik = new Frmİstatistik(_username);
            frmİstatistik.Show();
            this.Hide();
        }
    }
}
