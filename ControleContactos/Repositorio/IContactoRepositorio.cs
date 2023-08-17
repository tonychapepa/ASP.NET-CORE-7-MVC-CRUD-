using ControleContactos.Models;

namespace ControleContactos.Repositorio
{
    public interface IContactoRepositorio
    {
        ContactoModel ListarPorId(int id);
        ContactoModel Atualizar(ContactoModel contacto);
        ContactoModel Adicionar(ContactoModel contacto);
        List<ContactoModel> BuscarTodos();
        bool Apagar(int id);
    }
}