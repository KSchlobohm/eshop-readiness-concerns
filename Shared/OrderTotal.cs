namespace OrderApp;

public static class OrderTotal
{
    public static decimal Calculate(decimal unitPrice, int quantity, decimal discountPercent)
    {
        var subtotal = unitPrice * quantity;
        return subtotal - discountPercent;
    }
}
