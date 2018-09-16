using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ScotiaSuppliersAdmin.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        private List<Models.product> LoadProducts()
        {
            List<Models.product> sls = new List<Models.product>();
            int Sid = (int) Session["SID"]; 
            using (Models.scotiasuppliersEntities1 db = new Models.scotiasuppliersEntities1())
            {
                var GetProducts = db.products.Where(x => x.SupplierId.Equals(Sid));
                foreach (var s in GetProducts)
                {
                    sls.Add(s);
                }
            }
            return sls;
        }
        public ActionResult Index()
        {
            return View(LoadProducts());
        }
    }
}