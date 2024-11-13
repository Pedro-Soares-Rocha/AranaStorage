using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AranaStorage
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void estoqueBtn_Click(object sender, EventArgs e)
        {
            new Estoque().Show();
        }

        private void pcProntoBtn_Click(object sender, EventArgs e)
        {
            new MaquinaPronta().Show();
        }

        private void pcMontagemBtn_Click(object sender, EventArgs e)
        {
            new MontarMaquina().Show();
        }

        private void estoqueAdmBtn_Click(object sender, EventArgs e)
        {          
            if(loginTxb.Text == "José" && senhaTxb.Text == "Arana123") 
            { 
                new AdmEstoque().Show(); 
            }
            else
            {
                MessageBox.Show("Login ou senha incorretos. Por favor, tente novamente.");
            }
        }
    }
}
