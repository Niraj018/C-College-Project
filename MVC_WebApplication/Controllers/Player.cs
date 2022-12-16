using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_WebApplication.Data;
using MVC_WebApplication.Models;

namespace MVC_WebApplication.Controllers
{
    public class Player : Controller
    {
        private readonly MVC_WebApplicationContext _context;

        public Player(MVC_WebApplicationContext context)
        {
            _context = context;
        }

        // GET: Player
        public async Task<IActionResult> Index()
        {
              return View(await _context.players.ToListAsync());
        }

        // GET: Player/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.players == null)
            {
                return NotFound();
            }

            var player = await _context.players
                .FirstOrDefaultAsync(m => m.id == id);
            if (player == null)
            {
                return NotFound();
            }

            return View(player);
        }

        // GET: Player/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Player/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,Name,Position,Jno,Cid")] Player player)
        {
            if (ModelState.IsValid)
            {
                _context.Add(player);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(player);
        }

        // GET: Player/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.players == null)
            {
                return NotFound();
            }

            var player = await _context.players.FindAsync(id);
            if (player == null)
            {
                return NotFound();
            }
            return View(player);
        }

        // POST: Player/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Name,Position,Jno,Cid")] Player player)
        {
            if (id != player.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(player);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlayerExists(player.id))
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
            return View(player);
        }

        // GET: Player/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.players == null)
            {
                return NotFound();
            }

            var player = await _context.players
                .FirstOrDefaultAsync(m => m.id == id);
            if (player == null)
            {
                return NotFound();
            }

            return View(player);
        }

        // POST: Player/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.players == null)
            {
                return Problem("Entity set 'MVC_WebApplicationContext.players'  is null.");
            }
            var player = await _context.players.FindAsync(id);
            if (player != null)
            {
                _context.players.Remove(player);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlayerExists(int id)
        {
          return _context.players.Any(e => e.id == id);
        }
    }
}
