using Empresa.Service;
using ServicoWCF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Empresa.Controllers
{
    public class EmpresaController : Controller
    {
        // GET: Empresa
        public ActionResult Index()
        {
            var servico = new Service.ServicoClient();
            
           
            var lst = servico.Listar();

            return View(model: lst);
        }

        // GET: Empresa/Details/5
        public ActionResult Details(int id)
        {
            return View(new empresaEntities().empresa.First(e=> e.Id == id));
        }

        // GET: Empresa/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Empresa/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Service.empresa empresa)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    var servico =new  Service.ServicoClient();
                    servico.inserir(empresa);
                    /*empresaEntities context = new empresaEntities();
                    context.empresa.Add(empresa);
                    context.SaveChanges();*/
                    return RedirectToAction("Index");
                }
                return View(empresa);
            }
            catch
            {
                return View(empresa);
            }
        }

        // GET: Empresa/Edit/5
        public ActionResult Edit(int id)
        {
           // empresaEntities context = new empresaEntities();

            return View();
        }

        // POST: Empresa/Edit/5
        [HttpPost]
        public ActionResult Edit(Service.empresa empresa)
        {
            try
            {
                // TODO: Add update logic here
               /* if (ModelState.IsValid)
                {
                    empresaEntities context = new empresaEntities();
                    empresa em = context.empresa.First(e => e.Id == empresa.Id);
                    em.Nome = empresa.Nome;
                    em.Endereco = empresa.Endereco;
                    em.QtdFuncionario = empresa.QtdFuncionario;
                }*/
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Empresa/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Empresa/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult ConfirmeDelete(int id)
        {
            try
            {
                /*// TODO: Add delete logic here
                empresaEntities context = new empresaEntities();
                Service.empresa em = context.empresa.First(e => e.Id == id);
                context.empresa.Remove(em);
                context.SaveChanges();*/
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
