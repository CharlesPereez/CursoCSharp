// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Console.WriteLine(factorial(5));



static int factorial(int numero)
{

    //base
    if (numero == 1) return 1;

    //recursion
    return numero * factorial(numero - 1);
}


/*static int factorial(int numero)
{
    int res = 1;

    for (int i = numero; i >= 1; i--)
    {
        res *= i;
    }
    return res;
}*/