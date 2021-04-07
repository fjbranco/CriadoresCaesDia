using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CriadoresCaesDia.Models
{
    /// <summary>
    /// Descrição dos Criadores
    /// </summary>
    public class Criadores
    {
        
        public Criadores() {
            // inicializar a lista de cães do criador
            ListadeCaes = new HashSet<CriadoresCaes>();
        }

        /// <summary>
        /// Identificador de cada Criador
        /// </summary>
        [Key] // identifica este atributo como chave primária
        public int Id { get; set; }
        /// <summary>
        /// Nome do criador
        /// </summary>
        
        public string Nome { get; set; }
        /// <summary>
        /// Nome Comercial do criador
        /// </summary>
        
        public string NomeComercial { get; set; }
        /// <summary>
        /// Morada do Criador
        /// </summary>
        
        public string morada { get; set; }
        /// <summary>
        /// Código Postal da morada do criador
        /// </summary>
        
        public string CodPostal { get; set; }
        /// <summary>
        /// número de telemóvel do criador
        /// </summary>
        public string Telemóvel { get; set; }

        /// <summary>
        /// Email do Criador
        /// </summary>
        public string Email { get; set; }

        // ###########################################

        // lista de Cães associados ao Criador
        /// <summary>
        /// lista de cães associados ao criador
        /// </summary>        
        public ICollection<CriadoresCaes> ListadeCaes { get; set; }

    }
}
