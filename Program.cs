using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErsteKlasse
{
    class Program
    {
        static void Main(string[] args)
        {
            // erstellen eines Objektes meiner Human Klasse
            //Human andres = new Human();     //dies ruft den Konstruktor
            //andres.firstName = "Andrés";
            //andres.lastName = "Redondo";
            //Human andres = new Human("Andrés","Redondo"); //dies ruft den Konstruktor mit 2 Parameter
            Human andres = new Human("Andrés", "Redondo", "braun", (DateTime.Now.Year - 1987)); //dies ruft den Konstruktor mit 4 Parameter
            andres.IntroduceMyself();

            //Human michael = new Human();    //dies ruft den Konstruktor
            //michael.firstName = "Michael";
            //michael.lastName = "Von der Doofen";
            //Human michael = new Human("Michael", "Von der Doofen");    //dies ruft den Konstruktor mit 2 Parameter
            Human michael = new Human("Michael", "Von der Doofen","blau", (DateTime.Now.Year - 1984));    //dies ruft den Konstruktor mit 4 Parameter
            michael.IntroduceMyself();

            Human amalia = new Human("Amalia", "Panjuta", "blau", 1);
            amalia.IntroduceMyself();

            Human unbekannterMensch = new Human();
            unbekannterMensch.IntroduceMyself();

            Human martina = new Human("Martina", "Müller", "grün");
            martina.IntroduceMyself();

            // Parameterisierter Konstruktor mit noch weniger Argumente bzw Parameter verwenden
            Human hermut = new Human("Hermut", "Gläser", 35);
            hermut.IntroduceMyself();
            Human dieter = new Human("Dieter", "Dietrich");
            dieter.IntroduceMyself();


            Console.WriteLine("\n\nBox Klasse für PROPERTIES");
            Box meineKiste = new Box(5,10,10);
            //meineKiste.Length = 5; nicht nötig
            //meineKiste.Height = 10; nicht nötig
            //meineKiste.Width = 10; nicht nötig
            //meineKiste.volume = 500; Volume wird berechnet!
            meineKiste.DisplayInfo();


            //hereuasforderung
            Box neueKiste = new Box(10, 2, 5);
            neueKiste.DisplayInfo();

            Box nochein = new Box(2, 4, 6);
            nochein.DisplayInfo();



            //////Code vom Lehrer....
            //////Box box = new Box(5, 3, 4);
            //////Console.WriteLine("Die Gesichtsfläche ist {0}", box.FrontSurface);
            //////Console.WriteLine("Volume ist {0}", box.Volume);

            //////box.DisplayInfo();

            //////Console.ReadKey();
            Console.WriteLine(); 
            Console.WriteLine();
            Console.WriteLine();


            //Members und Finalizers bzw, destruktoren...
            Members member1 = new Members();
            member1.Introducing(true);
            Console.ReadKey();

            Console.ReadKey();
        }
    }
}
