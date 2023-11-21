using Grpc.Net.Client;
using Grpc.Core;
using Interfaces;

namespace Clients.ClientConfig;

public class ClientConfig : IGrpcClient
{   
    public string Url { get => _url;}

    public GrpcChannel GrpcChannel { get => _channel;}
    private readonly string _url;
    private readonly GrpcChannel _channel;

    public ClientConfig()
    {
        
        _url = "localhost:50051";
        _channel = GrpcChannel.ForAddress($"http://{_url}");
    }

}