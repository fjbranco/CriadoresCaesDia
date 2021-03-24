using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CriadoresCaesDia.Models
{
    public class CriadoresCaes{


        /// <summary>
        /// Data de compra do cão
        /// </summary>
        public DateTime DataCompra { get; set; }

        // ******************************************************

        /// <summary>
        /// FK para o Cão do Criador
        /// </summary>
        [ForeignKey(nameof(Cao))]
        public int CaesFK { get; set; }
        public Caes Cao { get; set; }

        /// <summary>
        /// FK para o Criador do Cão
        /// </summary>
        [ForeignKey(nameof(Criador))]
        public int CriadoresFK { get; set; }
        public Criadores Criador { get; set; }
    }
}
