using static System.Formats.Asn1.AsnWriter;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Transactions;
using System;

namespace RickDI.Services
{
    public interface IOperationScoped : IOperation
    {
        //A scoped lifetime means that a new instance of the service is created once per request(or per scope).
        
        //Use Cases:
        //Database Contexts: Services like Entity Framework's DbContext that should be created per request to ensure proper unit of work and transaction handling.
        //Unit of Work: Services that manage transactions across multiple repository operations within a single request.
        
        //Benefits:
        //Ensures a new instance for each client request, preventing issues with stale data or transaction management.
        //Ideal for web applications where each request should be isolated.
    }
}
