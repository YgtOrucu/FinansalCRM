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
    public partial class FrmBankaHaraketleri : Form
    {
        FinancialCrmEntities crmEntities = new FinancialCrmEntities();
        private string user;

        private void Temizle(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is TextBox)
                    ctrl.Text = string.Empty;

                // İçinde başka kontroller varsa onları da gez
                if (ctrl.HasChildren)
                    Temizle(ctrl);
            }
        }
        public void Listele()
        {
            var GetList = crmEntities.BankProsesses.OrderByDescending(x => x.ProsessDate).Select(y => new
            {
                y.Description,
                y.Amoun,
                y.ProsessType,
                y.ProsessDate,
                y.Banks.BankTitle
            }).ToList();
            dataGridView1.DataSource = GetList;
        }

        public FrmBankaHaraketleri()
        {
            InitializeComponent();
        }

        public FrmBankaHaraketleri(string user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void FrmBankaHaraketleri_Load(object sender, EventArgs e)
        {
            #region KullanıcıBilgisiniAl
            lblUser.Text = user;
            #endregion

            #region timer Start
            timer1.Start();
            #endregion

            #region Banka Bilgisini Al
            var GetBankaBilgileri = crmEntities.Banks.Select(x => new { x.BankID, x.BankTitle }).ToList();
            cmbBankaBilgisi.DataSource = GetBankaBilgileri;
            cmbBankaBilgisi.DisplayMember = "BankTitle";
            cmbBankaBilgisi.ValueMember = "BankID";

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

        private void btnHarcamalar_Click(object sender, EventArgs e)
        {
            FrmHarcamalar frmHarcamalar = new FrmHarcamalar(user);
            frmHarcamalar.Show();
            this.Hide();
        }

        private void btnCıkısYap_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBankayaGöre_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cmbBankaBilgisi.SelectedValue);
            var values = crmEntities.BankProsesses.Where(x => x.BankID == id).OrderByDescending(m => m.ProsessDate).Select(y => new
            {
                y.Description,
                y.Amoun,
                y.ProsessType,
                y.ProsessDate,
                y.Banks.BankTitle
            }).ToList();
            dataGridView1.DataSource = values;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            BankProsesses bankProsesses = new BankProsesses
            {
                Description = txtIslemTitle.Text,
                ProsessDate = dtDate.Value,
                ProsessType = cmbİslemTürü.Text,
                Amoun = decimal.Parse(txtIslemTutar.Text),
                BankID = Convert.ToInt32(cmbBankaBilgisi.SelectedValue)
            };
            crmEntities.BankProsesses.Add(bankProsesses);
            crmEntities.SaveChanges();
            MessageBox.Show("Ekleme İşlemi Başarılı", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Temizle(this);
            Listele();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIslemID.Text);
            var getUpdateValue = crmEntities.BankProsesses.Find(id);
            getUpdateValue.Description = txtIslemTitle.Text;
            getUpdateValue.ProsessDate = dtDate.Value;
            getUpdateValue.ProsessType = cmbİslemTürü.Text;
            getUpdateValue.Amoun = decimal.Parse(txtIslemTutar.Text);
            getUpdateValue.BankID = Convert.ToInt32(cmbBankaBilgisi.SelectedValue);

            crmEntities.SaveChanges();
            MessageBox.Show("Güncelleme İşlemi Başarılı", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Temizle(this);
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIslemID.Text);
            var getDeleteValue = crmEntities.BankProsesses.Find(id);
            crmEntities.BankProsesses.Remove(getDeleteValue);
            MessageBox.Show("Silme İşlemi Başarılı", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Temizle(this);
            Listele();
        }

        private void btnTariheGöre_Click(object sender, EventArgs e)
        {
            string value = cmbTariheGöre.Text;
            switch (value)
            {
                case "Son 5 Gün":
                    var Last5DayValue = DateTime.Now.AddDays(-5);
                    var Last5Day = crmEntities.BankProsesses.Where(x => x.ProsessDate >= Last5DayValue).Select(y => new
                    {
                        y.Description,
                        y.Amoun,
                        y.ProsessType,
                        y.ProsessDate,
                        y.Banks.BankTitle
                    }).ToList();
                    dataGridView1.DataSource = Last5Day;
                    break;
                case "Son 1 Ay":
                    var LastOneMountValue = DateTime.Now.AddMonths(-1);
                    var LastOneMount = crmEntities.BankProsesses.Where(x => x.ProsessDate >= LastOneMountValue).Select(y => new
                    {
                        y.Description,
                        y.Amoun,
                        y.ProsessType,
                        y.ProsessDate,
                        y.Banks.BankTitle
                    }).ToList();
                    dataGridView1.DataSource = LastOneMount;
                    break;
                case "Son 2 Ay":
                    var LastTwoMountValue = DateTime.Now.AddMonths(-2);
                    var LastTwoMount = crmEntities.BankProsesses.Where(x => x.ProsessDate >= LastTwoMountValue).Select(y => new
                    {
                        y.Description,
                        y.Amoun,
                        y.ProsessType,
                        y.ProsessDate,
                        y.Banks.BankTitle
                    }).ToList();
                    dataGridView1.DataSource = LastTwoMount;
                    break;
                case "Son 3 Yıl":
                    var LastThreeYearValue = DateTime.Now.AddYears(-3);
                    var LastThreeYear = crmEntities.BankProsesses.Where(x => x.ProsessDate >= LastThreeYearValue).Select(y => new
                    {
                        y.Description,
                        y.Amoun,
                        y.ProsessType,
                        y.ProsessDate,
                        y.Banks.BankTitle
                    }).ToList();
                    dataGridView1.DataSource = LastThreeYear;
                    break;
                case "Son 5 Yıl":
                    var LastFiveYearValue = DateTime.Now.AddYears(-5);
                    var LastFiveYear = crmEntities.BankProsesses.Where(x => x.ProsessDate >= LastFiveYearValue).Select(y => new
                    {
                        y.Description,
                        y.Amoun,
                        y.ProsessType,
                        y.ProsessDate,
                        y.Banks.BankTitle
                    }).ToList();
                    dataGridView1.DataSource = LastFiveYear;
                    break;
                case "Tüm Kayıtlar":
                    Listele();
                    break;
                default:
                    MessageBox.Show("Hatalı Filtreleme Yaptınız", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void btnİslemTürüneGöre_Click(object sender, EventArgs e)
        {
            string ıslemTürü = cmbİslemTürü.Text;

            var values = crmEntities.BankProsesses.Where(x => x.ProsessType == ıslemTürü).OrderByDescending(z=>z.ProsessDate).Select(y => new
            {
                y.Description,
                y.Amoun,
                y.ProsessType,
                y.ProsessDate,
                y.Banks.BankTitle
            }).ToList();
            dataGridView1.DataSource = values;
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
