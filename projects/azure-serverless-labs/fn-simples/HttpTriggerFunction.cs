using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace fn_simples
{
    public class HttpTriggerFunction
    {
        private readonly ILogger<HttpTriggerFunction> _logger;

        public HttpTriggerFunction(
            ILogger<HttpTriggerFunction> logger)
        {
            _logger = logger;
        }

        [Function(nameof(HttpTriggerFunction))]
        public IActionResult Run(
            [HttpTrigger(
                AuthorizationLevel.Function,
                "get",
                "post")]
            HttpRequest req)
        {
            _logger.LogInformation(
                "HTTP Trigger executada com sucesso.");

            return new OkObjectResult(new
            {
                message = "Azure Function executada com sucesso.",
                timestamp = DateTime.UtcNow
            });
        }
    }
}