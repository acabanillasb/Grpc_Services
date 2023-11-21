using Grpc.Core;
using Server;

namespace Server.Services;

public class NumberGeneratorService : NumberGenerator.NumberGeneratorBase
{
    public override async Task Generate(
              GenerationOptions request, 
              IServerStreamWriter<GeneratedNumber> responseStream, 
              ServerCallContext context)
    {
        /* parámetro que se envia desde cliente , que en este caso su valor es 10*/
        var current = request.Start;
        while (!context.CancellationToken.IsCancellationRequested)
        {
            /* Función del servidor */
            var number = new GeneratedNumber()
            {
                Number = current++,
                GeneratedAtTicks = DateTime.Now.Ticks
            };
            await responseStream.WriteAsync(number);
            if (current - request.Start == 10)
                break;
            await Task.Delay(request.DelaySeconds * 1000);
        }
    }
}