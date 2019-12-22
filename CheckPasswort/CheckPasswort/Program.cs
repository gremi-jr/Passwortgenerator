
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckPasswort
{
    class Program
    {
       



        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>



        [STAThread]
        static void Main(string[] args)
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Oberfläche());
            /* Start:
                 //Variablen
                 String passwortEingabe;
                 String randomPasswort;
                 String benutzerEingabe;
                 int passwortLänge;
                 int menü;
                 int randomPasswortLänge;
                 int programSchliessen = 0;
                 Boolean sonderzeichen = false;
                 Boolean großbuchstaben = false;
                 Boolean kleinbuchstaben = false;
                 Boolean zahlen = false;

                 try
                 {
                 Hub:
                     //Menü
                     Console.Clear();
                     Console.WriteLine("Zum überprüfen des Passwortes bitte die '1' eingeben.");
                     Console.WriteLine("Für den Passwort Generator bitte die '2' eingeben.");
                     Console.WriteLine("Um das Programm zu schliesen bitte '9' eingeben");
                     menü = Convert.ToInt32(Console.ReadLine());
                     Console.Clear();

                     while (programSchliessen != 9)
                     {
                         //Passwort überprüfen
                         if (menü == 1)
                         {
                         MenuOne:
                             Console.WriteLine("Das Passwort wird nach folgenden Kriterien überprüft:");
                             Console.WriteLine("1. Das Passwort muss mindestens 8 Zeichen kurz sein!");
                             Console.WriteLine("2. Das Passwort muss mindestens ein Groß-, sowie Kleinbuchstaben enthalten. Umlaute (ä, ö, ü) sind auch erlaubt und erwünscht!");
                             Console.WriteLine("3. Das Passwort muss mindestens ein Sonderzeichen enthalten. Erlaubte Sonderzeichen sind: /,.;:_?!+%&()><=$'*-");
                             Console.WriteLine("4. Das Passwort muss mindestens eine Zahl enthalten.");
                             Console.WriteLine("Um in das Menü zu kommen geben Sie '9' ein.");
                             Console.WriteLine("Bitte Passwort eingeben!");
                             passwortEingabe = Console.ReadLine();
                             passwortLänge = passwortEingabe.Length;

                             if (passwortLänge <= 7)
                             {
                                 Console.Clear();
                                 Console.WriteLine("---> Das Passwort muss mindestens 8 Zeichen kurz sein! Passwort erneut eingeben! <---");
                             }
                             else
                             {

                                 //SONDERZEICHEN
                                 if (Regex.IsMatch(passwortEingabe, @"[/,.;:_?!+%&()><=$'*-]"))
                                 {
                                     sonderzeichen = true;
                                 }
                                 else
                                 {
                                     sonderzeichen = false;
                                 }
                                 //GROßBUCHSTABEN
                                 if (Regex.IsMatch(passwortEingabe, @"[A-Z_ÄÜÖ]"))
                                 {
                                     großbuchstaben = true;
                                 }
                                 else
                                 {
                                     großbuchstaben = false;
                                 }
                                 //KLEINBUCHSTABEN
                                 if (Regex.IsMatch(passwortEingabe, @"[a-z_üäö]"))
                                 {
                                     kleinbuchstaben = true;
                                 }
                                 else
                                 {
                                     kleinbuchstaben = false;
                                 }
                                 //ZAHLEN
                                 if (Regex.IsMatch(passwortEingabe, @"[0-9]"))
                                 {
                                     zahlen = true;
                                 }
                                 else
                                 {
                                     zahlen = false;
                                 }
                                 //Überprüfung ob das Passwort den Ansprüchen genügt
                                 if (sonderzeichen && zahlen && großbuchstaben && kleinbuchstaben == true)
                                 {
                                     Console.Clear();
                                     Console.WriteLine("Ihr Passwort entspricht allen Anforderungen und kann ohne Bedenken genutzt werden.");
                                     Console.WriteLine("Möchten Sie noch ein Passwort kontrollieren? (Y/N)");
                                     benutzerEingabe = Console.ReadLine();
                                     Console.Clear();
                                     //Möglichkeit ein weiteres Passwort zu kontrollieren
                                     if (benutzerEingabe == "Y" || benutzerEingabe == "y")
                                     {
                                         goto MenuOne;
                                     }
                                     //Hier erhält man die Möglichkeit zurück in das Menü zu kommen
                                     if (benutzerEingabe == "n" || benutzerEingabe == "N")
                                     {
                                         Console.WriteLine("Um in das Menü zu gelangen, drücken Sie die '1'.");
                                         Console.WriteLine("Um das Programm zu schließen, drücken Sie die '2'.");
                                         benutzerEingabe = Console.ReadLine();
                                         if (benutzerEingabe == "1")
                                         {
                                             goto Hub;
                                         }
                                         else if (benutzerEingabe == "2")
                                         {
                                             Environment.Exit(0);
                                         }
                                     }
                                 }
                                 else
                                 {
                                     Console.Clear();
                                     Console.WriteLine("---> Das Passwort genügt nicht unseren Anforderungen! Bitte überdenken Sie ihr Passwort! <---");
                                 }
                             }
                             if (passwortEingabe == "9")
                             {
                                 goto Hub;
                             }
                         }
                         //Passwort Generator
                         else if (menü == 2)
                         {
                         MenuTwo:
                             Console.WriteLine("Wie lang soll das Passwort sein? Es muss mindestens 8 Zeichen kurz sein!");
                             Console.WriteLine("Um in das Menü zu kommen, geben Sie '0' ein.");
                             randomPasswortLänge = Convert.ToInt32(Console.ReadLine());
                             Console.Clear();

                             //Hier kann man zurück in das Menü gelangen
                             if (randomPasswortLänge == 0)
                             {
                                 goto Hub;
                             }
                             //Hier wird das Passwort auf die richtige Länge geprüft
                             if (randomPasswortLänge <= 7)
                             {
                                 Console.WriteLine("---> Passwort ist zu kurz! <---");
                                 goto MenuTwo;
                             }
                             else
                             {
                                 //Hier werden beliebig oft Passwörter generiert
                                 randomPasswort = PasswortGenerator(randomPasswortLänge);
                                 Console.WriteLine("Das erstellte Passwort ist: " + randomPasswort);
                                 Console.WriteLine("Noch ein Passwort generieren? (Y/N)");
                                 benutzerEingabe = Console.ReadLine();
                                 Console.Clear();
                                 if (benutzerEingabe == "Y" || benutzerEingabe == "y")
                                 {
                                     goto MenuTwo;
                                 }
                                 //Hier erhält man die Möglichkeit zurück in das Menü zu kommen
                                 if (benutzerEingabe == "n" || benutzerEingabe == "N")
                                 {
                                     Console.WriteLine("Um in das Menü zu gelangen, drücken Sie die '1'");
                                     Console.WriteLine("Um das Programm zu schließen, drücken Sie die '2'");
                                     benutzerEingabe = Console.ReadLine();
                                     if (benutzerEingabe == "1")
                                     {
                                         goto Hub;
                                     }
                                     else if (benutzerEingabe == "2")
                                     {
                                         Environment.Exit(0);
                                     }
                                 }
                             }
                         }
                         //Program schließen
                         else if (menü == 9)
                         {
                             Environment.Exit(0);
                         }
                         else if (menü != 1 || menü != 2 || menü != 9)
                         {
                             goto Hub;
                         }
                     }
                 }
                 //Hier werden unerlaubte Eingaben abgefangen!
                 catch (System.FormatException)
                 {
                     goto Start;
                 }
             }
             */
        }
    }


}