namespace TechTestWebApi.Exceptions
{
    public class RecordNotFoundException : AppException
    {
        public RecordNotFoundException() : base()
        {
        }

        public RecordNotFoundException(string subject)
            : base($"{subject} not found.")
        {
        }
    }
}
