namespace Telecare.Domain.Common
{
    public interface IEntity<G>
    {
        G Id { get; set; }
    }
}
