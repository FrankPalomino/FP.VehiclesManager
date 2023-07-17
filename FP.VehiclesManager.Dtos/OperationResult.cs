namespace FP.VehiclesManager.Dtos
{
    public class OperationResult
    {
        public List<string> Errors { get; set; } = new List<string>();
        public void AddError(string message) => Errors.Add(message);
        public bool HasErrors() => Errors.Count > 0;
    }
    public class OperationResult<T> : OperationResult
    {
        public T Result { get; set; }
        public void AddResult(T result) => Result = result;
    }
}
