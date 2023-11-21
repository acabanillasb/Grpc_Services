using Grpc.Core;
using System.Threading.Tasks;
using Server.Services;
using Server;
using Grpc.Core.Interceptors;
using Microsoft.Extensions.Options;
/*
class Program
{
const int Port = 50051;

public static async Task Main(string[] args)
{
    Grpc.Core.Server server = new Grpc.Core.Server
    {
        Services = 
        {
            Saludo.BindService(new SaludoService()),
            Pizza.BindService(new PizzaService()),
            FechaHora.BindService(new FechaHoraService())
        },
        Ports = { new ServerPort("0.0.0.0", Port, ServerCredentials.Insecure) }
    };

    server.Start();

    System.Console.WriteLine($"Server listening on port {Port}");
    System.Console.WriteLine("Press any key to stop the server...");
    System.Console.ReadKey();

    await server.ShutdownAsync();
}
}
*/

var builder = WebApplication.CreateBuilder(args);

// Agrega servicios al contenedor.
builder.Services.AddGrpc(options =>
{
    options.Interceptors.Add<LogInterceptor>();
});

// Agreo el evento del interceptor
builder.Services.AddSingleton<LogInterceptor>();

var app = builder.Build();

// Configura la canalización de procesamiento de solicitudes HTTP.
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    // Registrar el servicio Saludo con el interceptor
    endpoints.MapGrpcService<SaludoService>();
    // Registrar el servicio Pizza
    endpoints.MapGrpcService<PizzaService>();
    // Registrar el servicio FechaHora
    endpoints.MapGrpcService<FechaHoraService>();
    // Registrar el servicio JsonFile
    endpoints.MapGrpcService<JsonFileService>();
    // Stream
    endpoints.MapGrpcService<StreamEventsService>();
    // Stream NumberGenerator
    endpoints.MapGrpcService<NumberGeneratorService>();
});

app.Run();
