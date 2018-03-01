using System;

namespace Checkout
{
    public struct Money : IEquatable<Money>
    {
        private readonly decimal _value;
        private readonly int _hashCode;

        public Money(decimal value)
        {
            _value = value;
            _hashCode = value.GetHashCode();
        }

        public bool Equals(Money other)
        {
            return _value == other._value;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is Money money && Equals(money);
        }

        public override int GetHashCode()
        {
            return _hashCode;
        }

        public static bool operator ==(Money left, Money right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Money left, Money right)
        {
            return !left.Equals(right);
        }

        public static Money operator +(Money l, Money r)
        {
            return new Money(l._value + r._value);
        } 
    }
}