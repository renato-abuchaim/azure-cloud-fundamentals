using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace fn_tempo
{
    public class ScheduledTaskFunction
    {
        private readonly ILogger _logger;

        public ScheduledTaskFunction(
            ILoggerFactory loggerFactory)
        {
            _logger =
                loggerFactory.CreateLogger<ScheduledTaskFunction>();
        }

        [Function(nameof(ScheduledTaskFunction))]
        public void Run(
            [TimerTrigger("*/5 * * * * *")]
            TimerInfo timer)
        {
            _logger.LogInformation(
                $"Função executada em: {DateTime.UtcNow}");

            if (timer.ScheduleStatus is not null)
            {
                _logger.LogInformation(
                    $"Próxima execução: {timer.ScheduleStatus.Next}");
            }
        }
    }
}