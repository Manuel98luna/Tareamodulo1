namespace FastDeliveryApi;

public interface IAuditableEntity 
{
 public DateTime CreateOnUtc {get; set;}
public DateTime? Modified0Utc{get; set;}
}