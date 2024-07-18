namespace Domain.Exceptions
{
    public class AbortedException : Exception
    {
        public AbortedException(string? message) : base(message) { }
    }
}