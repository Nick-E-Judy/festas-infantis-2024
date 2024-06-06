using FestasInfantis.WinApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public class ControladorAluguel : ControladorBase
    {
        private RepositorioAluguel repositorioAluguel;
        private TabelaAluguelControl tabelaAluguel;

        public ControladorAluguel(RepositorioAluguel repositorio)
        {
            repositorioAluguel = repositorio;
        }

        public override string TipoCadastro { get { return "Aluguel"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar um novo aluguel"; } }

        public override string ToolTipEditar { get { return "Editar um aluguel existente"; } }

        public override string ToolTipExcluir { get { return "Excluir um aluguel existente"; } }

        public override void Adicionar()
        {
            TelaAluguelForm telaAluguel = new TelaAluguelForm();

            DialogResult resultado = telaAluguel.ShowDialog();

            // guardas = bloquear momentos em que a aplicação toma um "caminho triste"
            if (resultado != DialogResult.OK)
                return;

            Aluguel novoAluguel = telaAluguel.Aluguel;

            repositorioAluguel.Cadastrar(novoAluguel);

            CarregarAlugueis();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O aluguel de \"{novoAluguel.Cliente.Nome}\" foi criado com sucesso!");
        }

        public override void Editar()
        {
            TelaAluguelForm telaAluguel = new TelaAluguelForm();

            int idSelecionado = tabelaAluguel.ObterRegistroSelecionado();

            Aluguel aluguelSelecionado =
                repositorioAluguel.SelecionarPorId(idSelecionado);

            if (aluguelSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            telaAluguel.Aluguel = aluguelSelecionado;

            DialogResult resultado = telaAluguel.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Aluguel aluguelEditado = telaAluguel.Aluguel;

            repositorioAluguel.Editar(aluguelSelecionado.Id, aluguelEditado);

            CarregarAlugueis();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O aluguel de \"{aluguelEditado.Cliente.Nome}\" foi editado com sucesso!");
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaAluguel.ObterRegistroSelecionado();

            Aluguel aluguelSelecionado =
                repositorioAluguel.SelecionarPorId(idSelecionado);

            if (aluguelSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            DialogResult resposta = MessageBox.Show(
                $"Você deseja realmente excluir o aluguel de \"{aluguelSelecionado.Cliente.Nome}\"?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resposta != DialogResult.Yes)
                return;

            repositorioAluguel.Excluir(aluguelSelecionado.Id);

            CarregarAlugueis();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O aluguel de \"{aluguelSelecionado.Cliente.Nome}\" foi excluído com sucesso!");
        }

        private void CarregarAlugueis()
        {
            List<Aluguel> alugueis = repositorioAluguel.SelecionarTodos();

            tabelaAluguel.AtualizarRegistros(alugueis);
        }

        public override UserControl ObterListagem()
        {
            if (tabelaAluguel == null)
                tabelaAluguel = new TabelaAluguelControl();

            CarregarAlugueis();

            return tabelaAluguel;
        }
    }
}
