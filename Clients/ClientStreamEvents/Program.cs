using Grpc.Net.Client;
using Grpc.Core;
//using Client; // Usa el espacio de nombres generado para tu cliente
using Server;
using Clients.ClientConfig;
using System.Net;
/*
** GRPC de Cliente a Servidor con streaming en servidor, es decir,
** el servidor al recibir la petición del cliente, éste se queda abierto hasta 
** recibir el token de cancelación.
*/

namespace ClientStreamEvents;
class Program
{
    static async Task Main(string[] args)
    {
        // Suponiendo que el servidor esté corriendo en http://localhost:5001
        //using var channel = GrpcChannel.ForAddress("http://localhost:50051");
        //using var channel = GrpcChannel.ForAddress("http://172.17.0.3:50051");
        var cl = new ClientConfig();
        var client = new StreamEvents.StreamEventsClient(cl.GrpcChannel);
        string[] message = { "Mensaje cliente","Mensaje 2"};
        var cts = new CancellationTokenSource(TimeSpan.FromSeconds(10));
        // Crear una solicitud basada en el mensaje definido en tu archivo .proto


        var request = new ListenEventsRequest 
            { 
                MessageRequest = { message },
                DelaySeconds = 2
            
            };

        using (var call = client.ListenEvents(request))
        {
            int cont = 0;
            await foreach (var x in call.ResponseStream.ReadAllAsync())
            {
                Console.WriteLine($"{x.MessageResponse}");
                cont++;
                if(request.MessageRequest.Count == cont)
                    break;
            }
            Console.WriteLine("Finished. Press a key to close.");
            Console.ReadKey();


            /*
            while (await call.ResponseStream.MoveNext(cancellationToken: cts.Token))
            {
                var response = call.ResponseStream.Current;
                Console.WriteLine($"Mensaje del servidor: {response.MessageResponse}");
                Thread.Sleep(1);
            }*/
        }


        /*try
        {
            // Enviar la solicitud y recibir la respuesta
            var reply = await client.ListenEventsAsync(request);

            Console.WriteLine("Respuesta del servidor: " + reply.MessageResponse);
        }
        catch (RpcException e)
        {
            Console.WriteLine(e.Status.Detail);
        }*/
    }
}