using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataFit.DataBase.Contexts;
using DataFit.DataBase.Models;
using DataFit.Core.Clientes;

namespace DataFit.Site.Controllers
{
    public class ClientesController : Controller
    {
        //private readonly DataFitDbContext _context;
    
        private readonly IClientesManager clientesManager;
      

        public ClientesController( IClientesManager clientesManager)
        {
            this.clientesManager = clientesManager;
        }

        // GET: Clientes
        public async Task<IActionResult> Index()
        {
            var c = await this.clientesManager.GetAllAsync();
            return View(c);
        }

        // GET: Clientes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientes = await clientesManager.FindByIdAsync(id.Value);
            if (clientes == null)
            {
                return NotFound();
            }

            return View(clientes);
        }

        // GET: Clientes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Dirrecion,Telefono,FechaCreacion")] Clientes clientes)
        {
            if (ModelState.IsValid)
            {
                await clientesManager.CreateAsync(clientes);
                
                return RedirectToAction(nameof(Index));
            }
            return View(clientes);
        }

        // GET: Clientes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientes = await clientesManager.FindByIdAsync(id.Value); 
            if (clientes == null)
            {
                return NotFound();
            }
            return View(clientes);
        }

        // POST: Clientes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Dirrecion,Telefono,FechaCreacion")] Clientes clientes)
        {
            if (id != clientes.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {

                    await clientesManager.EditAsync(clientes);
                }
                catch (DbUpdateConcurrencyException)
                {
                    var t = await clientesManager.FindByIdAsync(id);
                   
                    if ( t == null) 
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
            return View(clientes);
        }

        // GET: Clientes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientes = await clientesManager.FindByIdAsync(id.Value);
            if (clientes == null)
            {
                return NotFound();
            }

            return View(clientes);
        }

        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var clientes =  await clientesManager.FindByIdAsync(id);
            await clientesManager.DeleteAsync(clientes);
            return RedirectToAction(nameof(Index));
        }

       
    }
}
