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
        [Required(ErrorMessage ="O Nome é de preenchimento obrigatório!")] // Anotação required para obrigar a introduzir o nome e não deixar o campo em branco na aplicação
        [StringLength(60, ErrorMessage = "O {0} não pode ter mais de {1} caracteres!")]
        [RegularExpression("([A-ZÁÉÍÓÚÀÈÌÒÙÂÊÎÔÛÄËÏÖÜÃÕÇÑa-záéíóúàèìòùâêîôûäëïöüãõçñ '-]+)+")]
        public string Nome { get; set; }

        /// <summary>
        /// Nome Comercial do criador
        /// </summary>
        [StringLength(20, ErrorMessage = "O {0} não pode ter mais de {1} caracteres!")]
        [RegularExpression("([A-Z]{1}[a-záéíóúàèìòùâêîôûãõç ]+)+")]
        [Display(Name = "Nome Comercial")]
        public string NomeComercial { get; set; }

        /// <summary>
        /// Morada do Criador
        /// </summary>
        [Required(ErrorMessage = "A Morada é de preenchimento obrigatório!")]
        [StringLength(70, ErrorMessage="O {0} não pode ter mais de {1} caracteres!")]
        [RegularExpression("([A-Z]{1}[a-záéíóúàèìòùãõâêîôûç ]*)+[,]?[ ]{1}[Nº]*[0-9]*")] 
        public string Morada { get; set; }

        /// <summary>
        /// Código Postal da Morada do criador
        /// </summary>
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório!")]
        [StringLength(30, MinimumLength =8, ErrorMessage = "O {0} deve ter entre {2} e {1} caracteres!")]
        // [RegularExpression("[0-9]{4}[-]{1}[0-9]{3}[ ][A-Z]{1}[a-z]+[ ]*([A-Z]*){1}[a-z]*")]
        [RegularExpression("[1-9][0-9]{3}[-]{1}[0-9]{3}( [A-Za-z-áéíóúàèìòùâêîôûãõçÁÉÍÓÚÀÈÌÒÒÃÕÇÂÊÎÔÛ]+)*", ErrorMessage = "O {0} deve ter o formato 0000-000 e pode ter a localidade.")]
        [Display(Name ="Código Postal")]
        public string CodPostal { get; set; }

        /// <summary>
        /// número de telemóvel do criador
        /// </summary>
        [StringLength(14, MinimumLength =9,ErrorMessage ="Introduza o {0} com {1} dígitos, por favor!")]
        [RegularExpression("((00)?([0-9]{2,3})[1-9][0-9]{8})", ErrorMessage ="Escreva por favor um número de {0} válido com 9 algarismos. Se quiseres poder pode acrescentar o indicativo nacional e internacional.")]
        [Display(Name = "Telemovel")]
        public string Telemovel { get; set; } // ou se escreve o telemóvel ou email ou os dois

        /// <summary>
        /// Email do Criador
        /// </summary>
        [StringLength(50,ErrorMessage ="O {0} não pode ter mais de {1} caracteres!")]
        [EmailAddress(ErrorMessage ="O {0} não é válido!")]
        [RegularExpression("((((aluno)|(es((tt)|(ta)|(gt))))[0-9]{4,5})|([a-z]+(.[a-z]+)*))@ipt.pt", ErrorMessage = "Só são aceites emails do IPT!")]
        public string Email { get; set; } // ou se escreve o telemóvel ou email ou os dois

        // ###########################################

        // lista de Cães associados ao Criador
        /// <summary>
        /// lista de cães associados ao criador
        /// </summary>        
        public ICollection<CriadoresCaes> ListadeCaes { get; set; }

    }
}
