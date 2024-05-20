using Microsoft.Extensions.Configuration;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Runtime.Intrinsics.X86;
using System;

namespace RickDI.Services
{
    public interface IOperationSingleton : IOperation
    {
        //A singleton lifetime means that a single instance of the service is created and shared throughout the application's lifetime.
        
        //Use Cases:
        //Configuration Services: Services that hold configuration data that doesn’t change over the application’s lifetime.
        //Caching Services: Services that manage data caching.
        //Logger Services: Services that handle logging activities.
        
        //Benefits:
        //Resource efficiency since the same instance is reused.
        //Ideal for stateless services or those that need to maintain state throughout the application.
    }
}
