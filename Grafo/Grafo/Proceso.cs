using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafo
{
    public class Proceso
    {
        public void Proceso1()
        {
            //SOLO HICE UN GRAFO INTERCONECTADO QUE RECORRE DESDE EL PRIMERO VERTICE AL ULTIMO PASANDO POR TODOS LOS PUNTOS
            //LAS TRAYECTORIAS LAS RESOLVI A MANO
            Grafo grafito = new Grafo(8);//AGREGO LA CANTIDAD DE VERTICES+1 NO SE PORQUE HAHA SALUDOS
            Console.WriteLine("1 = A \n2 = B \n3 = C \n4 = D \n5 = E \n6 = F \n7 = G");
            Console.Write("Camino para Llegar al Ultimo Elemento del Grafo \n1");
            grafito.AñadirFinal(1, 1);//AGREGO LAS CONEXIONES EXISTENTES EN EL GRAFO
            grafito.AñadirFinal(1, 2);
            grafito.AñadirFinal(2, 3);
            grafito.AñadirFinal(2, 7);
            grafito.AñadirFinal(3, 4);
            grafito.AñadirFinal(3, 7);
            grafito.AñadirFinal(4, 5);
            grafito.AñadirFinal(4, 6);
            grafito.AñadirFinal(5, 6);
            grafito.AñadirFinal(6, 7);
            grafito.DFS(1);//INDICO DESDE QUE POSICION INICIARE EL GRAFO
            Console.WriteLine("\nTrayectorias simples \nA->B->C->D->E \nA->A->B->C->D->E \nA->A->B->G->F->E \nA->B->C->G->F->D->E \nA->A->B->G->C->D->F->E");
            Console.ReadKey(true);

        }
    }
}
