
using ControleContactos.Data;
using ControleContactos.Models;
using ControleContactos.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace ControleContactos.Repositorio
{
    public class UsuarioRepositorio: IUsuarioRepositorio
    {
        private readonly BancoContext _context;

        public UsuarioRepositorio(BancoContext bancoContent)
        {
            this._context = bancoContent;
        }

      
        public UsuarioModel Adicionar(UsuarioModel usuario)
        {
            _context.usuario.Add(usuario);
            _context.SaveChanges();
            return usuario;
        }

        public UsuarioModel BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<UsuarioModel> BuscarTodos()
        {
            return _context.usuario.ToList();
        }
    }
}
