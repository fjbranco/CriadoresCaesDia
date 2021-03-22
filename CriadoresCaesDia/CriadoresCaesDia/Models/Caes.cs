using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CriadoresCaesDia.Models
{
    /// <summary>
    /// Descrição de cada um dos cães
    /// </summary>
    public class Caes
    {
        /// <summary>
        /// Identificador de cada Cão
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// Nome do Cão
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Sexo do cão
        /// M - Masculino
        /// F - Feminino
        /// </summary>
        public string Sexo { get; set; }

        /// <summary>
        /// Data de nascimento do cão
        /// </summary>
        public DateTime DataNasc { get; set; }
        
        /// <summary>
        /// Data de compra do cão
        /// </summary>
        public DateTime DataCompra { get; set; }

        /// <summary>
        /// Registo do cão no Livro de Origens Português
        /// </summary>
        public string LOP { get; set; }
    }
}
