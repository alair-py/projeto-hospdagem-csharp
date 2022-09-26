using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospedagem.Models
{
    public class Reserva
    {   
        public Reserva() {

        }
        public Reserva(int diasReservados) {
            DiasReservados = diasReservados;
        }

        public int DiasReservados { get; set; }
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }


        public void CadastrarHospedes(List<Pessoa> hospedes) {
            try {
                if(hospedes.Count <= Suite.Capacidade) {
                Hospedes = hospedes;
                }
                else {
                    Console.WriteLine("Capacidade da suíte insuficiente.");
                    Environment.Exit(0);
                }
            }
            catch(Exception err) {
                Console.WriteLine(err);
            } 
        }


        public void CadastraSuite(Suite suite) {
            Suite = suite;
        }


        public int ObterQtdHospedes() {
            return Hospedes.Count();
        }


        public decimal CalcularValor() {
            decimal valorSemDesconto = DiasReservados * Suite.ValorDiaria;

            if(DiasReservados > 10) {
                return valorSemDesconto - (valorSemDesconto * 10) / 100;
            }
            else {
                return valorSemDesconto;
            }

        }
    }
}