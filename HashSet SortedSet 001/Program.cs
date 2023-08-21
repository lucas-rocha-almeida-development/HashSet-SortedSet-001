using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet_SortedSet_001
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //instanciando um conjunto
            HashSet <string> set = new HashSet<string>();

            set.Add ("TV");
            set.Add("Notebook");
            set.Add("Playstation");
            //verificação se a palavra (string) valor definido existe no conjunto
            Console.WriteLine(set.Contains("TV"));//caso exista ira retornar true

            //vale lembrar que não podemos usar o for (justamente porque não e organizado pelo indice)
            //conforme e utilizado em uma lista ou vetores (array)
            //basicamente e obrigatorio utilizarmos o foreach
            foreach (string s in set)
            {
                
                Console.WriteLine( s);
            }


        }
    }
}
