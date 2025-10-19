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
using System.Windows.Forms.DataVisualization.Charting;

namespace FinansalCRM
{
    public partial class FrmGelirGider : Form
    {
        FinancialCrmEntities crmEntities = new FinancialCrmEntities();
        private string _user;

        public FrmGelirGider(string user)
        {
            InitializeComponent();
            _user = user;
        }
        public FrmGelirGider()
        {
            InitializeComponent();
        }
        private void FrmGelirGider_Load(object sender, EventArgs e)
        {
            #region KullanıcıBilgisiniAl
            lblUser.Text = _user;
            #endregion

            #region timer Start
            timer1.Start();
            #endregion

            #region Filtreleme İşlemleri
            cmbGelirGiderTürü.SelectedIndex = 0;

            var values = crmEntities.Banks.Select(x => new
            {
                x.BankID,
                x.BankTitle
            }).ToList();
            cmbBankaList.DataSource = values;
            cmbBankaList.DisplayMember = "BankTitle";
            cmbBankaList.ValueMember = "BankID";

            #endregion

            #region ToplamGelenGidenHavaleVeNetKar
            var getGelenHavale = crmEntities.BankProsesses.Where(x => x.ProsessType == "Gelen Havale").Sum(y => y.Amoun);
            lblTotalGelenHavale.Text = Convert.ToDecimal(getGelenHavale).ToString("N2") + " ₺";
            var getGidenHavale = crmEntities.BankProsesses.Where(x => x.ProsessType == "Giden Havale").Sum(y => y.Amoun);
            lblTotalGidenHavale.Text = Convert.ToDecimal(getGidenHavale).ToString("N2") + " ₺";
            lblNetBakiye.Text = Convert.ToDecimal(getGelenHavale - getGidenHavale).ToString("N2") + " ₺";
            #endregion

            #region AylaraGöreGelirGİderChartEkranı
            chart1.Series.Clear();
            var gelirSeries = chart1.Series.Add("Gelir");
            gelirSeries.ChartType = SeriesChartType.Column;
            gelirSeries.Color = Color.SeaGreen;

            var giderSeries = chart1.Series.Add("Gider");
            giderSeries.ChartType = SeriesChartType.Column;
            giderSeries.Color = Color.IndianRed;
            var data = crmEntities.BankProsesses
                .GroupBy(x => new
                {
                    Ay = SqlFunctions.DatePart("month", x.ProsessDate), //Managemet Sqlde ki DATEPART komutu
                    x.ProsessType
                }).Select(g => new
                {
                    Ay = g.Key.Ay,
                    g.Key.ProsessType,
                    Toplam = g.Sum(x => x.Amoun)
                }).OrderBy(x => x.Ay).ToList();

            foreach (var item in data)
            {
                string AyAdı = new DateTime(DateTime.Now.Year, (int)item.Ay, 1).ToString("MMMM");
                if(item.ProsessType == "Gelen Havale")
                {
                    gelirSeries.Points.AddXY(AyAdı, item.Toplam);
                }
                else
                {
                    giderSeries.Points.AddXY(AyAdı, item.Toplam);
                }
            }
            #endregion
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            lblDateTime.Text = dateTime.ToString("F");
        }

        private void btnBankalar_Click(object sender, EventArgs e)
        {
            FrmBanka frmBanka = new FrmBanka(_user);
            frmBanka.Show();
            this.Hide();
        }

        private void btnKategoriler_Click(object sender, EventArgs e)
        {
            FrmKategoriler frmKategoriler = new FrmKategoriler(_user);
            frmKategoriler.Show();
            this.Hide();
        }

        private void btnHarcamalar_Click(object sender, EventArgs e)
        {
            FrmHarcamalar frmHarcamalar = new FrmHarcamalar(_user);
            frmHarcamalar.Show();
            this.Hide();
        }

        private void btnBankaHaraketleri_Click(object sender, EventArgs e)
        {
            FrmBankaHaraketleri frmBankaHaraketleri = new FrmBankaHaraketleri(_user);
            frmBankaHaraketleri.Show();
            this.Hide();
        }

        private void btnFiltre_Click(object sender, EventArgs e)
        {
            string GelirGiderTürü = cmbGelirGiderTürü.Text;
            int bankId = Convert.ToInt32(cmbBankaList.SelectedValue);
            DateTime dateTime = dateTimePicker1.Value.Date;

            var value = crmEntities.BankProsesses.Where(x => x.ProsessType == GelirGiderTürü && x.BankID == bankId && x.ProsessDate >= dateTime).Select(y => new
            {
                y.Description,
                y.ProsessDate,
                y.ProsessType,
                y.Amoun,
                y.Banks.BankTitle
            }).ToList();
            dataGridView1.DataSource = value;
        }

        private void btnİstatistik_Click(object sender, EventArgs e)
        {
            Frmİstatistik frmİstatistik = new Frmİstatistik(_user);
            frmİstatistik.Show();
            this.Hide();
        }

        private void btnCıkısYap_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
