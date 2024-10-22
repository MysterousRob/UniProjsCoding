/* zadanie 1 */

Console.WriteLine("Zmienne i typy danych");

byte byteVariable = 50;
int integralVariable = 300;
long longVariable = 100000000;
char charVariable1 = (char)87;
char charVariable2 = 'a';
double doubleVariable = 50.0005;
float floatVariable = 50e10F;
string stringVariable = "How you doing?";

// tutaj wpisz rozwiązanie 

Console.WriteLine(byteVariable);
Console.WriteLine(integralVariable);
Console.WriteLine(longVariable);
Console.WriteLine(charVariable1);
Console.WriteLine(charVariable2);
Console.WriteLine(doubleVariable);
Console.WriteLine(floatVariable);
Console.WriteLine(stringVariable);

/* koniec zadania 1 */

// konwersja niejawna 

int num = 100;
long bigNum = num;

System.Console.WriteLine(bigNum);

// konwersja jawna 

double x = 1234.7;
int a;
a = (int)x;

System.Console.WriteLine(a);



/* zadanie 2 */
int num = 2147483647;
long bigNum = 88888888888;
string stringNum = "1024";

// zadeklaruj zmienną typu long i przypisz do niej zmienną num
long numLong = num;
// zadeklaruj zmienną typu int i przypisz do niej zmienną bigNum
int bigNumInt = (int)bigNum;
// zadeklaruj zmienną typu int i przypisz do niej zmienną stringNum (zastosuj Parse)
int parsedStringNum = int.Parse(stringNum);
// zbadaj zachowanie programu

/* koniec zadania 2 */

int a = 18;

int b = 6;

decimal price = 10.56m;

double doubleVal = 10.56;

double radius = 5.0;

double time = 1234.45;




// zadeklaruj zmienną c, do której przypisz wynik dodawania a i b  
int c = a + b;
// zadeklaruj zmienną d, do której przypisz wynik odejmowania a i b  
int d = a - b;
// zadeklaruj zmienną e, do której przypisz wynik mnożenia a i b  
int e = a * b;
// zadeklaruj zmienną f, do której przypisz wynik dzielenia a i b  
int f = a / b;
// zadeklaruj zmienną g, do której przypisz wynik reszty z dzielenia a i b  
int g = a % b;
// wypisz na ekran c,d,e,f,g 

Console.WriteLine(c);
Console.WriteLine(d);
Console.WriteLine(e);
Console.WriteLine(f);
Console.WriteLine(g);

// wypisz na ekran wynik zmiennej price pomnożonej przez samą siebie 
Console.WriteLine(price * price);
// wypisz na ekran wynik zmiennej doubleVal pomnożonej przez samą siebie 
System.out.println("Wynik: " + (doubleVal * doubleVal));
// wypisz na ekran wynik pola koła o promieniu równym radius
Console.WriteLine(radius * radius);

/* koniec zadania 3 */
/* zadanie 4 */
int toIncrement = 3;
int toDivide = 5;
// wstaw do zmiennej toIncrement jej obecną wartość powiększoną o jeden (nie używając żadnej cyfry)
toIncrement++;

// wstaw do zmiennej toDivide jej obecną wartość podzieloną o nią samą (nie używając żadnej cyfry)
toDivide /= toDivide;

// Sprawdzenie wyników
Console.WriteLine("toIncrement: " + toIncrement);
Console.WriteLine("toDivide: " + toDivide);

Math.Sqrt(9);            // pierwiastek kwadratowy
Math.Pow(3, 2);           // potęgowanie
Math.Abs(-10);           // moduł
Math.Sin(1.57);          // sinus kąta w radianach
Math.Round(1.5);         // zaokrąglenie do najbliższej wartości całkowitej
Math.Round(2.5);         // wynik taki jak dla funkcji wyżej   
Math.Truncate(1.95);     // część całkowita liczby zmiennoprzecinkowej
Math.Ceiling(1.95);      // najmniejsza liczba całkowita większa lub równa argumentowi
Math.Floor(1.95);        // największa liczba całkowita mniejsza lub równa argumentowi 
Math.Clamp(4, 0, 10));   // ograniczenie pierwszego argumentu do zakresu
Math.Max(2, 6);          // zwraca większy argument
Math.Min(2, 6);          // zwraca mniejszy argument
Math.Sign(-2);           // zwraca liczbę określającą znak argumentu: - 1, 0 lub 1

Math.PI
Math.E
Math.Tau


double sqrt = Math.Sqrt(9);  // Wynik: 3
double pow = Math.Pow(3, 2);  // Wynik: 9
int abs = Math.Abs(-10);  // Wynik: 10
double sin = Math.Sin(1.57);  // Wynik: około 1 (sin(π/2) ≈ 1)
double round1 = Math.Round(1.5);  // Wynik: 2
double round2 = Math.Round(2.5);  // Wynik: 2
double truncate = Math.Truncate(1.95);  // Wynik: 1
double ceiling = Math.Ceiling(1.95);  // Wynik: 2
double floor = Math.Floor(1.95);  // Wynik: 1
int clampedValue = Math.Clamp(4, 0, 10);  // Wynik: 4 (w zakresie 0-10)
int max = Math.Max(2, 6);  // Wynik: 6
int min = Math.Min(2, 6);  // Wynik: 2
int sign = Math.Sign(-2);  // Wynik: -1


double pi = Math.PI;  // Wynik: 3.141592653589793
double e = Math.E;  // Wynik: 2.718281828459045
double tau = Math.Tau;  // Wynik: 6.283185307179586


/* koniec zadania 4 */

/* zadanie 5 */
double degree = 45;
double sinValue;
// Zamiana stopni na radiany i obliczenie wartości sinusa
sinValue = Math.Sin(degree * (Math.PI / 180));

// Wyświetlenie wyniku
Console.WriteLine("Sinus 45 stopni: " + sinValue);

/* koniec zadania 5 */

/* zadanie 6 */
int year = 2024;
int month = 5;
int day = 3;
int hour = 23;
int minute = 30;
// Stworzenie zmiennej typu DateTime
DateTime date = new DateTime(year, month, day, hour, minute, 0);

// Dodanie 3 miesięcy i odjęcie 1 godziny
date = date.AddMonths(3).AddHours(-1);

// Wypisanie na ekran nazwy dnia tygodnia
Console.WriteLine("Dzień tygodnia: " + date.DayOfWeek);


//tworzenie łancuchów
string msgImplicityNull;
string msgExplicityNull = null;
string msgEmpty = string.Empty;
string msgInitiated = "Hello";
string pathWithEscapes = "c:\\programs\\app\\file.txt";
string pathWithoutEscapes = @"c:\programs\app\file.txt";
int counter = 6;
string msgEvaluation = $"Counter = {counter}";
char[] chars = { 'H', 'e', 'l', 'l', 'o' };
string msgFromCharArray = new string(chars);
String msgInitiatedByConstructor = new String(chars);

//Niezmienniczość łańcuchów
string a = "abcd";
string b = "efgh";
a += b;
Console.WriteLine(a.ToUpper());
Console.WriteLine(a);
/* koniec zadania 6 */

/* zadanie 7 */
string firstPart = "This is";
string secondPart = "a string";
string thirdPart = "with capital letters.";
// Złączenie tekstów z dodaniem brakujących odstępów
string combinedString = firstPart + " " + secondPart + " " + thirdPart;

// Wypisanie tekstu DRUKOWANYMI LITERAMI
string upperCaseString = combinedString.ToUpper();
Console.WriteLine(upperCaseString);

// Wypisanie długości ciągu znaków
int length = combinedString.Length;
Console.WriteLine("Długość ciągu: " + length);

//need to writeout all of the functions
bool IsGreater = false;
bool IsLower = true;

bool IsLower = !IsGreater;
bool IsInRange = IsLower && true;
bool IsEqual = !IsGreater || !IsLower;

int counter = 56;
double temperature = 14;
bool isGreaterThanLimit = counter > 100;
bool isCold = temperature < 5;
bool isEqualZero = counter == 0;
bool isNotZero = counter != 0;
bool isGreaterOrEqualZero = temperature >= 0.0;

/* koniec zadania 7 */

/* zadanie 8 */
double lengthA = 5;
double lengthB = 1;
double lengthC = 3;
// Sprawdzenie, czy z odcinków można zbudować trójkąt (Nierówność trójkąta)
bool canFormTriangle = (lengthA + lengthB > lengthC) && (lengthA + lengthC > lengthB) && (lengthB + lengthC > lengthA);

// Zmienna do sprawdzenia, czy trójkąt jest prostokątny
bool isRightTriangle = false;

if (canFormTriangle)
{
	// Sprawdzenie, czy jest to trójkąt prostokątny (Twierdzenie Pitagorasa)
	double aSquared = Math.Pow(lengthA, 2);
	double bSquared = Math.Pow(lengthB, 2);
	double cSquared = Math.Pow(lengthC, 2);

	isRightTriangle = (aSquared + bSquared == cSquared) || (aSquared + cSquared == bSquared) || (bSquared + cSquared == aSquared);
}

// Wypisanie wyników
Console.WriteLine("Czy można zbudować trójkąt: " + canFormTriangle);
if (canFormTriangle)
{
	Console.WriteLine("Czy trójkąt jest prostokątny: " + isRightTriangle);
}

//Przykład
static void Main(string[] args)
{
	int a = 5;        // zmienna a jest widoczna w bloku deklaracji metody Main
	{
		int b = 3;    // zmienna b jest widoczna tylko w bloku
		...
        b = a * 3;    // do zmiennej b można odwołać się tylko w bloku deklaracji
	}
	b = a * 3;        // błąd, zmienna b już nie istnieje
}

/* koniec zadania 8 */

/* zadanie 9 */
string conditionalString = "To be or not to be?";
// Sprawdzenie, czy długość ciągu znaków jest większa niż 10
if (conditionalString.Length > 10)
{
	Console.WriteLine(conditionalString);
}

/* koniec zadania 9 */

/* zadanie 10 */
int temperature = 22;
// jeśli temperatura jest większa niż 20`C wyświetl "ciepło", w przeciwnym wypadku "zimno"
if (temperature > 20)
{
	Console.WriteLine("Hot");
}
else
{
	Console.WriteLine("Cold");
}
/* koniec zadania 10 */

/*Zadanie  11??*/

if (char.IsUpper(ch))
{
	Console.WriteLine($"An uppercase letter: {ch}");
}
else if (char.IsLower(ch))
{
	Console.WriteLine($"A lowercase letter: {ch}");
}
else if (char.IsDigit(ch))
{
	Console.WriteLine($"A digit: {ch}");
}
else
{
	Console.WriteLine($"Not alphanumeric character: {ch}");
}

/*Koniec Zadanie 11*/

/* zadanie 12 */
int code = 4;
int quantity = 11;
decimal productPrice = 3.5m;
decimal sellPrice;

int code = 4;
int quantity = 11;
decimal productPrice = 3.5m;
decimal sellPrice;

// Ustalanie ceny sprzedaży na podstawie kodu produktu
if (code < 10)
{
	// Produkty o kodach poniżej 10 sprzedawane są po cenie określonej w productPrice
	sellPrice = productPrice;
}
else if (code >= 10 && code <= 15)
{
	// Produkty o kodach od 10 do 15 sprzedawane są po cenie o 5% mniejszej od productPrice
	sellPrice = productPrice * 0.95m;
}
else
{
	// Produkty o kodach powyżej 16 sprzedawane są po cenie zależnej od quantity
	if (quantity <= 10)
	{
		// Dla quantity do 10 cena jest o 5% wyższa od price
		sellPrice = productPrice * 1.05m;
	}
	else if (quantity >= 11 && quantity <= 20)
	{
		// Dla quantity od 11 do 20 cena jest równa price
		sellPrice = productPrice;
	}
	else if (quantity > 20 && quantity < 100)
	{
		// Dla quantity powyżej 20, ale mniejszej od 100
		int discountPercent = (quantity / 10) - 2; // zniżka 2% dla quantity = 20
		sellPrice = productPrice * (1 - (discountPercent * 0.01m));
	}
	else
	{
		// Dla quantity powyżej 100 cena jest niższa o 10%
		sellPrice = productPrice * 0.90m;
	}
}

Console.WriteLine($"Price: {sellPrice}");
//should print out 3.5


/* koniec zadania 12 */

/* zadanie 13 */
char hexNum = 'E';

switch (hexNum)
{
	case '0':
		Console.WriteLine($"Decimal number: 0");
		break;
	// ...

	default:
		Console.WriteLine($"Not a valid hexadecimal number!");
		break;
}

// naprawione
char hexNum = 'E';
int decimalNum;

switch (hexNum)
{
	case '0':
		decimalNum = 0;
		break;
	case '1':
		decimalNum = 1;
		break;
	case '2':
		decimalNum = 2;
		break;
	case '3':
		decimalNum = 3;
		break;
	case '4':
		decimalNum = 4;
		break;
	case '5':
		decimalNum = 5;
		break;
	case '6':
		decimalNum = 6;
		break;
	case '7':
		decimalNum = 7;
		break;
	case '8':
		decimalNum = 8;
		break;
	case '9':
		decimalNum = 9;
		break;
	case 'A':
	case 'a':
		decimalNum = 10;
		break;
	case 'B':
	case 'b':
		decimalNum = 11;
		break;
	case 'C':
		decimalNum = 12;
		break;
	case 'D':
	case 'd':
		decimalNum = 13;
		break;
	case 'E':
	case 'e':
		decimalNum = 14;
		break;
	case 'F':
	case 'f':
		decimalNum = 15;
		break;
	default:
		Console.WriteLine($"Not a valid hexadecimal number!");
		return;

		Console.WriteLine($"Decimal number: {decimalNum}");

/* koniec zadania 