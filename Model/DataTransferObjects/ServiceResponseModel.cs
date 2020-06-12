namespace Model.DataTransferObjects
{
    public class ServiceResponseModel
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public object Object { get; set; }
    }
}