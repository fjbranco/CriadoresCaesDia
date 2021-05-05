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

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Id { get; set; }

        public string Nome { get; set; }


        // **************************************
        // identificar os cães que são tratados pelo veterinário
        // vamos ignorar a tabela de relacionamento, como que se não existisse
        public ICollection<Caes> ListaCaesTratadosPeloVeterinario { get; set; }




    }
}
