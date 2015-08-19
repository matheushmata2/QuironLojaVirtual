using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
namespace Quiron.LojaVirtual.Dominio.Entidades
{

    public class Produto    
        {
            [Key]
            public int ProductId { get; set; }

            public string Descricao { get; set; }

            public string nome { get; set; }

            public decimal Preco { get; set; }

            public string categoria { get; set; }
        }
}
