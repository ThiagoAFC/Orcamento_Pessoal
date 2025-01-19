using System;
using System.Collections.Generic;

namespace Sistema_Bancario.Domain.Entities
{
    class Conta : IComparable<Conta>
    {
        public int ID { get; set; }
        public string TipoConta { get; set; }
        public double SaldoConta { get; set; }
        public int IDCliente { get; set; }

        // Implementação de IComparable<T>
        public int CompareTo(Conta other)
        {
            if (other == null) return 1;
            return TipoConta.CompareTo(other.TipoConta); // Comparação por TipoConta
        }

        // Sobrescrevendo Equals para garantir consistência com CompareTo
        public override bool Equals(object obj)
        {
            return obj is Conta conta && TipoConta == conta.TipoConta; // Comparação por TipoConta
        }

        // Sobrescrevendo GetHashCode
        public override int GetHashCode()
        {
            return TipoConta.GetHashCode(); // Gerando HashCode baseado no TipoConta
        }

        // Sobrecarga dos operadores de comparação
        public static bool operator ==(Conta co1, Conta co2)
        {
            if (ReferenceEquals(co1, null) && ReferenceEquals(co2, null)) return true;
            if (ReferenceEquals(co1, null) || ReferenceEquals(co2, null)) return false;
            return co1.Equals(co2); // Usando Equals para comparação
        }

        public static bool operator !=(Conta co1, Conta co2)
        {
            return !(co1 == co2); // Usando o operador == para determinar desigualdade
        }

        public static bool operator <(Conta co1, Conta co2)
        {
            return co1.CompareTo(co2) < 0; // Comparação usando CompareTo
        }

        public static bool operator <=(Conta co1, Conta co2)
        {
            return co1.CompareTo(co2) <= 0; // Comparação usando CompareTo
        }

        public static bool operator >(Conta co1, Conta co2)
        {
            return co1.CompareTo(co2) > 0; // Comparação usando CompareTo
        }

        public static bool operator >=(Conta co1, Conta co2)
        {
            return co1.CompareTo(co2) >= 0; // Comparação usando CompareTo
        }
        public override string ToString()
        {
            return $"{ID} - {TipoConta} - Saldo = R$ {SaldoConta:0.00} - Cliente: {IDCliente}";
        }
    }
}
