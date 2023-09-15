using AppNewBank.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppNewBank.Service
{
    public class DataServiceCorrentista : DataService
    {
        public static async Task<Correntistas> Cadastrar(Correntistas c)
        {
            var json_to_send = JsonConvert.SerializeObject(c);

            string json = await DataService.PostDataToService(json_to_send, "/correntista/save");

            Console.WriteLine("_____________________________________________");
            Console.WriteLine(json);
            Console.WriteLine("_____________________________________________");

            Correntistas correntista = JsonConvert.DeserializeObject<Correntistas>(json);

            return correntista;
        }

        public static async Task<Correntistas> Autorizar(Correntistas c)
        {
            var json_to_send = JsonConvert.SerializeObject(c);

            string json = await DataService.GetDataFromService(String.Format("/correntista/entrar?cpf={0}&senha={1}", c.CPF, c.Senha));

            Console.WriteLine("_____________________________________________");
            Console.WriteLine(json);
            Console.WriteLine("_____________________________________________");

            Correntistas correntista = new Correntistas();
            if(json != "false")
            {
                correntista = JsonConvert.DeserializeObject<Correntistas>(json);
            }
            

            return correntista;
        }
    }
}
