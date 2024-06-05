using FestasInfantis.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestasInfantis.WinApp.ModuloItem
{
    public class ControladorItem : ControladorBase
    {
        private RepositorioItem repositorioItem;
        private TabelaItemControl tabelaItem;

        public ControladorItem(RepositorioItem repositorio)
        {
            repositorioItem = repositorio;
        }

        public override string TipoCadastro { get { return "Itens"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar um novo item"; } }

        public override string ToolTipEditar { get { return "Editar um item existente"; } }

        public override string ToolTipExcluir { get { return "Excluir um item existente"; } }

        public override void Adicionar()
        {
            TelaItemForm telaItem = new TelaItemForm();

            DialogResult resultado = telaItem.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Item novoItem = telaItem.Item;

            repositorioItem.Cadastrar(novoItem);

            CarregarItens();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O item \"{novoItem.Id}\" foi criado com sucesso!");
        }

        public override void Editar()
        {
            TelaItemForm telaItem = new TelaItemForm();

            int idSelecionado = tabelaItem.ObterRegistroSelecionado();

            Item itemSelecionado =
                repositorioItem.SelecionarPorId(idSelecionado);

            if (itemSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            telaItem.Item = itemSelecionado;

            DialogResult resultado = telaItem.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Item itemEditado = telaItem.Item;

            repositorioItem.Editar(itemSelecionado.Id, itemEditado);

            CarregarItens();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{itemEditado.Id}\" foi editado com sucesso!");
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaItem.ObterRegistroSelecionado();

            Item itemSelecionado =
                repositorioItem.SelecionarPorId(idSelecionado);

            if (itemSelecionado == null)
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
                $"Você deseja realmente excluir o registro \"{itemSelecionado.Id}\"?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resposta != DialogResult.Yes)
                return;

            repositorioItem.Excluir(itemSelecionado.Id);

            CarregarItens();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{itemSelecionado.Id}\" foi excluído com sucesso!");
        }

        private void CarregarItens()
        {
            List<Item> items = repositorioItem.SelecionarTodos();

            tabelaItem.AtualizarRegistros(items);
        }

        public override UserControl ObterListagem()
        {
            if (tabelaItem == null)
                tabelaItem = new TabelaItemControl();

            CarregarItens();

            return tabelaItem;
        }
    }
}
