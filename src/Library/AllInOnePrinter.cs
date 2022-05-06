//---------------------------------------------------------------------------------
// <copyright file="AllInOnePrinter.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------
using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    public enum Destination
    {
        Console,
        File
    }

    // Una vez utilizado polimorfismo, esta clase no se utiliza mas. 

    public class AllInOnePrinter
    {
        public void PrintRecipe(Recipe recipe, Destination destination)
        {
            if (destination == Destination.Console)
            {
                Console.WriteLine(recipe.GetTextToPrint());
            }
            else
            {
                File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());
            }
        }
    }
}