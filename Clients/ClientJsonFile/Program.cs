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
        //ClientConfig cl = new ClientConfig();
        var cl = new ClientConfig();
        var jsonFileClient = new JsonFile.JsonFileClient(cl.GrpcChannel);
        var json_path = "/datos/Grpc_Services/prueba.json";

        // Leer el contenido del JSON
        string content = File.ReadAllText(json_path);

        try
        {
            // Enviar la solicitud y recibir la respuesta
            var reply = await jsonFileClient.MetodoJsonFileAsync(new PeticionJsonFile { JsonContent = content});


            Console.WriteLine("serial = " + reply.JsonResult);
        }
        catch (RpcException e)
        {
            Console.WriteLine(e.Status.Detail);
        }
        Console.ReadKey();
    }
}