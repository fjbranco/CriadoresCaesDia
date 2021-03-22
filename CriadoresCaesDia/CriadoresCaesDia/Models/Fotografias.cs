using System;
using System.Collections.Generic;
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
        public int Id { get; set; }

        /// <summary>
        /// Fotografia do Cão
        /// </summary>
        public int Fotografia { get; set; } // a ser corrigido o tipo de atributo

        /// <summary>
        /// Data da fotografia
        /// </summary>
        public DateTime DataFoto { get; set; }

        /// <summary>
        /// Local onde foi tirada a  fotografia
        /// </summary>
        public string LocalFoto { get; set; }
    }
}
