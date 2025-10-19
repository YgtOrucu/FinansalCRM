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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FinansalCRM
{
    public partial class FrmBanka : Form
    {
        FinancialCrmEntities crmEntities = new FinancialCrmEntities();
        #region constructor ile username getirme
        private string _username;
        public FrmBanka(string username)
        {
            InitializeComponent();
            _username = username;
        }
        #endregion
        public FrmBanka()
        {
            InitializeComponent();
        }

        private void FrmBanka_Load(object sender, EventArgs e)
        {
            #region KullanıcıBilgisiniAl
            lblUser.Text = _username;
            #endregion

            #region timer Start
            timer1.Start();
            #endregion

            #region Bakiye Bilgiler
            var ZiraatBankasıBalance = crmEntities.Banks.Where(x => x.BankTitle == "Ziraat Bankası").Select(y => y.BankBalance).FirstOrDefault();
            lblZiraatBakasıBalance.Text = Convert.ToDecimal(ZiraatBankasıBalance).ToString("N2") + " ₺";

            var VakıfBankBalance = crmEntities.Banks.Where(x => x.BankTitle == "VakıfBank").Select(y => y.BankBalance).FirstOrDefault();
            lblVakıfBakasıBalance.Text = Convert.ToDecimal(VakıfBankBalance).ToString("N2") + " ₺";

            var İsBankasıBalance = crmEntities.Banks.Where(x => x.BankTitle == "İş Bankası").Select(y => y.BankBalance).FirstOrDefault();
            lblİsBakasıBalance.Text = Convert.ToDecimal(İsBankasıBalance).ToString("N2") + " ₺";
            #endregion

            #region Banka Haraketleri Son 5 İşlem
            Label[] lblProcesses = new Label[]
            {
                 lblBankProsess1,
                 lblBankProsess2,
                 lblBankProsess3,
                 lblBankProsess4,
                 lblBankProsess5
            };

            var bankProsesses = crmEntities.BankProsesses.
                OrderByDescending(x => x.ProsessDate)
                .Take(5)
                .Select(y => new
                {
                    Description = y.Description,
                    ProsessDate = y.ProsessDate,
                    ProsessType = y.ProsessType,
                    Amoun = y.Amoun,
                    BankTitle = y.Banks.BankTitle
                }).ToList();

            for (int i = 0; i < lblProcesses.Length && i < bankProsesses.Count; i++)
            {
                var item = bankProsesses[i];
                lblProcesses[i].Text = $"{item.Description} | {item.ProsessDate:dd.MM.yyyy} | {item.ProsessType} | {item.Amoun:N2} ₺ | {item.BankTitle}";
            }
            #endregion
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            lblDateTime.Text = dateTime.ToString("F");
        }

        private void btnKategoriler_Click(object sender, EventArgs e)
        {
            string user = lblUser.Text;
            FrmKategoriler frmKategoriler = new FrmKategoriler(user);
            frmKategoriler.Show();
            this.Hide();
        }

        private void btnHarcamalar_Click(object sender, EventArgs e)
        {
            string user = lblUser.Text;
            FrmHarcamalar frmHarcamalar = new FrmHarcamalar(user);
            frmHarcamalar.Show();
            this.Hide();
        }

        private void btnCıkısYap_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBankaHaraketleri_Click(object sender, EventArgs e)
        {
            string user = lblUser.Text;
            FrmBankaHaraketleri frmBankaHaraketleri = new FrmBankaHaraketleri(user);
            frmBankaHaraketleri.Show();
            this.Hide();
        }

        private void btnGelirGider_Click(object sender, EventArgs e)
        {
            string user = lblUser.Text;
            FrmGelirGider frmGelirGider = new FrmGelirGider(user);
            frmGelirGider.Show();
            this.Hide();
        }

        private void btnİstatistik_Click(object sender, EventArgs e)
        {
            string user = lblUser.Text;
            Frmİstatistik frmİstatistik = new Frmİstatistik(user);
            frmİstatistik.Show();
            this.Hide();
        }
    }
}
