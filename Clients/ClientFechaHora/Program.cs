using Grpc.Core;
using Grpc.Net.Client;
//using Client; // Usa el espacio de nombres generado para tu cliente
using Server;
using Clients.ClientConfig;

namespace ClientFechaHora;

class Program
{
    static async Task Main(string[] args)
    {
        // Suponiendo que el servidor esté corriendo en http://localhost:5001
        //using var channel = GrpcChannel.ForAddress("http://localhost:50051");
        //using var channel = GrpcChannel.ForAddress("http://172.17.0.3:50051");
        var cl = new ClientConfig();
        Console.WriteLine("Servicio FechaHora...");
        // Crear el cliente para el servicio FechaHora
        var fechaHoraClient = new FechaHora.FechaHoraClient(cl.GrpcChannel);
        
        try
        {
            // Enviar la solicitud y recibir la respuesta
           var reply = await fechaHoraClient.MetodoFechaHoraAsync(new PeticionFechaHora());
            Console.WriteLine("Fecha: " + reply.FechaHoy + " Hora: " + reply.HoraHoy);
        }
        catch (RpcException e)
        {
            Console.WriteLine(e.Status.Detail);
        }
    }
}