using System;
using System.Collections.Generic;
using System.Text;

namespace AppNewBank.Model
{
    public class Correntista
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public int CPF { get; set; }
        public DateTime Data_Nascimento { get; set; }
    }
}
