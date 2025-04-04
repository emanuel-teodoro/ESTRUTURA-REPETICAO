internal class Program
{
    private static void Main(string[] args)
    {
        int N1, N2;
        string resposta;
        //UTILIZAÇÃO DE ESTRUTURAS CONDICIONAIS COMO DO/WHILE E IF/ELSE
        do {//DO PARA RODAR O CODIGO TODO EM LOOP ATE O USUARIO DECIDIR ENCERRAR
            
            Console.WriteLine("Informe o 1 valor");
            N1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o 2 valor");
            N2 = int.Parse(Console.ReadLine());
               
            //CORPO DO CODIGO UTILIZANDO IF/ELSE
                if (N1 > N2)
                {
                    Console.WriteLine("O maior valor é: " + N1);
                }
                else if (N2 > N1)
                {
                    Console.WriteLine("O maior valor é: " + N2);
                }
                else
                {
                    Console.WriteLine("Ambos os valores são iguais");
                }

                Console.WriteLine("Deseja realizar outra operação SIM/NÃO");
                resposta = Console.ReadLine().ToLower();
                
        } while (resposta == "sim");//CONDIÇÃO QUE MANTEM O CODIGO RODANDO EM LOOP ATE O USUARIO PARAR

        Console.WriteLine("Programa encerrado");
    }
}