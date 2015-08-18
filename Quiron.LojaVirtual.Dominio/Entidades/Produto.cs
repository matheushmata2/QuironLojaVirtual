using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiron.LojaVirtual.Dominio.Entidades
{
    class Produto
    {
        public int Produtoid { get; set;}

        public string Descricao { get; set; }

        public string nome { get; set; }

        public decimal Preco { get; set; }

        public string categoria { get; set; }
    }
}
