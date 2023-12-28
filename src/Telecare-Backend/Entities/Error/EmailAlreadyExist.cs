namespace Telecare.Domain.Error
{
    public class EmailAlreadyExists : IsExists
    {
        public EmailAlreadyExists(string email) : base($"{email} already exists.Try with another one")
        {
            
        }
    }
}
