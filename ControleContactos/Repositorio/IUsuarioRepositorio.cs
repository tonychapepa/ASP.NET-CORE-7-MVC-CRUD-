using ControleContactos.Data;
using ControleContactos.Models;

namespace ControleContactos.Repositorio
{
    public interface IUsuarioRepositorio
    {
        UsuarioModel BuscarPorId(int id);
        List<UsuarioModel> BuscarTodos();
        UsuarioModel Adicionar(UsuarioModel usuario);


    }
}
