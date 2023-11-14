using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj37652_PIS
{
    public partial class frm37652_PIS : Form
    {
        public frm37652_PIS()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtPIS.Text))
            {
                MessageBox.Show("Caixa de texto Vazia", "Erro", MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtPIS.Focus();
                return;
            }
            try
            {
                string PIS = txtPIS.Text.Trim();
                btnValidar.Text = cls37652_PIS.Validar(PIS)? "Válido": "Inválido";

                if(btnValidar.Text == "Válido")
                {
                    btnValidar.ForeColor = Color.Green;
                    txtPIS.ForeColor = Color.Green;
                }
                else
                {
                    btnValidar.ForeColor = Color.Red;
                    txtPIS.ForeColor = Color.Red;
                }         
            }
            catch (Exception)
            {
                MessageBox.Show("Erro inesperado","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void txtPIS_TextChanged(object sender, EventArgs e)
        {
            btnValidar.ForeColor = Color.Black;
            txtPIS.ForeColor = Color.Black;
        }

        private void txtPIS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != (char)Keys.Delete &&
                e.KeyChar != (char)3 && e.KeyChar != (char)22)
            {
                e.Handled = true;
            }
        }
    }
}
