using CriadoresCaesDia.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CriadoresCaesDia.Data {
    /// <summary>
    /// Esta classe representa a Base de Dados a ser utilizada neste projecto de Criadores de Cães
    /// </summary>    
    public class CriadoresCaesDB:DbContext {
        // construtor da classe CriadoresCaesDB
        // indicar onde está a BD à qual estas classes (tabelas) serão associadas
        // ver o conteúdo do ficheiro startup.cs
        public CriadoresCaesDB(DbContextOptions<CriadoresCaesDB> options):base(options) {

        }
        
        // Representar as Tabelas da BD
        public DbSet<Criadores> Criadores { get; set; }
        public DbSet<Caes> Caes { get; set; }
        public DbSet<Racas> Racas { get; set; }
        public DbSet<Fotografias> Fotografias { get; set; }
        public DbSet<CriadoresCaes> CriadoresCaes { get; set; }
    }
}
