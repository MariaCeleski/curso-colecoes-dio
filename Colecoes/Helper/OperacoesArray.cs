using System;

namespace Colecoes.Helper
{
    public class OperacoesArray
    {
        public void OrdenarBubbleSort(ref int[] array)
        {
            int temp = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }

        public void ImprimirArray(int[] array)
        {
            var linha = string.Join(", ", array);
            System.Console.WriteLine(linha);
        }

        public void Ordenar(ref int[] array)
        {
            Array.Sort(array);
        }

        public void Copiar(ref int[] array, ref int[] arrayDestino)
        {
            Array.Copy(array, arrayDestino, array.Length);
        }

        public bool Existe(int[] array, int valor)//verificando um elemento existente
        {
            return Array.Exists(array, elemento => elemento == valor);
        }

        public bool TodosMaiorQue(int[] array, int valor)//verificando todos os elementos do array
        {
            return Array.TrueForAll(array, elemento => elemento > valor);
        }

        public int ObterValor(int[] array, int valor)//encontrar um elemento no array
        {
            return Array.Find(array, element => element == valor);
        }

        public int ObterIndice(int[] array, int valor)//encontrando o índice de um valor
        {
            return Array.IndexOf(array, valor);//recebe o valor que procura, se não encontrar retorna -1
        }

        public void RedimensionarArray(ref int[] array, int novoTamanho)//redimensionando um array
        {
            Array.Resize(ref array, novoTamanho);
        }

        public string[] ConverterParaArrayString(int[] array)//convertendo um array
        {
            return Array.ConvertAll(array, elemento => elemento.ToString());
        }
    }
}