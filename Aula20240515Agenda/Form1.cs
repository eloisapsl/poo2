﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula20240515Agenda
{
    public partial class FormHome : Form
    {
        public List<Contato> listaContatos;
        public FormHome()
        {
            InitializeComponent();
            cbxTipoTelefone.Items.Add(new TipoTelefone(1, "Pessoal"));
            cbxTipoTelefone.Items.Add(new TipoTelefone(1, "Profissional"));
            cbxTipoTelefone.Items.Add(new TipoTelefone(1, "Whatsapp"));
            cbxTipoTelefone.Items.Add(new TipoTelefone(1, "Recado"));
            //cbxTipoTelefone.DisplayMember = "nome";

            listaContatos = new List<Contato>();
            listaContatos.Add(new Contato(1,"Cassio", "Capucho", "27998745632", (TipoTelefone)cbxTipoTelefone.Items[0] ));
            listaContatos.Add(new Contato(2, "João", "Capucho", "27998745611", (TipoTelefone)cbxTipoTelefone.Items[1]));
            listaContatos.Add(new Contato(3, "Pedro", "Capucho", "27998745622", (TipoTelefone)cbxTipoTelefone.Items[2]));

            dgvContatos.DataSource = null;
            dgvContatos.DataSource = listaContatos;
            dgvContatos.Refresh();


        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {


        }
    }
}
