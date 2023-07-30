namespace SoftwareDesignPrinciples;

public class ShoppingCart
{
    private List<CartItem> items;

    // Constructor to initialize an empty shopping cart
    public ShoppingCart()
    {
        items = new List<CartItem>();
    }

    // Method to add an item to the shopping cart
    public void AddItem(string productName, decimal price, int quantity)
    {
        var existingItem = items.Find(item => item.ProductName == productName);

        if (existingItem != null)
        {
            existingItem.Quantity += quantity;
        }
        else
        {
            var newItem = new CartItem(productName, price, quantity);
            items.Add(newItem);
        }
    }

    // Method to remove an item from the shopping cart
    public void RemoveItem(string productName)
    {
        items.RemoveAll(item => item.ProductName == productName);
    }

    // Method to calculate the total cost of all items in the shopping cart
    public decimal CalculateTotal()
    {
        decimal total = 0;

        foreach (var item in items)
        {
            total += item.Price * item.Quantity;
        }

        return total;
    }

    // Method to display the items in the shopping cart
    public void DisplayCart()
    {
        if (items.Count == 0)
        {
            Console.WriteLine("The shopping cart is empty.");
        }
        else
        {
            Console.WriteLine("Shopping Cart:");
            foreach (var item in items)
            {
                Console.WriteLine($"{item.ProductName} - {item.Quantity} x {item.Price:C}");
            }
            Console.WriteLine($"Total: {CalculateTotal():C}");
        }
    }
}

public class CartItem
{
    public string ProductName { get; }
    public decimal Price { get; }
    public int Quantity { get; set; }

    public CartItem(string productName, decimal price, int quantity)
    {
        ProductName = productName;
        Price = price;
        Quantity = quantity;
    }
}
