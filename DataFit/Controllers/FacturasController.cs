using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataFit.DataBase.Contexts;
using DataFit.DataBase.Models;
using DataFit.Core.Factura;

namespace DataFit.Site.Controllers
{
    public class FacturasController : Controller
    {
        private readonly DataFitDbContext _context;

        private readonly IFacturasManager facturasManager;

        public FacturasController(IFacturasManager facturasManager)
        {
            this.facturasManager = facturasManager;
            
        }

        // GET: Facturas
        public async Task<IActionResult> Index()
        {
            var c = await this.facturasManager.GetAllAsync();
            return View(c);
        }

        // GET: Facturas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var facturas = await facturasManager.FindByIdAsync(id.Value);
            if (facturas == null)
            {
                return NotFound();
            }
            return View(facturas);
        }

        // GET: Facturas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Facturas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Total,Subtotal,FechaCreacion,ClienteId")] Facturas facturas)
        {
            if (ModelState.IsValid)
            {
                await facturasManager.CreateAsync(facturas);

                return RedirectToAction(nameof(Index));
            }

            return View(facturas);
        }

        // GET: Facturas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var facturas = await facturasManager.FindByIdAsync(id.Value);
            if (facturas == null)
            {
                return NotFound();
            }
            return View(facturas);
        }

        // POST: Facturas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Total,Subtotal,FechaCreacion,ClienteId")] Facturas facturas)
        {
            if (id != facturas.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {

                    await facturasManager.EditAsync(facturas);
                }
                catch (DbUpdateConcurrencyException)
                {
                    var t = await facturasManager.FindByIdAsync(id);

                    if (t == null)
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
            return View(facturas);
        }

        // GET: Facturas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var facturas = await facturasManager.FindByIdAsync(id.Value);
            if (facturas == null)
            {
                return NotFound();
            }
            return View(facturas);
        }

        // POST: Facturas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var facturas = await facturasManager.FindByIdAsync(id);
            await facturasManager.DeleteAsync(facturas);
            return RedirectToAction(nameof(Index));
        }

        //private bool FacturasExists(int id)
        //{
        //    return _context.Facturas.Any(e => e.Id == id);
        //}
    }
}
