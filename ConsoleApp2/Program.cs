using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // VEICOLI
            Veicolo veicolo1 = new Veicolo();
            veicolo1.TipoVeicolo = "Automobile";
            veicolo1.Marca = "Fiat";
            veicolo1.Immatricolazione = 2002;
            Console.WriteLine("Lista veicoli:");
            Console.WriteLine("\n");
            Console.WriteLine("1° Veicolo: " + veicolo1.TipoVeicolo + "\n" + "Marca: " + veicolo1.Marca + "\n" + "Anno di immatricolazione: " + veicolo1.Immatricolazione);
            Console.WriteLine("\n");
            Veicolo veicolo2 = new Veicolo();
            veicolo2.TipoVeicolo = "Moto";
            veicolo2.Marca = "T-MAX";
            veicolo2.Immatricolazione = 2018;

            Console.WriteLine("2° Veicolo: " + veicolo2.TipoVeicolo + "\n" + "Marca: " + veicolo2.Marca + "\n" + "Anno di immatricolazione: " + veicolo2.Immatricolazione);
            Console.WriteLine("\n");


            // DIPENDENTI
            Dipendente dipendente1 = new Dipendente();
            dipendente1.Nome = "Filippo";
            dipendente1.Cognome = "Pascarello";
            dipendente1.Età = 43;
            dipendente1.Ruolo = "Impiegato Comunale";

            Dipendente dipendente2 = new Dipendente();
            dipendente2.Nome = "Checco";
            dipendente2.Cognome = "Zalone";
            dipendente2.Età = 50;
            dipendente2.Ruolo = "Posto Fisso";

            Console.WriteLine("Lista Dipendenti:");
            Console.WriteLine("\n");
            Console.WriteLine("Nome: " + dipendente1.Nome + "\n" + "Cognome: " + dipendente1.Cognome + "\n" + "Età: " + dipendente1.Età + "\n" + "Ruolo: " + dipendente1.Ruolo);
            Console.WriteLine("\n");
            Console.WriteLine("Nome: " + dipendente2.Nome + "\n" + "Cognome: " + dipendente2.Cognome + "\n" + "Età: " + dipendente2.Età + "\n" + "Ruolo: " + dipendente2.Ruolo);


            // Animali

            Animale animale1 = new Animale();
            animale1.Famiglia = "Canis Lupus";
            animale1.Razza = "Husky";
            animale1.Nome = "Yoghi";
            animale1.Età = 2;

            Animale animale2 = new Animale();
            animale2.Famiglia = "Felini";
            animale2.Razza = "Gatto Silvestro";
            animale2.Nome = "Finocchietto";
            animale2.Età = 7;

            Console.WriteLine("\n");
            Console.WriteLine("Lista Animali:");
            Console.WriteLine("\n");
            Console.WriteLine("Famiglia: " + animale1.Famiglia + "\n" + "Razza: " + animale1.Razza + "\n" + "Nome: " + animale1.Nome + "\n" + "Età: " + animale1.Età);
            Console.WriteLine("\n");
            Console.WriteLine("Famiglia: " + animale2.Famiglia + "\n" + "Razza: " + animale2.Razza + "\n" + "Nome: " + animale2.Nome + "\n" + "Età: " + animale2.Età);

            // Atleti

            Atleta atleta1 = new Atleta();
            atleta1.Nome = "Robin";
            atleta1.Cognome = "Puplasky";
            atleta1.Età = 18;
            atleta1.Sport = "Calcio";

            Atleta atleta2 = new Atleta();
            atleta2.Nome = "Masaki";
            atleta2.Cognome = "Nosense";
            atleta2.Età = 22;
            atleta2.Sport = "Basket";
            Console.WriteLine("\n");
            Console.WriteLine("Lista Atleti:");
            Console.WriteLine("\n");
            Console.WriteLine("Nome: " + atleta1.Nome + "\n" + "Cognome: " + atleta1.Cognome + "\n" + "Età: " + atleta1.Età + "\n" + "sport: " + atleta1.Sport);
            Console.WriteLine("\n");
            Console.WriteLine("Nome: " + atleta2.Nome + "\n" + "Cognome: " + atleta2.Cognome + "\n" + "Età: " + atleta2.Età + "\n" + "sport: " + atleta2.Sport);


            Console.ReadLine(); // non ferma l'esecuzione

        }
    }
}
