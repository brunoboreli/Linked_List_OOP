using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Ligada
{
    public class Lista
    {
        private No Inicio;
        private No Fim;

        public void init()
        {
            Inicio = null;
            Fim = null;
        }

        public void InsertBegin(int _data)
        {
            No newNo = new No();
            newNo.Dado = _data;

            if (Empty())
            {
                Inicio = newNo;
                Fim = newNo;
            }
            else
            {
                Inicio.Prev = newNo;
                newNo.Prox = Inicio;
                Inicio = newNo;
            }
        }

        public void InsertEnd(int _data)
        {
            No newNo = new No();
            newNo.Dado = _data;

            if (Empty())
            {
                Inicio = newNo;
                Fim = Inicio;
            }
            else
            {
                Fim.Prox = newNo;
                newNo.Prev = Fim;
                Fim = newNo;
            }

            
        }

        public bool ListRemove(int _data)
        {
            
            No aux = Inicio;

            while(aux.Dado != _data)
            {
                aux = aux.Prox;
            }

            if(aux == null)
            {
                return false;
            }
            else
            {   
                if(Inicio == Fim)
                {
                    Inicio = Fim = null;
                }
                else if(aux == Inicio)
                {
                    Inicio = aux.Prox;
                    Inicio.Prev = null;
                }
                else if(aux == Fim)
                {
                    Fim = aux.Prev;
                    Fim.Prox = null;
                }
                else
                {
                    aux.Prev.Prox = aux.Prox;
                    aux.Prox.Prev = aux.Prev;
                }
                

                return true;
            }
        }

        public bool Empty()
        {
            if(this.Inicio == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void printLista()
        {
            No aux = new No();
            aux = Inicio;

            while (aux != null)
            {
                Console.Write(aux.Dado + " ");
                aux = aux.Prox;
            }
        }

        public void printInvert()
        {
            No aux = Fim;

            while (aux != null)
            {
                Console.Write(aux.Dado + " ");
                aux = aux.Prev;
            }
        }
    }
}
