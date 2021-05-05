using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CriadoresCaesDia.Models {
    
    /// <summary>
    /// dados dos veterinários que tratam os cães
    /// um cão pode ser tratado por muitos veterinários
    /// um veterinário pode tratar muitos cães
    /// </summary>
    public class Veterinarios {
        
        public Veterinarios() {
            ListaCaesTratadosPeloVeterinario = new HashSet<Caes>();
        }

        /// <summary>
        /// identificador do veterinário
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Id { get; set; }

        /// <summary>
        /// Nome do veterinário
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// montante cobrado pelo veterinário pela consulta
        /// </summary>
        public decimal? Honorarios { get; set; }

        /// <summary>
        /// atributo auxiliar para receber o valor dos honorários
        /// </summary>
        [NotMapped]
        [Required]
        [Display(Name ="honorários")]
        [RegularExpression("[0-9]+[.,]?[0-9]{0,2}")] // formata a textbox para só aceitar valores decimais
        public string HonorarioAux { get; set; }


        // **************************************
        // identificar os cães que são tratados pelo veterinário
        // vamos ignorar a tabela de relacionamento, como que se não existisse
        public ICollection<Caes> ListaCaesTratadosPeloVeterinario { get; set; }




    }
}
