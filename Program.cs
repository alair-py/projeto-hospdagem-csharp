using System.Text;
using Hospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa("Alair", "Junior");
Pessoa p2 = new Pessoa("Brian", "Lima");


hospedes.Add(p1);
hospedes.Add(p2);

Suite suiteMaster = new Suite(tipoSuite: "Master", capacidade: 3, valorDiaria: 85);
Suite suiteStandard = new Suite(tipoSuite: "Stardard", capacidade: 2, valorDiaria: 50);
Suite suiteEconomy = new Suite(tipoSuite: "Economy", capacidade: 1, valorDiaria: 30);

Reserva reserva1 = new Reserva(diasReservados: 11);
reserva1.CadastraSuite(suiteMaster);
reserva1.CadastrarHospedes(hospedes);


Console.WriteLine($"Hóspedes: {reserva1.ObterQtdHospedes()}");
Console.WriteLine($"Valor a pagar: {reserva1.CalcularValor()}");
Console.WriteLine($"Hóspede: {p1.NomeCompleto}");