using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;


namespace FisioForms
{
    public partial class Fisio : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-994SM15;Initial Catalog=master;Integrated Security=True");
        

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
            var Dados = _context.Paciente.ToList();
            dgvPacientes.DataSource = Dados;
            InstanciarObj();
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                _context.Paciente.Add(objPaciente);
                _context.Ombro.Add(objOmbro);
                _context.Adm_Cervical.Add(objAdmCervical);
                _context.Adm_Cotovelo.Add(objAdmCotovelo);
                _context.Adm_Punho.Add(objAdmPunho);
                _context.Adm_Tronco.Add(objAdmTronco);
                _context.Joelho.Add(objJoelho);
                _context.Quadril.Add(objQuadril);
                _context.Pe.Add(objPe);
                _context.SaveChanges();

                InstanciarObj();
                MessageBox.Show("Salvo com sucesso!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }


        private void crystalReportViewer2_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Paciente", con);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
        }

        private void InstanciarObj()
        {
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

            pacienteBindingSource1.DataSource = objPaciente;
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
    }
}
