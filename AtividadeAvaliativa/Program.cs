using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAvaliativa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            int contMeca = 0;
            int contDs = 0;
            int contEdif= 0;
            int contAdm = 0;
            int continuar = 1;
            int curso;
            while(continuar==1) {
                Console.WriteLine("Insira O curso que deseja matricular o aluno: 1(ds) 2(meca) 3(edif) 4(adm)");
                
                curso = int.Parse(Console.ReadLine());

                switch (curso)
                {
                    case 1:
                        contDs++;
                        if (contDs<=5) {
                            Console.WriteLine("O aluno foi matrículado em Desenvolvimento de Sistemas.");                            
                        }
                        else {
                            Console.WriteLine("Não há mais vagas neste curso.");
                            contDs--;
                     }
                    break; 
                        case 2:
                        contMeca++;
                        if (contMeca <= 5)
                        {
                            Console.WriteLine("O aluno foi matrículado em Mecatrônica.");                          
                        }
                        else
                        {
                            Console.WriteLine("Não há mais vagas neste curso.");
                            contMeca--;
                        }
                        break;
                    case 3:
                        contEdif++;
                        if (contEdif <= 5)
                        {
                            Console.WriteLine("O aluno foi matrículado em Edificações.");                            
                        }
                        else
                        {
                            Console.WriteLine("Não há mais vagas neste curso.");
                            contEdif--;
                        }
                        break;
                    case 4:
                        contAdm++;
                        if (contAdm <= 5)
                        {
                            Console.WriteLine("O aluno foi matrículado em Adminastração.");                            
                        }
                        else
                        {
                            Console.WriteLine("Não há mais vagas neste curso.");
                            contAdm--;
                        }
                        break;                     
                }
                cont++;
                Console.WriteLine("Você deseja continuar: 1(sim)/2(não)");
                continuar = int.Parse(Console.ReadLine());                              
            }
            Console.WriteLine("Foram inscritas na seletiva " + cont + " pessoas, sendo que "
                + contDs + " pessoas foram inscritas em Desenvolvimento de Sistemas, "
                + contAdm + " pessoas foram inscritas em Administração, "
                +contEdif + " pessoas foram inscritas em Edificações, "
                +contMeca+" pessoas foram inscritas em Mecatrônica.");
            Console.ReadKey();
        }
    }
}
