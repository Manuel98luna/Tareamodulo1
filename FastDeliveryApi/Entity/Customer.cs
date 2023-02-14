namespace FastDeliveryApi.Entity;

public class Customer
{
    public int Id { get; set; }
    
    public string Name { get; set; }

    public string PhoneNumber { get; set; }
    
     public string Email { get; set; }

    public string Address { get; set; }

     public bool Status { get; set; }
}