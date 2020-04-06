using SportsX.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace SportsX.Controllers
{
    public class ClienteController : Controller
    {
        ClienteDbContext db;
        public ClienteController()
        {
            db = new ClienteDbContext();
        }
        // GET: Clientes
        public ActionResult Index()
        {
            var clientes = db.Clientes.ToList();
            return View(clientes);
        }

        public ActionResult Create()
        {
            ViewBag.Cliente = db.Clientes;
            var model = new ClienteViewModel();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClienteViewModel model)
        {
            var cliente = new Cliente();
            cliente.Identificador = model.Identificador;
            cliente.Nome = model.Nome;
            cliente.CEP = model.CEP;
            cliente.Email = model.Email;
            cliente.Classificacao = model.Classificacao;
            cliente.tipo = model.tipo;
            cliente.Telefone = model.Telefone;

            db.Clientes.Add(cliente);
            db.SaveChanges();
            return RedirectToAction("Index");
        // Se ocorrer um erro retorna para pagina
            //ViewBag.Clientes = db.Clientes;
            //return View(model);
        }


        // GET: Cliente/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cliente cliente = db.Clientes.Find(id);
            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ClienteId,Nome,Identificador,CEP,Email,Classificacao,tipo,Telefone")] Cliente model)
        {
            if (ModelState.IsValid)
            {
                var cliente = db.Clientes.Find(model.ClienteId);
                if (cliente == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                cliente.Identificador = model.Identificador;
                cliente.Nome = model.Nome;
                cliente.CEP = model.CEP;
                cliente.Email = model.Email;
                cliente.Classificacao = model.Classificacao;
                cliente.tipo = model.tipo;
                cliente.Telefone = model.Telefone;

                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        // GET: Cliente/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            Cliente cliente = db.Clientes.Find(id);
            if (cliente == null)
            {
                return HttpNotFound();
            }
        
            return View(cliente);
        }
        // POST: Produtos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cliente cliente = db.Clientes.Find(id);
            db.Clientes.Remove(cliente);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        // GET: Cliente/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cliente cliente = db.Clientes.Find(id);
            if (cliente == null)
            {
                return HttpNotFound();
            }
           
            return View(cliente);
        }
    }
}