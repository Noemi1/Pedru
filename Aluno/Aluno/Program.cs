using System;

namespace Aluno
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aluno aluno = new Aluno();

            //Console.Write("Nome do aluno: ");
            //aluno.Nome = Console.ReadLine();
            //Console.Write("RA: ");
            //aluno.RA = Convert.ToInt32(Console.ReadLine());
            //Console.Write("NOTA 1: ");
            //aluno.Nota1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("NOTA 2: ");
            //aluno.Nota2 = Convert.ToDouble(Console.ReadLine());


            //aluno.Nome = "Noemi";
            //aluno.RA = 15;
            //aluno.Nota1 = 10;
            //aluno.Nota2 = 10;


            Aluno aluno = new Aluno(125, "Noemi", 10, 10);
            aluno.VerificaSituacao();




        }
    }
}
