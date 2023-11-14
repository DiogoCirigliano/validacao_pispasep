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
            try
            {
                btnValidar.Text = cls37652_PIS.Validar(txtPIS.Text)? "Válido": "Inválido";
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
    }
}
