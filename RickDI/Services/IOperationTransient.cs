namespace RickDI.Services
{
    public interface IOperationTransient : IOperation
    {
        //A transient lifetime means that a new instance of the service is created every time it is requested.
     
        //Use Cases:
        //Lightweight Services: Services that are not expensive to create and do not hold state.
        //Stateless Services: Services where maintaining state between uses is not necessary or desired.
        
        //Benefits:
        //Always get a fresh instance, which can be useful if the service has state that should not be shared.
        //Ideal for stateless operations and operations that do not require resource-intensive initialization.
    }
}
