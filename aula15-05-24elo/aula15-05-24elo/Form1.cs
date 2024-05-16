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
    
    public partial class Form1 : Form
    {
        public List<Contato> listaContatos;
        public Form1()
        {
            InitializeComponent();

            listaContatos = new List<Contato>();
            //listaContatos.Add(new Contato(1, "Cassio", "Capucho", "27998745632", (TipoTelefone)cbx1.Items[0]));
            //listaContatos.Add(new Contato(2, "João", "Capucho", "27998745611", (TipoTelefone)cbx1.Items[1]));
            //listaContatos.Add(new Contato(3, "Pedro", "Capucho", "27998745622", (TipoTelefone)cbx1.Items[2]));

            dgvContatos.DataSource = null;
            dgvContatos.DataSource = listaContatos;
            dgvContatos.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        private void dgview1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
        }
    }
}

