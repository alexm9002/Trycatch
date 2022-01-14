using System;

namespace Trycath
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int resultado = n1 / n2;
                Console.WriteLine(resultado);
            }

            //catch (Exception e) {
            //    Console.WriteLine("Erro! " + e.Message); // "e.Message" Retorna a mensagem automática do sistema.
            //}

            //onde "e" é o nome temporário para a exceção.
            //"DivideByZeroException" é uma subclasse da super classe (Exception)"
            //Nesse exemplo vai ser aplicado um "Upcasting" no sistema.
            //Onde a subclasse vai ser localizada dentro da superclasse.

            catch (DivideByZeroException)
            {
                Console.WriteLine("Erro! Não pode fazer divisão por zero!");
            }
            // ou também pode ser colocado a própria Exceção "DivideByZeroException" (Sem o "e" no final), e com a mensagem desejada.
            catch (FormatException)
            {
                Console.WriteLine("Sistema não permite entrada em formato texto. Digite apenas números!");
            }
            //Outro exemplo de tratamento de exceção. Agora para erro de texto.

        }
    }
}