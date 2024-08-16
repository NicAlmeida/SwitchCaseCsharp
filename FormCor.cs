using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEstruturaCondicionalSwitchCase
{
    public partial class FormCor : Form
    {
        public FormCor()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string cor;

            cor = txtCor.Text.ToUpper();

            switch (cor)
            {
                case "VERDE":
                    MessageBox.Show("voce digitou VERDE");
                break;

                case "AZUL":
                    MessageBox.Show("voce digitou AZUL");
                break;

                case "AMARELO":
                    MessageBox.Show("voce digitou AMARELO");
                break;

                default:
                    MessageBox.Show("Não consegui descobrir");
                break;


            }

        }
    }
}
