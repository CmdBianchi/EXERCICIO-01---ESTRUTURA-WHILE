using System;

namespace EXERCICIO_01___ESTRUTURA_WHILE
{
class Program{
        /// -------> START / MAIN 
        /////////////////////////////////////////////////////////////////////////////////////////////
        static void Main(string[] args){
            Msg();
            Conditional();
        }
        /// -------> FUNCTIONS
        /////////////////////////////////////////////////////////////////////////////////////////////
        static void Msg(){
            Console.WriteLine("Determine qual o quadrante ao qual pertence o ponto.");
        }
        //------------------------------------------------------------------------------------------//
        static void Conditional(){
            Console.Write("DIGITE A SENHA: ");
            int password = int.Parse(Console.ReadLine());

            while (password != 2002){
                Console.Write("SENHA INVALIDA DIGITE NOVAMENTE: ");
                password = int.Parse(Console.ReadLine());//---------> DEVE-SE POR, PARA NAO CAIR EM LOOP INFINITO.
            }
            Console.WriteLine("Acesso Permitido");
        }
        /////////////////////////////////////////////////////////////////////////////////////////////
        /// -------> END
    }
}
