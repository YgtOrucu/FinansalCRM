using FinansalCRM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace FinansalCRM
{
    public partial class Frmİstatistik : Form
    {
        FinancialCrmEntities crmEntities = new FinancialCrmEntities();
        private string user;
        public Frmİstatistik(string user)
        {
            InitializeComponent();
            this.user = user;
        }

        public Frmİstatistik()
        {
            InitializeComponent();
        }

        private void Frmİstatistik_Load(object sender, EventArgs e)
        {
            #region KullanıcıBilgisiniAl
            lblUser.Text = user;
            #endregion

            #region timer Start
            timer1.Start();
            #endregion

            #region Ziraat Bankası Bakiye
            var ZiraatBankasıBakiye = crmEntities.Banks.Where(x => x.BankTitle == "Ziraat Bankası").Sum(y => y.BankBalance);
            lblZiraatBakasıBalance.Text = Convert.ToDecimal(ZiraatBankasıBakiye).ToString("N2") + " TL";
            #endregion

            #region VakıfBank Bakiye
            var VakıfBankBakiye = crmEntities.Banks.Where(x => x.BankTitle == "VakıfBank").Sum(y => y.BankBalance);
            lblVakıfBakasıBalance.Text = Convert.ToDecimal(VakıfBankBakiye).ToString("N2") + " TL";
            #endregion

            #region İş Bankası Bakiye
            var İşBankasıBakiye = crmEntities.Banks.Where(x => x.BankTitle == "İş Bankası").Sum(y => y.BankBalance);
            lblİsBakasıBalance.Text = Convert.ToDecimal(İşBankasıBakiye).ToString("N2") + " TL";
            #endregion

            #region Toplam Kard Bakiyesi
            var ToplamKardBakiyesi = crmEntities.Banks.Sum(y => y.BankBalance);
            lblTotalCardBalance.Text = Convert.ToDecimal(ToplamKardBakiyesi).ToString("N2") + " TL";
            #endregion

            #region Toplam Gelen Havale
            var ToplamGelenHavale = crmEntities.BankProsesses.Where(x => x.ProsessType == "Gelen Havale").Sum(y => y.Amoun);
            lblTotalGelir.Text = Convert.ToDecimal(ToplamGelenHavale).ToString("N2") + " TL";
            #endregion

            #region Toplam Giden Havale
            var ToplamGidenHavale = crmEntities.BankProsesses.Where(x => x.ProsessType == "Giden Havale").Sum(y => y.Amoun);
            lblTotalGider.Text = Convert.ToDecimal(ToplamGidenHavale).ToString("N2") + " TL";
            #endregion

            #region Toplam Net Bakiye
            var ToplamNetBakiye = (ToplamGelenHavale - ToplamGidenHavale);
            lblToplamNetBakiye.Text = Convert.ToDecimal(ToplamNetBakiye).ToString("N2") + " TL";
            #endregion

            #region Toplam Banka Sayısı
            var ToplamBankaSayısı = crmEntities.Banks.Select(x => x.BankTitle).Count().ToString();
            lblTotalBankCount.Text = ToplamBankaSayısı;
            #endregion

            #region Toplam Kategori
            var ToplamKategori = crmEntities.Categories.Count();
            lblTotalCategory.Text = ToplamKategori.ToString();
            #endregion

            #region En Fazla Harcama Yapılan Kategori
            var EnFazlaHarcamaYapılanKategori = crmEntities.Spendings.OrderByDescending(X => X.SpendingAmount).Select(y => y.Categories.CategoryName).FirstOrDefault();
            lblEnFazlaHarcamaKategorisi.Text = EnFazlaHarcamaYapılanKategori;
            #endregion

            #region En Az Harcama Yapılan Kategori
            var EnAzHarcamaYapılanKategori = crmEntities.Spendings.OrderBy(X => X.SpendingAmount).Select(y => y.Categories.CategoryName).FirstOrDefault();
            lblEnAzHarcamaKategorisi.Text = EnAzHarcamaYapılanKategori;
            #endregion

            #region En Fazla Gelen Havale Miktari
            var EnFazlaGelenHavaleMiktari = crmEntities.BankProsesses.Where(x => x.ProsessType == "Gelen Havale").OrderByDescending(y => y.Amoun).Select(m => m.Amoun).FirstOrDefault();
            lblTotalGelenHavaleAmount.Text = Convert.ToDecimal(EnFazlaGelenHavaleMiktari).ToString("N2") + " TL";
            #endregion

            #region En Fazla Giden Havale Miktari
            var EnFazlaGidenHavaleMiktari = crmEntities.BankProsesses.Where(x => x.ProsessType == "Giden Havale").OrderByDescending(y => y.Amoun).Select(m => m.Amoun).FirstOrDefault();
            lblTotalGidenHavaleAmount.Text = Convert.ToDecimal(EnFazlaGidenHavaleMiktari).ToString("N2") + " TL";
            #endregion

            #region En Fazla Harcama Yapılan Yıl
            var EnFazlaHarcamaYapılanYıl = crmEntities.Spendings
                .GroupBy(x => SqlFunctions.DatePart("YEAR", x.SpendingDate))
                .Select(y => new
                {
                    Year = y.Key,
                    ToplamHarcama = y.Count()
                }).ToList();
            foreach (var item in EnFazlaHarcamaYapılanYıl)
            {
                lblEnAzHarcamaYapılanYıl.Text = $"{item.Year} Yılı";
            }
            #endregion

            #region Toplam Admin Sayısı
            var ToplamAdminSayısı = crmEntities.Users.Count();
            lblToplamAdminSayısı.Text = ToplamAdminSayısı.ToString();
            #endregion

            #region Aktif Admin Sayısı
            var AktifAdminSayısı = crmEntities.Users.Where(x => x.Status == true).Count();
            lblAktifAdminSayısı.Text = AktifAdminSayısı.ToString();
            #endregion

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            lblDateTime.Text = dateTime.ToString("F");
        }

        private void btnKategoriler_Click(object sender, EventArgs e)
        {
            FrmKategoriler frmKategoriler = new FrmKategoriler(user);
            frmKategoriler.Show();
            this.Hide();
        }

        private void btnBankalar_Click(object sender, EventArgs e)
        {
            FrmBanka frmBanka = new FrmBanka(user);
            frmBanka.Show();
            this.Hide();
        }

        private void btnHarcamalar_Click(object sender, EventArgs e)
        {
            FrmHarcamalar frmHarcamalar = new FrmHarcamalar(user);
            frmHarcamalar.Show();
            this.Hide();
        }

        private void btnGelirGider_Click(object sender, EventArgs e)
        {
            FrmGelirGider frmGelirGider = new FrmGelirGider(user);
            frmGelirGider.Show();
            this.Hide();
        }

        private void btnBankaHaraketleri_Click(object sender, EventArgs e)
        {
            FrmBankaHaraketleri frmBankaHaraketleri = new FrmBankaHaraketleri(user);
            frmBankaHaraketleri.Show();
            this.Hide();
        }

        private void btnCıkısYap_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
