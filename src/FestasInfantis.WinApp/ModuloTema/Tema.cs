using FestasInfantis.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloCliente;
using FestasInfantis.WinApp.ModuloItem;

namespace FestasInfantis.WinApp.ModuloTema
{
    public class Tema : EntidadeBase
    {
        public string Nome { get; set; }
        public decimal ValorTotal { get; set; }
        public List<Item> Itens { get; set; }
        //public Aluguel Alugueis { get; set; }

        public Tema(string nome, decimal valorTotal, List<Item> itens)
        {
            Nome = nome;
            ValorTotal = valorTotal;
            Itens = itens;
        }
        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Nome.Trim()))
                erros.Add("O campo \"nome\" é obrigatório");


            return erros;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Tema atualizado = (Tema)novoRegistro;

            Nome = atualizado.Nome;
            ValorTotal = atualizado.ValorTotal;
            Itens = atualizado.Itens;
        }
    }
}