// See https://aka.ms/new-console-template for more information
using System;
using System.Reflection;
//inizializzo l'array
string[] array = new string[5];
string[] favoriteDishes = new string[] { "Pasta", "Pizza", "Carne", "Gelato", "Pesce", "Cioccolata" };
//stampo lunghezza Array
Console.Write("Il numero totale dei tuoi piatti preferiti è: " + favoriteDishes.Length);
Console.WriteLine("");
//stampa lista piatti
for (int i = 0; i < favoriteDishes.Length; i++)
{
    Console.WriteLine(String.Format("piatto preferito[{0}] = {1}", i+1, favoriteDishes[i]));
}

Console.WriteLine("il tuo cibo preferito è: " + favoriteDishes.First());
Console.WriteLine("il tuo cibo meno preferito è: " + favoriteDishes.Last());

if (favoriteDishes.Length % 2 == 1)
{
    Console.WriteLine("Il piatto centrale è: " + favoriteDishes[(favoriteDishes.Length / 2)]);
} else  
{ 
    Console.WriteLine("I piatti centrali nella tua lista sono: " + favoriteDishes[(favoriteDishes.Length / 2)] + " e " + favoriteDishes[(favoriteDishes.Length / 2 - 1)]);
}

