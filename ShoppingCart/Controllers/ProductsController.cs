using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ShoppingCart;

namespace ShoppingCart.Controllers
{
    public class ProductsController : Controller
    {
        private ShoppingCartEntities db = new ShoppingCartEntities();

        // GET: Products
        public ActionResult Index()
        {
            var product = db.Product.Include(p => p.Category).Include(p => p.Mark).Include(p => p.Supplier);
            return View(product.ToList());
        }

        // GET: Products/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Product.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            ViewBag.CategoryId = new SelectList(db.Category, "Id", "Name");
            ViewBag.MarkId = new SelectList(db.Mark, "Id", "Name");
            ViewBag.SupplierId = new SelectList(db.Supplier, "Id", "Name");
            return View(new Product());
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Code,Name,Description,ListPrice,PurchasePrice,MinStock,MaxStock,SupplierId,CategoryId,MarkId,Width,Height,Weight,Color,Enabled")] Product product, HttpPostedFileBase file)
        {
            if (ModelState.IsValid)
            {
                if (file != null)
                {
                    string pictureUrl = System.IO.Path.GetFileName(file.FileName);
                    string pathUrl = System.IO.Path.Combine(Server.MapPath("/Public/Products"), pictureUrl);

                    file.SaveAs(pathUrl);

                    //Save Image in DB

                    product.Picture = pictureUrl;
                }

                product.Id = Guid.NewGuid().ToString();
                product.CreatedDate = DateTime.Now;
                db.Product.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CategoryId = new SelectList(db.Category, "Id", "Name", product.CategoryId);
            ViewBag.MarkId = new SelectList(db.Mark, "Id", "Name", product.MarkId);
            ViewBag.SupplierId = new SelectList(db.Supplier, "Id", "Name", product.SupplierId);
            return View(product);
        }

        // GET: Products/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Product.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoryId = new SelectList(db.Category, "Id", "Name", product.CategoryId);
            ViewBag.MarkId = new SelectList(db.Mark, "Id", "Name", product.MarkId);
            ViewBag.SupplierId = new SelectList(db.Supplier, "Id", "Name", product.SupplierId);
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Code,Name,Description,ListPrice,PurchasePrice,MinStock,MaxStock,SupplierId,CategoryId,MarkId,Width,Height,Weight,Color,Picture,Enabled")] Product product)
        {
            if (ModelState.IsValid)
            {
                product.CreatedDate = DateTime.Now;

                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CategoryId = new SelectList(db.Category, "Id", "Name", product.CategoryId);
            ViewBag.MarkId = new SelectList(db.Mark, "Id", "Name", product.MarkId);
            ViewBag.SupplierId = new SelectList(db.Supplier, "Id", "Name", product.SupplierId);
            return View(product);
        }

        // GET: Products/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Product.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Product product = db.Product.Find(id);
            db.Product.Remove(product);
            db.SaveChanges();
            return RedirectToAction("Index");
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
