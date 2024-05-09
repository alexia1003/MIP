using Proiect3_MIP.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web.Mvc;

namespace Proiect3_MIP.Controllers
{
    public class ProdusController : Controller
    {
        private MagazinDbContext mdc = new MagazinDbContext();

        // Linq - Vizualizare lista produse
        // foreign key error
        public ActionResult Index()
        {
            // ordonare lista produse dupa pret rescator
            var produsList = mdc.Produse.OrderBy(p => p.Pret).ToList();
            scrieProdusInFisier(produsList);
            return View(produsList);
        }

        // Scriere fisier cu Trace
        private void scrieProdusInFisier(List<Produs> produsList)
        {
            // eroare file path access
            try 
            { 
                string filePath = Server.MapPath("~/App_Data/produsList.txt");

                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    foreach (var produs in produsList)
                    {
                        sw.WriteLine($"ID: {produs.IdProdus}, Nume: {produs.Nume}, Pret: {produs.Pret}");
                    }
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine($"Eroare la scrierea in fisier: {ex.Message}");
            }
        }

        // Vizualizare pagina creare produs nou
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // Creare produs
        [HttpPost]
        public ActionResult Create(Produs produs)
        {
            try
            {
                if (produs != null)
                {
                    // adaugare produs la BD si salvare
                    mdc.Produse.Add(produs);
                    mdc.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    return HttpNotFound();
                }
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index");
            }
        }

    }
}
