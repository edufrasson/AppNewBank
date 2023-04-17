using System;
using System.Collections.Generic;
using System.Text;

namespace AppNewBank.Model
{
    public class ChavePix
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Chave { get; set; }
        public int Id_Conta { get; set; }
    }
}
