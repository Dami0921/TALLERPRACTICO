
using TALLERPRACTICO;

Console.WriteLine("PRODUCTS");
Console.WriteLine("-------------------------------------------------");

CPRODUCTS product1 = new CFixedValueProduct()
{
    Description = "Vino Gato Negro",
    ID = 1010,
    Price = 46000,
    Tax = 1.09F
};

CPRODUCTS product2 = new CFixedValueProduct()
{
    Description = "Pan Bimbo Artesanal",
    ID = 2020,
    Price = 15600,
    Tax = 1.09F
};

CPRODUCTS product3 = new CVariablePriceProduct()
{
    Description = "Queso Holandes",
    ID = 3030,
    Measurement = "Kilo",
    Price = 32000,
    Quantity = 0.536F,
    Tax = 1.09F
};

CPRODUCTS product4 = new CVariablePriceProduct()
{
    Description = "Cabano",
    ID = 4040,
    Measurement = "Kilo",
    Price = 18000,
    Quantity = 0.389F,
    Tax = 1.09F
};

CPRODUCTS product5 = new CComposedProduct()
{
    Description = "Ancheta #1",
    ID = 5050,
    Discount = 0.88F,
    _products = new List<CPRODUCTS>() { product1, product2, product3, product4 }
};

Console.WriteLine(product1);
Console.WriteLine(product2);
Console.WriteLine(product3);
Console.WriteLine(product4);
Console.WriteLine(product5);

CInvoice invoice = new CInvoice();
invoice.AddProducts(product1);
invoice.AddProducts(product3);
invoice.AddProducts(product5);
Console.WriteLine(invoice);

