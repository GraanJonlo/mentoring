using System;

namespace Checkout
{
    public struct Transaction : IEquatable<Transaction>
    {
        public readonly string Reference;
        public readonly Money Value;

        public Transaction(string reference, Money value)
        {
            Reference = reference;
            Value = value;
        }

        public bool Equals(Transaction other)
        {
            return string.Equals(Reference, other.Reference, StringComparison.InvariantCultureIgnoreCase) &&
                   Value.Equals(other.Value);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is Transaction transaction && Equals(transaction);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (StringComparer.InvariantCultureIgnoreCase.GetHashCode(Reference) * 397) ^ Value.GetHashCode();
            }
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
