namespace Full_GRASP_And_SOLID.Library
{
    /* Para solucionar este caso, se utiliza polimorfismo, ya que "cuando comportamientos relacionados 
    varian segun el tipo o clase, asignar las responsabilidades por el comportamiento usando
    operaciones polimorficas a los tipos cuyo comportamiento varia". Como esto se cumple para este caso,
    se debe separar la clase AllInOnePrinter en dos clases del mismo tipo,
    para luego aplicar las operaciones polimorficas sobre los mismos. Por esta razon, se crea una interfaz
    IDestination, y dos clases que implementan la misma, ConsolePrinter y FilePrinter, */
    public interface IDestination
    {
        void PrintRecipe(Recipe recipe, Destination destination);
    }
}