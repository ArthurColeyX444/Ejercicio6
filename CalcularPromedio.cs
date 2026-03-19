using System;

public class Class1
{
	public Class1()
	{

        
        /// Calcula el promedio de una lista de números.
        
        /// <param name="numeros">Lista de números enteros</param>
        /// <returns>Promedio de los números</returns>
        public double CalcularPromedio(List<int> numeros)
    {
        if (numeros == null || numeros.Count == 0)
        {
            return 0;
        }

        double suma = 0;

        foreach (int numero in numeros)
        {
            suma += numero;
        }

        double promedio = suma / numeros.Count;

        return promedio;
    }
}
}
