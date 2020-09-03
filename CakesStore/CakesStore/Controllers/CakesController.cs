using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CakesStore.Data;
using CakesStore.Models;

namespace CakesStore.Controllers
{
    public class CakesController : Controller
    {
        private readonly AppDbContext _context;

        public CakesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Cakes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Cakes.ToListAsync());
        }
    }
}
