using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Net.Client;

namespace Interfaces
{
    public interface IGrpcClient
    {
        string Url { get; }
        GrpcChannel GrpcChannel { get; }
    }
}