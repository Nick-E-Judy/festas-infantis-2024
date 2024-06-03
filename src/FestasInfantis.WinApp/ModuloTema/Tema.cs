using FestasInfantis.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloCliente;

namespace FestasInfantis.WinApp.ModuloTema
{
    public class Tema : EntidadeBase
    {
        public string Nome { get; set; }
        public decimal ValorTotal { get; set; }
        //public List<Item> Itens { get; set; }
        //public Aluguel Alugueis { get; set; }

        public Tema(string nome, decimal valorTotal)
        {
            Nome = nome;
            ValorTotal = valorTotal;
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
            Cliente atualizado = (Cliente)novoRegistro;

            Nome = atualizado.Nome;

        }
    }
}
