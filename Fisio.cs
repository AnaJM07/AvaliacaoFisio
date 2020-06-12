using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;


namespace FisioForms
{
    public partial class Fisio : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-994SM15;Initial Catalog=master;Integrated Security=True");
        ReportDocument rprt = new  ReportDocument();

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

        private void Fisio_Load(object sender, EventArgs e)
        {

        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {

                this.pacienteTableAdapter1.Fill(this.masterDataSet2.Paciente);
                this.tornozeloTableAdapter.Fill(this.masterDataSet2.Tornozelo);
                this.ombroTableAdapter1.Fill(this.masterDataSet2.Ombro);
                this.adm_CervicalTableAdapter1.Fill(this.masterDataSet2.Adm_Cervical);
                this.adm_CotoveloTableAdapter1.Fill(this.masterDataSet2.Adm_Cotovelo);
                this.adm_PunhoTableAdapter.Fill(this.masterDataSet2.Adm_Punho);
                this.adm_TroncoTableAdapter.Fill(this.masterDataSet2.Adm_Tronco);
                this.joelhoTableAdapter1.Fill(this.masterDataSet2.Joelho);
                this.quadrilTableAdapter.Fill(this.masterDataSet2.Quadril);
                this.peTableAdapter1.Fill(this.masterDataSet2.Pe);
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
                
              

                
                MessageBox.Show("Salvo com sucesso!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "SELECT * FROM Paciente";
            SqlCommand cmd = new SqlCommand(s, con);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adap.Fill(ds, "Paciente");
            CrystalReport1 cr1 = new CrystalReport1();
            cr1.SetDataSource(ds);
            crystalReportViewer2.ReportSource = cr1;
            crystalReportViewer2.Refresh();
        }


        private void crystalReportViewer2_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Paciente", con);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());


            
        }
    }
}
