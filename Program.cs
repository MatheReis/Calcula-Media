using System;

namespace Idade_Média_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            Double media = 0;
            Double idade1 = 0;
            Double idade2 = 0;
            Double idade3 = 0;
            Double idade4 = 0;
            Double idade5 = 0;

            //idades dos alunos
            Console.WriteLine("Programa que calcula a idade media de cinco alunos");
            Console.WriteLine("Informe a idade do 1° aluno :");
            idade1 = Convert.ToDouble((Console.ReadLine()));

            Console.WriteLine("Programa que calcula a idade media de cinco alunos");
            Console.WriteLine("Informe a idade do 2° aluno :");
            idade2 = Convert.ToDouble((Console.ReadLine()));

            Console.WriteLine("Programa que calcula a idade media de cinco alunos");
            Console.WriteLine("Informe a idade do 3° aluno :");
            idade3 = Convert.ToDouble((Console.ReadLine()));

            Console.WriteLine("Programa que calcula a idade media de cinco alunos");
            Console.WriteLine("Informe a idade do 4° aluno :");
            idade4 = Convert.ToDouble((Console.ReadLine()));

            Console.WriteLine("Programa que calcula a idade media de cinco alunos");
            Console.WriteLine("Informe a idade do 5° aluno :");
            idade5 = Convert.ToDouble((Console.ReadLine()));
            
            //média das idades
            media = (idade1 + idade2 + idade3 + idade4 + idade5) / 5;
            Console.WriteLine("A idade média dos alunos é " + media);
            Console.ReadKey();
        }
    }
}
