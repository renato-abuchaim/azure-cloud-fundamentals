using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace fn_input_blob
{
    public class BlobProcessorFunction
    {
        [Function(nameof(BlobProcessorFunction))]
        [BlobOutput(
            "output/{name}-output.txt",
            Connection = "BlobStorageConnection")]
        public static string Run(
            [BlobTrigger(
                "samples-workitems/{name}",
                Connection = "BlobStorageConnection")]
            string triggerContent,

            [BlobInput(
                "samples-workitems/{name}",
                Connection = "BlobStorageConnection")]
            string blobContent,

            string name,
            FunctionContext context)
        {
            var logger =
                context.GetLogger(nameof(BlobProcessorFunction));

            logger.LogInformation(
                "Arquivo recebido: {name}",
                name);

            logger.LogInformation(
                "Conteúdo: {content}",
                blobContent);

            return
$"""
Arquivo processado com sucesso.

Nome:
{name}

Conteúdo:
{blobContent}

Processado em:
{DateTime.UtcNow}
""";
        }
    }
}