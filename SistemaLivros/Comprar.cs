using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Venda_Livros_PJ
{
    class Comprar
    {

        public float Total { get; set; }
        public int Reserva { get; set; }
        List <Comprar> Compra = new List <Comprar> ();

        public Comprar ()
        {

        }

        public Comprar(float total, int reserva)
        {
            Total = total;
            Reserva = reserva;

        }



    }
}
