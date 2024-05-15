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
        List<Contato> listaContatos;
        public Form1()
        {
            InitializeComponent();
            cbx1.Items.Add(new TipoTelefone(1, "Profissional"));
            cbx1.Items.Add(new TipoTelefone(2, "Pessoal"));
            cbx1.Items.Add(new TipoTelefone(3, "Residencial"));
            cbx1.Items.Add(new TipoTelefone(4, "Escolar"));
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
    }
}

