using System;
using System.Windows.Forms;


namespace FisioForms
{
    public partial class Fisio : Form
    {
        Paciente objPaciente;
        Adm_Cervical objAdmCervical;
        Ombro objOmbro;
        public Fisio()
        {
            InitializeComponent();
            objPaciente = new Paciente();
            objAdmCervical = new Adm_Cervical();
            objOmbro = new Ombro();

            pacienteBindingSource.DataSource = objPaciente;
            OmbroBindingSource.DataSource = objOmbro;
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
        

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Context _context = new Context();
            _context.Paciente.Add(objPaciente);
            _context.Adm_Cervical.Add(objAdmCervical);
            _context.Ombro.Add(objOmbro);

            _context.SaveChanges();
        }


        private void btnRelatorio_Click(object sender, EventArgs e)
        {
         
        }
    }
}
