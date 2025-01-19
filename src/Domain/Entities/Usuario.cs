using System;
using System.Collections.Generic;

namespace Sistema_Bancario.Domain.Entities
{
    class Usuario : IComparable<Usuario>
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public bool Admin { get; set; }

        // Implementação de IComparable<T>
        public int CompareTo(Usuario other)
        {
            if (other == null) return 1;
            return Nome.CompareTo(other.Nome); // Comparação por Nome
        }

        // Sobrescrevendo Equals para garantir consistência com CompareTo
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Usuario)) return false;
            return Nome == ((Usuario)obj).Nome; // Comparação por Nome
        }

        // Sobrescrevendo GetHashCode
        public override int GetHashCode()
        {
            return Nome.GetHashCode(); // Gerando HashCode baseado no Nome
        }

        // Sobrecarga dos operadores de comparação
        public static bool operator ==(Usuario u1, Usuario u2)
        {
            if (ReferenceEquals(u1, null) && ReferenceEquals(u2, null)) return true;
            if (ReferenceEquals(u1, null) || ReferenceEquals(u2, null)) return false;
            return u1.Equals(u2); // Usando Equals para comparação
        }

        public static bool operator !=(Usuario u1, Usuario u2)
        {
            return !(u1 == u2); // Usando o operador == para determinar desigualdade
        }

        public static bool operator <(Usuario u1, Usuario u2)
        {
            return u1.CompareTo(u2) < 0; // Comparação usando CompareTo
        }

        public static bool operator <=(Usuario u1, Usuario u2)
        {
            return u1.CompareTo(u2) <= 0; // Comparação usando CompareTo
        }

        public static bool operator >(Usuario u1, Usuario u2)
        {
            return u1.CompareTo(u2) > 0; // Comparação usando CompareTo
        }

        public static bool operator >=(Usuario u1, Usuario u2)
        {
            return u1.CompareTo(u2) >= 0; // Comparação usando CompareTo
        }
        public override string ToString()
        {
            return $"{Id} - {Nome}"; // Representação personalizada do usuário
        }
    }
}