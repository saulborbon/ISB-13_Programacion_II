using System;    

class nodo
{
    public int Dato;
    public nodo siguiente;
    public nodo(int dato)
    {
        Dato = dato;
        siguiente = null;
    }
}

class ListaEnlazada
{
    private nodo cabeza;
    public ListaEnlazada()
    {
        cabeza = null;
    }

    public void InsertarInicio(int dato)
    {
        nodo nuevoNodo = new nodo(dato);
        nuevoNodo.siguiente = cabeza;
        cabeza = nuevoNodo;
    }

    public void MostrarLista()
    {
        nodo actual = cabeza;
        while (actual != null)
        {
            Console.Write(actual.Dato + " -> ");
            actual = actual.siguiente;
        }
        Console.WriteLine("Fin de la clase.");
    }
}

class program
{
    static void Main()
    {
        ListaEnlazada lista = new ListaEnlazada();
        lista.InsertarInicio(10);
        lista.InsertarInicio(20);
        lista.InsertarInicio(30);
        lista.InsertarInicio(40);
        Console.WriteLine("----Elementos de la lista enlazada:----");
        lista.MostrarLista();
        lista.InsertarInicio(50);
        lista.InsertarInicio(60);
        lista.InsertarInicio(70);
        lista.InsertarInicio(80);
        Console.WriteLine("----Elementos de la lista enlazada:----");
        lista.MostrarLista();
    }
}
