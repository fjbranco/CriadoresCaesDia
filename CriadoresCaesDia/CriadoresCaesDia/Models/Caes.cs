using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        /// descrição de cada um dos cães do criador
        /// </summary>
        public Caes() {
            // inicializar a lista de fotografias para cada um dos cães
            ListaDeFotografias = new HashSet<Fotografias>();

            // inicializar a lista de criadores do cão
            ListaCriadores = new HashSet<CriadoresCaes>();

            ListadeVeterinariosQueTrataramOCao = new HashSet<Veterinarios>();
        }

        /// <summary>
        /// Identificador de cada Cão
        /// </summary>
        [Key]
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
        /// Registo do cão no Livro de Origens Português
        /// </summary>
        public string LOP { get; set; }

        // ***************************************

        /// <summary>
        /// FK para a Raça do Cão
        /// </summary>
        [ForeignKey(nameof(Raca))] // esta anotação indica que o atributo RacaFK está a executar o mesmo que o atributo Raca, e que representa uma FK para a classe Raca 
        public int RacaFK { get; set; } // atributo para ser usado no SGDB e no C#. Representa a FK para a Raça  do Cão 
        public Racas Raca { get; set; } // atributo para ser usado no C#. Representa a FK para a Raça  do Cão  

        /* Se estivéssemos a criar a tabela Caes em SQL
        CREATE TABLE Caes (
            Id INT PRIMARY KEY,
            Nome VARCHAR(30) NOT NULL,
            ...    
        LOP VARCHAR(20),
        RacaFK INT NOT NULL,
        FOREIGN KEY (RacaFK) REFERENCES Racas(Id)
            
        )
         */

        // ##########################################

        // associar os cães às suas fotografias
        /// <summary>
        /// Lista das fotografias do cão
        /// </summary>
        public ICollection<Fotografias> ListaDeFotografias { get; set; }

        // ##########################################

        // associar os cães aos seus criadores
        /// <summary>
        /// Lista dos Criadores associados ao cão
        /// </summary>
        public ICollection<CriadoresCaes> ListaCriadores { get; set; }



        // ********************************************
        // ********************************************
        // Associar os Cães aos Veterinários
        // à semelhança do executado na classe dos veterinários
        // vamos ignorar a tabela do relacionamento N-M
        // ********************************************
        public ICollection<Veterinarios> ListadeVeterinariosQueTrataramOCao { get; set; }
        // ********************************************

    }
}
