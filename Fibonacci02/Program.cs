int resultado = 0;
int numeroEscolhido = 0;
int numeroAnterior = 0;
int numeroAtual = 1;
bool pertence = false;

try
{
    Console.WriteLine("Digite um número inteiro: ");
    numeroEscolhido = int.Parse(Console.ReadLine());

    Console.WriteLine(resultado);
    do
    {
        resultado = numeroAnterior + numeroAtual;
        numeroAnterior = numeroAtual;
        numeroAtual = resultado;
        Console.WriteLine(resultado);
        if (numeroEscolhido == resultado)
        {
            pertence = true;
        }
    } while (resultado <= numeroEscolhido);


    string simOuNao = pertence ? "" : "não";
    string pertenceOuNao = $"O número informado({numeroEscolhido}) {simOuNao} pertence a sequência.";
    Console.WriteLine(pertenceOuNao);

    Console.WriteLine("\n Aperte qualquer tecla para continuar:");
    Console.ReadLine();

}
catch (Exception e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine("\nAperte qualquer tecla para continuar:");
    Console.ReadLine();
}


