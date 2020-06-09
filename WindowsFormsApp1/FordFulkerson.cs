using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class FordFulkerson
    {

        int V = 6; //Numarul nodurilor 

        /* Returnează adevărat daca este un drum
        de la sursa s la chiuveta t in graf.
        În acelasi timp umple vectorul parent[] 
        care stochează drumul*/
        private bool bfs(int[,] rGraph, int s, int t, int[] parent)
        {            
            bool[] visited = new bool[V];   // Crează un vecor de vizitatori având  nodurile nevizitate
            for (int i = 0; i < V; ++i)
                visited[i] = false;
            
            List<int> queue = new List<int>(); // Crează o coadă și pune in ea sursele nodurilor si trece nodurile ca fiind vizitate in vectorul visited[] 
            queue.Add(s);
            visited[s] = true;
            parent[s] = -1;

            // Bfs (Parcurgere in latime)
            while (queue.Count != 0)
            {
                int u = queue[0];
                queue.RemoveAt(0);

                for (int v = 0; v < V; v++)
                {
                    if (visited[v] == false && rGraph[u, v] > 0)
                    {
                        queue.Add(v);
                        parent[v] = u;
                        visited[v] = true;
                    }
                }
            }

            /*  Daca am ajuns la punctul 
              de la final folosind cautarea 
              in latime de la sursa functia
              returnează adevărat, iar in
              caz contrar fals
            */

            return (visited[t] == true);
        }

        /* Functia Run returneaza debitul maxim
         de la un punct s la t intr-un graf dat
        */
        public int Run(int[,] graph, int s, int t, int integer)
        {
            V = integer;
            int u, v;
            /*  Crează un graf cu capacitățile date */

            /* Graficul unde rGraph[i,j] indică
             capacitatea marginii de la i la j
             (daca nu există o margine atunci
             rGraph[i, j] este 0)
            */
            int[,] rGraph = new int[V, V];

            for (u = 0; u < V; u++)
                for (v = 0; v < V; v++)
                    rGraph[u, v] = graph[u, v];
            
            int[] parent = new int[V];  //Acest vector este umplut de funcția BFS si stochează drumul

            int max_flow = 0; // Nu există nici un "flow" inițial

            //  Se mareste fluxul atâta timp cât există
            //un drum de la sursă la final

            while (bfs(rGraph, s, t, parent))   
            {
                //  Caută debitul maxim din drumul găsit
                int path_flow = int.MaxValue;
                for (v = t; v != s; v = parent[v])
                {
                    u = parent[v];
                    path_flow = Math.Min(path_flow, rGraph[u, v]);
                }

                //   actualizează capacitatea vectorul rGraph 
                // și inversează muchiile de-a lungul drumului
                for (v = t; v != s; v = parent[v])
                {
                    u = parent[v];
                    rGraph[u, v] -= path_flow;
                    rGraph[v, u] += path_flow;
                }

                max_flow += path_flow;  //Adaugă fluxul path_flow la fluxul general care o să fie returnat in final
            }

            return max_flow;    //Returnează fluxul
        }
    }
}
