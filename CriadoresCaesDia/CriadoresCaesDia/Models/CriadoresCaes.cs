using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CriadoresCaesDia.Models
{
    public class CriadoresCaes{

        /// <summary>
        /// PK para a tabela do relacionamento entre Cães e criadores
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Data de compra do cão
        /// </summary>
        public DateTime DataCompra { get; set; }

        // ******************************************************

        /// <summary>
        /// FK para o Cão do Criador
        /// </summary>
        //[Key, Column(Order = 1)]
        [ForeignKey(nameof(Cao))]
        public int CaesFK { get; set; }
        public Caes Cao { get; set; }

        /// <summary>
        /// FK para o Criador do Cão
        /// </summary>
        //[Key, Column(Order = 2)]
        //[Key]
        //[Column(Order = 2)]
        [ForeignKey(nameof(Criador))]
        public int CriadoresFK { get; set; }
        public Criadores Criador { get; set; }
    }
}
