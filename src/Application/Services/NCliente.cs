using System;
using System.Collections.Generic;
using Sistema_Bancario.Domain.Entities;

namespace Sistema_Bancario.Application.Services;
{
    static class NCliente
    {
        private static List<Cliente> clientes = new List<Cliente>();
        public static void Inserir(Cliente c)
        {
            int id = clientes.Count == 0 ? 1 : clientes.Select(cliente => cliente.Id).Max() + 1;
            c.Id = id;
            clientes.Add(c);
        }
        public static List<Cliente> Listar()
        {
            clientes.Sort();
            return clientes;
        }
            public static Cliente Listar(int id)
        {
            foreach (Cliente obj in clientes)
                if (obj.Id == id) return obj;
            return null;
        }
        public static Cliente ListarUsuario(int idUsuario)
        {
            foreach (Cliente obj in clientes)
                if (obj.IdUsuario == idUsuario) return obj;
            return null;
        }
        public static void Excluir(Cliente c)
        {
            Cliente atual = Listar(c.Id);
            if (atual != null)
                clientes.Remove(atual);
        }
        public static List<Cliente> Saldos()
        {
            return clientes.ToList();
        }
        public static Cliente Saldos(decimal saldo)
        {
            decimal tolerancia = 0.001m;
            foreach (Cliente obj in clientes)
            {
                if (Math.Abs(obj.Saldo - saldo) < tolerancia) // Verifica a diferença absoluta
                    return obj;
            }
            return null;
        }
    }
}
