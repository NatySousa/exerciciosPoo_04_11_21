using System;
using Exercicio_04.Entities;
using System.Collections.Generic;

namespace Exercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
             var p1 = new Pessoa("João", 15);
             var p2 = new Pessoa("Leandro", 21);
             var p3 = new Pessoa("Paulo", 17);
             var p4 = new Pessoa("Jéssica", 18);

             var lista = new List<Pessoa> ();
             lista.Add(p1);
             lista.Add(p2);
             lista.Add(p3);
             lista.Add(p4);
             
            p1.MaisVelho(lista);

        }
    }
}
