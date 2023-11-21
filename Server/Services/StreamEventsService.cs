using Grpc.Core;
using Server;

namespace Server.Services;

public class StreamEventsService : StreamEvents.StreamEventsBase
{
    public override async Task ListenEvents(
                ListenEventsRequest request,
                IServerStreamWriter<ListenEventsResponse> responseStream,
                ServerCallContext context)
    {
        Console.WriteLine("Petición eventos...");

        while (!context.CancellationToken.IsCancellationRequested)
        {
            foreach (var m in request.MessageRequest)
            {
                var s = new ListenEventsResponse()
                {
                    MessageResponse = m
                };
                await responseStream.WriteAsync(s);

                await Task.Delay(request.DelaySeconds * 1000);
            }
        }
    }
}