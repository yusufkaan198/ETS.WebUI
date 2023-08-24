namespace MVCWebUI.Models
{
    public class ResponseComing<T>
    {
        public List<T> data { get; set; }
        public List<string> errorMessage { get; set; }
    }
}
