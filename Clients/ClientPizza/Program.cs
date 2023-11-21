using Grpc.Net.Client;
using Grpc.Core;
//using Client; // Usa el espacio de nombres generado para tu cliente
using Server;
using Clients.ClientConfig;

public class ListaPizza
{
    public string[] Pizzas {get => _pizzas;}
    private readonly string[] _pizzas;

    public ListaPizza()
    {
        _pizzas = new string[] { "Pepperoni", "Calzone", "Margarita" };
    }
}

class Program
{
    static async Task Main(string[] args)
    {
        // Suponiendo que el servidor esté corriendo en http://localhost:5001
        //using var channel = GrpcChannel.ForAddress("http://localhost:50051");
        //using var channel = GrpcChannel.ForAddress("http://172.17.0.3:50051");
        ClientConfig cl = new ClientConfig();
        var pizza = new Pizza.PizzaClient(cl.GrpcChannel);
        /*******/
        var pz = new ListaPizza();

        Console.WriteLine("Listado de pizzas disponibles");
        Console.WriteLine("#############################");
        foreach (var item in pz.Pizzas)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("\nIntroducir pizza a pedir: ");
        var tipo = Console.ReadLine();
        var request = new PeticionPizza { Tipo = tipo/* Set properties */ };

        try
        {
            // Enviar la solicitud y recibir la respuesta
            var reply = await pizza.MetodoPizzaAsync(request);

            Console.WriteLine("Ingredientes: " + reply.Ingredientes);
        }
        catch (RpcException e)
        {
            Console.WriteLine(e.Status.Detail);
        }
        Console.ReadKey();
    }
}