using System.Net;

namespace AirLiquide.Teste.Services
{
    public sealed class ServiceResult
    {
        public bool Success { get; private set; }

        public string Error { get; private set; }

        public HttpStatusCode StatusCode { get; private set; }

        public object Data { get; set; }

        public ServiceResult(bool success, HttpStatusCode statusCode, string errorMessage = "")
        {
            Success = success;
            StatusCode = statusCode;
            Error = errorMessage;
        }

        public ServiceResult(bool success, HttpStatusCode statusCode, object data)
        {
            Success = success;
            StatusCode = statusCode;
            Data = data;
            Error = string.Empty;
        }

        public void SetData(object data) => Data = data;
    }
}
