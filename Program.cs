﻿// See https://aka.ms/new-console-template for more information
using System;
using System.Reflection;
//inizializzo l'array
string[] array = new string[5];
string[] favoriteDishes = new string[] { "Pasta", "Pizza", "Carne", "Gelato", "Pesce" };
//stampo lunghezza Array
Console.Write("Il numero totale dei tuoi piatti preferiti è:" + favoriteDishes.Length);
Console.WriteLine("");
//stampa lista piatti
for (int i = 0; i < favoriteDishes.Length; i++)
{
    Console.WriteLine(String.Format(" favoriteDishes[{0}] = {1}", i, favoriteDishes[i]));
}
