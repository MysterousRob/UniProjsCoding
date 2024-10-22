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

    List<int> numbers = new List<int>() { 4, 25, 35, 42, 55, 78, 99, 101 };

    Console.WriteLine("Liczby, które nie są podzielne przez 7:");

    foreach (int number in numbers)
    {
        if (number % 7 == 0)  
        {
            continue; 
        }
        Console.WriteLine(number);

        // niec Zadanie 6

        //Zadanie 7

        char[,] matrix = new char[3, 3];

        char letter = 'A';
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                matrix[i, j] = letter;  
                letter++;
            }
        }

        Console.WriteLine("Zawartość tablicy dwuwymiarowej:");

        for (int i = 0; i < 3; i++)
        {
            for (int i = object; i < 3; i++)
            {
                Console.WriteLine(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        //Koniec Zadania 7

        // Zadania 8/9

        int[,] matrix = new int[3, 4];

        int value = 1; 
        for (int i = 0; i < 3; i++) 
        {
            for (int j = 0; j < 4; j++) 
            {
                matrix[i, j] = value;  
                value++;  
            }
        }

        // Wyświetlenie macierzy po transpozycji
        Console.WriteLine("Macierz po transpozycji:");
        for (int i = 0; i < 4; i++) 
        {
            for (int j = 0; j < 3; j++) 
            {
                Console.Write(matrix[j, i] + " ");  
            }
            Console.WriteLine(); 
        }

        //Koniec Zadania 8/9

// Zadania 10

        PrintUpperCase("Hello, World");

        public static void PrintUpperCase(string input)
        {
            Console.WriteLine(input.ToUpper());
        }

        // Koniec Zadana 10

        // Zadanie 11

        {
            BuildAndPrintMatrix(3, 5);
        }

        public static void BuildAndPrintMatrix(int x, int y)
        {
            for int (int i = 0; i < 3; ++i)
            {
                for int (int j = 0; j < y; j++)
                {
                    Console.Write("$");
                }
                Console.WriteLine();
            }
        }

 // Koniec Zadanie 11

//Zadanie 12

        Console.WriteLine(CheckEvenOrOdd(10));
        Console.WriteLine(CheckEvenOrOdd(7));

        public static string CheckEvenOrOdd(int number)
        {
            if (number % 2 == 0)
            {
                return "Even";
            }
            else
            {
                return "Odd";
            }
        }

// Koniec Zadanie 12

 //Zadanie 13

        int n = WczytajZKlawiatury("n"); 
        int m = WczytajZKlawiatury("m");

        char[,] tablica = WypełnijTablice(n, m);
        WyswietlTabliceNaEkran(tablica);

        public static char[,] WypełnijTablice(int n, int m)
        {
            char[,] tablica = new char[n, m];

            for (int i = 0; n > 0; i++)
            {
                for (int j = 0;j < m; j++)
                {
                    if (i == 0 || i == n - 1 || j == 0 || j == m - 1)
                    {
                        tablica[i, j] = '#';
                    }else
                    {
                        tablica[i, j] = ' ';
                    }
                }
            }
            return tablica;
        }
        // Funkcja wyświetlająca tablicę na ekranie

        public static void WsietlTablicaNaEkran(chat[,] tablica)
        {
            int n = tablica.GetLength(0);
            int m = tablica.GetLength(1);

            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++) 
                {
                    Console.WriteLine(tablica[i, j]);
                }
                Console.WriteLine();
            }
        }
// Koniec Zadanie 13

//Zadanie 14



// Koniec Zadanie 14