using Grpc.Core;
using Grpc.Core.Interceptors;

namespace Server.Services;

public class LogInterceptor : Interceptor 
{
    public override async Task<TResponse> UnaryServerHandler<TRequest, TResponse>(
        TRequest request, ServerCallContext context, UnaryServerMethod<TRequest, TResponse> continuation)
    {
        Console.WriteLine($"Call received: Method={context.Method}");
        return await continuation(request, context);
    }
}