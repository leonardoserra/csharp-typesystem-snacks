/*
 * consegna
 *  Snack 1: L’utente inserisce due numeri in successione. Il software stampa il maggiore.
    Snack 2 : L’utente inserisce due parole in successione. Il software stampa prima la parola più corta, poi la parola più lunga.
    Snack 3: Il software deve chiedere per 10 volte all’utente di inserire un numero. Il programma stampa la somma di tutti i numeri inseriti.
    Snack 4: Calcola la somma e la media dei numeri da 2 a 10.
    Snack 5: Il software chiede all’utente di inserire un numero. Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo.
    Snack 6: In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby. Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.
    Snack 7: Crea un array vuoto. Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo nell’array.
    Snack 8: Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.
    Snack 9: Crea un array vuoto e chiedi all’utente un numero da inserire nell’array. Continua a chiedere i numeri all’utente e a inserirli nell’array, fino a quando la somma degli elementi è minore di 50.
    Snack 10: Fai inserire un numero, che chiameremo N, all’utente. Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100. Ogni volta che ne crei uno, stampalo a schermo.
Buon lavoro!
POSSIBILE BONUS:
Creare un menù dove mostro gli snacks all'utente e chiedo quale vuole eseguire. Una volta la scelta il programma esegue il snack corrispondente.
 */
using System;

namespace csharp_typesystem_snacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Digita il numero dello snack che vuoi eseguire da 1 a 10: ");
            int snackToExecute = int.Parse(Console.ReadLine());
            //Snack 1: L’utente inserisce due numeri in successione.Il software stampa il maggiore.  
            switch (snackToExecute)
            {
                case 1:
                    Console.WriteLine($"Snack 1: comparatore di maggioranza.");

                    try
                    {

                        int firstNumber;
                        int secondNumber;
                        Console.Write("Inserisci il primo numero intero e premi invio: ");
                        firstNumber = int.Parse(Console.ReadLine());
                        Console.Write("Inserisci il secondo numero intero e premi invio: ");
                        secondNumber = int.Parse(Console.ReadLine());

                        if (firstNumber < secondNumber)
                        {
                            Console.WriteLine($"il numero con il valore piú alto è il: {secondNumber}");
                        }
                        else if (firstNumber == secondNumber)
                        {
                            Console.WriteLine($"I numeri inseriti hanno lo stesso valore");
                        }
                        else
                        {
                            Console.WriteLine($"il numero con il valore piú alto è il: {firstNumber}");
                        }

                    }catch (Exception e)
                    {
                        Console.WriteLine("Riavvia il programma e inserisci un numero valido");
                    }
    
                    break;

                case 2:
                    //Snack 2 : L’utente inserisce due parole in successione.
                    //Il software stampa prima la parola più corta, poi la parola più lunga.
                    Console.WriteLine();
                    Console.WriteLine($"Snack 2: Quale parola è la piú lunga?");

                    try
                    {
                        string firstString;
                        string secondString;
                        int firstStringLength;
                        int secondStringLenght;
                        Console.Write("Inserisci la prima parola o frase e premi invio: ");
                        firstString = Console.ReadLine();
                        Console.Write("Inserisci la seconda parola o frase e premi invio: ");
                        secondString = Console.ReadLine();
                        if (firstString.Length >= 0)
                        {
                            firstStringLength = firstString.Length;
                        }
                        else
                        {
                            firstStringLength = 0;
                        }

                        if (secondString.Length >= 0)
                        {
                            secondStringLenght = secondString.Length;
                        }
                        else
                        {
                            secondStringLenght = 0;
                        }

                        if (firstStringLength < secondStringLenght)
                        {
                            Console.WriteLine($"la parola o frase piú lunga è: {secondString}");
                        }
                        else if (firstStringLength == secondStringLenght)
                        {
                            Console.WriteLine($"Le parole o frasi inserite hanno la stessa lunghezza in caratteri(anche lo spazio è contato)");
                        }
                        else
                        {
                            Console.WriteLine($"la parola o frase piú lunga è: {firstString}");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Riavvia il programma e inserisci qualcosa, i valori nulli non valgono");
                    }
                    break;

                case 3:
                    //Snack 3: Il software deve chiedere per 10 volte all’utente di inserire un numero.
                    //Il programma stampa la somma di tutti i numeri inseriti.
                    Console.WriteLine();
                    Console.WriteLine($"Snack 3: Somma di 10 valori");

                    try
                    {
                        int sum = 0;
                        for (int i = 0; i < 10; i++)
                        {
                            Console.WriteLine($"Inserisci il valore num: {i + 1}");
                            sum += int.Parse(Console.ReadLine());
                        }
                        Console.WriteLine($"la somma dei valori inseriti è {sum}");

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Non mettere valori nulli, riavvia");
                    }

                    break;

                case 4:
                    //Snack 4: Calcola la somma e la media dei numeri da 2 a 10.

                    Console.WriteLine();
                    Console.WriteLine($"Snack 4: Calcolo di somma e media dei numeri da 2 a 10");

                    try
                    {
                        int sum = 0;
                        int[] numbers = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            sum += numbers[i];
                        }
                        int average = sum / numbers.Length;
                        Console.WriteLine($"la somma dei valori è {sum}");
                        Console.WriteLine($"la media dei valori è {average}");


                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Qualcosa è andato storto.. riavvia");
                    }


                    break;

                case 5:
                    //Snack 5: Il software chiede all’utente di inserire un numero.
                    //Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo.

                    Console.WriteLine();
                    Console.WriteLine($"Snack 5: Numero Pari or next");

                    try
                    {

                        Console.Write($"Inserisci un numero e vediamo se è pari: ");
                        int number = int.Parse(Console.ReadLine());
                        if (number % 2 == 0)
                        {
                            Console.WriteLine(number);
                        }
                        else
                        {
                            Console.Write($"Il numero inserito non è pari. Inserisci un altro numero e stampiamolo: ");
                            number = int.Parse(Console.ReadLine());
                            Console.WriteLine(number);

                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Inserisci un valore valido, riavvia");
                    }

                    break;

                case 6:
                    //Snack 6: In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby.
                    //Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.

                    Console.WriteLine();
                    Console.WriteLine($"Snack 6: Lista invitati.");

                    try
                    {
                        string[] whiteList = { "Giannino", "Gregory", "Poldo", "Eufemio", "Markus", "Gerry Scotty", "Il Campione", "Lucius", "Franco" };
                        Console.Write($"Devo verificare che tu sia invitato alla festa..Come ti chiami? ");
                        string name = Console.ReadLine();
                        foreach (string nameInList in whiteList)
                        {
                            if (nameInList == name)
                            {
                                Console.WriteLine($"Benvenuto mr.{name}!!! La stavamo aspettando con ansia e un brivido di eccitazione!");
                            }
                            else
                            {
                                Console.WriteLine($"Mi spiace sig.{name}. Non è presente tra gli invitati, sono costretto ad allontanarla. (In realtà non gli dispiace)");
                                break;
                            }
                        }

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Inserisci un valore valido, riavvia");
                    }

                    break;

                case 7:
                    //Snack 7: Crea un array vuoto. Chiedi per 6 volte all’utente di inserire un numero,
                    //se è dispari inseriscilo nell’array.
                    Console.WriteLine("Ciao carissimo, inseriamo qualche numero in un array... ma solo se è dispari!");
                    try {
                        int[] oddNumbersArray = new int[6];
                        for (int i = 0; i < oddNumbersArray.Length; i++)
                        {
                            Console.WriteLine($"Tentativi rimasti: {oddNumbersArray.Length - i}");

                            Console.Write($"Digita un numero: ");
                            int inputNumber = int.Parse(Console.ReadLine());
                            if (inputNumber % 2 != 0)
                            {
                                oddNumbersArray[i] = inputNumber;
                            }

                        }
                        Console.WriteLine("Fine! La lista è piena, eccola di seguito: ");
                        foreach (int number in oddNumbersArray)
                        {
                            Console.Write($"{number} ");
                        }

                    }catch(Exception e)
                    {
                        Console.WriteLine("Inserisci valori validi...riavvia il programma");
                    }
                    break;

                case 8:
                    //Snack 8: Crea un array di numeri interi e fai la somma di tutti gli elementi che
                    //sono in posizione dispari.
                    Console.WriteLine("La somma dei numeri con indice dispari della lista seguente ");
                    try
                    {

                        int[] intNumbers = { 2, 45, 654, 2, 9, 78, 1, 5, 6, 44, 83, 5, 24, 7, 96, 4, 0 };
                        int sum = 0;
                        foreach (int number in intNumbers)
                        {   
                            Console.Write($"{number} ");
                            
                            if(number % 2 != 0)
                            {
                                sum += number;
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine($"é: {sum}");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Qualcosa è andato storto... riavvia");
                    }
                    break;

                case 9:

                    break;

                case 10:

                    break;

                default:
                    Console.WriteLine("Input non valido.");
                    break;
            }

        }
    }
}