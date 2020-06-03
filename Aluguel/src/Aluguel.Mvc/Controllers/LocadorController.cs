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
    public class LocadorController : Controller
    {
        private readonly AluguelDbContext _context;

        public LocadorController(AluguelDbContext context)
        {
            _context = context;
        }

        // GET: Locador
        public async Task<IActionResult> Index()
        {
            return View(await _context.Locadores.ToListAsync());
        }

        // GET: Locador/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var locador = await _context.Locadores
                .FirstOrDefaultAsync(m => m.LocadorId == id);
            if (locador == null)
            {
                return NotFound();
            }

            return View(locador);
        }

        // GET: Locador/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Locador/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LocadorId,Nome,SobreNome,Cpf,Rg,OrgaoEmissor,Profissao,EstadoCivil,Email,Tel,TelTestemunha")] Locador locador)
        {
            if (ModelState.IsValid)
            {
                _context.Add(locador);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(locador);
        }

        // GET: Locador/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var locador = await _context.Locadores.FindAsync(id);
            if (locador == null)
            {
                return NotFound();
            }
            return View(locador);
        }

        // POST: Locador/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LocadorId,Nome,SobreNome,Cpf,Rg,OrgaoEmissor,Profissao,EstadoCivil,Email,Tel,TelTestemunha")] Locador locador)
        {
            if (id != locador.LocadorId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(locador);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LocadorExists(locador.LocadorId))
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
            return View(locador);
        }

        // GET: Locador/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var locador = await _context.Locadores
                .FirstOrDefaultAsync(m => m.LocadorId == id);
            if (locador == null)
            {
                return NotFound();
            }

            return View(locador);
        }

        // POST: Locador/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var locador = await _context.Locadores.FindAsync(id);
            _context.Locadores.Remove(locador);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LocadorExists(int id)
        {
            return _context.Locadores.Any(e => e.LocadorId == id);
        }
    }
}
