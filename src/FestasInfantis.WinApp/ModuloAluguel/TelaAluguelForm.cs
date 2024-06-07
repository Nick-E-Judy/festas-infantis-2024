using FestasInfantis.WinApp.ModuloCliente;
using FestasInfantis.WinApp.ModuloTema;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public partial class TelaAluguelForm : Form
    {
        private Aluguel aluguel;
        public Aluguel Aluguel
        {
            set
            {
                txtId.Text = value.Id.ToString();
            }
            get
            {
                return aluguel;
            }
        }

        public TelaAluguelForm()
        {
            InitializeComponent();
            cbCliente.DisplayMember = "Nome";
            cbTema.DisplayMember = "Nome";
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)cbCliente.SelectedItem;
            Tema temaSelecionado = (Tema)cbTema.SelectedItem;
            string cidade = txtCidade.Text;
            string estado = txtEstado.Text;
            string rua = txtRua.Text;
            string bairro = txtBairro.Text;
            int numero = Convert.ToInt32(txtNumero.Text);
            DateTime dataFesta = dtpDataFesta.Value;
            TimeSpan horarioInicio = dtpHoraInicio.Value.TimeOfDay;
            TimeSpan horarioTermino = dtpHoraFim.Value.TimeOfDay;
            Festa festa = new Festa(cidade, estado, rua, bairro, numero, dataFesta, horarioInicio, horarioTermino);
            aluguel = new Aluguel(clienteSelecionado, temaSelecionado, festa);

            List<string> erros = aluguel.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }

        public void CarregarClientes(List<Cliente> clientes)
        {
            cbCliente.Items.Clear();

            foreach (Cliente c in clientes)
                cbCliente.Items.Add(c);
        }

        public void CarregarTemas(List<Tema> temas)
        {
            cbTema.Items.Clear();

            foreach (Tema t in temas)
                cbTema.Items.Add(t);
        }
        private void toolStripCalcular_Click(object sender, EventArgs e)
        {
            MessageBox.Show("clicou");
        }
    }
}
