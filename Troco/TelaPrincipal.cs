using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Troco
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal compra = 0;
            decimal dinheiro = 0;
            decimal troco = 0;

            compra = Convert.ToDecimal (txtCompra.Text);
            dinheiro = Convert.ToDecimal (txtDinheiro.Text);
            troco = dinheiro - compra;

            txtTroco.Text = Convert.ToString(troco);

            // Para as moedas
            // Entre parenteses converte também

            int moedas100 = (int)(troco / 1);
            troco = troco % 1;
            label100.Text = moedas100.ToString();

            int moedas050 = (int)(troco / 0.50m);
            troco = troco % 0.50m;
            label050.Text = moedas050.ToString();

            int moedas025 = (int)(troco / 0.25m);
            troco = troco % 0.25m;
            label025.Text = moedas025.ToString();

            int moedas010 = (int)(troco / 0.10m);
            troco = troco % 0.10m;
            label010.Text = moedas010.ToString();

            int moedas005 = (int)(troco / 0.05m);
            troco = troco % 0.05m;
            label005.Text = moedas005.ToString();
                  
            int moedas001 = (int)(troco / 0.01m);
            troco = troco % 0.01m;
            label001.Text = moedas001.ToString();

        }
    }
}
