using Ficha4.Models;
using System;
using System.Collections.Generic;

namespace Ficha4.App_Data
{
    public class DadosExemplo
    {
        static List<UnidadeMonetaria> ListaDeUnidadesMonetarias = null;
        static int counter = 0;

        public static List<UnidadeMonetaria> UnidadesMonetarias
        {
            get
            {
                if (ListaDeUnidadesMonetarias == null)
                    ListaDeUnidadesMonetarias = GerarDadosAleatorios();

                return ListaDeUnidadesMonetarias;
            }
        }

        static public int GetId()
        {
            return ++counter;
        }

        static private List<UnidadeMonetaria> GerarDadosAleatorios()
        {
            List<UnidadeMonetaria> newList = new List<UnidadeMonetaria>();
            UnidadeMonetaria um1 = new UnidadeMonetaria { Codigo = "USD", Valor = 0.88, Id = ++counter, Data = DateTime.Now };
            UnidadeMonetaria um2 = new UnidadeMonetaria { Codigo = "JPY", Valor = 0.0077, Id = ++counter, Data = DateTime.Now };
            UnidadeMonetaria um3 = new UnidadeMonetaria { Codigo = "GB", Valor = 1.3, Id = ++counter, Data = DateTime.Now };

            newList.Add(um1);
            newList.Add(um2);
            newList.Add(um3);

            return newList;
        }
    }
}
