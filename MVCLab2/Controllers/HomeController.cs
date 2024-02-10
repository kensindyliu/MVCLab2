using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCLab2.Models;

namespace MVCLab2.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        InventoryManage im = new();
        return View(im.GetAllProducts());
    }

    public IActionResult Delete(int ProductID)
    {
        InventoryManage im = new();
        im.Delete(ProductID);
        return RedirectToAction("Index");
    }

    public IActionResult AddProduct(string ProductName, string Price, string Description, string Quantity)
    {
        InventoryManage im = new();
        im.AddProduct(ProductName, Price, Description, Quantity);
        return RedirectToAction("index");
    }


    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

