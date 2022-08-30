namespace Onion.Architecture.Application.Wrappers
{
    public class Response<T>
    {
        public Response()
        {
        }

        // Se ejecuto Correctamente
        public Response( T data, string message = null!)
        {
            Succeeded = true;
            Message = message;
            Data = data;
        }


        //Se ejecuto Incorrectamente
        public Response(string message)
        {
            Succeeded = false;
            Message = message;
        }

        public bool Succeeded { get; set; }
        public string Message { get; set; }
        public IEnumerable<string> Erros { get; set; }
        public T Data { get; set; }
    }
}
