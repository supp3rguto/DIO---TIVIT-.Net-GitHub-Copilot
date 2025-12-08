namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        public string Modelo { get; set; }
        public string IMEI { get; set; }
        public int Memoria { get; set; }

        public Smartphone(string numero)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            this.Numero = numero;

            Modelo = Modelo;
            IMEI = IMEI;
            Memoria = Memoria;

            this.Modelo = Modelo;
            this.IMEI = IMEI;
            this.Memoria = Memoria;

        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}