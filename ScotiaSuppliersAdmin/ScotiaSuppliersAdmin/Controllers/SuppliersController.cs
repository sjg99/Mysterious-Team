using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ScotiaSuppliersAdmin.Controllers
{
    public class SuppliersController : Controller
    {
        // GET: Suppliers
        private List<Models.supplier> LoadSuppliers()
        {
            List<Models.supplier> sls = new List<Models.supplier>();
            using (Models.scotiasuppliersEntities db = new Models.scotiasuppliersEntities())
            {
                var GetSuppliers = db.suppliers.Where(x => x.SupplierId > 0);
                foreach(var s in GetSuppliers)
                {
                    sls.Add(s);
                }
            }
            return sls;
        }
        public ActionResult Index()
        {
            return View(LoadSuppliers());
        }
    }
}