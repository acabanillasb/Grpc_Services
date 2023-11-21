using Grpc.Net.Client;
using Grpc.Core;
//using Client; // Usa el espacio de nombres generado para tu cliente
using Server;
using Clients.ClientConfig;

class Program
{
    static async Task Main(string[] args)
    {
       /* Se crea la conexión con el Servidor */
        var cl = new ClientConfig();
        var client = new NumberGenerator.NumberGeneratorClient(cl.GrpcChannel);
        /* Creo objeto cliente */
        var options = new GenerationOptions()
        {
            Start = 10,
            DelaySeconds = 2
        };
        /* LLamo a la función rpc desde cliente y le paso como parámetro el objeto de cliente al servidor,
        aquí es donde empieza la llamada al servidor*/
        using (var response = client.Generate(options))
        {
            await foreach (var number in response.ResponseStream.ReadAllAsync())
            {
                var time = new DateTime(number.GeneratedAtTicks);
                Console.WriteLine($"{number.Number} generated at {time:T}");
            }
        }
        Console.WriteLine("Finished. Press a key to close.");
        Console.ReadKey();
    }
}