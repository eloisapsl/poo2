using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula15_05_24elo
{
    public partial class Form2 : Form
    {
        Form1 origem;
        public Form2(Form1 origem)
        {
            InitializeComponent();
            this.origem = origem;
            cbx1.Items.Add(new TipoTelefone(1, "Pessoal"));
            cbx1.Items.Add(new TipoTelefone(2, "Profissional"));
            cbx1.Items.Add(new TipoTelefone(3, "Whatsapp"));
            cbx1.Items.Add(new TipoTelefone(4, "Recado"));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            int proxID = origem.listaContatos.Count + 1;

            Contato aux = new Contato(proxID,
                txbNome.Text,
                txbSobrenome.Text,
                txbTelefone.Text,
                (TipoTelefone)cbx1.SelectedItem
                );

            origem.listaContatos.Add(aux);

            origem.dgvContatos.DataSource = null;
            origem.dgvContatos.DataSource = origem.listaContatos;
            origem.dgvContatos.Refresh();

            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbx1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
