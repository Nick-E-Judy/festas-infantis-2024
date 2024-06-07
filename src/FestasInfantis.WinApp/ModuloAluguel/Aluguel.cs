using FestasInfantis.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloCliente;
using FestasInfantis.WinApp.ModuloTema;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public class Aluguel : EntidadeBase
    {
        public Aluguel(Cliente cliente, Tema tema, Festa festa)
        {
            Cliente = cliente;
            Tema = tema;
            Festa = festa;
            DataPagamento = festa.DataFesta;
            Status = false;
        }

        public Cliente Cliente { get; set; }
        public Tema Tema { get; set; }
        public Festa Festa { get; set; }
        public DateTime DataPagamento { get; set; }
        public bool Status { get; set; }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            return erros;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Aluguel atualizado = (Aluguel)novoRegistro;

            Cliente = atualizado.Cliente;
            Tema = atualizado.Tema;
            DataPagamento = atualizado.DataPagamento;
            Status = atualizado.Status;
        }
    }
}
