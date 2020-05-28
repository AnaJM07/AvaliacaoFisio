using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;


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
            MessageBox.Show("Salvo com sucesso!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.pacienteTableAdapter.Fill(this.masterDataSet.Paciente);
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    FisioReport rpt = new FisioReport();
                    SqlConnection conn;
                    SqlCommand cmd = new SqlCommand();
                    SqlDataAdapter da = new SqlDataAdapter();
                    DataSet ds = new DataSet();


                    conn = new SqlConnection("Data Source = DESKTOP-994SM15; Initial Catalog=master; Integrated Security = True");
                    cmd.Connection = conn;
                    cmd.CommandText = "Select * from Paciente";
                    cmd.CommandType = CommandType.Text;

                    da.SelectCommand = cmd;
                    da.Fill(ds, "Customers");

                    rpt.SetDataSource(ds);

                    crystalReportViewer1.ReportSource = rpt;
                    crystalReportViewer1.Refresh();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(null, "Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
