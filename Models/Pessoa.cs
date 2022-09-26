using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospedagem.Models
{
    public class Pessoa
    {
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        private string _Nome;
        private string _Sobrenome;

        public string Nome
        {
            get
            {
                return _Sobrenome;
            }
            set
            {
                if (value != "")
                {
                    _Nome = value;
                }
                else
                {
                    Console.WriteLine("Campo 'Nome' não pode ser vazio.");
                }
            }
        }
        public string Sobrenome
        {
            get
            {
                return _Sobrenome;
            }
            set
            {
                if (value != "")
                {
                    _Sobrenome = value;
                }
                else
                {
                    Console.WriteLine("Campo 'Sobrenome' não pode ser vazio.");
                }
            }
        }

        public string NomeCompleto {
            get {
                return _Nome + " " + _Sobrenome;
            }
        }
    }
}