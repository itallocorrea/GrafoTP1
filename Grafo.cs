using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Autor: Ítallo Corrêa de Almeida

namespace GrafoTP1
{
    class Grafo
    {
        private int[,] MA;
        private int qtVertices;

        public Grafo(int qtVertices)
        {
            this.qtVertices = qtVertices;
            MA = new int[qtVertices, qtVertices];

            for(int i = 0; i < qtVertices; i++)
            {
                for (int j = 0; j < qtVertices; j++)
                {
                    MA[i, j] = 0;
                }
            }
        }

        public bool existeVertice(int vertice)
        {
            if (vertice >= 0 && vertice <= qtVertices - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Ordem()
        {
            return qtVertices;
        }

        public bool inserirAresta(int v1, int v2)
        {
            bool insere = false;

            if (MA[v1, v2] == 0 && MA[v2, v1] == 0 && existeVertice(v1) && existeVertice(v2))
            {
                MA[v1, v2] = 1;
                MA[v2, v1] = 1;

                insere = true;
            }

            return insere;
        }

        public bool removerAresta(int v1, int v2)
        {
            bool remove = false;

            if (MA[v1, v2] == 1 && MA[v2, v1] == 1 && existeVertice(v1) && existeVertice(v2))
            {
                MA[v1, v2] = 0;
                MA[v2, v1] = 0;

                remove = true;
            }

            return remove;
        }

        public int Grau(int vertice)
        {
            int grauVertice = 0;

            for (int i = 0; i < qtVertices; i++)
            {
                if (MA[vertice, i] == 1)
                {
                    grauVertice++;
                }
            }

            return grauVertice;
        }

        public bool isCompleto()
        {
            bool completo = true;

            for (int i = 0; i < qtVertices; i++)
            {
                for (int j = 0; j < qtVertices; j++)
                {
                    if (MA[i, j] != 1 && i != j)
                    {
                        completo = false;
                    }
                }
            }

            return completo;
        }

        public bool isRegular()
        {
            bool regular = true;
            int grauVertice = 0;
            int grauVertice2;

            for (int i = 0; i < qtVertices; i++)
            {
                if (MA[0, i] == 1)
                {
                    grauVertice++;
                }
            }

            for (int i = 1; i < qtVertices; i++)
            {
                grauVertice2 = 0;

                for (int j = 0; j < qtVertices; j++)
                {
                    if (MA[i, j] == 1)
                    {
                        grauVertice2++;
                    }
                }

                if (grauVertice != grauVertice2)
                {
                    regular = false;
                }
            }

            return regular;
        }

        public void showMA()
        {
            Console.Write("\t");
            for (int i = 0; i < qtVertices; i++)
            {
                Console.Write(i + "\t");
            }

            Console.WriteLine();

            for (int i = 0; i < qtVertices; i++)
            {
                Console.Write(i + "\t");

                for (int j = 0; j < qtVertices; j++)
                {
                    Console.Write(MA[i, j] + "\t");
                }

                Console.WriteLine();
            }
        }

        public void showLA()
        {
            for (int i = 0; i < qtVertices; i++)
            {
                Console.Write(i + ": ");

                for (int j = 0; j < qtVertices; j++)
                {
                    if(MA[i,j] == 1)
                    Console.Write(j + " ");
                }

                Console.WriteLine();
            }
        }

        public void sequenciaGraus()
        {
           List<int> listaGraus = new List<int>();
            int grauVertice;

            for(int i = 0; i < qtVertices; i++)
            {
                grauVertice = 0;
                for(int j = 0; j < qtVertices; j++)
                {
                    if(MA[i,j] == 1)
                    {
                        grauVertice++;
                    }
                }

                listaGraus.Add(grauVertice);
            }

            listaGraus.Sort();

            foreach(int x in listaGraus)
            {
                Console.Write(x + " ");
            }
        }

        public void verticesAdjacentes(int v1)
        {
            Console.Write(v1 + ": ");
            for(int i = 0; i < qtVertices; i++)
            {
                if(MA[v1,i] == 1)
                {
                    Console.Write(i + " ");
                }
            }
        }

        public bool isIsolado(int v1)
        {
            bool isolado = true;

            for(int i = 0; i < qtVertices; i++)
            {
                if(MA[v1, i] == 1)
                {
                    isolado = false;
                }
            }

            return isolado;
        }
        
        public bool isImpar(int v1)
        {
            bool impar = false;
            int grau = 0;

            for(int i = 0; i < qtVertices; i++)
            {
                if(MA[v1,i] == 1)
                {
                    grau++;
                }
            }

            if((grau != 0) && (grau%2 == 1))
            {
                impar = true;
            }

            return impar;
        }

        public bool isPar(int v1)
        {
            bool par = false;
            int grau = 0;

            for (int i = 0; i < qtVertices; i++)
            {
                if (MA[v1, i] == 1)
                {
                    grau++;
                }
            }

            if ((grau != 0) && (grau % 2 == 0))
            {
                par = true;
            }

            return par;
        }

        public bool adjacentes(int v1, int v2)
        {
            return MA[v1, v2] == 1;
        }

    }
}
