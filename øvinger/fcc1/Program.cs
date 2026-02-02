int value = 1;
value++;
Console.WriteLine("First " + value);
Console.WriteLine($"Second: {value++}");// skriver ut og øker med en etter utskrift.
Console.WriteLine("Third " + value); // viser nåværende verdi av value
Console.WriteLine("Fourth " + (++value)); //øker med en for så å skrive ut.
