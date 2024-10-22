using System;

// Zadanie 1
int i = 10;
do
{
    Console.WriteLine(i);
    i--;
}
while (i >= 0);
}

// Koniec Zadanie 1

//Zadanie 2 

string password = "";

while (password != "Koniec")
{
    Console.WriteLine("Padaj Has?o: ");
    password = Console.ReadLine();
}

Console.WriteLine("Program zakonczony.");
// Koniec Zadanie 2

// Zadanie 3 

//P?tla while z klauzul? if – liczby parzyste od 1 do 100:
int i = 1;
while (i <= 100);
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
    i++;
}

//P?tla while z klauzul? if – liczby parzyste od 1 do 100:
for (int i = 1 ; i <= 100 ; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }



// Zadnaie 4

for (int i = 1: i <= 15: i++)
    {
        int square = i * i;
        Console.WriteLine($"Liczba: {i}, Kwadrat: {square}");
    }

// Koniec Zadanie 4