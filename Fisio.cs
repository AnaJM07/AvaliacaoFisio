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
        Paciente objPaciente;
        Adm_Cervical objAdmCervical;
        Ombro objOmbro;
        Adm_Cotovelo objAdmCotovelo;
        Adm_Punho objAdmPunho;
        Adm_Tronco objAdmTronco;
        Quadril objQuadril;
        Tornozelo objTornozelo;
        Joelho objJoelho;
        Pe objPe;

        
        FisioModel _context;
        public Fisio()
        {
            InitializeComponent();
            _context = new FisioModel();
            objPaciente = new Paciente();
            objOmbro = new Ombro();
            objAdmCervical = new Adm_Cervical();
            objAdmCotovelo = new Adm_Cotovelo();
            objAdmPunho = new Adm_Punho();
            objAdmTronco = new Adm_Tronco();
            objJoelho = new Joelho();
            objQuadril = new Quadril();
            objTornozelo = new Tornozelo();
            objPe = new Pe();

            pacienteBindingSource.DataSource = objPaciente;
            ombroBindingSource.DataSource = objOmbro;
            adm_CervicalBindingSource.DataSource = objAdmCervical;
            adm_cotoveloBindingSource.DataSource = objAdmCotovelo;
            adm_PunhoBindingSource.DataSource = objAdmPunho;
            adm_TroncoBindingSource.DataSource = objAdmTronco;
            joelhoBindingSource.DataSource = objJoelho;
            quadrilBindingSource7.DataSource = objQuadril;
            tornozeloBindingSource.DataSource = objTornozelo;
             peBindingSource.DataSource = objPe;

        }

        private void Fisio_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'masterDataSet.Tornozelo'. Você pode movê-la ou removê-la conforme necessário.
            this.tornozeloTableAdapter.Fill(this.masterDataSet.Tornozelo);
            // TODO: esta linha de código carrega dados na tabela 'masterDataSet.Quadril'. Você pode movê-la ou removê-la conforme necessário.
            this.quadrilTableAdapter.Fill(this.masterDataSet.Quadril);
            // TODO: esta linha de código carrega dados na tabela 'masterDataSet.Pe'. Você pode movê-la ou removê-la conforme necessário.
            this.peTableAdapter.Fill(this.masterDataSet.Pe);
            // TODO: esta linha de código carrega dados na tabela 'masterDataSet.Ombro'. Você pode movê-la ou removê-la conforme necessário.
            this.ombroTableAdapter.Fill(this.masterDataSet.Ombro);
            // TODO: esta linha de código carrega dados na tabela 'masterDataSet.Joelho'. Você pode movê-la ou removê-la conforme necessário.
            this.joelhoTableAdapter.Fill(this.masterDataSet.Joelho);
            // TODO: esta linha de código carrega dados na tabela 'masterDataSet.Adm_Tronco'. Você pode movê-la ou removê-la conforme necessário.
            this.adm_TroncoTableAdapter.Fill(this.masterDataSet.Adm_Tronco);
            // TODO: esta linha de código carrega dados na tabela 'masterDataSet.Adm_Punho'. Você pode movê-la ou removê-la conforme necessário.
            this.adm_PunhoTableAdapter.Fill(this.masterDataSet.Adm_Punho);
            // TODO: esta linha de código carrega dados na tabela 'masterDataSet.Adm_Cotovelo'. Você pode movê-la ou removê-la conforme necessário.
            this.adm_CotoveloTableAdapter.Fill(this.masterDataSet.Adm_Cotovelo);
            // TODO: esta linha de código carrega dados na tabela 'masterDataSet.Paciente'. Você pode movê-la ou removê-la conforme necessário.
            this.pacienteTableAdapter.Fill(this.masterDataSet.Paciente);
            // TODO: esta linha de código carrega dados na tabela 'masterDataSet.Adm_Cervical'. Você pode movê-la ou removê-la conforme necessário.
            this.adm_CervicalTableAdapter.Fill(this.masterDataSet.Adm_Cervical);

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            _context.Paciente.Add(objPaciente);
            _context.Ombro.Add(objOmbro);
            _context.Adm_Cervical.Add(objAdmCervical);
            _context.Adm_Cotovelo.Add(objAdmCotovelo);
            _context.Adm_Punho.Add(objAdmPunho);
            _context.Adm_Tronco.Add(objAdmTronco);
            _context.Joelho.Add(objJoelho);
            _context.Quadril.Add(objQuadril);
            _context.Tornozelo.Add(objTornozelo);
            _context.Pe.Add(objPe);
        }
    }
}
