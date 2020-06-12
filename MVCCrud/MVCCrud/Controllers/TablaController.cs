using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCCrud.Controllers;
using MVCCrud.Models;
using MVCCrud.Models.ViewModels;

namespace MVCCrud.Controllers
{
    public class TablaController : Controller
    {
        // GET: Tabla
        public ActionResult Index()
        {
            List<ListTablaViewModel> lst;
            using (CrudEntities db = new CrudEntities())
            {
                lst = (from d in db.Tabla
                       select new ListTablaViewModel
                       {
                           Id = d.id,
                           Nombre = d.correo,
                           Correo = d.correo
                       }).ToList();
            }
            return View(lst);
        }
    }
}