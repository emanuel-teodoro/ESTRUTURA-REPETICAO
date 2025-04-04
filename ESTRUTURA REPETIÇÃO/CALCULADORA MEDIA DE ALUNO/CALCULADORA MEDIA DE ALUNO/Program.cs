internal class Program
{
    private static void Main(string[] args)
    {
        int N1, N2, N3, N4, media;
        string resposta;

        do
        {
            Console.WriteLine("Informe a nota do 1 bimestre");
            N1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a nota do 2 bimestre");
            N2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a nota do 3 bimestre");
            N3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a nota do 4 bimestre");
            N4 = int.Parse(Console.ReadLine());

            media = (N1 + N2 + N3 + N4) / 4;

            if (media >= 3 && media < 6)
            {
                Console.WriteLine("Aluno em recuperação: Nota " + media);
            }
            else if(media >= 6)
            {
                Console.WriteLine("Aluno aprovado: Nota " + media);
            }
            else
            {
                Console.WriteLine("Aluno reprovado: Nota " + media);
            }

            Console.WriteLine("Deseja realizar outra operação? SIM/NÃO");
            resposta = Console.ReadLine().ToLower();
        } while (resposta == "sim");

        Console.WriteLine("Programa finalizado.");
    }
}