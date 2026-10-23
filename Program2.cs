

Console.WriteLine("================================");
Console.WriteLine("   MEIN KONTOSTANDRECHNER");
Console.WriteLine("================================");
Console.WriteLine("1 - Einnahmen und Ausgaben eingeben");
Console.WriteLine("2 - Kontostand anzeigen");
Console.WriteLine("3 - Monatsübersicht anzeigen");
Console.WriteLine("4 - Beenden\n");
Console.WriteLine("Bitte wählen Sie eine Option:");

int auswahl = Convert.ToInt32(Console.ReadLine());

switch (auswahl)
{
    case 1:


    
        string nameEinnahme;
        string nameAusgabe;
        int einnahme;
        int ausgaben;
        int result;
        Console.WriteLine("Wie heisst deine Einnahme?");
        nameEinnahme = Console.ReadLine();

        Console.WriteLine("Wie hoch ist deine Einnahme?");
        einnahme = (int)Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Wie heisst deine Ausgabe?");
        nameAusgabe = Console.ReadLine();

        Console.WriteLine("Wie hoch ist deine Ausgabe?");
        ausgaben = (int)Convert.ToDouble(Console.ReadLine());

        result = einnahme - ausgaben;

        Console.WriteLine("Deine Einnahme: " + nameEinnahme
            + " - " + einnahme + " CHF");

        Console.WriteLine("Deine Ausgabe: " + nameAusgabe
            + " - " + ausgaben + " CHF");

        Console.WriteLine("Dein Kontostand: " + result + " CHF");
        break;

    case 2:
        Console.WriteLine("Kontostand anzeigen");
        break;

    case 3:
        Console.WriteLine("Monatsübersicht anzeigen");
        break;

    case 4:
        Console.WriteLine("Programm wird beendet.");
        break;

    default:
        Console.WriteLine("Ungültige Auswahl!");
        break;
}



