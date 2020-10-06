using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErsteKlasse
{
    // Mensch Klasse
    // Eine Blaupause für einen Datentypen

    // Füge zwei weitere Membervariablen "eyeColor" und "age" zu Human hinzu.
    // Erweitere den Konstruktor, sodass er alle vier Variablen verwendet, wenn ein Objekt von Human angelegt wird
    // Erstelle zwei Objekte von Human

    class Human
    {
        // Membervariable Vorname und Nachname
        // Member = Mitglied
        public string firstName;
        public string lastName;

        public string eyeColour;
        public int age;



        // Default Konstruktor
        public Human()
        {
            Console.WriteLine("Default Konstruktor aufgerufen");
            firstName = "Unbekannt";
            lastName = "Unbekannt";
            eyeColour = "braun"; 
            age = 0;
        }


        // Parameterisierter Konstruktor mit noch weniger Argumente bzw Parameter direkt erstellen
        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;     //this um zu sagen es geht um dieses Objekt
            this.lastName = lastName;
            //this.eyeColour = eyeColour;
            //this.age = age;
            //Console.WriteLine("Objekt von Human erstellt");
        }

        // Parameterisierter Konstruktor mit nochweniger Argumente bzw Parameter direkt erstellen
        public Human(string firstName, string lastName, int age)
        {
            this.firstName = firstName;     //this um zu sagen es geht um dieses Objekt
            this.lastName = lastName;
            //this.eyeColour = eyeColour;
            this.age = age;
            //Console.WriteLine("Objekt von Human erstellt");
        }


        // Parameterisierter Konstruktor mit weniger Argumente bzw Parameter direkt erstellen
        public Human(string firstName, string lastName, string eyeColour)
        {
            this.firstName = firstName;     //this um zu sagen es geht um dieses Objekt
            this.lastName = lastName;
            this.eyeColour = eyeColour;
            //this.age = 0;
            //Console.WriteLine("Objekt von Human erstellt");
        }


        // Parameterisierter Konstruktor mit 4 Argumente bzw Parameter direkt erstellen
        public Human(string firstName, string lastName, string eyeColour, int age)
        {
            this.firstName = firstName;     //this um zu sagen es geht um dieses Objekt
            this.lastName = lastName;
            this.eyeColour = eyeColour;
            this.age = age;
            Console.WriteLine("Objekt von Human erstellt");
        }


        // Member Methode //selber verbessert.
        public void IntroduceMyself()
        {
            if (age!=1 && age != 0 && lastName != null && firstName != null && eyeColour != null)
            {
                Console.WriteLine($"Hi, ich bin {firstName} {lastName}! Meine augen sind {eyeColour} und ich bin {age} Jahre alt.");
            }
            else if (age == 1 && lastName != null && firstName != null && eyeColour != null)
            {
                Console.WriteLine($"Hi, ich bin {firstName} {lastName}! Meine augen sind {eyeColour} und ich bin {age} Jahr alt.");
            }
            else if ( lastName != null && firstName != null && eyeColour != null)
            {
                Console.WriteLine($"Hi, ich bin {firstName} {lastName}! Meine augen sind {eyeColour}.");
            }
            else if (lastName != null && firstName != null && age != 0)
            {
                Console.WriteLine($"Hi, ich bin {firstName} {lastName}! und ich bin {age} Jahr alt.");
            }

            else if (lastName != null && firstName != null )
            {
                Console.WriteLine($"Hi, ich bin {firstName} {lastName}!");
            }
        }


    }
}
