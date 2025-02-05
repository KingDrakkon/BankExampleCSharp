using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankLibrary;

namespace BankApp
{
    public partial class Withdraw : Form
    {
        public Withdraw()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Withdraw_Load(object sender, EventArgs e)
        {
            Account.GenerateTestAccounts();
            foreach (var account in Account.Accounts)
            {
                cmbAccounts.Items.Add(account.AccountHolder);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
        }
    }
}
