﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APSFactoryMethod.Classes
{
    class Calca : Roupas
    {
        public string Tipo { get ; set ; }
        public string Tamanho { get ; set ; }
        public string Cor { get ; set ; }
        public decimal Preco { get ; set ; }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Calça {Tipo}: Tamanho {Tamanho}, Cor {Cor}, Preço R${Preco}");
        }
    }
}
