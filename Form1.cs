using _9_ADONET.Classes;
using _9_ADONET.DAO;
using System.Data;

namespace _9_ADONET
{
    public partial class frmAgenda : Form
    {
        public frmAgenda()
        {
            InitializeComponent();
        }

        private void frmAgenda_Load(object sender, EventArgs e)
        {
            CarregarDataGriView();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int id = (int)dgvAgenda.CurrentRow.Cells[0].Value;
            ContatoDAO contatoDAO = new ContatoDAO();
            contatoDAO.Excluir(id);
            CarregarDataGriView();

        }
        private void CarregarDataGriView()
        {
            ContatoDAO contatoDao = new ContatoDAO();
            /*
            DataSet ds = contatoDao.GetContatos();
            dgvAgenda.DataSource = ds.Tables["CONTATOS"];
            dgvAgenda.Refresh();
            */
            DataTable dataTable = contatoDao.GetContatos();
            dgvAgenda.DataSource = dataTable;
            dgvAgenda.Refresh();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmIncluirAlterarContato form = new frmIncluirAlterarContato();
            form.ShowDialog();
            CarregarDataGriView();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Contato contato = new Contato
            {
                Id = (int)dgvAgenda.CurrentRow.Cells[0].Value,
                Nome = dgvAgenda.CurrentRow.Cells[1].Value.ToString(),
                Email = dgvAgenda.CurrentRow.Cells[2].Value.ToString(),
                Telefone = (int)dgvAgenda.CurrentRow.Cells[3].Value
            };
            frmIncluirAlterarContato form = new frmIncluirAlterarContato(contato);
            form.ShowDialog();
            CarregarDataGriView();
        }
    }
}
