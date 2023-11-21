using Grpc.Core;
using Server;

namespace Server.Services;

public class SaludoService : Saludo.SaludoBase
{
    public override Task<RespuestaSaludo> MetodoSaludo(PeticionSaludo request, ServerCallContext context)
    {
        Console.WriteLine("Se saluda...");
        return Task.FromResult(new RespuestaSaludo
        {
            Message = "Hola " + request.Name
        });
    }
}
