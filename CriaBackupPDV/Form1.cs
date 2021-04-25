using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CriaBackupPDV.Entities;
using CriaBackupPDV.Enums;

namespace CriaBackupPDV
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            
            if (cbNomeCliente.Text == string.Empty || txtVersao.Text == string.Empty || txtDraft.Text == string.Empty)
            {
                MessageBox.Show("Favor preencher todos os campos!");
                cbNomeCliente.Focus();
            }
            else
            {
                Clientes nomeCliente = (Clientes)Enum.Parse(typeof(Clientes), cbNomeCliente.Text);
                int pdvVersao = int.Parse(txtVersao.Text);
                int numeroDraft = int.Parse(txtDraft.Text);
                Arquivo arquivo = new Arquivo(nomeCliente, pdvVersao, numeroDraft);
                arquivo.CriaBackup();
            }
            
        }
    }
}
