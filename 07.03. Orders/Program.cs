//var list = new Dictionary<string, List<decimal>>();
Dictionary<string, List<decimal>> products = new();

string input = Console.ReadLine();

while (input != "buy")
{
    string[] inputArrey = input.Split();
    string product = inputArrey[0];
    decimal price = decimal.Parse(inputArrey[1]);
    decimal quantity = decimal.Parse(inputArrey[2]);

    if (products.ContainsKey(product))
    {
        products[product][0] = price;
        products[product][1] += quantity;
    }
    else
    { 
        //products.Add(product, new() { price, quantity});
        products.Add(product, new List<decimal>());
        products[product].Add(price);
        products[product].Add(quantity);
    }
    input = Console.ReadLine();
}

foreach (KeyValuePair<string, List<decimal>> currentProduct in products)
{
    string currentProductName = currentProduct.Key;
    decimal currentProductPrice = currentProduct.Value[0];
    decimal currentProductQuantity = currentProduct.Value[1];

    decimal currentProductAmount = currentProductPrice * currentProductQuantity;
    Console.WriteLine($"{currentProductName} -> {currentProductAmount}");
}