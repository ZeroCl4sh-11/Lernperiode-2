int auswahl = 0;
List<string> einnahmenNamen = new List<string>();
List<double> einnahmenBeträge = new List<double>();
List<string> ausgabenNamen = new List<string>();
List<double> ausgabenBeträge = new List<double>();
List<int> monate = new List<int>();

while (auswahl != 4)
{
    Console.WriteLine("================================");
    Console.WriteLine("   MEIN KONTOSTANDRECHNER");
    Console.WriteLine("================================");
    Console.WriteLine("1 - Einnahmen und Ausgaben eingeben");
    Console.WriteLine("2 - Kontostand anzeigen");
    Console.WriteLine("3 - Monatsübersicht anzeigen");
    Console.WriteLine("4 - Beenden\n");
    Console.WriteLine("Bitte wählen Sie eine Option:");

    auswahl = Convert.ToInt32(Console.ReadLine());

    switch (auswahl)
    {
        case 1:
            Console.WriteLine("Für welchen Monat? (1-12)");
            int monat;
            while (!int.TryParse(Console.ReadLine(), out monat) || monat < 1 || monat > 12)
            {
                Console.WriteLine("Ungültig! Bitte gib einen Monat von 1 bis 12 ein:");
            }
            monate.Add(monat);

            Console.WriteLine("Wie heisst deine Einnahme?");
            string nameEinnahme = Console.ReadLine();
            einnahmenNamen.Add(nameEinnahme);

            Console.WriteLine("Wie hoch ist deine Einnahme?");
            double einnahme = Convert.ToDouble(Console.ReadLine());
            einnahmenBeträge.Add(einnahme);

            Console.WriteLine("Wie heisst deine Ausgabe?");
            string nameAusgabe = Console.ReadLine();
            ausgabenNamen.Add(nameAusgabe);

            Console.WriteLine("Wie hoch ist deine Ausgabe?");
            double ausgabe = Convert.ToDouble(Console.ReadLine());
            ausgabenBeträge.Add(ausgabe);

            Console.WriteLine("Gespeichert!");
            break;

        case 2:
            Console.WriteLine("Kontostand anzeigen");


            double summeeinnahmen = einnahmenBeträge.Sum();
            double summeaussgaben = ausgabenBeträge.Sum();
            double Kontostand = summeeinnahmen - summeaussgaben;
            Console.WriteLine(Kontostand + " CHF");            
            break;

        case 3:
            Console.WriteLine("Welchen Monat willst du sehen? (1-12)");
            int gewähltermonat = Convert.ToInt32(Console.ReadLine());

            double einnahmenMonat = 0;
            double ausgabenMonat = 0;

            Console.WriteLine("===== MONATSÜBERSICHT: Monat " + gewähltermonat + " =====");

            Console.WriteLine("Einnahmen:");
            for (int i = 0; i < einnahmenNamen.Count; i++)
            {
                if (monate[i] == gewähltermonat)
                {
                    Console.WriteLine("  + " + einnahmenNamen[i] + ": " + einnahmenBeträge[i] + " CHF");
                    einnahmenMonat = einnahmenMonat + einnahmenBeträge[i];
                }
            }

            Console.WriteLine("Ausgaben:");
            for (int i = 0; i < ausgabenNamen.Count; i++)
            {
                if (monate[i] == gewähltermonat)
                {
                    Console.WriteLine("  - " + ausgabenNamen[i] + ": " + ausgabenBeträge[i] + " CHF");
                    ausgabenMonat = ausgabenMonat + ausgabenBeträge[i];
                }
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine("Total Einnahmen: " + einnahmenMonat + " CHF");
            Console.WriteLine("Total Ausgaben:  " + ausgabenMonat + " CHF");
            Console.WriteLine("Kontostand:      " + (einnahmenMonat - ausgabenMonat) + " CHF");
            break;

        case 4:
            Console.WriteLine("Programm wird beendet.");
            break;

        default:
            Console.WriteLine("Ungültige Auswahl!");
            break;
    }
}
