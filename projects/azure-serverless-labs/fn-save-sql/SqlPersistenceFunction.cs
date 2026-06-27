using System.Net;
using System.Text.Json;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Extensions.Sql;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace fn_save_sql
{
    public static class SqlPersistenceFunction
    {
        [Function(nameof(SqlPersistenceFunction))]
        public static async Task<OutputType> Run(
            [HttpTrigger(
                AuthorizationLevel.Function,
                "post",
                Route = "clientes")]
            HttpRequestData req,
            FunctionContext context)
        {
            var logger =
                context.GetLogger(nameof(SqlPersistenceFunction));

            logger.LogInformation(
                "Recebendo novo cliente.");

            var cliente =
                await JsonSerializer.DeserializeAsync<ClienteItem>(
                    req.Body);

            cliente ??= new ClienteItem();

            cliente.Id = Guid.NewGuid();
            cliente.DataCadastro = DateTime.UtcNow;

            var response =
                req.CreateResponse(HttpStatusCode.Created);

            await response.WriteStringAsync(
                "Cliente cadastrado com sucesso.");

            return new OutputType
            {
                Cliente = cliente,
                HttpResponse = response
            };
        }
    }

    public class OutputType
    {
        [SqlOutput(
            "dbo.Clientes",
            connectionStringSetting:
            "SqlConnectionString")]
        public ClienteItem Cliente { get; set; }

        public HttpResponseData HttpResponse { get; set; }
    }
}