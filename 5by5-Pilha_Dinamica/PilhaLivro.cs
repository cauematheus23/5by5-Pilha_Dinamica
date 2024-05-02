using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5by5_Pilha_Dinamica
{
    internal class PilhaLivro
    {
        Livro topo; //Topo da pilha

        public PilhaLivro() //construtor inicial declarando a pilha vazia
        {
            this.topo = null;
        }
        bool PilhaVazia() //verifica se o topo é vazio, se sim pilha vazia
        {
            if (this.topo == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void push(Livro aux) //insere o Objeto livro na pilha
        {
            if (PilhaVazia() == true)
            {
                topo = aux; //Se topo vazio ele recebe o livro aonde a auxiliar esta apontando
            }
            else
            {
                aux.setAnterior(topo); //Se nao o anterior recebe o topo e o topo recebe o aux
                topo = aux;
                
            }
        }
        public void print()
        {
            Livro aux = topo;
            if (PilhaVazia())
            {
                Console.WriteLine("Impossivel imprimir, pilha vazia");
                Console.WriteLine("Pressione qualquer tecla para continuar...") ;
                Console.ReadKey();
            }
            else
            {
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.getAnterior();
                } while (aux != null);
            }
        }

        public void BuscarLivro()
        {
            Livro aux = topo;
            string livro_buscar;
            int contador = 0;
            Console.WriteLine("Digite o livro que deseja buscar: ");
            livro_buscar = Console.ReadLine();

            if (PilhaVazia())
            {
                Console.WriteLine("Pilha vazia, nada a buscar!");
            }
            else
            {
                do
                {
                    if (aux.getTitulo() == livro_buscar)
                    {
                        contador++;
                        Console.WriteLine($"{livro_buscar} existe na pilha");
                        aux = aux.getAnterior();
                    }
                    else
                    {
                        aux = aux.getAnterior();
                    }

                } while (aux != null);
            }
            if (contador == 0)
            {
                Console.WriteLine("O livro digitado não foi encontrado na pilha");
            }
            else
            {
                Console.WriteLine($"O livro digitado foi encontrado {contador} na pilha");
            }
        }
        public void pop()
        {
            if (PilhaVazia())
            {
                print();
            }
            else
            {
                topo = topo.getAnterior();
            }
        }
    }
}
