using OrderApp;

var total = OrderTotal.Calculate(unitPrice: 20m, quantity: 3, discountPercent: 10m);
Console.WriteLine($"Order total: {total:F2}");
