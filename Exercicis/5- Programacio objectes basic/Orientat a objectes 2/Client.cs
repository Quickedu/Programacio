using System.ComponentModel.DataAnnotations.Schema;
using Banquer_analogic;
namespace Banquer_analogic
{
    public class Client{
        public int numero {get;}
        public int saldo {get; set;}
        public string nompersona {get;}


        public Client(int num, int que_te, string nom)
        {
            nompersona = nom;
            numero = num;
            saldo = que_te;
        }        
    }
}