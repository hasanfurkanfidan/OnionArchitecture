namespace Application.Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(string message, bool success, T data) : base(message, success)
        {
            Data = data;
        }
        public DataResult(bool success, T data) : base(success)
        {
            Data = data;
        }
        public DataResult(bool success) : base(success)
        {
            Data = default(T);
        }
        public T Data { get; set; }
    }
}
