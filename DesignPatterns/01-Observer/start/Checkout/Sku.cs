using System;

namespace Checkout
{
    public struct Sku : IEquatable<Sku>
    {
        private readonly string _value;

        public Sku(string value)
        {
            _value = value;
        }

        public bool Equals(Sku other)
        {
            return string.Equals(_value, other._value);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is Sku sku && Equals(sku);
        }

        public override int GetHashCode()
        {
            return _value.GetHashCode();
        }

        public override string ToString()
        {
            return _value;
        }

        public static bool operator ==(Sku left, Sku right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Sku left, Sku right)
        {
            return !left.Equals(right);
        }
    }
}
