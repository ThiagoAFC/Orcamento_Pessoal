using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_Bancario.Domain.Entities;

namespace Sistema_Bancario.Application.Services;

static class NUsuario

{
    private static List<Usuario> usuarios = new List<Usuario>();
    public static Usuario Autenticar(string nome, string senha)
    {
        foreach (Usuario obj in usuarios)
            if (obj.Nome == nome && obj.Senha == senha) return obj;
        return null;
    }
    public static int Inserir(Usuario u)
    {
        int id = usuarios.Count == 0 ? 1 : usuarios.Select(obj => obj.Id).Max() + 1;
        u.Id = id;
        usuarios.Add(u);
        return id;
    }
}
