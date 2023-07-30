namespace SoftwareDesignPrinciples.LazyLoading;

public class Customer
{
    public int CustomerId { get; }
    public string Name { get; }

    // Private field to store the orders (lazy loaded)
    private List<Order> orders;
    
    // Constructor
    public Customer(int customerId, string name)
    {
        CustomerId = customerId;
        Name = name;
    }

    // Property to access the orders, implementing lazy loading
    public List<Order> Orders
    {
        get
        {
            if (orders == null)
            {
                // Simulate loading the orders from a database or some external source
                LoadOrders();
            }
            return orders;
        }
    }

    // Private method to load the orders from the database (or external source)
    private void LoadOrders()
    {
        // Simulating loading from a database or an external source
        // In this example, we'll just create some sample orders for demonstration purposes
        orders = new List<Order>
        {
            new Order(1, "Product A", 10),
            new Order(2, "Product B", 5),
            new Order(3, "Product C", 8),
            new Order(4, "Product D", 3)
        };
    }
}

public class Order
{
    public int OrderId { get; }
    public string ProductName { get; }
    public int Quantity { get; }

    public Order(int orderId, string productName, int quantity)
    {
        OrderId = orderId;
        ProductName = productName;
        Quantity = quantity;
    }
}

public class Program
{
    public static void Main()
    {
        // Create a new customer (orders are not loaded yet)
        var customer = new Customer(1, "John Doe");

        // Access the orders property (lazy loading occurs here)
        List<Order> orders = customer.Orders;

        // Now we can work with the loaded orders
        foreach (var order in orders)
        {
            Console.WriteLine($"Order ID: {order.OrderId}, Product: {order.ProductName}, Quantity: {order.Quantity}");
        }
    }
}
