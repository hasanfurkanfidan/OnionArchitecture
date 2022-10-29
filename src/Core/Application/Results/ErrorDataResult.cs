namespace Application.Results
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(string message) : base(message, false, default(T))
        {

        }
    }
}
