namespace RickDI.Services
{
    public class Operation : IOperationTransient, IOperationScoped, IOperationSingleton
    {
        
        public Operation()
        {
            //To generate a new Guid
            OperationId = Guid.NewGuid().ToString();
        }

        public string OperationId { get; }
    }
}
