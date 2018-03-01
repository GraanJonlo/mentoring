using System;

namespace Checkout
{
    public struct Transaction : IEquatable<Transaction>
    {
        private readonly string _reference;
        public readonly Money Value;

        private readonly int _hashCode;

        public Transaction(string reference, Money value)
        {
            _reference = reference;
            Value = value;

            _hashCode = ((reference?.GetHashCode() ?? 0) * 397) ^ value.GetHashCode();
        }

        public bool Equals(Transaction other)
        {
            return string.Equals(_reference, other._reference) && Value.Equals(other.Value);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is Transaction transaction && Equals(transaction);
        }

        public override int GetHashCode()
        {
            return _hashCode;
        }

        public static bool operator ==(Transaction left, Transaction right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Transaction left, Transaction right)
        {
            return !left.Equals(right);
        }
    }
}
