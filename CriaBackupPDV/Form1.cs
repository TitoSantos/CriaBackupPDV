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
            string nameClient = txtNome.Text.ToUpper();
            int pdvVersion = int.Parse(txtVersao.Text);
            int draftNumber = int.Parse(txtDraft.Text);

            try
            {

            }
            catch ()
            {

            }
        }
    }
}
