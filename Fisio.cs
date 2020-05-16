using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FisioForms
{
    public partial class Fisio : Form
    {
        public Fisio()
        {
            InitializeComponent();
        }

        private void adm_CervicalBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.adm_CervicalBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.masterDataSet);

        }

        private void Fisio_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'masterDataSet.Adm_Cervical'. Você pode movê-la ou removê-la conforme necessário.
            this.adm_CervicalTableAdapter.Fill(this.masterDataSet.Adm_Cervical);

        }

        private void Cervical_Enter(object sender, EventArgs e)
        {

        }

        private void abducao_DireitaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void abducao_DireitaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void abducao_EsquerdaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void abducao_EsquerdaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void aducao_DireitaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void aducao_DireitaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void aducao_EsquerdaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void aducao_EsquerdaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rotExterna_DireitaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void rotExterna_DireitaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rotExterna_EsquerdaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void rotExterna_EsquerdaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void extensao_DireitaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void aducao_DireitaTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
