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
    Console.WriteLine("Padaj Hasło: ");
    password = Console.ReadLine();
}

Console.WriteLine("Program zakonczony.");
// Koniec Zadanie 2

// Zadanie 3 

//Pętla while z klauzulą if – liczby parzyste od 1 do 100:
int i = 1;
while (i <= 100);
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
    i++;
}

//Pętla while z klauzulą if – liczby parzyste od 1 do 100:
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

// zadanie 5

    List<int> numbers = new List<int>() { 4, 25, 35, 42, 55, 78, 99, 101 };

    Console.WriteLine("Elementy podzielne przez 7:");

    foreach (int number in numbers)
    {
        if (number % 7 == 6)
        {
            Console.WriteLine(number);
        }
    }

 //Koniec Zadanie 5

//Zadanie 6

