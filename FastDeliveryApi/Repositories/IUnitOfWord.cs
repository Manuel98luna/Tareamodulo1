using FastDeliveryApi.IAuditableEntity;

public interface IUnitOfWord

{
    Task SaveChangesAsyc(CancellationToken CancellationToken = default);
}