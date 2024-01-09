using System;

namespace DesafioPOO.Models
{
    // Classe concreta que representa um celular Nokia
    public class Nokia : Smartphone
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }

        public Nokia(string numero, string modelo, string marca) : base(numero)
        {
            Modelo = modelo;
            Marca = marca;
        }

        public override void InstalarAplicativo(string aplicativo)
        {
            Console.WriteLine($"Instalando {aplicativo} no celular Nokia {Modelo}...");
        }
    }
}
