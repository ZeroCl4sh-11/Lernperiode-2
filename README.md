# Lernperiode-2
**16.10.26**
- [x] Zahlratespiel erstellen
- [x]  Rate-Logik programmieren

## Zusammenfassung der heutigen Sitzung
Heute habe ich mit C# ein Zahlratespiel programmiert. Ich habe gelernt, wie man eine zufällige Zahl erstellt und prüft, ob die geratene Zahl zu hoch oder zu tief ist. Mit einer while-Schleife kann man so lange raten bis die richtige Zahl gefunden wurde. Ich habe länger gebraucht als geplant, weil ich einige Fehler im Code beheben musste.

## Nächstes Mal
- [x] Projektidee auswählen und Funktionen festlegen.
- [x] Projekt planen und den Programmaufbau erstellen.
- [x] Grundgerüst in C# programmieren.
- [x] Erste Funktionen testen und Fehler beheben.
      Ich habe das so geschrieben weil ich noch keine Ahnung habe was ich machen will.


# Projektauftrag: Einnahmen- und Ausgabenmanager

## Projektidee

Ich möchte mit C# ein Programm machen, mit dem man seine Einnahmen und Ausgaben verwalten kann. So sieht man, wie viel Geld man hat und wofür man es ausgibt.

## Funktionen

- Einnahmen und Ausgaben eintragen
- Kontostand automatisch berechnen
- Monatsübersicht anzeigen
- Ausgaben nach Kategorien sortieren
- Daten speichern
- Menu mit verschiedene möglichkeiten zum Auswählen
**23.10.26**
## Zusammenfassung heutiger Sitzung 
Heute habe ich an meinem C#-Kontostandrechner gearbeitet. Ich habe ein Menü erstellt, in dem man Einnahmen und Ausgaben eingeben kann. Ausserdem habe ich gelernt, wie man Benutzereingaben speichert und mit double Kommazahlen berechnet. 


## Für nächstes Mal
Hausaufgabe
- [x] Eine while-Schleife einbauen damit das Menü nach jeder Auswahl wieder angezeigt wird und das Programm bei Auswahl 4 ganz beendet wird.
## Arbeitspakete für nächstes Mal
- [x] Die Variablen für Einnahmen, Ausgaben und Kontostand so anpassen, dass die eingegebenen Werte gespeichert bleiben und bei Auswahl 2 angezeigt werden.
- [x] Bei Auswahl 3 die Einnahmen Ausgaben und den verbleibenden Kontostand übersichtlich ausgeben( als Monatsansicht).
- [x] Prüfen ob die Benutzereingaben gültig sind Kommazahlen mit double ermöglichen und verschiedene Eingaben testen.
## Zusammenfassung Hausaufgaben
Ich habe einen Kontostandrechner in C# mit einem Menü und einem switch geschrieben. Als Hausaufgabe habe ich eine while-Schleife eingebaut. Dafür habe ich die Variable auswahl ganz oben mit 0 erstellt und das Menü und den switch in while (auswahl != 4) gesetzt. So erscheint das Menü nach jeder Auswahl wieder, und bei 4 wird das Programm beendet.




**30.10.26**
## Zusammenfasssung Heute
Heute habe ich an meinem Kontostandrechner in C# gearbeitet. Ich habe mithilfe von Listen mehrere Einträge gespeichert und damit den Kontostand bei Option 2 und eine Monatsübersicht mit for-Schleife und if bei Option 3 programmiert. Ausserdem habe ich Fehlermeldungen behoben und angefangen, Benutzereingaben mit TryParse zu prüfen.

## Nächstes mal 
- [ ] Ich sollte anstatt so Monat 1 sollte ich so ändern auf Monat januar
- [ ] TryParse bei Menü, Einnahme und Ausgabe einbauen und testen.
- [ ] TryParse bei case 3 einbauen und verschiedene Eingaben testen.
- [ ] for-Schleife und if üben und die Monatsübersicht erweitern.
- [ ] Ausgabe verschönern mit Monatsnamen und zwei Kommastellen.

**06.11.2026**
## Zusammenfassung Heute
In dieser Sitzung habe ich an meinem Kontostandrechner in C# gearbeitet. Zuerst habe ich mit einem Array den Monatsnamen statt der Zahl angezeigt. Weil Arrays bei 0 anfangen, musste ich [monat -1] schreiben.
Danach wurden die restlichen Aufträge umgesetzt. Alle Eingaben verwenden jetzt TryParse statt Convert, damit das Programm bei falschen Eingaben nicht abstürzt. Die Monatsübersicht zeigt jetzt an, wenn es keine Einträge gibt, nennt die grösste Ausgabe und warnt bei einem negativen Kontostand. Beträge werden mit ToString("F2") immer mit zwei Kommastellen angezeigt.
      
## Kennelernen
- [ ] Ich will Methoden kennenlernen
## Nächstes mal
- [ ] Eine TryParse-Schleife löschen und ohne Hilfe neu schreiben.
- [ ] Einnahme und Ausgabe in zwei getrennte Menüpunkte aufteilen.
- [ ] Jahresübersicht mit allen 12 Monaten als neuen Menüpunkt einbauen.
- [ ] Methoden lernen und die TryParse-Schleifen in eine Methode auslagern.

