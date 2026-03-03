using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EFCoreMVCWebDEmo.Models;

namespace EFCoreMVCWebDEmo.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly LPUTrialDbDbContext _context;

        public EmployeeController(LPUTrialDbDbContext context)
        {
            _context = context;
        }

        // GET: EmployeeVMs
        public async Task<IActionResult> Index()
        {
            return View(await _context.EmployeeVM.ToListAsync());
        }

        // GET: EmployeeVMs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeVM = await _context.EmployeeVM
                .FirstOrDefaultAsync(m => m.EmpID == id);
            if (employeeVM == null)
            {
                return NotFound();
            }

            return View(employeeVM);
        }

        // GET: EmployeeVMs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EmployeeVMs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EmpID,Name,Age,Address,DeptId")] EmployeeVM employeeVM)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employeeVM);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employeeVM);
        }

        // GET: EmployeeVMs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeVM = await _context.EmployeeVM.FindAsync(id);
            if (employeeVM == null)
            {
                return NotFound();
            }
            return View(employeeVM);
        }

        // POST: EmployeeVMs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EmpID,Name,Age,Address,DeptId")] EmployeeVM employeeVM)
        {
            if (id != employeeVM.EmpID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employeeVM);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeVMExists(employeeVM.EmpID))
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
            return View(employeeVM);
        }

        // GET: EmployeeVMs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeVM = await _context.EmployeeVM
                .FirstOrDefaultAsync(m => m.EmpID == id);
            if (employeeVM == null)
            {
                return NotFound();
            }

            return View(employeeVM);
        }

        // POST: EmployeeVMs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employeeVM = await _context.EmployeeVM.FindAsync(id);
            if (employeeVM != null)
            {
                _context.EmployeeVM.Remove(employeeVM);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeVMExists(int id)
        {
            return _context.EmployeeVM.Any(e => e.EmpID == id);
        }
    }
}
