namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    // DONE
    public class Nokia : Smartphone
    {

        public string Numero { get; set; }

        public Nokia(string numero, string modelo, string imei, int memoria)
        : base(numero, modelo, imei, memoria)
        {


        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        // DONE
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Aplicativo {nomeApp} instalado!");
        }
    }
}