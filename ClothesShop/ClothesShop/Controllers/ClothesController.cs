using ClothesShop.DatabaseContext;
using ClothesShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ClothesShop.Controllers
{
    public class ClothesController : Controller
    {
        private BaseContext db = new BaseContext();
        // GET: Clothes
        public ActionResult Index()
        {
            List<Clothe> clothes = db.Clothes.OrderBy(x => x.Name).ToList();
            return View(clothes);
        }

        //GET: Clothes/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Clothe clothe = db.Clothes.Find(id);
            if (clothe == null)
            {
                return HttpNotFound();
            }
            return View(clothe);
        }

        public ActionResult AddToCart(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Clothe clothe = db.Clothes.Find(id);
            if (clothe == null)
            {
                return HttpNotFound();
            }
            var shoppingCart = db.ShoppingCarts.OrderByDescending(x => x.DateCreated).Where(s => s.Paid == false).FirstOrDefault();
            if (shoppingCart == null)
            {
                shoppingCart = db.ShoppingCarts.Add(new ShoppingCart());
            }
            shoppingCart.AddToCart(clothe);
            db.SaveChanges();
            //return RedirectToAction("Index", "ShoppingCarts");
            return RedirectToAction("Details", "ShoppingCart", new { id = shoppingCart.Id });
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }


}
