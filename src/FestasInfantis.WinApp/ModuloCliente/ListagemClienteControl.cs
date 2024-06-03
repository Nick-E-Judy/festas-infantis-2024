namespace FestasInfantis.WinApp.ModuloCliente
{
    public partial class ListagemClienteControl : UserControl
    {
        public ListagemClienteControl()
        {
            InitializeComponent();
        }

        public void AtualizarRegistros(List<Cliente> clientes)
        {
            listClientes.Items.Clear();

            foreach (Cliente cliente in clientes)
                listClientes.Items.Add(cliente);
        }

        public Cliente ObterRegistroSelecionado()
        {
            if (listClientes.SelectedItem == null)
                return null;

            return (Cliente)listClientes.SelectedItem;
        }
    }
}
