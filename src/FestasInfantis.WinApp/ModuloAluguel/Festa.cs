using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public class Festa
    {
        public Festa(string cidade, string estado, string rua, string bairro, int numero, DateTime dataFesta, TimeSpan horarioInicio, TimeSpan horarioTermino)
        {
            Cidade = cidade;
            Estado = estado;
            Rua = rua;
            Bairro = bairro;
            Numero = numero;
            DataFesta = dataFesta;
            HorarioInicio = horarioInicio;
            HorarioTermino = horarioTermino;
        }

        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }
        public DateTime DataFesta { get; set; }
        public TimeSpan HorarioInicio { get; set; }
        public TimeSpan HorarioTermino { get; set; }
    }
}
