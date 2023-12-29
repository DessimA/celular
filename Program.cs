using System;
using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main()
        {
            // Realizar os testes com as classes Nokia e Iphone
            Nokia nokia = new Nokia("123456789", "Nokia Model X", "IMEI123", 64);
            Iphone iphone = new Iphone("987654321", "iPhone 12", "IMEI456", 128);

            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("Facebook");

            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("WhatsApp");
        }
    }
}