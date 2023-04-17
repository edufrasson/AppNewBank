using System;
using System.Collections.Generic;
using System.Text;

namespace AppNewBank.Model
{
    public class Conta
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public double Saldo { get; set; }
        public int Id_Correntista { get; set; }
    }
}
