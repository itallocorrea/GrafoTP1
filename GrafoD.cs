using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Autor: Ítallo Corrêa de Almeida

namespace GrafoTP1
{
    class GrafoD
    {
        private Dictionary<int, List<int>> GD;

        public GrafoD()
        {
            GD = new Dictionary<int, List<int>>();
        }

        private bool existeVertice(int v1)
        {
            if (GD.ContainsKey(v1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool existeAresta(int v1, int v2)
        {
            if(GD[v1].Contains(v2) && GD[v2].Contains(v1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int ordem()
        {
            return GD.Count;
        }

        public bool inserirVertice(int v1)
        {
            bool inserirVertice = false;

            if (!existeVertice(v1))
            {
                GD.Add(v1, new List<int>());
                inserirVertice = true;
            }

            return inserirVertice;
        }

        public bool removerVertice(int v1)
        {
            bool removerVertice = false;

            if (existeVertice(v1))
            {
                GD.Remove(v1);
                removerVertice = true;
            }

            return removerVertice;
        }

        public bool inserirAresta(int v1, int v2)
        {
            bool inserirAresta = false;

            if(existeVertice(v1) && existeVertice(v2) && !existeAresta(v1, v2))
            {
                GD[v1].Add(v2);
                GD[v2].Add(v1);
                inserirAresta = true;
            }

            return inserirAresta;
        }

        public bool removerAresta(int v1, int v2)
        {
            bool removerAresta = false;

            if (existeVertice(v1) && existeVertice(v2) && existeAresta(v1, v2))
            {
                GD[v1].Remove(v2);
                GD[v2].Remove(v1);
                removerAresta = true;
            }

            return removerAresta;
        }

        public int grau(int v1)
        {
            return (GD[v1].Count);
        }

        public bool isCompleto()
        {
            bool completo = true;

            foreach(int i in GD.Keys)
            {
                if(GD[i].Count != GD.Count - 1)
                {
                    completo = false;
                }
            }

            return completo;
        }

        public bool isRegular()
        {
            bool regular = true;
            List<int> graus = new List<int>();

            foreach(List<int> list in GD.Values)
            {
                graus.Add(list.Count);
            }

            int grau1 = graus[0];

            foreach(int i in graus)
            {
                if(i != grau1)
                {
                    regular = false;
                }
            }

            return regular;
        }

        public void showLA()
        {
            foreach(int i in GD.Keys)
            {
                Console.Write(i + ": ");
                foreach(int j in GD[i])
                {
                    Console.Write(j + "  ");
                }
                Console.WriteLine();
            }
        }

        public void sequenciaGraus()
        {
            List<int> graus = new List<int>();

            foreach(List<int> list in GD.Values)
            {
                graus.Add(list.Count);
            }

            graus.Sort();

            foreach(int i in graus)
            {
                Console.Write(i + " ");
            }
        }

        public void verticesAdjacentes(int v1)
        {
            Console.Write(v1 + ": ");
            foreach(int i in GD[v1])
            {
                Console.Write(i + " ");
            }
        }

        public bool isIsolado(int v1)
        {
            return (GD[v1].Count == 0);
        }

        public bool isImpar(int v1)
        {
            bool impar = false;

            if(GD[v1].Count % 2 != 0)
            {
                impar = true;
            }

            return impar;
        }

        public bool isPar(int v1)
        {
            bool par = false;

            if (GD[v1].Count % 2 == 0 && GD[v1].Count != 0)
            {
                par = true;
            }

            return par;
        }

        public bool adjacentes(int v1, int v2)
        {
            return existeAresta(v1, v2);
        }
    }
}
