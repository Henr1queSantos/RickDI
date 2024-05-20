using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using RickDI.Models;
using RickDI.Services;

namespace Rick_DI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IOperationTransient _transientOperation1;
        private readonly IOperationTransient _transientOperation2;

        private readonly IOperationSingleton _singletonOperation1;
        private readonly IOperationSingleton _singletonOperation2;

        private readonly IOperationScoped _scopedOperation1;
        private readonly IOperationScoped _scopedOperation2;

        public HomeController(ILogger<HomeController> logger,
                                IOperationTransient transientOperation1,
                                IOperationTransient transientOperation2,
                                IOperationScoped operationScoped1,
                                IOperationScoped operationScoped2,
                                IOperationSingleton operationSingleton1,
                                IOperationSingleton operationSingleton2
                                )
        {
            _logger = logger;
            _transientOperation1 = transientOperation1;
            _transientOperation2 = transientOperation2;
            _scopedOperation1 = operationScoped1;
            _scopedOperation2 = operationScoped2;
            _singletonOperation1 = operationSingleton1;
            _singletonOperation2 = operationSingleton2;
        }

        public string Index()
        {
            return $"Transient1 : {_transientOperation1.OperationId} \n" +
                   $"Transient2 : {_transientOperation2.OperationId} \n\n" +
                   $"Scoped1 : {_scopedOperation1.OperationId} \n" +
                   $"Scoped2 : {_scopedOperation2.OperationId} \n\n" +
                   $"Singleton1 : {_singletonOperation1.OperationId} \n" +
                   $"Singleton2: {_singletonOperation2.OperationId} \n";
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}