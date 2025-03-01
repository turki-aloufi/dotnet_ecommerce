public class OrderViewModel
{
    public int OrderId { get; set; }
    public DateTime OrderDate { get; set; }
    public List<OrderDetailViewModel> OrderDetails { get; set; }
}

public class OrderDetailViewModel
{
    public string ProductName { get; set; }
    public int Quantity { get; set; }
    public double SubTotal { get; set; }
}
