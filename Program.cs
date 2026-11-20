int auswahl = 0;
List<string> einnahmenNamen = new List<string>();
List<double> einnahmenBeträge = new List<double>();
List<string> ausgabenNamen = new List<string>();
List<double> ausgabenBeträge = new List<double>();
List<int> monate = new List<int>();
string[] monatsNamen = { "Januar", "Februar", "März", "April", "Mai", "Juni", "Juli", "August", "September", "Oktober", "November", "Dezember" };
string dateiPfad = "daten.txt";

// Gespeicherte Daten beim Start laden
if (File.Exists(dateiPfad))
{
    string[] zeilen = File.ReadAllLines(dateiPfad);

    foreach (string zeile in zeilen)
    {
        string[] teile = zeile.Split(';');

        if (teile.Length == 5)
        {
            monate.Add(int.Parse(teile[0]));
            einnahmenNamen.Add(teile[1]);
            einnahmenBeträge.Add(double.Parse(teile[2]));
            ausgabenNamen.Add(teile[3]);
            ausgabenBeträge.Add(double.Parse(teile[4]));
        }
    }

    Console.WriteLine(monate.Count + " Einträge geladen.\n");
}

while (auswahl != 4)
{
    Console.WriteLine("================================");
    Console.WriteLine("   MEIN KONTOSTANDRECHNER");
    Console.WriteLine("================================");
    Console.WriteLine("1 - Einnahmen und Ausgaben eingeben");
    Console.WriteLine("2 - Kontostand anzeigen");
    Console.WriteLine("3 - Monatsübersicht anzeigen");
    Console.WriteLine("4 - Beenden\n");
    Console.WriteLine("Bitte wähle eine Option:");

    while (!int.TryParse(Console.ReadLine(), out auswahl) || auswahl < 1 || auswahl > 4)
    {
        Console.WriteLine("Ungültig! Bitte gib eine Zahl von 1 bis 4 ein:");
    }

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
            string nameEinnahme = Console.ReadLine().Replace(";", ",");
            einnahmenNamen.Add(nameEinnahme);

            Console.WriteLine("Wie hoch ist deine Einnahme?");
            double einnahme;
            while (!double.TryParse(Console.ReadLine(), out einnahme) || einnahme < 0)
            {
                Console.WriteLine("Ungültig! Bitte gib einen positiven Betrag ein:");
            }
            einnahmenBeträge.Add(einnahme);

            Console.WriteLine("Wie heisst deine Ausgabe?");
            string nameAusgabe = Console.ReadLine().Replace(";", ",");
            ausgabenNamen.Add(nameAusgabe);

            Console.WriteLine("Wie hoch ist deine Ausgabe?");
            double ausgabe;
            while (!double.TryParse(Console.ReadLine(), out ausgabe) || ausgabe < 0)
            {
                Console.WriteLine("Ungültig! Bitte gib einen positiven Betrag ein:");
            }
            ausgabenBeträge.Add(ausgabe);

            
            string neueZeile = monat + ";" + nameEinnahme + ";" + einnahme + ";" + nameAusgabe + ";" + ausgabe;
            File.AppendAllText(dateiPfad, neueZeile + Environment.NewLine);

            Console.WriteLine("Gespeichert für " + monatsNamen[monat - 1] + "!");
            break;

        case 2:
            Console.WriteLine("Kontostand anzeigen");

            double summeEinnahmen = einnahmenBeträge.Sum();
            double summeAusgaben = ausgabenBeträge.Sum();
            double kontostand = summeEinnahmen - summeAusgaben;
            Console.WriteLine(kontostand.ToString("F2") + " CHF");
            break;

        case 3:
            Console.WriteLine("Welchen Monat willst du sehen? (1-12)");
            int gewählterMonat;
            while (!int.TryParse(Console.ReadLine(), out gewählterMonat) || gewählterMonat < 1 || gewählterMonat > 12)
            {
                Console.WriteLine("Ungültig! Bitte gib einen Monat von 1 bis 12 ein:");
            }

            double einnahmenMonat = 0;
            double ausgabenMonat = 0;
            int anzahlEinnahmen = 0;
            int anzahlAusgaben = 0;
            double grössteAusgabe = 0;
            string grössteAusgabeName = "";

            Console.WriteLine("===== MONATSÜBERSICHT: " + monatsNamen[gewählterMonat - 1] + " =====");

            Console.WriteLine("Einnahmen:");
            for (int i = 0; i < einnahmenNamen.Count; i++)
            {
                if (monate[i] == gewählterMonat)
                {
                    Console.WriteLine("  + " + einnahmenNamen[i] + ": " + einnahmenBeträge[i].ToString("F2") + " CHF");
                    einnahmenMonat = einnahmenMonat + einnahmenBeträge[i];
                    anzahlEinnahmen++;
                }
            }
            if (anzahlEinnahmen == 0)
            {
                Console.WriteLine("  (keine Einnahmen in diesem Monat)");
            }

            Console.WriteLine("Ausgaben:");
            for (int i = 0; i < ausgabenNamen.Count; i++)
            {
                if (monate[i] == gewählterMonat)
                {
                    Console.WriteLine("  - " + ausgabenNamen[i] + ": " + ausgabenBeträge[i].ToString("F2") + " CHF");
                    ausgabenMonat = ausgabenMonat + ausgabenBeträge[i];
                    anzahlAusgaben++;

                    if (ausgabenBeträge[i] > grössteAusgabe)
                    {
                        grössteAusgabe = ausgabenBeträge[i];
                        grössteAusgabeName = ausgabenNamen[i];
                    }
                }
            }
            if (anzahlAusgaben == 0)
            {
                Console.WriteLine("  (keine Ausgaben in diesem Monat)");
            }

            double bilanz = einnahmenMonat - ausgabenMonat;

            Console.WriteLine("------------------------------");
            Console.WriteLine("Total Einnahmen: " + einnahmenMonat.ToString("F2") + " CHF");
            Console.WriteLine("Total Ausgaben:  " + ausgabenMonat.ToString("F2") + " CHF");
            Console.WriteLine("Kontostand:      " + bilanz.ToString("F2") + " CHF");

            if (anzahlAusgaben > 0)
            {
                Console.WriteLine("Grösste Ausgabe: " + grössteAusgabeName + " (" + grössteAusgabe.ToString("F2") + " CHF)");
            }

            if (bilanz < 0)
            {
                Console.WriteLine("Achtung: Du hast in diesem Monat mehr ausgegeben als eingenommen!");
            }
            break;

        case 4:
            Console.WriteLine("Programm wird beendet.");
            break;
    }
}

