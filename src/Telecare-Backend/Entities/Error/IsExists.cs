namespace Telecare.Domain.Error
{
    public abstract class IsExists : Exception
    {
        public IsExists(string message) : base(message)
        {
            
        }
    }
}
