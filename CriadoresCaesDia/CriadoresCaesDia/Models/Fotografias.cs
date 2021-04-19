using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CriadoresCaesDia.Models
{
    /// <summary>
    /// Fotografias referentes a cada cão
    /// </summary>
    public class Fotografias
    {
        /// <summary>
        /// Identificador da fotografia
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Fotografia do Cão
        /// </summary>
        public string Fotografia { get; set; } // a ser corrigido o tipo de atributo

        /// <summary>
        /// Data da fotografia
        /// </summary>
        //[Display(Name ="")]
        public DateTime DataFoto { get; set; }

        /// <summary>
        /// Local onde foi tirada a  fotografia
        /// </summary>
        public string LocalFoto { get; set; }

        // ********************************************

        // criação da FK que referencia o Cão ao qual a fotografia pertence
        /// <summary>
        /// FK para os Caes da Fotografia
        /// </summary>
        [ForeignKey(nameof(Cao))]
        public int CaoFK { get; set; }
        public Caes Cao { get; set; }

    }
}
