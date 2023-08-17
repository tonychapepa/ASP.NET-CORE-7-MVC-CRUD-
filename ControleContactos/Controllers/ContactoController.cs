using ControleContactos.Models;
using ControleContactos.Repositorio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace ControleContactos.Controllers
{
    public class ContactoController : Controller
    {
        private readonly IContactoRepositorio _contactoRepositorio;

        public ContactoController(IContactoRepositorio contactoRepositorio)
        {
            _contactoRepositorio = contactoRepositorio;
        }
        public IActionResult Index()
        {
           List<ContactoModel>contacto =_contactoRepositorio.BuscarTodos();
            
            return View(contacto);
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {
            ContactoModel contacto =  _contactoRepositorio.ListarPorId(id);
            return View(contacto);
        }

        public IActionResult Apagar(int id)
        {
            _contactoRepositorio.Apagar(id);
            return RedirectToAction("Index");
        }
        public IActionResult ApagarConfirmacao(int id)
        {
            ContactoModel contacto = _contactoRepositorio.ListarPorId(id);
            return View(contacto);
            return View(contacto);
        }

        [HttpPost]
        public IActionResult Criar(ContactoModel contacto)
        {
            if (ModelState.IsValid)
            {
                _contactoRepositorio.Adicionar(contacto);
                return RedirectToAction("Index");
            }
            return View(contacto);
           
        }


        [HttpPost]
        public IActionResult Alterar(ContactoModel contacto)
        {
            _contactoRepositorio.Atualizar(contacto);
            return RedirectToAction("Index");
        }
    }
}
