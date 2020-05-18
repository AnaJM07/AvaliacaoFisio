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
            // TODO: esta linha de código carrega dados na tabela 'masterDataSet.Paciente'. Você pode movê-la ou removê-la conforme necessário.
            this.pacienteTableAdapter.Fill(this.masterDataSet.Paciente);
            // TODO: esta linha de código carrega dados na tabela 'masterDataSet.Adm_Cervical'. Você pode movê-la ou removê-la conforme necessário.
            this.adm_CervicalTableAdapter.Fill(this.masterDataSet.Adm_Cervical);

        }

        private void flexao_DireitaLabel_Click(object sender, EventArgs e)
        {

        }

        private void flexao_DireitaTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRotInemaE_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
