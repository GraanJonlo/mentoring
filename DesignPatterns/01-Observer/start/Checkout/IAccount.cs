namespace Checkout
{
    public interface IAccount
    {
        void Sold(Sku s, Money m);
        Money Balance();
    }
}
