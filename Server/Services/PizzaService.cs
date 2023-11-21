using Grpc.Core;
using Server;

namespace Server.Services;

public class PizzaService : Pizza.PizzaBase
    {
        public override Task<RespuestaPizza> MetodoPizza(PeticionPizza request, ServerCallContext context)
        {
            var ingredientes = ObtenerIngredientes(request.Tipo);
            Console.WriteLine($"El tipo de pizza recibido es: {request.Tipo}");
            return Task.FromResult(new RespuestaPizza
            {
                Ingredientes = {ingredientes}
            });
        }

        private IEnumerable<string> ObtenerIngredientes(string tipo)
        {
            // Aquí iría la lógica para determinar los ingredientes basado en el tipo de pizza.
            // Por ejemplo, una simple comprobación con un switch o una búsqueda en una base de datos.
            switch (tipo)
            {
                case "Margarita":
                    return new[] { "Tomate", "Mozzarella", "Albahaca" };
                case "Pepperoni":
                    return new[] { "Tomate", "Mozzarella", "Pepperoni" };
                case "Calzone":
                    return new[] { "Tomate", "Mozarella", "Orégano", "Mascarponne", "Rucula"};
                // Agrega más casos según sea necesario.
                default:
                    throw new ArgumentException("Tipo de pizza no reconocido");
            }
        }
    }
