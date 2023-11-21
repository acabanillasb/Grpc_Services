using System.Text.Json;
using Grpc.Core;
using Server;

namespace Server.Services;

public class JsonFileService : JsonFile.JsonFileBase
{
    public override Task<RespuestaJsonFile> MetodoJsonFile(PeticionJsonFile request, ServerCallContext context)
    {
        string result = "";
        var jsonObject = JsonSerializer.Deserialize<Dictionary<string, object>>(request.JsonContent);
        Console.WriteLine("Datos del archivo JSON:");
        foreach (var key in jsonObject)
        {
            Console.WriteLine($"Key: {key.Key}, Value: {key.Value}");
            if(key.Key.Equals("serial"))
            {
                result = key.Value.ToString();
            }
        }
        return Task.FromResult(new RespuestaJsonFile
        {
            JsonResult = result
        });
    }
}