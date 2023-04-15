/*void matriz ()
{
    string[] nombre = new string[]
    {
        "Anderson", "Brandon", "Yeimi","Fatima","Vivian"
    };
    foreach (string n in nombre)
    {
        Console.WriteLine("nombre:" + n);
    }
    int[] notas = new int[]  ( 25, 30, 50, 75, 90);
    int mayor = 0;
    for (int i=1; i<notas.Length; i++)
    {
        if (notas[i]> notas[mayor])
        {
            mayor = i;
        }
    }
    Console.WriteLine("El alumno con la nota mas alta es:" + nombre[mayor] + "y su nota es de" + notas[mayor]);
}
matriz();*/

void matriz()
{
    Console.WriteLine("Ingrese la cantidad de alumnos:");
    int numAlumnos = int.Parse(Console.ReadLine());
    string[] nombre = new string[numAlumnos];
    int[] notas = new int[numAlumnos];
    for (int i = 0; i < numAlumnos; i++)
    {
        Console.WriteLine("Ingrese el nombre del alumno " + (i+1) + ":");
        nombre[i] = Console.ReadLine();
        Console.WriteLine("Ingrese la nota del alumno " + (i+1) + ":");
        notas[i] = int.Parse(Console.ReadLine());
    }
   
    int mayor = 0;
    int menor = 0;
    for (int i = 1; i < numAlumnos; i++)
    {
        if (notas[i] > notas[mayor])
        {
            mayor = i;
        }
        if (notas[i] < notas[menor])
        {
            menor = i;
        }
    }
    Console.WriteLine("El alumno con la nota más alta es: " + nombre[mayor] + " y su nota es de " + notas[mayor]);
    Console.WriteLine("El alumno con la nota más baja es: " + nombre[menor] + " y su nota es de " + notas[menor]);
}
matriz();
Console.ReadLine();


