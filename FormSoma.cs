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
    public partial class FormSoma : Form
    {
        public FormSoma()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double n1, n2, total = 0;

            n1 = double.Parse(txtV1.Text);
            n2 = double.Parse(txtV2.Text);


            switch (cbOperacao.SelectedIndex)
            {
                case 0:
                    total = n1 + n2;
                    break;

                case 1:
                    total = n1 - n2;
                    break;

                case 2:
                    total = n1 * n2;
                    break;

                case 3:
                    total = n1 / n2;
                    break;
            }
        }
    }
}
