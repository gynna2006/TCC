using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LuNascimento.Data;
using Microsoft.EntityFrameworkCore;

namespace LuNascimento.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppDbContext _context;

    public HomeController(ILogger<HomeController> logger, AppDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Products()
    {
        var aromatizantes = _context.Produtos.Where(p => p.CategoriaId == 1).ToList();
        return View(aromatizantes);
    }

    public IActionResult Aromas()
    {
        return View();
    }
    public IActionResult Exclusivos()
    {
        return View();
    }
    public IActionResult Aromaterapia()
    {
        return View();
    }
    
    public IActionResult Outros()
    {
        var outros = _context.Produtos.Where(p => p.CategoriaId != 1).ToList();
        return View(outros);
    }

    public IActionResult QuemSomos()
    {
        return View();
    }
    public IActionResult Detalhes()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View("Error!");
    }
}
