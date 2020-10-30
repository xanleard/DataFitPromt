using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataFit.DataBase.Contexts;
using DataFit.DataBase.Models;
using DataFit.Core.Productos;

namespace DataFit.Site.Controllers
{
    public class ProductosController : Controller
    {
        //private readonly DataFitDbContext _context;

        private readonly IProductosManager productoManager;

        public ProductosController(IProductosManager productoManager)
        {
            this.productoManager = productoManager;
        }

        // GET: Productos
        public async Task<IActionResult> Index()
        {
            var c = await this.productoManager.GetAllAsync();
            return View(c);
        }

        // GET: Productos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productos = await productoManager.FindByIdAsync(id.Value);
            if (productos == null)
            {
                return NotFound();
            }

            return View(productos);
        }

        // GET: Productos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Productos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Descripcion,PrecioReal,PrecioVenta,FechaCreacion,FechaModificacion")] Productos productos)
        {

            if (ModelState.IsValid)
            {
                await productoManager.CreateAsync(productos);

                return RedirectToAction(nameof(Index));
            }
            return View(productos);
        }

        // GET: Productos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productos = await productoManager.FindByIdAsync(id.Value);
            if (productos == null)
            {
                return NotFound();
            }
            return View(productos);
        }

        // POST: Productos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Descripcion,PrecioReal,PrecioVenta,FechaCreacion,FechaModificacion")] Productos productos)
        {
            if (id != productos.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {

                    await productoManager.EditAsync(productos);
                }
                catch (DbUpdateConcurrencyException)
                {
                    var t = await productoManager.FindByIdAsync(id);

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
            return View(productos);
        }

        // GET: Productos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientes = await productoManager.FindByIdAsync(id.Value);
            if (clientes == null)
            {
                return NotFound();
            }

            return View(clientes);
        }

        // POST: Productos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var productos = await productoManager.FindByIdAsync(id);
            await productoManager.DeleteAsync(productos);
            return RedirectToAction(nameof(Index));
        }      
    }
}
