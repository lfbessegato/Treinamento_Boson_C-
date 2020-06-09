using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> valores = new List<int>();

            //Insere no final da Lista
            valores.Add(16);
            valores.Add(18);
            valores.Add(23);
            valores.Add(12);

            //Array 
            int[] numeros = new int[] { 32, 12, 7, 20 };

            //Adciona um range de numeros do array a Lista
            valores.AddRange(numeros);

            Console.WriteLine("A lista possui " + valores.Count() + " elementos");
            Console.WriteLine("O primeiro item é " + valores[0]);

            // Exibir cada elemento da lista
            foreach(int item in valores)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("Inserido o item 13 (Insert), na posição 1 da Lista");

            //A propriedade insere o elemento em uma posição desejada
            valores.Insert(1, 13);
            foreach (int item in valores)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("Remove o item 12 (Remove), na primeira ocorrencia que for encontrada");
            valores.Remove(12);
            foreach (int item in valores)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("Remove o item de uma posicao qualquer (RemoveAt), na primeira ocorrencia que for encontrada");
            valores.RemoveAt(2);
            foreach (int item in valores)
            {
                Console.WriteLine(item.ToString());
            }
           
            //Pesquisar a existencia de um item
            int valorProcurado = 16;
            bool valorExiste;

            valorExiste = valores.Contains(valorProcurado);

            if (valorExiste)
            {
                Console.WriteLine("Valor encontrado!");
            } else
            {
                Console.WriteLine("Valor não encontrado!");
            }

            Console.WriteLine("Ordernar uma Lista (Sort");
            valores.Sort();
            foreach (int item in valores)
            {
                Console.WriteLine(item.ToString());
            }


            Console.ReadLine();
        }
    }
}
