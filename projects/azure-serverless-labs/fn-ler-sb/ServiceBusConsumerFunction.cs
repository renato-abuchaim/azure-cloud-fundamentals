using System.Text;
using Azure.Messaging.ServiceBus;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace fn_ler_sb
{
    public class ServiceBusConsumerFunction
    {
        private readonly ILogger<ServiceBusConsumerFunction> _logger;
        private readonly HttpClient _httpClient;

        public ServiceBusConsumerFunction(
            ILogger<ServiceBusConsumerFunction> logger,
            HttpClient httpClient)
        {
            _logger = logger;
            _httpClient = httpClient;
        }

        [Function(nameof(ServiceBusConsumerFunction))]
        public async Task Run(
            [ServiceBusTrigger(
                "logicapp",
                Connection = "ServiceBusConnection")]
            ServiceBusReceivedMessage message,
            ServiceBusMessageActions messageActions)
        {
            _logger.LogInformation(
                "Mensagem recebida.");

            _logger.LogInformation(
                "MessageId: {id}",
                message.MessageId);

            _logger.LogInformation(
                "Body: {body}",
                message.Body);

            var jsonContent = message.Body.ToString();

            var content = new StringContent(
                jsonContent,
                Encoding.UTF8,
                "application/json");

            var apiUrl =
                Environment.GetEnvironmentVariable("ApiUrl");

            if (string.IsNullOrWhiteSpace(apiUrl))
            {
                _logger.LogError(
                    "ApiUrl não configurada.");

                await messageActions.DeferMessageAsync(message);
                return;
            }

            var response =
                await _httpClient.PostAsync(
                    apiUrl,
                    content);

            if (response.IsSuccessStatusCode)
            {
                _logger.LogInformation(
                    "Mensagem processada com sucesso.");

                await messageActions
                    .CompleteMessageAsync(message);
            }
            else
            {
                _logger.LogError(
                    "Falha ao enviar mensagem para API.");

                await messageActions
                    .DeferMessageAsync(message);
            }
        }
    }
}