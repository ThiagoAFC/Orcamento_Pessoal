using System;
using System.Collections.Generic;

namespace Sistema_Bancario.Domain.Entities;

class Cliente : IComparable<Cliente>
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public double Saldo { get; set; }
    public int IdUsuario { get; set; }
    public int CompareTo(Cliente other)
    {
        if (other == null) return 1;
        return Nome.CompareTo(other.Nome);
    }
    public override bool Equals(object obj)
    {
        if (obj == null || !(obj is Cliente)) return false;
        return Nome == ((Cliente)obj).Nome; // Comparação por Nome
    }
    public override int GetHashCode()
    {
        return Nome.GetHashCode(); // Gerando HashCode baseado no Nome
    }
    public static bool operator ==(Cliente c1, Cliente c2)
    {
        if (ReferenceEquals(c1, null) && ReferenceEquals(c2, null)) return true;
        if (ReferenceEquals(c1, null) || ReferenceEquals(c2, null)) return false;
        return c1.Equals(c2); // Usando Equals para comparação
    }
    public static bool operator !=(Cliente c1, Cliente c2)
    {
        return !(c1 == c2); // Usando o operador == para determinar desigualdade
    }
    public static bool operator <(Cliente c1, Cliente c2)
    {
        return c1.CompareTo(c2) < 0; // Comparação usando CompareTo
    }
    public static bool operator <=(Cliente c1, Cliente c2)
    {
        return c1.CompareTo(c2) <= 0; // Comparação usando CompareTo
    }
    public static bool operator >(Cliente c1, Cliente c2)
    {
        return c1.CompareTo(c2) > 0; // Comparação usando CompareTo
    }
    public static bool operator >=(Cliente c1, Cliente c2)
    {
        return c1.CompareTo(c2) >= 0; // Comparação usando CompareTo
    }
    public override string ToString()
    {
        return $"{Id} - {Nome}"; // Representação personalizada do cliente
    }
}
