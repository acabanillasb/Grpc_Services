using Grpc.Net.Client;
using Grpc.Core;
//using Client; // Usa el espacio de nombres generado para tu cliente
using Server;
using Clients.ClientConfig;

class Program
{
    static async Task Main(string[] args)
    {
        // Suponiendo que el servidor esté corriendo en http://localhost:5001
        //using var channel = GrpcChannel.ForAddress("http://localhost:50051");
        //using var channel = GrpcChannel.ForAddress("http://172.17.0.3:50051");
        var cl = new ClientConfig();
        
        var client = new Saludo.SaludoClient(cl.GrpcChannel);
        var nombre = "Pepe";
        // Crear una solicitud basada en el mensaje definido en tu archivo .proto
        var request = new PeticionSaludo { Name = nombre/* Set properties */ };

        try
        {
            // Enviar la solicitud y recibir la respuesta
            var reply = await client.MetodoSaludoAsync(request);

            Console.WriteLine("Respuesta del servidor: " + reply.Message);
        }
        catch (RpcException e)
        {
            Console.WriteLine(e.Status.Detail);
        }
    }
}