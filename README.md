# Lernperiode 2

## 16.10.2026
### Ziele
- [x] Zahlratespiel erstellen
- [x] Rate-Logik programmieren

### Zusammenfassung
Heute habe ich mit C# ein Zahlratespiel programmiert. Ich habe gelernt, wie man eine
zufällige Zahl erstellt und prüft, ob die geratene Zahl zu hoch oder zu tief ist. Mit einer
while-Schleife kann man so lange raten, bis die richtige Zahl gefunden wurde. Ich habe
länger gebraucht als geplant, weil ich einige Fehler im Code beheben musste.

### Nächstes Mal
- [x] Projektidee auswählen und Funktionen festlegen
- [x] Projekt planen und den Programmaufbau erstellen
- [x] Grundgerüst in C# programmieren
- [x] Erste Funktionen testen und Fehler beheben

Diese Punkte habe ich allgemein gehalten, weil ich mich zu diesem Zeitpunkt noch
nicht für ein Projekt entschieden hatte.


# Projektauftrag: Einnahmen- und Ausgabenmanager

## Projektidee
Ich möchte mit C# ein Programm machen mit dem man seine Einnahmen und Ausgaben
verwalten kann. So sieht man wie viel Geld man hat und wofür man es ausgibt.

## Funktionen
- [x] Einnahmen und Ausgaben eintragen
- [x] Kontostand automatisch berechnen
- [x] Monatsübersicht anzeigen
- [ ] Ausgaben nach Kategorien sortieren
- [x] Daten speichern (in einer Datei)
- [x] Menü mit verschiedenen Auswahlmöglichkeiten

---

## 23.10.2026
### Zusammenfassung
Heute habe ich an meinem C#-Kontostandrechner gearbeitet. Ich habe ein Menü erstellt,
in dem man Einnahmen und Ausgaben eingeben kann. Ausserdem habe ich gelernt, wie man
Benutzereingaben speichert und mit double Kommazahlen berechnet.

### Hausaufgabe
- [x] Eine while-Schleife einbauen, damit das Menü nach jeder Auswahl wieder angezeigt
      wird und das Programm bei Auswahl 4 beendet wird.

### Arbeitspakete für nächstes Mal
- [x] Die Variablen für Einnahmen, Ausgaben und Kontostand so anpassen, dass die
      eingegebenen Werte gespeichert bleiben und bei Auswahl 2 angezeigt werden.
- [x] Bei Auswahl 3 die Einnahmen, Ausgaben und den verbleibenden Kontostand
      übersichtlich ausgeben (als Monatsansicht).
- [x] Prüfen, ob die Benutzereingaben gültig sind, Kommazahlen mit double ermöglichen
      und verschiedene Eingaben testen.

### Zusammenfassung Hausaufgabe
Ich habe einen Kontostandrechner in C# mit einem Menü und einem switch geschrieben.
Als Hausaufgabe habe ich eine while-Schleife eingebaut. Dafür habe ich die Variable
auswahl ganz oben mit 0 erstellt und das Menü und den switch in while (auswahl != 4)
gesetzt. So erscheint das Menü nach jeder Auswahl wieder, und bei 4 wird das Programm
beendet.

## 30.10.2026
### Zusammenfassung
Heute habe ich an meinem Kontostandrechner in C# gearbeitet. Ich habe mithilfe von
Listen mehrere Einträge gespeichert. Damit habe ich den Kontostand bei Option 2 und
eine Monatsübersicht mit for-Schleife und if bei Option 3 programmiert. Ausserdem habe
ich Fehlermeldungen behoben und angefangen, Benutzereingaben mit TryParse zu prüfen.

### Nächstes Mal
- [x] Statt „Monat 1“ den Monatsnamen anzeigen, wie zum Beispiel „Januar“
- [x] TryParse bei Menü, Einnahme und Ausgabe einbauen und testen
- [x] TryParse bei case 3 einbauen und verschiedene Eingaben testen
- [x] for-Schleife und if üben und die Monatsübersicht erweitern
- [x] Ausgabe verschönern mit Monatsnamen und zwei Kommastellen

## 06.11.2026
### Zusammenfassung
In dieser Sitzung habe ich an meinem Kontostandrechner in C# gearbeitet. Zuerst habe
ich mit einem Array den Monatsnamen statt der Zahl angezeigt. Weil Arrays bei 0
anfangen, musste ich [monat - 1] schreiben.

Danach habe ich die restlichen Aufträge umgesetzt. Alle Eingaben verwenden jetzt
TryParse statt Convert, damit das Programm bei falschen Eingaben nicht abstürzt. Die
Monatsübersicht zeigt jetzt an, wenn es keine Einträge gibt, nennt die grösste Ausgabe
und warnt bei einem negativen Kontostand. Beträge werden mit ToString("F2") immer
mit zwei Kommastellen angezeigt.

### Kennenlernen
- [ ] Ich will Methoden kennenlernen

### Nächstes Mal
- [ ] Eine TryParse-Schleife löschen und ohne Hilfe neu schreiben
- [ ] Einnahme und Ausgabe in zwei getrennte Menüpunkte aufteilen
- [ ] Jahresübersicht mit allen 12 Monaten als neuen Menüpunkt einbauen
- [ ] Methoden lernen und die TryParse-Schleifen in eine Methode auslagern


## 13.11.2026 – Cisco Networking Basics (Module 2–4)
### Zusammenfassung
Heute habe ich an Cisco Networking Basics (Cybersecurity) gearbeitet. Ich konnte mich
sehr gut konzentrieren und bin weit gekommen: Ich habe drei Module abgeschlossen. Ich
habe gelernt, wie man ein Heimnetzwerk einrichtet, und habe den Test gemacht.
Schwierigkeiten hatte ich mit Kabel- und DSL-Verbindungen.

### Nächstes Mal
Diese Arbeitspakete habe ich heute nicht gemacht. Ich mache sie nächstes Mal:
- [ ] Einnahme und Ausgabe in zwei getrennte Menüpunkte aufteilen
- [ ] Methoden lernen
- [ ] Ausgaben nach Kategorien sortieren
- [ ] Eine TryParse-Schleife löschen und ohne Hilfe neu schreiben
## Hausaufgaben
- [x] Daten speichern (in einer Datei)

## *20.11.2026*  Daten in einer Datei speichern

### Zusammenfassung
Bis jetzt waren alle Einträge weg, wenn ich das Programm beendet habe.
Heute habe ich eingebaut dass die Einträge in einer Textdatei (daten.txt)
gespeichert und beim nächsten Start wieder geladen werden.

### Speichern
Wenn man bei Option 1 einen Eintrag macht, wird er als neue Zeile in die Datei
geschrieben. Die Werte sind mit ; getrennt.

csharp
string neueZeile = monat + ";" + nameEinnahme + ";" + einnahme + ";" + nameAusgabe + ";" + ausgabe;
File.AppendAllText(dateiPfad, neueZeile + Environment.NewLine);


AppendAllText hängt die Zeile unten an die Datei an. So bleiben die alten Einträge erhalten.

### Laden
Beim Start prüft das Programm mit File.Exists, ob die Datei schon existiert.
Dann liest es alle Zeilen und teilt jede Zeile mit Split(';')` in 5 Teile auf.
Die Teile werden wieder in die Listen eingefügt.

csharp
string[] teile = zeile.Split(';');
monate.Add(int.Parse(teile[0]));
einnahmenNamen.Add(teile[1]);


### Schwierigkeiten
Wenn jemand ein ; im Namen eingibt, geht die Zeile kaputt. Deshalb ersetze ich
; mit Replace(;, ;,) durch ein Komma.

### Was ich gelernt habe
- Mit File.AppendAllText etwas in eine Datei schreiben
- Mit File.ReadAllLines eine Datei lesen
- Mit Split einen Text in Teile aufteilen

### Nächstes Mal
- [ ] Einnahme und Ausgabe in zwei getrennte Menüpunkte aufteilen
- [x] Methoden lernen
- [ ] Ausgaben nach Kategorien sortieren
- [ ] Eine TryParse-Schleife löschen und ohne Hilfe neu schreiben

*20.11.2026*
## Heute

Heute habe ich mich an ein neues Ziel gewendet ich möchte jede Woche so kleine Mini Projekte machen damit ich mehr lerne das was wir lernen und anzuwenden und damit ich auch Ende Jahr eine Grosse Sammlung an Projekten habe.Die READMe habe ich auf einem Separaten Reposority .ICh habe mich noch mit Methoden befasst ich habe ein Youtube Video geschaut : https://www.youtube.com/watch?v=IPpEefuFiVM

- [ ] Ausgaben nach Kategorien sortieren
- [ ] Eine TryParse-Schleife löschen und ohne Hilfe neu schreiben
- [ ] Einnahme und Ausgabe in zwei getrennte Menüpunkte aufteilen
- [ ] Mein Mini Projekt fertig machen
