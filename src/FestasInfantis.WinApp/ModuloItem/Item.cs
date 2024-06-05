using FestasInfantis.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestasInfantis.WinApp.ModuloItem
{
    public class Item : EntidadeBase
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        //public Tema Tema { get; set; }
        public Item(string descricao, decimal valor)
        {
            Descricao = descricao;
            Valor = valor;
        }
        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Item atualizado = (Item)novoRegistro;

            Descricao = atualizado.Descricao;
            Valor = atualizado.Valor;
        }
        public override List<string> Validar()
        {
            List<string> erros = [];
            return erros;
        }
    }
}