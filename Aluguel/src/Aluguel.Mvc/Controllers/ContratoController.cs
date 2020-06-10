using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Aluguel.Data.ORM;
using Aluguel.Dominio.Models;

namespace Aluguel.Mvc.Controllers
{
    public class ContratoController : Controller
    {
        private readonly AluguelDbContext _context;

        public ContratoController(AluguelDbContext context)
        {
            _context = context;
        }

        // GET: Contrato
        public async Task<IActionResult> Index()
        {
            var aluguelDbContext = _context.Contratos.Include(c => c.Imovel).Include(c => c.Locador).Include(c => c.Locatario);
            return View(await aluguelDbContext.ToListAsync());
        }

        // GET: Contrato/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contrato = await _context.Contratos
                .Include(c => c.Imovel)
                .Include(c => c.Locador)
                .Include(c => c.Locatario)
                .FirstOrDefaultAsync(m => m.ContratoId == id);
            if (contrato == null)
            {
                return NotFound();
            }

            return View(contrato);
        }

        // GET: Contrato/Create
        public IActionResult Create()
        {
            ViewData["imovelId"] = new SelectList(_context.Imovels, "ImovelId", "Bairro");
            ViewData["LocadorId"] = new SelectList(_context.Locadores, "LocadorId", "Email");
            ViewData["LocatarioId"] = new SelectList(_context.Locatarios, "LocatarioId", "Email");
            return View();
        }

        // POST: Contrato/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ContratoId,LocadorId,LocatarioId,imovelId,DataContrato,DiaVencimentoAlguel,DataInicio,DataFim,Status")] Contrato contrato)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contrato);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["imovelId"] = new SelectList(_context.Imovels, "ImovelId", "Bairro", contrato.imovelId);
            ViewData["LocadorId"] = new SelectList(_context.Locadores, "LocadorId", "Email", contrato.LocadorId);
            ViewData["LocatarioId"] = new SelectList(_context.Locatarios, "LocatarioId", "Email", contrato.LocatarioId);
            return View(contrato);
        }

        // GET: Contrato/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contrato = await _context.Contratos.FindAsync(id);
            if (contrato == null)
            {
                return NotFound();
            }
            ViewData["imovelId"] = new SelectList(_context.Imovels, "ImovelId", "Bairro", contrato.imovelId);
            ViewData["LocadorId"] = new SelectList(_context.Locadores, "LocadorId", "Email", contrato.LocadorId);
            ViewData["LocatarioId"] = new SelectList(_context.Locatarios, "LocatarioId", "Email", contrato.LocatarioId);
            return View(contrato);
        }

        // POST: Contrato/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ContratoId,LocadorId,LocatarioId,imovelId,DataContrato,DiaVencimentoAlguel,DataInicio,DataFim,Status")] Contrato contrato)
        {
            if (id != contrato.ContratoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contrato);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContratoExists(contrato.ContratoId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["imovelId"] = new SelectList(_context.Imovels, "ImovelId", "Bairro", contrato.imovelId);
            ViewData["LocadorId"] = new SelectList(_context.Locadores, "LocadorId", "Email", contrato.LocadorId);
            ViewData["LocatarioId"] = new SelectList(_context.Locatarios, "LocatarioId", "Email", contrato.LocatarioId);
            return View(contrato);
        }

        // GET: Contrato/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contrato = await _context.Contratos
                .Include(c => c.Imovel)
                .Include(c => c.Locador)
                .Include(c => c.Locatario)
                .FirstOrDefaultAsync(m => m.ContratoId == id);
            if (contrato == null)
            {
                return NotFound();
            }

            return View(contrato);
        }

        // POST: Contrato/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contrato = await _context.Contratos.FindAsync(id);
            _context.Contratos.Remove(contrato);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContratoExists(int id)
        {
            return _context.Contratos.Any(e => e.ContratoId == id);
        }
    }
}
