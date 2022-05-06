
using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{

    //Creo una nueva clase ConsolePrinter, la cual va a ser la encargada de imprimir la receta en consola.
    public class FilePrinter : IDestination
    {
        public void PrintRecipe(Recipe recipe, Destination destination)
        {
            File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());
        }
    }
}