using Proiect3_MIP.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using System.Xml.Linq;

namespace Proiect3_MIP.Controllers
{
    public class CumparareController : Controller
    {
        private MagazinDbContext mdc = new MagazinDbContext();

        // Lista de cumparaturi realizate
        public ActionResult Index()
        {
            var cump = mdc.Cumparaturi.Include(c => c.Produse).ToList();
            return View(cump);
        }

        // Vizualizare pagina creare lista de cumparaturi
        [HttpGet]
        public ActionResult Create()
        {
            var view = new Cumparare
            {
                // lista produse din DB pt. cumparare
                Produse = mdc.Produse.ToList()
            };
            return View(view);
        }

        // Creare lista de cumparaturi
        [HttpPost]
        public ActionResult Create(Cumparare view)
        {
            try
            {
                // Nu e valid -> return lista Produse
                if (!ModelState.IsValid)
                {
                    view.Produse = mdc.Produse.ToList();
                    return View(view);
                }

                // gasire produs cu Id cautat
                var product = mdc.Produse.Find(view.ProdusId);

                // creare obiect Cumparare
                var cump = new Cumparare
                {
                    NumeUser = view.NumeUser,
                    DataComanda = DateTime.Now,
                    Cantitate = view.Cantitate,
                    ProdusId = view.ProdusId
                };

                // adaugare la BD si salvare
                mdc.Cumparaturi.Add(cump);
                mdc.SaveChanges();

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Home");
            }
        }

        // Scrie comenzi in fisier xml
        public ActionResult ScrieComenziInXML()
        {
            try
            {
                var orders = mdc.Cumparaturi.Include(c => c.Produse).ToList();

                // Creare fisier xml
                XDocument xmlDocument = new XDocument(
                    new XElement("Orders",
                        from order in orders
                        select new XElement("Order",
                            new XElement("NumeUser", order.NumeUser),
                            new XElement("DataComanda", order.DataComanda),
                            new  XElement("Cantitate", order.Cantitate),
                            new XElement("ProdusId", order.ProdusId)
                        )
                    )
                );

                // eroare file path access
                string filePath = Server.MapPath("~/App_Data/orders.xml");

                xmlDocument.Save(filePath);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Home");
            }
        }


    }
}