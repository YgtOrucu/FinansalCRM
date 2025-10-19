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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }
        FinancialCrmEntities db = new FinancialCrmEntities();   
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string admin = txtAdminName.Text;
            string sifre = txtSifre.Text;

            var bilgiler = db.Users.FirstOrDefault(x=>x.Username == admin && x.Password==sifre);
            if(bilgiler != null)
            {
                FrmBanka frmBanka = new FrmBanka(admin);
                frmBanka.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı","Hatalı Giriş",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                txtAdminName.Text = "";
                txtSifre.Text = "";
            }

        }
    }
}
