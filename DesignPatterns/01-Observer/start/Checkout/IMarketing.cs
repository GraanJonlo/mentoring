namespace Checkout
{
    public interface IMarketing
    {
        void Sold(Sku s, Money m);
    }
}
