using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Autor: Ítallo Corrêa de Almeida

namespace GrafoTP1
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;

            Console.Write("TRABALHO PRÁTICO - GRAFOS");
            Console.WriteLine();
            Console.WriteLine("Opções: ");
            Console.WriteLine("1 - Grafo Matriz");
            Console.WriteLine("2 - Grafo Lista");
            Console.Write("Digite a opção desejada: ");
            op = int.Parse(Console.ReadLine());

            if (op == 1)
            {
                int opc = 0;
                int v1, v2;

                Console.Write("Digite o nº de vértices do grafo: ");
                int qv = int.Parse(Console.ReadLine());
                Grafo g = new Grafo(qv);

                while (opc != 15)
                {
                    Console.Clear();
                    Console.WriteLine("\nMenu de Opções: ");
                    Console.WriteLine("1 - Ordem");
                    Console.WriteLine("2 - Inserir Aresta");
                    Console.WriteLine("3 - Remover Aresta");
                    Console.WriteLine("4 - Grau");
                    Console.WriteLine("5 - Completo?");
                    Console.WriteLine("6 - Regular?");
                    Console.WriteLine("7 - Exibir Matriz de Adjacência");
                    Console.WriteLine("8 - Exibir Lista de Adjacência");
                    Console.WriteLine("9 - Sequência de Graus");
                    Console.WriteLine("10 - Vértices Adjacentes");
                    Console.WriteLine("11 - Isolado?");
                    Console.WriteLine("12 - Ímpar?");
                    Console.WriteLine("13 - Par?");
                    Console.WriteLine("14 - Adjacentes?");
                    Console.WriteLine("15 - Sair");
                    Console.WriteLine();
                    Console.Write("Digite a opção desejada: ");
                    opc = int.Parse(Console.ReadLine());

                    switch (opc)
                    {
                        case 1:
                            Console.Clear();
                            Console.Write("O grafo possui " + g.Ordem() + " vértices");
                            Console.ReadKey();
                            break;

                        case 2:
                            Console.Clear();
                            Console.Write("Digite o 1º vértice da aresta: ");
                            v1 = int.Parse(Console.ReadLine());
                            Console.Write("Digite o 2º vértice da aresta: ");
                            v2 = int.Parse(Console.ReadLine());
                            g.inserirAresta(v1, v2);
                            Console.ReadKey();
                            break;

                        case 3:
                            Console.Clear();
                            Console.Write("Digite o 1º vértice da aresta: ");
                            v1 = int.Parse(Console.ReadLine());
                            Console.Write("Digite o 2º vértice da aresta: ");
                            v2 = int.Parse(Console.ReadLine());
                            g.removerAresta(v1, v2);
                            Console.ReadKey();
                            break;

                        case 4:
                            Console.Clear();
                            Console.Write("Deseja verificar o grau de qual vértice? ");
                            v1 = int.Parse(Console.ReadLine());
                            Console.Write("O vértice é de grau " + g.Grau(v1));
                            Console.ReadKey();
                            break;

                        case 5:
                            Console.Clear();
                            if (g.isCompleto())
                            {
                                Console.Write("O grafo é completo");
                            }
                            else
                            {
                                Console.Write("O grafo não é completo");
                            }
                            Console.ReadKey();
                            break;

                        case 6:
                            Console.Clear();
                            if (g.isRegular())
                            {
                                Console.Write("O grafo é regular");
                            }
                            else
                            {
                                Console.Write("O grafo não é regular");
                            }
                            Console.ReadKey();
                            break;

                        case 7:
                            Console.Clear();
                            g.showMA();
                            Console.ReadKey();
                            break;

                        case 8:
                            Console.Clear();
                            g.showLA();
                            Console.ReadKey();
                            break;

                        case 9:
                            Console.Clear();
                            Console.WriteLine("A sequencia de graus é: ");
                            g.sequenciaGraus();
                            Console.ReadKey();
                            break;

                        case 10:
                            Console.Clear();
                            Console.Write("Deseja ver os vértices adjacentes a qual vértice?");
                            v1 = int.Parse(Console.ReadLine());
                            g.verticesAdjacentes(v1);
                            Console.ReadKey();
                            break;

                        case 11:
                            Console.Clear();
                            Console.Write("Digite o vértice que deseja verificar: ");
                            v1 = int.Parse(Console.ReadLine());
                            if (g.isIsolado(v1))
                            {
                                Console.Write("O vértice é isolado");
                            }
                            else
                            {
                                Console.Write("O vértice não é isolado");
                            }
                            Console.ReadKey();
                            break;

                        case 12:
                            Console.Clear();
                            Console.Write("Digite o vértice que deseja verificar: ");
                            v1 = int.Parse(Console.ReadLine());
                            if (g.isImpar(v1))
                            {
                                Console.Write("O vértice é ímpar");
                            }
                            else
                            {
                                Console.Write("O vértice não é ímpar");
                            }
                            Console.ReadKey();
                            break;

                        case 13:
                            Console.Clear();
                            Console.Write("Digite o vértice que deseja verificar: ");
                            v1 = int.Parse(Console.ReadLine());
                            if (g.isPar(v1))
                            {
                                Console.Write("O vértice é par");
                            }
                            else
                            {
                                Console.Write("O vértice não é par");
                            }
                            Console.ReadKey();
                            break;

                        case 14:
                            Console.Clear();
                            Console.Write("Digite o 1º vértice: ");
                            v1 = int.Parse(Console.ReadLine());
                            Console.Write("Digite o 2º vértice: ");
                            v2 = int.Parse(Console.ReadLine());
                            if (g.adjacentes(v1, v2))
                            {
                                Console.Write("Os vértices são adjacentes");
                            }
                            else
                            {
                                Console.Write("Os vértices não são adjacentes");
                            }
                            Console.ReadKey();
                            break;

                        case 15:
                            Console.Clear();
                            Console.Write("Digite uma tecla para sair");
                            Console.ReadKey();
                            break;

                        default:
                            Console.Write("Opção Inválida");
                            break;
                    }

                }

                Console.ReadKey();

            } else if(op == 2)
            {
                GrafoD g = new GrafoD();
                int opc = 0;
                int v1, v2;

                while (opc != 16)
                {
                    Console.Clear();
                    Console.WriteLine("\nMenu de Opções: ");
                    Console.WriteLine("1 - Ordem");
                    Console.WriteLine("2 - Inserir Vértice");
                    Console.WriteLine("3 - Remover Vértice");
                    Console.WriteLine("4 - Inserir Aresta");
                    Console.WriteLine("5 - Remover Aresta");
                    Console.WriteLine("6 - Grau");
                    Console.WriteLine("7 - Completo?");
                    Console.WriteLine("8 - Regular?");
                    Console.WriteLine("9 - Exibir Lista de Adjacência");
                    Console.WriteLine("10 - Sequência de Graus");
                    Console.WriteLine("11 - Vértices Adjacentes");
                    Console.WriteLine("12 - Isolado?");
                    Console.WriteLine("13 - Impar?");
                    Console.WriteLine("14 - Par?");
                    Console.WriteLine("15 - Adjacentes?");
                    Console.WriteLine("16 - Sair");
                    Console.WriteLine();
                    Console.Write("Digite a opção desejada: ");
                    opc = int.Parse(Console.ReadLine());

                    switch (opc)
                    {
                        case 1:
                            Console.Clear();
                            Console.Write("O grafo possui " + g.ordem() + " vértices");
                            Console.ReadKey();
                            break;

                        case 2:
                            Console.Clear();
                            Console.Write("Digite o nº do vértice: ");
                            v1 = int.Parse(Console.ReadLine());
                            g.inserirVertice(v1);
                            Console.ReadKey();
                            break;

                        case 3:
                            Console.Clear();
                            Console.Write("Digite o nº do vértice: ");
                            v1 = int.Parse(Console.ReadLine());
                            g.removerVertice(v1);
                            Console.ReadKey();
                            break;

                        case 4:
                            Console.Clear();
                            Console.Write("Digite o 1º vértice da aresta: ");
                            v1 = int.Parse(Console.ReadLine());
                            Console.Write("Digite o 2º vértice da aresta: ");
                            v2 = int.Parse(Console.ReadLine());
                            g.inserirAresta(v1, v2);
                            Console.ReadKey();
                            break;

                        case 5:
                            Console.Clear();
                            Console.Write("Digite o 1º vértice da aresta: ");
                            v1 = int.Parse(Console.ReadLine());
                            Console.Write("Digite o 2º vértice da aresta: ");
                            v2 = int.Parse(Console.ReadLine());
                            g.removerAresta(v1, v2);
                            Console.ReadKey();
                            break;

                        case 6:
                            Console.Clear();
                            Console.Write("Deseja verificar o grau de qual vértice? ");
                            v1 = int.Parse(Console.ReadLine());
                            Console.Write("O vértice é de grau " + g.grau(v1));
                            Console.ReadKey();
                            break;

                        case 7:
                            Console.Clear();
                            if (g.isCompleto())
                            {
                                Console.Write("O grafo é completo");
                            }
                            else
                            {
                                Console.Write("O grafo não é completo");
                            }
                            Console.ReadKey();
                            break;

                        case 8:
                            Console.Clear();
                            if (g.isRegular())
                            {
                                Console.Write("O grafo é regular");
                            }
                            else
                            {
                                Console.Write("O grafo não é regular");
                            }
                            Console.ReadKey();
                            break;

                        case 9:
                            Console.Clear();
                            g.showLA();
                            Console.ReadKey();
                            break;

                        case 10:
                            Console.Clear();
                            Console.WriteLine("A sequencia de graus é: ");
                            g.sequenciaGraus();
                            Console.ReadKey();
                            break;

                        case 11:
                            Console.Clear();
                            Console.Write("Deseja ver os vértices adjacentes a qual vértice?");
                            v1 = int.Parse(Console.ReadLine());
                            g.verticesAdjacentes(v1);
                            Console.ReadKey();
                            break;

                        case 12:
                            Console.Clear();
                            Console.Write("Digite o vértice que deseja verificar: ");
                            v1 = int.Parse(Console.ReadLine());
                            if (g.isIsolado(v1))
                            {
                                Console.Write("O vértice é isolado");
                            }
                            else
                            {
                                Console.Write("O vértice não é isolado");
                            }
                            Console.ReadKey();
                            break;

                        case 13:
                            Console.Clear();
                            Console.Write("Digite o vértice que deseja verificar: ");
                            v1 = int.Parse(Console.ReadLine());
                            if (g.isImpar(v1))
                            {
                                Console.Write("O vértice é ímpar");
                            }
                            else
                            {
                                Console.Write("O vértice não é ímpar");
                            }
                            Console.ReadKey();
                            break;

                        case 14:
                            Console.Clear();
                            Console.Write("Digite o vértice que deseja verificar: ");
                            v1 = int.Parse(Console.ReadLine());
                            if (g.isPar(v1))
                            {
                                Console.Write("O vértice é par");
                            }
                            else
                            {
                                Console.Write("O vértice não é par");
                            }
                            Console.ReadKey();
                            break;

                        case 15:
                            Console.Clear();
                            Console.Write("Digite o 1º vértice: ");
                            v1 = int.Parse(Console.ReadLine());
                            Console.Write("Digite o 2º vértice: ");
                            v2 = int.Parse(Console.ReadLine());
                            if (g.adjacentes(v1, v2))
                            {
                                Console.Write("Os vértices são adjacentes");
                            }
                            else
                            {
                                Console.Write("Os vértices não são adjacentes");
                            }
                            Console.ReadKey();
                            break;

                        case 16:
                            Console.Clear();
                            Console.Write("Digite uma tecla para sair");
                            //Console.ReadKey();
                            break;

                        default:
                            Console.Write("Opção Inválida");
                            break;
                    }

                }

                Console.ReadKey();
            }
        }
    }
}
