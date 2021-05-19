using System;
using System.Collections.Generic;
using System.Text;

namespace Aluno
{
    class Aluno
    {

        public Aluno()
        {

        }

        public Aluno(int RA, string Nome, double Nota1, double Nota2)
        {
            this.RA = RA;
            this.Nome = Nome;
            this.Nota1 = Nota1;
            this.Nota2 = Nota2;
        }

        public int RA
        {
            get { return RA; }
            set
            {
                if (value > 0)
                {
                    RA = value;
                }
                else
                {
                    RA = 0;
                }
            }
        }
        public string Nome
        {
            get { return Nome; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Nome = "";
                }
                else if (value.Length > 5)
                {

                    Nome = "";
                }
                else
                {
                    Nome = value;
                }
            }
        }
        public double Nota1 { 
            get { return Nota1;  } 
            set
            {
                if ( value < 0)
                {
                    Nota1 = 0;
                } 
                else
                {
                    Nota1 = value;
                }
            }
        }
        public double Nota2
        {
            get { return Nota2; }
            set
            {
                if (value < 0)
                {
                    Nota2 = 0;
                }
                else
                {
                    Nota2 = value;
                }
            }        
        }

        public double CalcularMedia()
        {
            return (this.Nota1 + this.Nota2) / 2;
        }


        public void VerificaSituacao()
        {
            double Media = CalcularMedia();
            if (Media >= 5)
                Console.WriteLine("Aprovado");
            else
                Console.WriteLine("Reprovado");
        }



    }
}
