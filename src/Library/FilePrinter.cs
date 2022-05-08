
using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{

    // Creo una nueva clase FilePrinter, la cual va a ser la encargada de imprimir la receta
    // en un archivo de texto.
    public class FilePrinter : IDestination
    {
        public void PrintRecipe(Recipe recipe)
        {
            File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());
        }
    }
}