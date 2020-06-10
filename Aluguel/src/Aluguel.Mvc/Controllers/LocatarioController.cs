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
    public class LocatarioController : Controller
    {
        private readonly AluguelDbContext _context;

        public LocatarioController(AluguelDbContext context)
        {
            _context = context;
        }

        // GET: Locatario
        public async Task<IActionResult> Index()
        {
            return View(await _context.Locatarios.ToListAsync());
        }

        // GET: Locatario/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var locatario = await _context.Locatarios
                .FirstOrDefaultAsync(m => m.LocatarioId == id);
            if (locatario == null)
            {
                return NotFound();
            }

            return View(locatario);
        }

        // GET: Locatario/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Locatario/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LocatarioId,Status,Nome,SobreNome,Cpf,Rg,OrgaoEmissor,Profissao,EstadoCivil,Email,Tel,TelTestemunha")] Locatario locatario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(locatario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(locatario);
        }

        // GET: Locatario/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var locatario = await _context.Locatarios.FindAsync(id);
            if (locatario == null)
            {
                return NotFound();
            }
            return View(locatario);
        }

        // POST: Locatario/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LocatarioId,Status,Nome,SobreNome,Cpf,Rg,OrgaoEmissor,Profissao,EstadoCivil,Email,Tel,TelTestemunha")] Locatario locatario)
        {
            if (id != locatario.LocatarioId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(locatario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LocatarioExists(locatario.LocatarioId))
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
            return View(locatario);
        }

        // GET: Locatario/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var locatario = await _context.Locatarios
                .FirstOrDefaultAsync(m => m.LocatarioId == id);
            if (locatario == null)
            {
                return NotFound();
            }

            return View(locatario);
        }

        // POST: Locatario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var locatario = await _context.Locatarios.FindAsync(id);
            _context.Locatarios.Remove(locatario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LocatarioExists(int id)
        {
            return _context.Locatarios.Any(e => e.LocatarioId == id);
        }
    }
}
