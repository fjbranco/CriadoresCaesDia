using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CriadoresCaesDia.Data;
using CriadoresCaesDia.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace CriadoresCaesDia.Controllers {
    public class FotografiasController : Controller {
        /// <summary>
        /// este atributo representa a base de dados do projecto
        /// </summary>
        private readonly CriadoresCaesDB _context;

        /// <summary>
        /// este atributo
        /// </summary>
        private readonly IWebHostEnvironment _caminho;
        public FotografiasController(CriadoresCaesDB context,
            IWebHostEnvironment _caminho) {
            _context = context;
            this._caminho = _caminho;
        }

        // GET: Fotografias
        public async Task<IActionResult> Index() {
            // criação de uma variável que vai conter um conjunto de dados
            // vindos da base de dados
            // se fosse em SQL, a pesquisa seria:
            // SELECT *
            //  FROM Fotografias f, Caes c
            //  WHERE f.CaoFK = c.Id
            // exactamente equivalente a _context.Fotografias.Include(f => f.Cao);
            // f =>f.Cao <---------- expressão 'lambda'
            // ^  ^  ^
            // |  |  |
            // |  |  |
            // |  |  representa cada um dos registo individuais da tabela  das fotografias
            // |  |  e associa a cada fotografia o seu respectivo cao
            // |  |  equivalente à parte WHERE do comando SQL
            // |  |
            // |  um símbolo que separa os ramos da expressão
            // | 
            // representa todos os registos das fotografias
            var fotografias = _context.Fotografias.Include(f => f.Cao);
            // invoca a View, entregando-lhe a lista de registos
            return View(await fotografias.ToListAsync());
        }

        // GET: Fotografias/Details/5
        /// <summary>
        /// mostra os detalhes de uma fotografia
        /// </summary>
        /// <param name="id">identifcador da fotografia</param>
        /// <returns></returns>
        public async Task<IActionResult> Details(int? id) {
            if (id == null) {
                // entro aqui se não foi espeificado o ID
                // redirecionar para a página de inicio
                return RedirectToAction("Index");
                //return NotFound();
            }

            // se chego aqui, foi especificado um ID
            // vou procurar se existe uma fotografia com esse valor
            var fotografia = await _context.Fotografias
                .Include(f => f.Cao)
                .FirstOrDefaultAsync(f => f.Id == id);
            if (fotografia == null) {
                // o ID especificado não corresponde a uma fotografia
                // redirecionar para a página de inicio
                return RedirectToAction("Index");
                //return NotFound();
            }
            // se cheguei aqui é porque a fotogtafia existe e foi encontrada
            // então, mostro-a na View
            return View(fotografia);
        }

        // GET: Fotografias/Create
        [HttpGet]  // por omissão responde ao GET, não era necessária esta linha
        /// <sumary>
        /// invoca , na primeira vez, a View com os dados da criação de uma fotografia
        /// <sumary>
        /// <returns></returns>
        public IActionResult Create() {
            /* geração da lista de valores disponível na Dropdown
             * o ViewData transporta dados a serem associados ao atributo "CaoFK"
             * o SelectList é um tipo de dados especial que serve para armazenar a lista
             * de opções de um objecto do tipo <SELECT> do HTML
             * contém dois calores: ID + nome a sr apresentado no ecrã
             * _context.Caes -> representa a fonte dos dados
             *                  na prática estamos a executar o comando sql
             *                  SELECT * FROM Caes
             *                  ORDER BY Nome (acrescentar para a pesquisa a significar)
             *                  e fica: _context.Caes.OrderBy(c=>c.Nome)
            */
            ViewData["CaoFK"] = new SelectList(_context.Caes.OrderBy(c => c.Nome), "Id", "Nome");
            return View();
        }

        // POST: Fotografias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DataFoto,LocalFoto,CaoFK")] Fotografias photo, IFormFile fotoCao) {


            // avaliar se o utilizador escolheu uma opção válida na dropdown do cão
            if (photo.CaoFK < 0) {
            
                // não foi escolhido um cão válido
                ModelState.AddModelError("", "Não se esqueça de escolher um cão!");

                //devolver o controlo à View
                ViewData["CaoFK"] = new SelectList(_context.Caes.OrderBy(c => c.Nome), "Id", "Nome", photo.CaoFK);
                return View(photo);
            }

            /* processar o ficheiro
             *  - existe ficheiro?
             *    - se não existe ficheiro, o que fazer?
             *      - gerar uma mensagem de erro, e devolver o controlo à View
             *    - senão continua, porque o ficheiro existe
             *      - mas é do tipo correcto?
             *        - avaliar se é imagem
             *          - se sim: - especificar novo nome do ficheiro
             *                    - especificar a localização
             *                    - associar ao objecto "photo", o nome deste ficheiro
             *                    - guardar o ficheiro no disco do servidor
             *          - se não: gerar uma mensagem de erro, e devolver o controlo à View
            */


            // definir o novo nome da fotografia do cão
            string nomeImagem = "";

            if (fotoCao == null) {
                // não há ficheiro
                // adicionar msg de erro
                ModelState.AddModelError("", "Adicione, por favor, uma fotografia do cão");

                // devolver o controlo à view
                ViewData["CaoFK"] = new SelectList(_context.Caes.OrderBy(c => c.Nome), "Id", "Nome"/*,photo.CaoFK*/);
                return View(photo);
            } else {
                // há ficheiro, mas é um ficheiro válido?
                // link mime types
                if (fotoCao.ContentType == "image/jpeg" || fotoCao.ContentType == "image/png") {
                    Guid g;
                    g = Guid.NewGuid();
                    nomeImagem = photo.CaoFK + "_" + g.ToString();
                    //determinara extensão do nome da imagem
                    string extensao = Path.GetExtension(fotoCao.FileName).ToLower();
                    // agora sim, consjigo ter o nome final do ficheiro
                    nomeImagem += extensao;

                    // associar este ficheiro aos dados da fotogrqfia do cão
                    photo.Fotografia = nomeImagem;

                    // especificar a localização do armazenamento da imagem
                    string localizacaoFicheiro = _caminho.WebRootPath;
                    nomeImagem = Path.Combine(localizacaoFicheiro, "fotos", nomeImagem);


                } else {
                    // não há ficheiro
                    // adicionar msg de erro
                    ModelState.AddModelError("", "Só pode escolher uma imagem para associar ao cão");

                    // devolver o controlo à view
                    ViewData["CaoFK"] = new SelectList(_context.Caes.OrderBy(c => c.Nome), "Id", "Nome"/*,photo.CaoFK*/);
                    return View(photo);
                }

            }

            if (ModelState.IsValid) {
                try {
                    //adicionar os dados da novav fotografia à base de dados    
                    _context.Add(photo);
                    // consolidar os dados na base de dados
                    await _context.SaveChangesAsync();
                    // se cheguei aqui, tudo correu bem
                    // vou guardar, agora, no disco do  servidor a imagem
                    using var stream = new FileStream(nomeImagem, FileMode.Create);
                    await fotoCao.CopyToAsync(stream);
                    return RedirectToAction(nameof(Index));
                } catch (Exception /*ex*/) {
                    ModelState.AddModelError("", "Ocorreu um erro fatal!!!");
                    /*Console.WriteLine(ex);   */
                }

            }

            // devolver o controlo à view
            ViewData["CaoFK"] = new SelectList(_context.Caes.OrderBy(c => c.Nome), "Id", "Nome"/*,photo.CaoFK*/);
            return View(photo);
        }

        // GET: Fotografias/Edit/5
        public async Task<IActionResult> Edit(int? id) {
            if (id == null) {
                return NotFound();
            }

            var fotografias = await _context.Fotografias.FindAsync(id);
            if (fotografias == null) {
                return NotFound();
            }
            ViewData["CaoFK"] = new SelectList(_context.Caes, "Id", "Id", fotografias.CaoFK);
            return View(fotografias);
        }

        // POST: Fotografias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Fotografia,DataFoto,LocalFoto,CaoFK")] Fotografias fotografias) {
            if (id != fotografias.Id) {
                return NotFound();
            }

            if (ModelState.IsValid) {
                try {
                    _context.Update(fotografias);
                    await _context.SaveChangesAsync();
                } catch (DbUpdateConcurrencyException) {
                    if (!FotografiasExists(fotografias.Id)) {
                        return NotFound();
                    } else {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CaoFK"] = new SelectList(_context.Caes, "Id", "Id", fotografias.CaoFK);
            return View(fotografias);
        }

        // GET: Fotografias/Delete/5
        public async Task<IActionResult> Delete(int? id) {
            if (id == null) {
                return NotFound();
            }

            var fotografias = await _context.Fotografias
                .Include(f => f.Cao)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (fotografias == null) {
                return NotFound();
            }

            return View(fotografias);
        }

        // POST: Fotografias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id) {
            var fotografias = await _context.Fotografias.FindAsync(id);
            try {
                // proteger a eliminação de uma fotografia
                _context.Fotografias.Remove(fotografias);
                await _context.SaveChangesAsync();
                // não esquecer de apagar o ficheiro da fotografia do disco
            } catch (Exception) {

                throw;
            }
            return RedirectToAction(nameof(Index));
        }

        private bool FotografiasExists(int id) {
            return _context.Fotografias.Any(e => e.Id == id);
        }
    }
}
