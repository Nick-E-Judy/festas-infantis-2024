using FestasInfantis.WinApp.ModuloItem;

namespace FestasInfantis.WinApp.ModuloTema
{
    public partial class TelaTemaForm : Form
    {
        public TelaTemaForm()
        {
            InitializeComponent();
            listItens.DisplayMember = "Descricao";
        }
        private Tema tema;
        public Tema Tema
        {
            set
            {
                txtId.Text = value.Id.ToString();
                txtNome.Text = value.Nome;
            }
            get
            {
                return tema;
            }
        }
        public void CarregarItens(List<Item> itens)
        {
            listItens.Items.Clear();

            foreach (Item i in itens)
                listItens.Items.Add(i);
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            decimal valorTotal = CalcularValorTotalItens();
            List<Item> itensSelecionados = ObterItensSelecionados();

            tema = new Tema(nome, valorTotal, itensSelecionados);

            List<string> erros = tema.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);
                DialogResult = DialogResult.None;
            }
        }

        private decimal CalcularValorTotalItens()
        {
            decimal valorTotal = 0;

            foreach (Item item in listItens.CheckedItems)
            {
                valorTotal += item.Valor;
            }

            return valorTotal;
        }

        private List<Item> ObterItensSelecionados()
        {
            List<Item> itensSelecionados = new List<Item>();

            foreach (Item item in listItens.CheckedItems)
            {
                itensSelecionados.Add(item);
            }

            return itensSelecionados;
        }
    }
}