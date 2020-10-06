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

            Console.ReadKey();
        }
    }
}
