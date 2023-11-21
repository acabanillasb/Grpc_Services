using Grpc.Core;
using Server;

namespace Server.Services
{
    public class FechaHoraService : FechaHora.FechaHoraBase
    {
        public override Task<RespuestaFechaHora> MetodoFechaHora(PeticionFechaHora request, ServerCallContext context)
        {
            Console.WriteLine("Petición de fecha y hora...");
            var resultados = ObtenerFechaHora();
            
            return Task.FromResult(new RespuestaFechaHora
            {
                FechaHoy = resultados.Item1,
                HoraHoy =  resultados.Item2
            });
        }

        private (string, string) ObtenerFechaHora()
        {
            //Obtengo fecha y hora local
            TimeZoneInfo timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("Europe/Berlin");

            var dat = DateTime.Now; 
            var fechaHoy = dat.ToString("dd/MM/yyyy");
            // Hora
            DateTimeOffset localTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, timeZoneInfo);
            //Console.WriteLine(localTime.ToString("HH:mm:ss"));
            string horaHoy = localTime.ToString("HH:mm:ss");
            return (fechaHoy, horaHoy);

        }
    }
}