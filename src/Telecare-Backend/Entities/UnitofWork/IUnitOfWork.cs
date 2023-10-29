namespace Telecare.Domain.UnitofWork
{
    public interface IUnitOfWork
    {
        Task SavChangeAsync(CancellationToken cancellationToken);
    }
}
