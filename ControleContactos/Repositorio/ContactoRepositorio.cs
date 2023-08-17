using ControleContactos.Data;
using ControleContactos.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleContactos.Repositorio
{
    public class ContactoRepositorio : IContactoRepositorio
    {
        private readonly BancoContext _bancoContext;

        public ContactoRepositorio(BancoContext bancoContext)
        {
            this._bancoContext = bancoContext;
        }
        public ContactoModel ListarPorId(int id)
        {
            return _bancoContext.contacto.FirstOrDefault(x => x.Id == id);

        }

        public List<ContactoModel> BuscarTodos()
        {
            return _bancoContext.contacto.ToList();
        }

        public ContactoModel Adicionar(ContactoModel contacto)
        {
            //Add to Database
            _bancoContext.contacto.Add(contacto);
            _bancoContext.SaveChanges();

            return contacto;
        }

        public ContactoModel Atualizar(ContactoModel contacto)
        {
            ContactoModel contactoDB = ListarPorId(contacto.Id);

            if (contactoDB == null) throw new Exception("Houve erro na atualização!");
            contactoDB.Nome = contacto.Nome;
            contactoDB.Celular = contacto.Celular;
            contactoDB.Email = contacto.Email;

            _bancoContext.contacto.Update(contactoDB);
            _bancoContext.SaveChanges();

            return contactoDB;
        }

        public bool Apagar(int id)
        {
            ContactoModel contactoDB = ListarPorId(id);
            if (contactoDB == null) throw new Exception("Houve erro na remoção do contacto");
            _bancoContext.contacto.Remove(contactoDB);
            _bancoContext.SaveChanges();

            return true;
           
        }
    }
}
