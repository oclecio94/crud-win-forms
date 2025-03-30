using crud.Repositorios;

namespace crud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var pessoaRepositorio = new PessoaRepositorio();
            BuscarTodasAsPessoas(pessoaRepositorio);
        }

        private void LimparCampos()
        {
            txtCpf.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtId.Text = string.Empty;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
               string.IsNullOrWhiteSpace(txtEmail.Text) ||
               string.IsNullOrWhiteSpace(txtCpf.Text))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var pessoa = new Pessoa(0, txtNome.Text, txtEmail.Text, txtCpf.Text);

            var pessoaRepositorio = new PessoaRepositorio();

            pessoaRepositorio.Inserir(pessoa);

            LimparCampos();
            BuscarTodasAsPessoas(pessoaRepositorio);
        }

        private void BuscarTodasAsPessoas(PessoaRepositorio pessoaRepositorio)
        {
            var pessoas = pessoaRepositorio.BuscarTodasPessoas();
            dgPessoa.DataSource = pessoas.ToList();
        }

        private void dgPessoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            if (dgv == null) return;

            txtId.Text = dgv.CurrentRow.Cells["Id"]?.Value.ToString();
            txtNome.Text = dgv.CurrentRow.Cells["Nome"]?.Value.ToString();
            txtEmail.Text = dgv.CurrentRow.Cells["Email"]?.Value.ToString();
            txtCpf.Text = dgv.CurrentRow.Cells["Cpf"]?.Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Selecione uma pessoa antes de editar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtCpf.Text))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var pessoa = new Pessoa(Convert.ToInt32(txtId.Text), txtNome.Text, txtEmail.Text, txtCpf.Text);

            var pessoaRepositorio = new PessoaRepositorio();

            pessoaRepositorio.Atualizar(pessoa);

            LimparCampos();
            BuscarTodasAsPessoas(pessoaRepositorio);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Selecione uma pessoa antes de remover!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var pessoaRepositorio = new PessoaRepositorio();
            pessoaRepositorio.Deletar(Convert.ToInt32(txtId.Text));

            LimparCampos();
            BuscarTodasAsPessoas(pessoaRepositorio);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}
