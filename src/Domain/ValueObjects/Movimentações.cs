using System;

namespace Sistema_Bancario.Domain.ValueObjects
{
    class Movimentações : IComparable<Movimentações>
    {
        public int ID { get; set; }
        public DateTime data { get; set; }
        public double valor { get; set; }
        public int IDConta { get; set; }

        // Implementação de IComparable<T>
        public int CompareTo(Movimentações other)
        {
            if (other == null) return 1;
            return data.CompareTo(other.data); // Comparação por data
        }

        // Sobrescrevendo Equals para garantir consistência com CompareTo
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Movimentações)) return false;
            return data == ((Movimentações)obj).data; // Comparação por data
        }

        // Sobrescrevendo GetHashCode
        public override int GetHashCode()
        {
            return data.GetHashCode(); // Gerando HashCode baseado na data
        }

        // Sobrecarga dos operadores de comparação
        public static bool operator ==(Movimentações m1, Movimentações m2)
        {
            if (ReferenceEquals(m1, null) && ReferenceEquals(m2, null)) return true;
            if (ReferenceEquals(m1, null) || ReferenceEquals(m2, null)) return false;
            return m1.Equals(m2); // Usando Equals para comparação
        }

        public static bool operator !=(Movimentações m1, Movimentações m2)
        {
            return !(m1 == m2); // Usando o operador == para determinar desigualdade
        }

        public static bool operator <(Movimentações m1, Movimentações m2)
        {
            return m1.CompareTo(m2) < 0; // Comparação usando CompareTo
        }

        public static bool operator <=(Movimentações m1, Movimentações m2)
        {
            return m1.CompareTo(m2) <= 0; // Comparação usando CompareTo
        }

        public static bool operator >(Movimentações m1, Movimentações m2)
        {
            return m1.CompareTo(m2) > 0; // Comparação usando CompareTo
        }

        public static bool operator >=(Movimentações m1, Movimentações m2)
        {
            return m1.CompareTo(m2) >= 0; // Comparação usando CompareTo
        }
        public override string ToString()
        {
            return $"{ID} - {data:dd/MM/yyyy} - Valor: R$ {valor:0.00}";
        }
    }
}