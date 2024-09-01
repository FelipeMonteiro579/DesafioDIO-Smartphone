using Smartphone.Models;

namespace Smartphone
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Smartphone Nokia:");
            Nokia nokia = new Nokia(numero:"12345", modelo:"modelo 01", imei:"1111111", memoria:64);
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("WhatsApp");

            Console.WriteLine("\n");

            Console.WriteLine("Smartphone Iphone:");
            Iphone iphone = new Iphone(numero: "67890", modelo: "modelo 02", imei: "2222222", memoria: 128);
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");
        }
    }
}
