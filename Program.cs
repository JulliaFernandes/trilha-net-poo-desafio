using DesafioPOO.Models;
using System;

namespace Trilha_net_poo_desafio_main
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Smartphone Nokia");
            Nokia nk = new Nokia(numero: "123456789", modelo: "Nokia", imei:"11212121", memoria: 128);
            nk.Ligar();
            nk.InstalarAplicativo("Tiktok");
            nk.ReceberLigacao();

            System.Console.WriteLine("\n");

            System.Console.WriteLine("Smartphone Iphone");
            Iphone ip = new Iphone(numero: "987654321", modelo: "Iphone 12 Pro Max", imei:"3433434343", memoria: 256);
            nk.Ligar();
            nk.InstalarAplicativo("Linkedin");
            nk.ReceberLigacao();
        }
    }
}