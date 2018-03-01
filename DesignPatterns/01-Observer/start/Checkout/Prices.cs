namespace Checkout
{
    public interface IPrices
    {
        Money PriceFor(Sku sku);
    }
}