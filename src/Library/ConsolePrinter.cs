// Esta clase esta hecha para complementar el código provisto implementandole el principio de SRP, donde cada clase tiene una unica función, en este caso, ser el que imprime por consola.
using Full_GRASP_And_SOLID.Library;
using System;
namespace Full_GRASP_And_SOLID{
    public class ConsolePrinter{
        public static void ImprimirReceta(Recipe receta){
            Console.WriteLine($"Receta de {receta.FinalProduct.Description}:");
            foreach (Step step in receta.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        }
    }
}