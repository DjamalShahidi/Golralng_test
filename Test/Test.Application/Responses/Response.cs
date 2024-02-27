namespace Store.Application.Responses
{
    public class Response
    {
        public bool IsSuccess { get; set; } = true;
        public List<string> ErrorMessages { get; set; }
        public object Result { get; set; }
    }
}
