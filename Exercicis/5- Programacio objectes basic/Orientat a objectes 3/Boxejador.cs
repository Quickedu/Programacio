using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using boxejadors;
using Microsoft.VisualBasic;
namespace boxejadors{
    public class Boxejador{
        public string nom {get;}
        public int vida {get;}
        public int victories {get; set;}
        private int onpica;
        private int protecio;
        public int num {get; set;}

        private Random rnd = new ();
        

        public Boxejador(string name, int hp, int numero)
        {
            nom = name;
            vida = hp;
            victories = 0;
            num = numero;
        }

        public int picar (){
            onpica = rnd.Next(1,4);
            return onpica;
        }
        public string quepica (){
            var lloc = "";
            switch (onpica){
                case 1:
                lloc = "Cap";
                break;
                case 2:
                lloc = "Braç dret";
                break;
                case 3:
                lloc = "Braç esquerre";
                break;
                case 4:
                lloc = "Panxa";
                break;
            }
            return lloc;
        }
        public string onestaprotegit(){
            var output = "";
            switch (protecio){
                case 1:
                output = "braç dret, braç esquerre i panxa";
                break;
                case 2:
                output = "cap, braç esquerre i panxa";
                break;
                case 3:
                output = "cap, braç dret, i panxa";
                break;
                case 4:
                output = "cap, braç dret i braç esquerre";
                break;
            }
            return output;
        }
        public int protegirse (){
            protecio = rnd.Next(1,4);
            return protecio;
        }
        public void victoria (){
            victories++;
        }
    }
}