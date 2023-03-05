using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hotel.modelos
{
    public class Reserva
    {
        public List<Pessoa> Hospedes {get; set;}
        public Suite Suite {get;set;}
        public int DiasDeReservas{get;set;}

        public Reserva() {}

         public Reserva(int diasDeReservas)
         {
            DiasDeReservas = diasDeReservas;
         }

   public void CadastrarHospedes(List<Pessoa> hospedes)
   {
   if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("Número de hóspedes excede a capacidade da suíte.");
            }
   }

     public void CadastrarSuite(Suite suite)
     {

      Suite = suite;  
     }

     public int ObterQuantidadeHospedes(){
       //TODO: retorna a quantidade de hospedes (propriedade Hospedes)
       
       
        return Hospedes.Count;
     }
     public decimal CalcularValorDiaria()
     {
         // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*


            decimal valor = DiasDeReservas*Suite.ValorDiaria;

              // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            if (DiasDeReservas >=10)
            {
                valor *= 0.9M; //APLICA O DESCONTO DE 10%
            }

            return valor;
     }
    }
}